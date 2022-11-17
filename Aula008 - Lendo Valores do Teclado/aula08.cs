using System;

class aula08 {
    static void Main() {
        int v1, v2, soma;
        string nome;

        Console.Write("Digite o 1° valor: ");
        v1 = int.Parse(Console.ReadLine()); // converte string para int
        Console.Write("Digite o 1° valor: ");
        v2 = Convert.ToInt32(Console.ReadLine()); // converte string para int

        soma = v1+v2; // atribui valor da operação p/ variável

        Console.WriteLine("{0} + {1} = {2}", v1, v2, soma);
    }
}