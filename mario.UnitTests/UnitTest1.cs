using System;
using System.Collections.Generic;
using mario.Controllers;
using Microsoft.AspNetCore.Mvc;
using Xunit;

namespace mario.UnitTests
{
    public class UnitTest1
    {

        [Theory]
        [InlineData(120)]
        [InlineData(15)]
        [InlineData(1)]
        public void DibujaEscaleraTest(int tamanoTorre)
        {
            // Arrange
            var controller = new HomeController();

            // Act
            var viewResult = controller.Escalera(tamanoTorre) as ViewResult;
            var resultado = viewResult.Model as List<string>;

            // Assert
            Assert.NotNull(viewResult);
            Assert.Equal<int>(tamanoTorre, resultado.Count);
            Assert.Equal(new String('#', 1).PadLeft(tamanoTorre), resultado[0]);
            Assert.Equal(new String('#', tamanoTorre).PadLeft(tamanoTorre), resultado[tamanoTorre - 1]);

        }


    }
}
