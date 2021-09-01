using System;

namespace NomeCompleto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\nescreva seu primeiro nome: ");
            string nome = Console.ReadLine();
            
            Console.Write("escreva seu sobrenome: ");
            string sobrenome = Console.ReadLine();

            Console.WriteLine($"\nNome Completo: {nome} {sobrenome}");
            Console.WriteLine($"Nome de Catálogo: {sobrenome.ToUpper()} {nome}\n");
            
            
        }
    }
}
