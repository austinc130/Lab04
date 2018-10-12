using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc;
using WaffleGenerator;

namespace WebApplication1.Controllers
{
    public class Lab4Controller : Controller
    {
        public IActionResult Index()
        {
            DateTime date = DateTime.Now;
            return View(date);

        }

        public IActionResult Waffle(int id)
        {
            var waffle = WaffleEngine.Html(2, true, false);
            IList<HtmlString> waffleList = new List<HtmlString>();
            for (int i = 0; i < id; i++)
            {
                waffleList.Add(new HtmlString(waffle));
            }
            
            return View(waffleList);
        }
         
    }
}