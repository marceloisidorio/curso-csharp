using System;

class aula020 {
    static void Main() {
        int[] num = new int[10];

        int i = num.Length;

        while(i>0) {
            // num[i] = 0; (da erro por conta da posição a mais do array)
            Console.WriteLine(i);
            i--;
        }
    }
}