/*
* Student ID : 1690703457
* Name       : Kittipop Mongkol
* Section    : 129A
* No.        : 
* Course     : GI113 Computer Programming (GI)
*/

namespace Lab06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int lives = 0;

            //if (lives == 0) // ด้านในวงเล็บ ต้องมีค่าเป็น Boolean
            //{
            //    Console.WriteLine("Game Over");
            //}
            //else
            //{
            //    Console.WriteLine("Continue Running");
            //}

            ////2
            //int coins = 80;
            //int price = 100;

            //if (coins >= price)
            //{
            //    Console.WriteLine("Purchased");
            //}
            //else
            //{
            //    Console.WriteLine("Not enough coin.");
            //}

            ////3
            //int score = 75;

            //if (score >= 90)
            //{
            //    Console.WriteLine("Rank S");
            //}
            //else if (score >= 60)
            //{
            //    Console.WriteLine("Rank A");
            //}
            //else
            //{
            //    Console.WriteLine("Rank B");
            //}

            ////4
            //bool haskey = true;
            //Console.Write("Your Level (1-99): ");
            //bool ok = int.TryParse(Console.ReadLine(), out int level);

            //if (!ok || level < 1 || level > 99)
            //{
            //    Console.WriteLine("Invalid Level, please try agin");
            //}
            //else if (level >= 10 && haskey)
            //{
            //    Console.WriteLine("Boss floor unlocked.");
            //}
            //else if (level >= 5)
            //{
            //    Console.WriteLine("Boss floor unlocked.");
            //}
            //else
            //{
            //    Console.WriteLine("The door stays shut.");
            //}

            int heroHP = 100;
            int monHP = 100;
            int atk = 50;

            Console.WriteLine("Adventure of Brian");
            Console.WriteLine(">==== Monster Encounter 1 <====");
            Console.WriteLine("ACTION A: ATTACK");
            Console.WriteLine("ACTION B: FLEE");
            Console.WriteLine("ACTION C: DEFEND\n");

            Console.WriteLine("Your turn.");
            Console.Write("Choose your action: ");
            bool inputOk = char.TryParse(Console.ReadLine(), out char choice);

            if (!inputOk || (choice != 'a' && choice != 'A' && choice != 'b' && choice != 'B' && choice != 'c' && choice != 'C'))
            {
                Console.WriteLine("Invalid input. Please choose between A and B.");
            }
            else if (choice == 'a' || choice == 'A')
            {
                Console.WriteLine("You attacked the monster.");
                monHP -= atk;
                Console.WriteLine($"You attacked the monster for {atk} points. Monster HP: {monHP}");
                if (monHP <= 0)
                {
                    Console.WriteLine($"Player attack monster with {atk} points, Monster defeated!!!");
                }
                else
                {
                    Console.WriteLine($"Player attack monster with {atk} points, Monster HP has {monHP}HP left.");
                }
            }
            else if (choice == 'b' || choice == 'B')
            {
                Console.WriteLine("You fled from the monster.");
                heroHP -= atk;
                Console.WriteLine($"You fled from the monster. You got attacked for {atk} damage. Your HP: {heroHP}");

            }
            else if (choice == 'c' || choice == 'C')
            {
                Console.WriteLine("You defended against the monster's attack.");
                heroHP -= atk / 2;
                Console.WriteLine($"You defended against the monster's attack. You took {atk / 2} points. Your HP: {heroHP}");
            }
            else
            {
                Console.WriteLine("Timeout: You ran out of time.");
            }
        }
    }
}
