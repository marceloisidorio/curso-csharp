using System;

class aula020 {
    static void Main() {
        int[] num = new int[10];

        int i = num.Length-1; // identifica o tamanho do array
        // -1 pois ultrapassa o n° de posições da matriz

        while(i>=0) {
            num[i] = i;
            Console.WriteLine(num[i]);

            i--; // decremento
        }

        Console.WriteLine("Fim do loop");
    }
}