using System;

class aula015 {
    static void Main() {
        char escolha;
        int tempo = 0;

        Console.WriteLine("Belo Horizonte/MG a Vitória/ES");
        Console.WriteLine("Escolha o transporte:");
        Console.WriteLine("[a] Avião | [c] Carro | [o] Ônibus");

        escolha = char.Parse(Console.ReadLine());

        switch(escolha) {
            case 'a':
            case 'A':
                tempo = 50;
                break;
            case 'c':
            case 'C':
                tempo = 480;
                break;
            case 'o':
            case 'O':
                tempo = 660;
                break;
            default:
                tempo = -1;
                break;
        }

            if(tempo < 0) {
                Console.WriteLine("Transporte Indisponível");
            } else {
                Console.WriteLine("Para o transporte escolhido, o tempo é: {0} minutos", tempo);
            }

    }

}