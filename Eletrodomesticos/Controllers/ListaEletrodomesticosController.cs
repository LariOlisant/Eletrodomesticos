using Eletrodomesticos.Models;
using Microsoft.AspNetCore.Mvc;

namespace Eletrodomesticos.Controllers
{
    public class ListaEletrodomesticosController : Controller
    {
        public IActionResult Index()
        {
            List<Eletrodomestico> eletrodomesticos = new List<Eletrodomestico>()
            {
                new Geladeira { Marca = "Brastemp", Modelo = "Brastemp Ative!", ConsumoEnergetico = 0.74, CapacidadeLitros = 375, TemFreezer = true },
                new Televisor { Marca = "Lg", Modelo = "Alexa", ConsumoEnergetico = 500, TamanhoTela = 75 },
                new Geladeira { Marca = "Samsung", Modelo = "Duplex", ConsumoEnergetico = 3500, CapacidadeLitros = 500, TemFreezer = false },
                new Televisor { Marca = "Samsung", Modelo = "Samsung QLED 4K - Q60C", ConsumoEnergetico = 90 - 130, TamanhoTela = 65 }
            };
            return View(eletrodomesticos);
        }
    }
}