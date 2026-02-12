using Microsoft.AspNetCore.Mvc;
using Sistema_Cuenta_Ahorros.Models;

namespace Sistema_Cuenta_Ahorros.Controllers
{
    public class CuentaController : Controller
    {
        // Simulación de una cuenta en memoria
        private static Cuenta cuenta = new Cuenta();

        public IActionResult Index()
        {
            return View(cuenta);
        }
    }
}
