using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MovieController : Controller
    {
        public ActionResult Random()
        {
            var movie = new Movie(){Id = 1, Name = "Gone in 60 Seconds"};

            var name;

            return View (movie);
        }
    }
}
