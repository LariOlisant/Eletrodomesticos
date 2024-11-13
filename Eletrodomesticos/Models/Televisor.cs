namespace Eletrodomesticos.Models
{
        public class Televisor : Eletrodomestico
        {
            public int TamanhoTela { get; set; }
            public bool EhSmart { get; set; }
            public override string ExibirDetalhes()
            {
                return $"Marca: {Marca}, Modelo: {Modelo}, Consumo: {ConsumoEnergetico} kWh, Tamanho da tela em polegadas: {TamanhoTela}, A TV é uma Smart TV? {(EhSmart ? "Sim" : "Não")}";
            }
        }
    }
