using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services;

namespace plantillaApp.Controllers
{
    public class PersonaController : Controller
    {
        // GET: Persona
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Crear()
		    {
          return View();
		    }

		    #region Metodo para guardar los datos de una persona
		    [HttpPost]
        public ActionResult Guardar(string tCedula, string tNombre, string tApellidos, string tFetTelefono, string tEmail, string tFecha, string tSexo, string tDireccion, string tCiudad, string tNacionalidad)
        {
          ViewBag.mensaje = "Hola " + tNombre + " Se guardaron los datos";
          return View("Crear");
        }
		    #endregion
	}
}