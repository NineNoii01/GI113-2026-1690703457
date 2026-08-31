/*
 * Student ID : 1690703457
 * Name       : Kittipop Mongkol
 * Section    : 129A
 * No.        : 
 * Course     : GI113 Computer Programming (GI)
 */

namespace Lab03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int MaxLevel = 10;

            var bossName = "Kirin";   // ต้องประกาศด้วย var ห้ามเขียน string ตรงๆ
            var rank = 'S';            // ต้องประกาศด้วย var ห้ามเขียน char ตรงๆ
            int level = 7;
            int maxHp = 240;
            int currentHp = 115;       // ค่าตั้งต้นของ Lab นี้คือ HP "หลังโดนโจมตี" จาก Lab 2 แล้ว ไม่ใช่ 175
            float attackPower = 42.5f;
            double critMultiplier = 1.75;
            bool isBoss = true;
            // output แสดงค่าตัวแปร
            Console.WriteLine("===== KIRIN SAVE CONVERTER =====");
            Console.WriteLine($"Name : {bossName}\nRank : {rank}\nLevel : {level} / {MaxLevel}\nHP : {currentHp} / {maxHp}" +
                $"\nAttack Poer : {attackPower}\nCrit Multiplier : {critMultiplier}\nIs Boss : {isBoss}");

            // ทำ Implicit int --> double
            Console.WriteLine("\n----- Implicit Conversion: HP as double -----");
            double currentHpDouble = currentHp; // int -> Double แปลงแบบไม่ cast ใส่ค่าได้เลย
            Console.WriteLine($"HP (double): {currentHpDouble}");

            // ทำ Implicit หลังการคำนวณที่ผลลัพธ์มีทศนิยม
            Console.WriteLine("\n----- Exact HP Percent (no integer truncation) -----");
            double hpPercent = currentHpDouble * 100 / maxHp;   // int หาร int จากนั้นแปลงผลลัพธ์การคำนสณเป็น double เพื่อเก็บทศนิยม
            Console.WriteLine($"HP Percent: {hpPercent}%");

            // ทำ Explicit โดยหาร Casting (float) Attack Power -> Int
            Console.WriteLine("\n----- Explicit Cast: Attack Power -> Display Int -----");
            int attackInt = (int)attackPower;   // แปลงข้อมูลโดยการ Cast Syntax: (ชนิดที่ต้องการแปลง)ชื่อตัวแปรที่อยากแปลง
            Console.WriteLine($"Attack Power (int cast): {attackInt}");

            //
            Console.WriteLine("\n----- Cast vs Convert: Crit Multiplier -----");
            int critCast = (int)critMultiplier;
            int critConvert = Convert.ToInt32(critMultiplier);
            Console.WriteLine($"Crit Multiplier (int cast): {critCast}" +
                $"\nCrit Multiplier (Convert rounded): {critConvert}");
        }
    }
}
