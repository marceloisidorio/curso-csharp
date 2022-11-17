using System;

class aula010 {
    enum DiasSemana{Domingo, Segunda, Terça, Quarta, Quinta, Sexta, Sábado};
    static void Main() {
        DiasSemana ds = DiasSemana.Domingo;
        DiasSemana ds2 = (DiasSemana) 3; // índice 3
        int indice = (int) DiasSemana.Sexta; // contrário

        Console.WriteLine(ds);
        Console.WriteLine(ds2);
        Console.WriteLine(indice);

    }
}