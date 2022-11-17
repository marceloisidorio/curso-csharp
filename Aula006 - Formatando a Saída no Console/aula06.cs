using System;

class aula06 {
    static void Main() {
        int n1, n2, n3;
        n1=10; n2=20; n3=30;

        // {} índice 
        // \n e \t caracteres de scape
        Console.WriteLine("N1\t=\t{0}\nN2\t=\t{1}\nN3\t=\t{2}\n", n1, n2, n3);

        double valCompra = 5.50;
        double valVenda;
        double lucro = 0.1;
        string produto = "Pastel";

        valVenda = valCompra+(valCompra*lucro);

        // {indíce, espaçamento:formato}
        Console.WriteLine("Produto.....:{0,10}", produto);
        Console.WriteLine("Val.Compra..:{0,10:c}", valCompra); // formato monetário
        Console.WriteLine("Lucro.......:{0,10:p}", lucro); // formato percentual
        Console.WriteLine("Val.Venda...:{0,10:c}", valVenda);

    }
}