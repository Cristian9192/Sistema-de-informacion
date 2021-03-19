using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sistema_Informacion.Models;

namespace Sistema_Informacion.Controllers
{
    public class BuscarController : Controller
    {
        // GET: Buscar
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Index(FormCollection coleccion)
        {
            MantenimientoUsuario ma = new MantenimientoUsuario();
            Usuario usu = ma.Recuperar(int.Parse(coleccion["ID"].ToString()));
            if (usu != null)
                return View("ModificacionUsuario", usu);
            else
                return View("UsuarioNoExistente");
        }
        [HttpPost]
        public ActionResult

        ModificacionArticulo(FormCollection coleccion)
        {
            MantenimientoUsuario ma = new MantenimientoUsuario();
            Usuario usu = new Usuario
            {
                ID = int.Parse(coleccion["id"].ToString()),
                Documento = int.Parse(coleccion["documento"].ToString()),
                TipoDocumento = coleccion["tipodoc"].ToString(),
                Nombre = coleccion["nombre"].ToString(),
                Celular = coleccion["celular"].ToString(),
                Email = coleccion["email"].ToString(),
                Genero = coleccion["celular"].ToString(),
                Aprendiz = bool.Parse(coleccion["aprendiz"].ToString()),
                Egresado = bool.Parse(coleccion["egresado"].ToString()),
                AreaFormacion = coleccion["areaformacion"].ToString(),
                FechaEgresado = DateTime.Parse(coleccion["fechaegresado"].ToString()),
                Direccion = coleccion["direccion"].ToString(),
                Barrio = coleccion["barrio"].ToString(),
                Ciudad = coleccion["ciudad"].ToString(),
                Departamento = coleccion["departamento"].ToString(),
                FechaRegistro = DateTime.Parse(coleccion["fechaegresado"].ToString())
            };
            ma.Modificar(usu);
            return RedirectToAction("Index");
        }
    }
}