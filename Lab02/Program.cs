/*
 * Student ID : 1690703457
 * Name       : Kittipop Mongkol
 * Section    : 129A
 * No.        : 
 * Course     : GI113 Computer Programming (GI)
 */

using static System.Net.Mime.MediaTypeNames;

namespace Lab02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bossName = "Kirin";
            char rank = 'S';
            int level = 7;
            int maxHp = 240;
            int currentHp = 175;
            float attackPower = 42.5f;
            double critMultiplier = 1.75;
            bool isBoss = true;

            Console.WriteLine("===== BOSS STATUS: INITIAL =====");
            Console.WriteLine($"Name: {bossName}");
            Console.WriteLine($"Rank: {rank}");
            Console.WriteLine($"Level: {level}");
            Console.WriteLine($"HP: {currentHp} / {maxHp}");
            Console.WriteLine($"Attack Power: {attackPower}");
            Console.WriteLine($"Crit Multiplier: {critMultiplier}");
            Console.WriteLine($"Is Boss: {isBoss}");
            Console.WriteLine();

            int hpPercent = currentHp * 100 / maxHp;
            Console.WriteLine($"HP Percent: {hpPercent}%");
            Console.WriteLine();
            Console.WriteLine("Kirin takes 60 damage!");
            currentHp = currentHp - 60;
            Console.WriteLine();
            Console.WriteLine("===== BOSS STATUS: AFTER DAMAGE =====");
            Console.WriteLine($"HP: {currentHp} / {maxHp}");
            Console.WriteLine($"HP Percent: {currentHp * 100 / maxHp}%");
            Console.WriteLine();    

            //Part B

            Console.WriteLine("===== PartB : Game Kak =====\n");
            string Name1 = "Peak";
            char rank1 = 'S';
            int level1 = 5;
            int maxHp1 = 200;
            int currentHp1 = 190;
            float attackPower1 = 50.0f;
            double critMultiplier1 = 1.5;

            Console.WriteLine($"Name: {Name1}" +
                $"\nRank: {rank1}" +
                $"\nLevel: {level1}" +
                $"\nHP: {currentHp1} / {maxHp1}" +
                $"\nAttack Power: {attackPower1}" +
                $"\nCrit Multiplier: {critMultiplier1}\n");
            
            string Name2 = "Not";
            char rank2 = 'S';
            int level2 = 5;
            int maxHp2 = 200;
            int currentHp2 = 175;
            float attackPower2 = 35.0f;
            double critMultiplier2 = 1.5;

            Console.WriteLine($"Name: {Name2}" +
                $"\nRank: {rank2}" +
                $"\nLevel: {level2}" +
                $"\nHP: {currentHp2} / {maxHp2}" +
                $"\nAttack Power: {attackPower2}" +
                $"\nCrit Multiplier: {critMultiplier2}\n");

            string Name3 = "Bank";
            char rank3 = 'A';
            int level3 = 5;
            int maxHp3 = 200;
            int currentHp3 = 150;
            float attackPower3 = 20.0f;
            double critMultiplier3 = 1.5;

            Console.WriteLine($"Name: {Name3}" +
                $"\nRank: {rank3}" +
                $"\nLevel: {level3}" +
                $"\nHP: {currentHp3} / {maxHp3}" +
                $"\nAttack Power: {attackPower3}" +
                $"\nCrit Multiplier: {critMultiplier3}\n");

            string Name4 = "Ken";
            char rank4 = 'B';
            int level4 = 5;
            int maxHp4 = 200;
            int currentHp4 = 100;
            float attackPower4 = 15.0f;
            double critMultiplier4 = 1.5;

            Console.WriteLine($"Name: {Name4}" +
                $"\nRank: {rank4}" +
                $"\nLevel: {level4}" +
                $"\nHP: {currentHp4} / {maxHp4}" +
                $"\nAttack Power: {attackPower4}" +
                $"\nCrit Multiplier: {critMultiplier4}\n");

        }
    }
}
