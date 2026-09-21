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
            int defend = atk / 2;

            Console.WriteLine("Monster Slayer");
            Console.WriteLine(">==== Monster Found <====\n");
            
            Console.WriteLine("Press 1: Fight");
            Console.WriteLine("Press 2: Flee\n");
            Console.Write("Choose your action: ");
            bool inputOk01 = int.TryParse(Console.ReadLine(), out int choice01);
            if (!inputOk01 || (choice01 != 1 && choice01 != 2))
            {
                Console.WriteLine("Invalid input. Please choose between 1 and 2.");
            }
            else if (choice01 == 1)
            {
                Console.WriteLine("You chose to fight the monster.");
                Console.WriteLine("ACTION A: ATTACK");
                Console.WriteLine("ACTION B: FLEE");
                Console.WriteLine("ACTION C: DEFEND\n");

                Console.WriteLine("Your turn.\n");
                Console.Write("Choose your action: ");
                bool inputOk02 = char.TryParse(Console.ReadLine(), out char choice02);

                if (!inputOk02 || (choice02 != 'a' && choice02 != 'A' && choice02 != 'b' && choice02 != 'B' && choice02 != 'c' && choice02 != 'C'))
                {
                    Console.WriteLine("Invalid input. Please choose between A, B, and C.");
                }
                else if (choice02 == 'a' || choice02 == 'A')
                {
                    Console.WriteLine("You attacked the monster.");
                    monHP -= atk;
                    Console.WriteLine($"You attacked the monster for {atk} points.");
                    if (monHP <= 0)
                    {
                        Console.WriteLine($"Player attack monster with {atk} points, Monster defeated!!!");
                    }
                    else
                    {
                        Console.WriteLine($"Player attack monster with {atk} points, Monster HP has {monHP}HP left.");
                    }
                }
                else if (choice02 == 'b' || choice02 == 'B')
                {
                    Console.WriteLine("You fled from the monster.");
                    heroHP -= atk;
                    Console.WriteLine($"You fled from the monster. You got attacked for {atk} damage. Your HP: {heroHP}");

                }
                else if (choice02 == 'c' || choice02 == 'C')
                {
                    Console.WriteLine("You defended against the monster's attack.");
                    heroHP -= defend;
                    Console.WriteLine($"You defended against the monster's attack. You took {defend} points. Your HP: {heroHP}");
                }
                else
                {
                    Console.WriteLine("Timeout: You ran out of time.");
                }
            }
            else
            {
                Console.WriteLine("You chose to flee from the monster.");
            }

            
            
        }
    }
}
