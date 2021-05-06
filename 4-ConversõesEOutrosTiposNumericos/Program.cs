using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ConversõesEOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o Projeto 4");


            double salario  = 1200.50;




            // o int é uma variavel que suporta até 32 bits
            int SalarioEmInterio = (int)salario;


            Console.WriteLine(SalarioEmInterio);


            // long é uma variavel de 64 bits
            long idade = 1300000000000;
            Console.WriteLine(idade);


            // O short é uma variavel que suporta até 16 bits
            short quantidadeProdutos = 15000;
            Console.WriteLine(quantidadeProdutos);


            float altura = 1.80f;
            Console.WriteLine(altura);

            Console.ReadLine();



            Console.ReadLine();
        }
    }
}
