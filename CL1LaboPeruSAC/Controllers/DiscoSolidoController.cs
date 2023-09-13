using CL1LaboPeruSAC.Models;
using Microsoft.AspNetCore.Mvc;

namespace CL1LaboPeruSAC.Controllers
{
    public class DiscoSolidoController : Controller
    {
        public IConfiguration _config;

        //creamos un constructor...
        public DiscoSolidoController(IConfiguration IConfig)
        {
            _config = IConfig;
        }

        public IActionResult Index()
        {
            return RedirectToAction("Index", "VentasHardware");
            //return View();
        }  //fin del metodo...

        public IActionResult DiscoSolido()
        {
            return View();
        }  //fin del metodo...

        public IActionResult CalcularCds(ClassCalcular calcular)
        {
            int capacidadGb = calcular.Disco;
            int capacidadMb = capacidadGb * 1024;
            int numeroCds = (int)Math.Ceiling(capacidadMb / 700.0);

            // Pasar los resultados al modelo
            calcular.total = numeroCds;
            //calcular.total = numeroCds * 700;

            return View(calcular);
        }
    }
}
