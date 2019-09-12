using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Demo1.Models.Pages;
using EPiServer.Web.Mvc;

namespace Demo1.Controllers
{
    public class StandardPageController : PageController<StandardPage>
    {
        // GET: StandardPage
        public ActionResult Index(StandardPage currentPage)
        {
            var model = currentPage;

            return View(model);
        }
    }
}