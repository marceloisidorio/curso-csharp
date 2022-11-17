using System;

class aula011 {
    static void Main() {
        int n1 = 10;
        float n2 = n1; // conversão segura

        Console.WriteLine("Conversão segura n2: " + n2);

        n2 = 10.5f;
        n1 = (int) n2; // conversão explícita

        Console.WriteLine("Conversão explícita n1: " + n1);

        int vInt = 10;
        short vShort = (short) vInt; // typecast
    }
}