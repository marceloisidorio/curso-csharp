/* Aula sobre Métodos para Arrays - parte 1


    BinarySearch => retorna a posição de um elemento a ser procurado em um array
   
    Copy => faz a cópia dos elementos de um array para outro
    
    CopyTo => copia os elementos de um array para outro a partir de uma posição específica

    GetLongLength => retorna a quantidade de elementos de um array

    GetLowerBound => retorna o menor índice de um vetor ou matriz

    GetUpperBound => retorna o maior índice de um vetor ou matriz

    GetValue => retorna o valor de um vetor ou matriz a partir do seu índice
*/
using System;

class aula023 {
    static void Main() {
        int[] vetor1 = new int[5];
        int[] vetor2 = new int[5];
        int[] vetor3 = new int[5];
        int[,] matriz = new int[2,5]{{11,22,00,44,55} {66,77,88,99,00}};

        Random random = new Random(); // objeto criado pela classe Random
        for(int i=0;i<vetor1.Length;i++) {
           vetor1[i] = random.Next(50); // método Next com n° aleatório máx=50
        }

        Console.WriteLine("Elementos do Vetor 1:");
        foreach (int n in vetor1) { // imprime os valores do vetor1
            Console.WriteLine(n);
        }



        // public static int BinarySearch(array, valor);
        Console.WriteLine(" Binary Search");
        int procurado = 33;
        int pos = Array.BinarySearch(vetor1, procurado); // se não encontrar procurado, retorna n<0
        Console.WriteLine(" Valor {0} está na posição {1}", procurado, pos);
        Console.WriteLine("---------------------------------------------");



        // public static void Copy(ar_origem, ar_destino, qtde_elementos);
        Console.WriteLine(" Copy");
        Array.Copy(vetor1,vetor2,vetor1.Length); // copia todos os elementos de vetor1 para vetor2
        foreach(int n in vetor2) {
            Console.WriteLine(n); // imprime os valores de vetor2
        }
        Console.WriteLine("---------------------------------------------");



        // public void CopyTo(ar_destino, a_partir_desta_pos);
        Console.WriteLine(" CopyTo");
        vetor1.CopyTo(vetor3, 0); // copia todos os elementos de vetor1 para vetor3 (pos = 0)
        foreach(int n in vetor3) {
            Console.WriteLine(n); // imprime os valores do vetor3
        }
        Console.WriteLine("---------------------------------------------");



        // public long GetLongLength(dimensão);
        Console.WriteLine(" GetLongLength");
        long qtde_elementos = vetor1.GetLongLength(0); // vetor: dimensão == 1
        Console.WriteLine("Quantidade de Elementos: {0}", qtde_elementos);
        Console.WriteLine("---------------------------------------------");

        

        // public int GetLowerBound(dimensão)
        Console.WriteLine(" GetLowerBound");
        int menor_indice_vetor = vetor1.GetLowerBound(0);
        int menor_indice_matriz_d1 = matriz.GetLowerBound(1); // primeira dimensão da matriz
        Console.WriteLine("Menor índice do vetor1: {0}", menor_indice_vetor);
        Console.WriteLine("---------------------------------------------");



        // public int GetUpperBound(dimensão);
        Console.WriteLine(" GetUpperBound");
        int maior_indice_vetor = vetor1.GetUpperBound(0);
        int maior_indice_matriz_d1 = matriz.GetUpperBound(1);
        Console.WriteLine("Maior índice do vetor: {0}", maior_indice_vetor);
        Console.WriteLine("---------------------------------------------");

        

        // public object GetValue(long índice);
        Console.WriteLine(" GetValue");
        int valor0 = Convert.ToInt32(vetor1.GetValue(3));
        int valor1 = Convert.ToInt32(matriz.GetValue(1,3)); // matriz
        Console.WriteLine("Valor da posição 3 do vetor1: {0}", valor0);
        Console.WriteLine("---------------------------------------------");



        // public static int 

    } // end main
}