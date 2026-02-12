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

        [HttpPost]

        public IActionResult Depositar(decimal monto)
        {
            cuenta.Depositar(monto);
            ViewBag.Mensaje = "Depósito realizado correctamente.";
            return View("Index", cuenta);
        }
        [HttpPost]
        public IActionResult Retirar(decimal monto)
        {
            bool exito = cuenta.Retirar(monto);

            if (!exito)
                ViewBag.Error = "Saldo insuficiente o monto inválido.";
            else
                ViewBag.Mensaje = "Retiro realizado.";

            return View("Index", cuenta);
        }
    }
}
