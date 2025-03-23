using System;

class Program {
    static void Main() {
        char[,] pattern = {
            { '&', '&', '&', '&', '&', '&' },
            { '*', '&', '*', '*', '*', '*' },
            { '*', '*', '&', '*', '*', '*' },
            { '*', '*', '*', '&', '*', '*' },
            { '*', '*', '*', '*', '&', '*' },
            { '&', '&', '&', '&', '&', '&' }
        };

        for (int i = 0; i < 6; i++) {
            for (int j = 0; j < 6; j++) {
                Console.Write(pattern[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
