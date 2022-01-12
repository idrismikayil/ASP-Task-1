using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            ViewResult view = new ViewResult();
            view.ViewName = "Index";
            return view;

        }

        public ActionResult About()
        {
            return new ViewResult { ViewName = "About" };
        }

        public ActionResult Contact()
        {
            return new ViewResult { ViewName = "Contact" };
        }
    }
}
