using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sistema_Informacion.Models;

namespace Sistema_Informacion.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            MantenimientoUsuario ma = new MantenimientoUsuario();
            return View(ma.RecuperarTodos());
        }

        // GET: Home/Details/5
        public ActionResult Details(int id)
        {
            MantenimientoUsuario ma = new MantenimientoUsuario();
            Usuario usu = ma.Recuperar(id);
            return View(usu);
        }

        // GET: Home/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Home/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            MantenimientoUsuario ma = new MantenimientoUsuario();
            Usuario usu = new Usuario
            {
                ID=int.Parse(collection["id"]),
                Documento = int.Parse(collection["documento"]),
                TipoDocumento = collection["tipodoc"],
                Nombre = collection["nombre"].ToString(),
                Celular = collection["celular"].ToString(),
                Email = collection["email"].ToString(),
                Genero = collection["aprendiz"].ToString(),
                Aprendiz = bool.Parse(collection["aprendiz"].ToString()),
                Egresado = bool.Parse(collection["egresado"].ToString()),
                AreaFormacion = collection["areaformacion"].ToString(),
                FechaEgresado = DateTime.Parse(collection["fechaegresado"].ToString()),
                Direccion = collection["direccion"].ToString(),
                Barrio = collection["barrio"].ToString(),
                Ciudad = collection["ciudad"].ToString(),
                Departamento = collection["departamento"].ToString(),
                FechaRegistro = DateTime.Parse(collection["fecharegistro"].ToString())
            };
            ma.Alta(usu);
            return RedirectToAction("Index");
        }

        // GET: Home/Edit/5
        public ActionResult Edit(int id)
        {
            MantenimientoUsuario ma = new MantenimientoUsuario();
            Usuario usu = ma.Recuperar(id);
            return View(usu);
        }

        // POST: Home/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            MantenimientoUsuario ma = new MantenimientoUsuario();
            Usuario usu = new Usuario
            {
                ID = id,
                Documento = int.Parse(collection["documento"]),
                TipoDocumento = collection["tipodoc"],
                Nombre = collection["nombre"].ToString(),
                Celular = collection["celular"].ToString(),
                Email = collection["email"].ToString(),
                Genero = collection["aprendiz"].ToString(),
                Aprendiz = bool.Parse(collection["aprendiz"].ToString()),
                Egresado = bool.Parse(collection["egresado"].ToString()),
                AreaFormacion = collection["areaformacion"].ToString(),
                FechaEgresado = DateTime.Parse(collection["fechaegresado"].ToString()),
                Direccion = collection["direccion"].ToString(),
                Barrio = collection["barrio"].ToString(),
                Ciudad = collection["ciudad"].ToString(),
                Departamento = collection["departamento"].ToString(),
                FechaRegistro = DateTime.Parse(collection["fecharegistro"].ToString())
            };
            ma.Modificar(usu);
            return RedirectToAction("Index");
        }

        // GET: Home/Delete/5
        public ActionResult Delete(int id)
        {
            MantenimientoUsuario ma = new MantenimientoUsuario();
            Usuario us = ma.Recuperar(id);
            return View();
        }

        // POST: Home/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            MantenimientoUsuario ma = new MantenimientoUsuario();
            ma.Borrar(id);
            return RedirectToAction("Index");
        }
    }
}