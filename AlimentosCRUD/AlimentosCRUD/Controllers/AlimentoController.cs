using AlimentosCRUD.Models;
using AlimentosCRUD.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AlimentosCRUD.Controllers
{
    public class AlimentoController : Controller
    {
        AlimentoService AlimentoService = new AlimentoService(); 
        // GET: Alimento
        public ActionResult Index()
        {
            List<Alimento> alimentos = AlimentoService.ObtenerAlimentos();
            return View();
        }
    }
}