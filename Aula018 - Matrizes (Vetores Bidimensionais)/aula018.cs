using System;

class aula018 {
    static void Main() {
        int[,] n = new int[2, 3];
        int[,] m = new int[2, 2] {{10,20}, {30, 40}};

        n[0, 0] = 10;
        n[0, 1] = 20;
        n[0, 2] = 30;
        n[1, 0] = 10;
        n[1, 1] = 20;
        n[1, 2] = 30;
    }
}