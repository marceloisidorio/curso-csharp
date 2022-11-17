using System;

/* padrão dotnet */
namespace Aula002 { // armazena objetos, classes e elementos
    class Program { // classe
        static void Main(string[] args) { // método principal
            Console.WriteLine("Hello World!");
            if(args.GetLength(0) > 0) {
                Console.WriteLine(args.GetValue(0));
            }
            
        }
    }
}
