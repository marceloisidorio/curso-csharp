/*
    Aula sobre o loop Foreach que é ideal para a apresentação/leitura de
    valores de uma coleção (array), onde uma variável n recebe os valores de todas as suas posições e exibe na tela para o usuário
*/
using System;

class aula022 {
    static void Main() {
        int[] num = new int[5] {11,22,33,44,55};

        for(int i=0; i<num.Length; i++) {
            Console.WriteLine(num[i]);
        }
        Console.WriteLine("Fim do FOR");

        foreach (int n in num) { // n recebe todos os valores da coleção num
            Console.WriteLine(n); // imprime os resultados na tela
        }
        Console.WriteLine("Fim do FOREACH");

    }
}