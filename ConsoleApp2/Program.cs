using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tipe in the size of the minefield.\nFormat: <width height>\nMin: 10 x 10\nMax 30 x 30");
            Console.ReadKey();
            Console.WriteLine("10 15");
            Console.ReadKey();
            Console.WriteLine("how many bombs do you want?\nFormat: <number>\nMin: 15 (10% of all field)\nMax: 45 (30% of all field)");
            Console.ReadKey();
            Console.WriteLine("15");
            Console.ReadKey();


            Console.Clear();
            Console.Write("    ");
            for (int i = 0; i < 15; i++)
            {
                Console.Write(i < 8 ? $"{i + 1}  " : $"{i + 1} ");
            }
            Console.WriteLine("\n");
            for (int j = 0; j < 10; j++)
            {
                Console.Write(j < 9 ? $" {j + 1}  " : $"{j + 1}  ");
                for (int i = 0; i < 15; i++)
                {
                    Console.Write($"X  ");
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine();
            Console.WriteLine("Do something!\nOptions: Poke(p) or Flag(f) a valid coardinate(x y)\nFormat: <move xCordinate yCordinate>");
            Console.ReadKey();
            Console.WriteLine("p 5 7");
            Console.ReadKey();


            Console.Clear();
            Console.Write("    ");
            for (int i = 0; i < 15; i++)
            {
                Console.Write(i < 8 ? $"{i + 1}  " : $"{i + 1} ");
            }
            Console.WriteLine("\n");
            for (int j = 0; j < 10; j++)
            {
                Console.Write(j < 9 ? $" {j + 1}  " : $"{j + 1}  ");
                for (int i = 0; i < 15; i++)
                {
                    Console.Write(i + 1 == 5 && j + 1 == 7 ? $"2  " : $"X  ");
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine();
            Console.WriteLine("Do something!\nOptions: Poke(p) or Flag(f) a valid coardinate(x y)\nFormat: <move xCordinate yCordinate>");
            Console.ReadKey();
            Console.WriteLine("p 6 7");
            Console.ReadKey();


            Console.Clear();
            Console.Write("    ");
            for (int i = 0; i < 15; i++)
            {
                Console.Write(i < 8 ? $"{i + 1}  " : $"{i + 1} ");
            }
            Console.WriteLine("\n");
            for (int j = 0; j < 10; j++)
            {
                Console.Write(j < 9 ? $" {j + 1}  " : $"{j + 1}  ");
                for (int i = 0; i < 15; i++)
                {
                    Console.Write(i + 1 == 5 && j + 1 == 7 ? $"2  " : i + 1 == 6 && j + 1 == 7 ? $"1  " : $"X  ");
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine();
            Console.WriteLine("Do something!\nOptions: Poke(p) or Flag/UnFlag(f) a valid coardinate(x y)\nFormat: <move xCordinate yCordinate>");
            Console.ReadKey();
            Console.WriteLine("p 6 6");
            Console.ReadKey();


            Console.Clear();
            Console.WriteLine("    1  2  3  4  5  6  7  8  9 10 11 12 13 14 15\n\n" +
                              " 1  X  X  X  X  X  X  X  X  X  X  X  X  X  X  X\n\n" +
                              " 2  X  X  X  X  X  X  X  X  X  X  X  X  X  X  X\n\n" +
                              " 3  X  X  X  X  X  X  X  X  X  X  X  X  X  X  X\n\n" +
                              " 4  X  X  X  1  1  2  3  X  X  X  X  X  X  X  X\n\n" +
                              " 5  X  X  X  1  0  0  1  X  X  X  X  X  X  X  X\n\n" +
                              " 6  X  X  X  1  0  0  1  3  X  X  X  X  X  X  X\n\n" +
                              " 7  X  X  X  2  2  1  0  3  X  X  X  X  X  X  X\n\n" +
                              " 8  X  X  X  X  X  1  1  2  X  X  X  X  X  X  X\n\n" +
                              " 9  X  X  X  X  X  X  X  X  X  X  X  X  X  X  X\n\n" +
                              "10  X  X  X  X  X  X  X  X  X  X  X  X  X  X  X\n\n");
            Console.WriteLine("Do something!\nOptions: Poke(p) or Flag(f) a valid coardinate(x y)\nFormat: <move xCordinate yCordinate>");
            Console.ReadKey();
            Console.WriteLine("f 5 8");
            Console.ReadKey();


            Console.Clear();
            Console.WriteLine("    1  2  3  4  5  6  7  8  9 10 11 12 13 14 15\n\n" +
                              " 1  X  X  X  X  X  X  X  X  X  X  X  X  X  X  X\n\n" +
                              " 2  X  X  X  X  X  X  X  X  X  X  X  X  X  X  X\n\n" +
                              " 3  X  X  X  X  X  X  X  X  X  X  X  X  X  X  X\n\n" +
                              " 4  X  X  X  1  1  2  3  X  X  X  X  X  X  X  X\n\n" +
                              " 5  X  X  X  1  0  0  1  X  X  X  X  X  X  X  X\n\n" +
                              " 6  X  X  X  1  0  0  1  3  X  X  X  X  X  X  X\n\n" +
                              " 7  X  X  X  2  2  1  0  3  X  X  X  X  X  X  X\n\n" +
                              " 8  X  X  X  X  F  1  1  2  X  X  X  X  X  X  X\n\n" +
                              " 9  X  X  X  X  X  X  X  X  X  X  X  X  X  X  X\n\n" +
                              "10  X  X  X  X  X  X  X  X  X  X  X  X  X  X  X\n\n");
            Console.WriteLine("Do something!\nOptions: Poke(p) or Flag(f) a valid coardinate(x y)\nFormat: <move xCordinate yCordinate>");
            Console.ReadKey();
            Console.WriteLine("f 4 8");
            Console.ReadKey();


            Console.Clear();
            Console.WriteLine("    1  2  3  4  5  6  7  8  9 10 11 12 13 14 15\n\n" +
                              " 1  X  X  X  X  X  X  X  X  X  X  X  X  X  X  X\n\n" +
                              " 2  X  X  X  X  X  X  X  X  X  X  X  X  X  X  X\n\n" +
                              " 3  X  X  X  X  X  X  X  X  X  X  X  X  X  X  X\n\n" +
                              " 4  X  X  X  1  1  2  3  X  X  X  X  X  X  X  X\n\n" +
                              " 5  X  X  X  1  0  0  1  X  X  X  X  X  X  X  X\n\n" +
                              " 6  X  X  X  1  0  0  1  3  X  X  X  X  X  X  X\n\n" +
                              " 7  X  X  X  2  2  1  0  3  X  X  X  X  X  X  X\n\n" +
                              " 8  X  X  X  F  F  1  1  2  X  X  X  X  X  X  X\n\n" +
                              " 9  X  X  X  X  X  X  X  X  X  X  X  X  X  X  X\n\n" +
                              "10  X  X  X  X  X  X  X  X  X  X  X  X  X  X  X\n\n");
            Console.WriteLine("Do something!\nOptions: Poke(p) or Flag(f) a valid coardinate(x y)\nFormat: <move xCordinate yCordinate>");
            Console.ReadKey();
            Console.WriteLine("f 5 8");
            Console.ReadKey();


            Console.Clear();
            Console.WriteLine("    1  2  3  4  5  6  7  8  9 10 11 12 13 14 15\n\n" +
                              " 1  X  X  X  X  X  X  X  X  X  X  X  X  X  X  X\n\n" +
                              " 2  X  X  X  X  X  X  X  X  X  X  X  X  X  X  X\n\n" +
                              " 3  X  X  X  X  X  X  X  X  X  X  X  X  X  X  X\n\n" +
                              " 4  X  X  X  1  1  2  3  X  X  X  X  X  X  X  X\n\n" +
                              " 5  X  X  X  1  0  0  1  X  X  X  X  X  X  X  X\n\n" +
                              " 6  X  X  X  1  0  0  1  3  X  X  X  X  X  X  X\n\n" +
                              " 7  X  X  X  2  2  1  0  3  X  X  X  X  X  X  X\n\n" +
                              " 8  X  X  X  F  X  1  1  2  X  X  X  X  X  X  X\n\n" +
                              " 9  X  X  X  X  X  X  X  X  X  X  X  X  X  X  X\n\n" +
                              "10  X  X  X  X  X  X  X  X  X  X  X  X  X  X  X\n\n");
            Console.WriteLine("Do something!\nOptions: Poke(p) or Flag(f) a valid coardinate(x y)\nFormat: <move xCordinate yCordinate>");
            Console.ReadKey();
            Console.WriteLine("p 5 8");
            Console.ReadKey();


            Console.Clear();
            Console.WriteLine("    1  2  3  4  5  6  7  8  9 10 11 12 13 14 15\n\n" +
                              " 1  X  X  X  !  X  X  X  X  X  X  X  X  X  X  X\n\n" +
                              " 2  X  X  X  X  X  X  X  X  X  X  X  X  X  X  X\n\n" +
                              " 3  X  !  X  X  X  !  !  X  X  X  X  !  X  X  X\n\n" +
                              " 4  X  X  X  1  1  2  3  X  X  X  X  X  X  X  X\n\n" +
                              " 5  X  X  !  1  0  0  1  !  X  X  X  X  X  X  X\n\n" +
                              " 6  X  X  X  1  0  0  1  3  !  X  X  X  X  X  X\n\n" +
                              " 7  !  X  X  2  2  1  0  3  !  X  X  X  X  X  X\n\n" +
                              " 8  X  X  X  !  !  1  1  2  !  X  X  !  X  X  X\n\n" +
                              " 9  X  X  X  X  X  X  !  X  X  X  X  X  X  X  X\n\n" +
                              "10  X  X  X  X  X  X  X  X  X  X  X  X  X  X  X\n\n");
            Console.WriteLine("You have been exploded!!!    :'(    RIP you.");
            Console.ReadKey();
        }
    }
}
