/*
* Student ID : 1690703457
* Name       : Kittipop Mongkol
* Section    : 129A
* No.        : 40
* Course     : GI113 Computer Programming (GI)
*/

using System;

namespace Assignment02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const String name = "Iron";
            const double smeltRate = 0.3000;
            const double salvageRate = 0.4000;
            const double maxBatch = 500.00;
            var inGot = 0.0;
            var ore = 0.0;
            Console.WriteLine("=============ForgingStation=============");
            Console.WriteLine("-------This is the rate for today-------");
            Console.WriteLine($"{name} ore Smelting 0.30 / Salvage 0.40");
            Console.WriteLine("Key 'S' for Smelt (Ore -> Ingot)");
            Console.WriteLine("Key 'B' for Breakdown (Ingot -> Ore)");
            Console.WriteLine("----------------------------------------");
            Console.Write("Select what  you want to do : ");
            bool iskeychar = char.TryParse(Console.ReadLine(), out char key);

            if (!iskeychar || (key != 's' && key != 'S' && key != 'b' && key != 'B'))
            {
                Console.WriteLine("error : please write (s , S , B ,b)");
            }

            else if (key == 'S' || key == 's')
            {
                Console.Write("How much do you want to Smelt (1-500): ");
                bool isamountnum = double.TryParse(Console.ReadLine(), out double amount);
                if (!isamountnum || (amount > maxBatch && amount <= 0))
                {
                    if (amount > maxBatch && amount <= 0)
                    {
                        Console.WriteLine("error : plese write (1-500)");
                    }
                    else
                    {
                        Console.WriteLine("error : plese write (1-500)");
                    }
                }
                else if (amount <= maxBatch && (amount > 0))
                {
                    inGot = amount * smeltRate;
                    Console.WriteLine($"{amount:f2} {name} ore = {inGot:f2} {name} ingot");
                }
                else
                {
                    Console.WriteLine("error : plese write (1-500)  ");
                }

            }
            else if (key == 'B' || key == 'b')
            {
                Console.Write("How much do you want to Breakdown ( 1-500): ");
                bool isamountnum = double.TryParse(Console.ReadLine(), out double amount);
                if (!isamountnum)
                {
                    if (amount > maxBatch && amount <= 0)
                    {
                        Console.WriteLine("error : please write (1-500)");
                    }
                    else
                    {
                        Console.WriteLine("error : please write (1-500)");
                    }
                }
                else if (amount <= maxBatch && (amount > 0))
                {
                    ore = amount / salvageRate;
                    Console.WriteLine($"{amount:f2} {name} ingot = {ore:f2} {name} ore");
                }
                else
                {
                    Console.WriteLine("error : please write (1-500)  ");
                }
            }
        }
    }
}
