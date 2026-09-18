/*
* Student ID : 1690703457
* Name       : Kittipop Mongkol
* Section    : 129A
* No.        : 
* Course     : GI113 Computer Programming (GI)
*/

using System;

namespace Assignment01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string GameTitle = "GENSHIN IMPACT"; // const, PascalCase

            var heroName = "Ganyu";             // var บน string
            var heroClass = "Cryo Archer";      // เพิ่มคลาสให้สมบูรณ์
            var heroRank = 'S';                 // var บน char
            int heroLevel = 90;                 // int
            float critChance = 0.65f;           // float
            double staminaPrecise = 240.8;      // double (เลขหลังจุดเป็น 5 ขึ้นไป)
            bool isPlayable = true;

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("|----------------------------------------------|");
            Console.WriteLine($"|           {GameTitle, -35}|");
            Console.WriteLine("|----------------------------------------------|");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"|  Name        : {heroName,-30}|");
            Console.WriteLine($"|  Class       : {heroClass,-30}|");
            Console.WriteLine($"|  Rank        : {heroRank,-30}|");
            Console.WriteLine($"|  Level       : {heroLevel,-30}|");
            Console.WriteLine($"|  Crit Chance : {critChance,-30}|");
            Console.WriteLine($"|  Stamina     : {staminaPrecise,-30}|");
            Console.WriteLine($"|  Playable    : {isPlayable,-30}|");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("|----------------------------------------------|\n");
            Console.ResetColor();

            double heroLevelAsDouble = heroLevel;                      // implicit — ไม่มี cast
            int staminaTruncated = (int)staminaPrecise;                // explicit cast
            int staminaRounded = Convert.ToInt32(staminaPrecise);      // Convert

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine($"Level as double (implicit): {heroLevelAsDouble}");
            Console.WriteLine($"Stamina cast (truncates)  : {staminaTruncated}");
            Console.WriteLine($"Stamina Convert (rounds)  : {staminaRounded}");
            Console.ResetColor();
        }
    }
}
