using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;
using AppEventos;
using CrudAPI;

namespace AppEventosMVC.Controllers
{
    public class AsistentesController : Controller
    {
        private string urlApi;

        public AsistentesController(IConfiguration configuration)
        {
            urlApi = configuration.GetValue("ApiUrlBase", "").ToString() + "/Asistentes";
        }

        // GET: DepartamentosController
        public ActionResult Index()
        {
            var data = Crud<Asistente>.Read(urlApi);
            return View(data);
        }

        // GET: DepartamentosController/Details/5
        public ActionResult Details(int id)
        {
            var data = Crud<Asistente>.Read_ById(urlApi, id);
            return View(data);
        }

        // GET: DepartamentosController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DepartamentosController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Asistente data)
        {
            try
            {
                var newData = Crud<Asistente>.Create(urlApi, data);

                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return View(data);
            }
        }

        // GET: DepartamentosController/Edit/5
        public ActionResult Edit(int id)
        {
            var data = Crud<Asistente>.Read_ById(urlApi, id);
            return View(data);
        }

        // POST: DepartamentosController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Asistente data)
        {
            try
            {
                Crud<Asistente>.Update(urlApi, id, data);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return View(data);
            }
        }

        // GET: DepartamentosController/Delete/5    
        public ActionResult Delete(int id)
        {
            var data = Crud<Asistente>.Read_ById(urlApi, id);
            return View(data);
        }

        // POST: DepartamentosController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Asistente data)
        {
            try
            {
                Crud<Asistente>.Delete(urlApi, id);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return View(data);
            }
        }
    }
}
