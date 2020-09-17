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

            return View(alimentos);
        }

        public ActionResult Agregar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Agregar(Alimento a)
        {
            AlimentoService.CrearAlimento(a);

            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Modificar(int id)
        {
            Alimento a = AlimentoService.AlimentoPorId(id);
            
            return View(a);
        }

        [HttpPost]
        public ActionResult Modificar(Alimento a)
        {
            AlimentoService.ModificarAlimento(a);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Eliminar(int id)
        {
            AlimentoService.EliminarAlimento(id);

            return RedirectToAction("Index");
        }
    }
}