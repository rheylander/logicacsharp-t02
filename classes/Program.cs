using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logica13
{
    //Definição da classe Carro
    internal class Carro
    {
        // propriedade pública: Pode ser acessada e modificada fora da classe
        public string Marca { get; set; } // Publica a propriedade Marca

        // Propriedade privada: Não pode ser acessada ou modificada fora da classe
        private string Modelo { get; set; } // Privada, acessível apenas dentro da classe

        // Propriedade privada com um campo privado e um método getter e setter personalizados
        private int _ano; // Campo privado

        public int Ano
        {
            get { return _ano; } // Getter, para acessar o valo do campo privado
            set
            {
                if (value > 1900 && value <= DateTime.Now.Year) // Verificação para garantir um valor válido
                {
                    _ano = value;
                }
                else
                {
                    Console.WriteLine("Ano inválido.");
                }
            }
        }
    }
}