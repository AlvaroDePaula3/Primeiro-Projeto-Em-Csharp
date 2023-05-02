using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjetoEmC_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite aqui o seu nome: ");
            string Nome =  Console.ReadLine();

            Console.WriteLine("Digite a sua idade: ");
            UInt16 Idade = Convert.ToUInt16(Console.ReadLine());

            Console.WriteLine("Digite o seu documento: ");
            string Documento = Console.ReadLine();

            Console.WriteLine("Digite aqui o número da sua casa: ");
            UInt32 NumeroDaCasa = Convert.ToUInt32(Console.ReadLine());

            Console.WriteLine("Digite M se você for homem, e F se você for mulher: ");
            Char GeneroDoUsuario = Console.ReadKey(true).KeyChar;

            Console.WriteLine("Olá " + Nome + ", mostraremos os dados e ao final nos diga se está tudo correto");
            Console.WriteLine("NOME: " + Nome);
            Console.WriteLine("IDADE: " + Idade);
            Console.WriteLine("DOCUMENTO: " + Documento);
            Console.WriteLine("NÚMERO DA CASA: " + NumeroDaCasa);
            Console.WriteLine("GÊNERO: " + GeneroDoUsuario);

            Console.WriteLine("Todas as informações assim estão corretas ? (pressione S se estiver, pressione N se não estiver)");
            Char confirmacao = Console.ReadKey(true).KeyChar;

            Console.WriteLine("Aperte qualquer tecla para encerrar");
            Console.ReadKey();
        }
    }
}