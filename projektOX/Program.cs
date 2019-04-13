using System;

namespace projektOX
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string imieGraczaA = "";
            string imieGraczaB = "";

            char znakGraczaA = 'O';
            char znakGraczaB = 'X';

            char[,] plansza = new char[3, 3]
            {
                {'1', '2', '3' },
                {'4', '5', '6' },
                {'7', '8', '9' }
            };

            Console.Write("Wpisz imie gracza A: ");
            imieGraczaA = Console.ReadLine();
            Console.Write("Wpisz imie gracza B: ");
            imieGraczaB = Console.ReadLine();
        }
    }
}
