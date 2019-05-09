using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using mario.Models;

namespace mario.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Escalera(int tamanoTorre)
        {
            List<string> stairs = new List<string>();
            int sky = tamanoTorre-1;
            int step = 1;
            string hs = "";
            string skys = "";
            string steps = "";
            for (int i=0;i<tamanoTorre;i++)
            {
                skys="";
                skys = skys.PadRight(sky, ' ');
                steps = steps.PadRight(step, '#');
                hs = (skys + steps + ' ' + steps + skys);
                sky--;
                step++;
                stairs.Add(hs);
            }
            return View(stairs);
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
