using System;

class Program {
    static void Main() { // Operadores de Bitwise
        int num = 10;

        num = num<<1; // dobra o valor 1 única vez
        num = num>>1; // diminui pela metade 1 única vez

        Console.WriteLine(num);
    }
}