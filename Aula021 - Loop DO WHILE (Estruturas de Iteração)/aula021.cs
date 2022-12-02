using System;

class aula021 {
    static void Main() {
        string senha = "123";
        string teste;
        int tentativa = 0;

        do {
            Console.Clear();
            Console.Write("Digite a senha: ");
            teste = Console.ReadLine();

            tentativa++;

        } while(senha != teste);

        Console.WriteLine("Senha Correta! Tentativas: {0}", tentativa);

    }
}