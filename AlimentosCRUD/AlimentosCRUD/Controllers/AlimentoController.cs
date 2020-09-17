using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AlimentosCRUD.Controllers
{
    public class AlimentoController : Controller
    {
        // GET: Alimento
        public ActionResult Index()
        {
            return View();
        }
    }
}