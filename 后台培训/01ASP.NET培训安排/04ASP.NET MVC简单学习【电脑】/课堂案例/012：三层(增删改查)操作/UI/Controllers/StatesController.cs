using Bll;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UI.Controllers
{
    public class StatesController : Controller
    {
        StatesBll statesbll = new StatesBll();
        // GET: States
        public ActionResult Index()
        {
            ViewData.Model = statesbll.GetList(10, 0);
            return View();
        }

        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(States states)
        {
            statesbll.Add(states);
            return Redirect(Url.Action("Index"));
        }
    }
}