using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_CaracteresETextos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 5 caracteres e textos");

            // Character
            char primeiraLetra = ' ';
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)61;
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)(primeiraLetra + 1);
            Console.WriteLine(primeiraLetra);


            string titulo = "alura Cursos de tecnologia " + 2020;
            string CursosProgramacao = 
 @" - .NET 
 - Java
 - JavaScript";
                


            Console.WriteLine(titulo);
            Console.WriteLine(CursosProgramacao);

            Console.ReadLine();
        }
    }
}
