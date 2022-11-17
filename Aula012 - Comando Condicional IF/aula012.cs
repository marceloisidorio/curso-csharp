using System;

class aula012 {
    static void Main() {
        int n1, n2, n3, n4, res;
        n1 = n2 = n3 = n4 = res = 0;
        string resultado = "Reprovado";

        Console.WriteLine("Digite a 1° nota: ");
        n1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite a 2° nota: ");
        n2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite a 3° nota: ");
        n3 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite a 4° nota: ");
        n4 = int.Parse(Console.ReadLine());

        res = n1 + n2 + n3 + n4;

        if(res >= 60) {
            resultado = "Aprovado";
        }

        Console.WriteLine("Nota: {0} - Resultado: {1}", res, resultado);

    }
}