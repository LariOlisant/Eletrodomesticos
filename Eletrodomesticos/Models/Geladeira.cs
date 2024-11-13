using System.Reflection;
using System.Text.RegularExpressions;

namespace Eletrodomesticos.Models
{
    public class Geladeira : Eletrodomestico
    {
        public int CapacidadeLitros { get; set; }
        public bool TemFreezer { get; set; }
        public override string ExibirDetalhes()
        {
            return $"Marca: {Marca}, Modelo: {Modelo}, Capacidade {CapacidadeLitros}, Tem freezer: {(TemFreezer ? "Sim" : "Não")}";
        }
    }
}