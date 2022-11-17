using System;

class Aula003 {
    static void Main() {
        byte n1 = 10; //variável de 8bits, armazena valores entre 0 e 255
        int num = -10, num1, num2, res;
        char letra = 'C';
        float valor = 3.14f;
        string nome = "Bruno";

        var aux = "CFB Cursos"; //não especifica o tipo de dado

        num1 = 10;
        num2 = 2;
        res = num1*num2;

        Console.WriteLine("Valor da variável: " + aux + ";");
        Console.WriteLine(num1 + " + " + num2 + " = " + res);

    }
}