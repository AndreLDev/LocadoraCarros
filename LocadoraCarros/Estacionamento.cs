using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraCarros
{
    public class Estacionamento
    {
        private decimal _precoInicial = 0;
        private decimal _precoHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoHora) { 
            this._precoInicial=precoInicial;
            this._precoHora=precoHora;

        }

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a Placa do veiculo");
            string placa = Console.ReadLine();

            if (veiculos.Any(x => x.Equals(placa)))
            {
                Console.WriteLine("Já existe uma veiculo com essa placa");
            }
            else
            {
                veiculos.Add(placa);
                Console.WriteLine("Veiculo Cadastrado ComSucesso");
            }
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veiculo");
            string placa = Console.ReadLine();

            if(veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veiculo ficou no estacionamento");
                int horas = Convert.ToInt32(Console.ReadLine());
                decimal precoTotal = _precoInicial + (_precoHora * horas);
                veiculos.Remove(placa);
                Console.WriteLine($"O Veiculo de placa: {placa} foi removido e deve pagar {precoTotal}");
            }
            else
            {
                Console.WriteLine("O veiculo ão foi encontrado no pátio");
            }
        }

        public void ListarVeiculos()
        {
            if (veiculos.Any()) {
                Console.WriteLine("Os veiculos estacionados são: ");
                foreach (var veiculo in veiculos) 
                {
                    Console.WriteLine(veiculo);
                }
            }else {

                Console.WriteLine("Não há veiculos no pátio");
                    
            }
        }
    }
}
