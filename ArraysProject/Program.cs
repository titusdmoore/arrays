using System;

namespace ArraysProject {
    class Program {
        static void Main(string[] args) {
            // Create Array
            int[] frames = new int[10];
            // Add Data
            frames[0] = 18;
            frames[1] = 17;
            frames[2] = 5;
            frames[3] = 19;
            frames[4] = 26;
            frames[5] = 30;
            frames[6] = 12;
            frames[7] = 12;
            frames[8] = 23;
            frames[9] = 10;

            // While Loop
            int index = 0;
            int total = 0;
            while (index < 10) {
                total = total + frames[index];
                index++;
            }
            Console.WriteLine($"Total is {total}");
        }
    }
}
