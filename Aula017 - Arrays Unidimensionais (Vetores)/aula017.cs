using System;

class aula017 {
    static void Main() {
        // int n1, n2, n3, n4, n5;
        int[] n = new int[5]; // 0-4  => indica tamanho
        // int[] num = new int[3] {55, 77, 99};
        int[] num = {55, 77, 99}; // atribui cadeia de valores
        string[] veiculos = new string[3];

        string[0] = "Carro";
        string[1] = "Avião";
        string[2] = "Navio";

        n[0] = 11;
        n[1] = 22;
        n[2] = 33;
        n[3] = 44;
        n[4] = 55;

        Console.WriteLine(num[2]);

    }
}