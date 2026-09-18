/*
* Student ID : 1690703457
* Name       : Kittipop Mongkol
* Section    : 129A
* No.        : 
* Course     : GI113 Computer Programming (GI)
*/

namespace Lab05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ===> BATTLE MAGE <=== ");
            Console.WriteLine("Hero vs. Monsters -- Fight calculator ");

            // User input of Hero Stats
            Console.Write("Hero Health: ");
            bool isHeroHp = int.TryParse(Console.ReadLine(), out int heroHp);
            Console.Write("Hero Attack: ");
            bool isHeroAtk = int.TryParse(Console.ReadLine(), out int heroAtk);
            Console.Write("Hero Defence: ");
            bool isHeroDef = int.TryParse(Console.ReadLine(), out int heroDef);

            // User input of Monster Stats
            Console.Write("Monster Health: ");
            bool isMonHp = int.TryParse(Console.ReadLine(), out int monHp);
            Console.Write("Monster Attack: ");
            bool isMonAtk = int.TryParse(Console.ReadLine(), out int monAtk);
            Console.Write("HMonster Defence: ");
            bool isMonDef = int.TryParse(Console.ReadLine(), out int monDef);

            // Check if player input is valid
            bool allSHeroValid = isHeroHp && isHeroAtk && isHeroDef;
            bool allMonValid = isMonHp && isMonAtk && isMonDef;
            Console.WriteLine($"Stats Validation: HERO: {allSHeroValid}, MONSTER: {allMonValid}");
            Console.WriteLine($"[HERO]      HP: {heroHp} ATK: {heroAtk} DEF: {heroDef}");
            Console.WriteLine($"[MONSTER]   HP: {monHp} ATK: {monAtk} DEF: {monDef}");

            // Before fighting: Hero drinks a potion (Compound Assignment)
            int potionHeal = 8;
            // 1.   heroHp = heroHp + potionHeal;
            /* 2.*/ heroHp += potionHeal; // แนะนำแบบนี้ คำนวณเหมือนกัน 1 = 1+2
            Console.WriteLine($"\n=> Hero dribks a potion, Healing {potionHeal}HP. health is now {heroHp}.");

            // คำนวณ damage normal attack (Arithmetic + Math)
            int normalDamage = Math.Max(0, heroAtk - monDef);
            Console.WriteLine($"Normal Attack deal: {normalDamage} DMG");

            // คำนวณ power attack (Predence ลำดับการคำนวณ คูณ ก่อนที่จะ ลบ)
            int powerDamage = Math.Max(0, heroAtk * 2 - monDef); // เรียงลำดับ * มาก่อน - ไม่จำเป็นต้องมี ()
            Console.WriteLine($"Power Attack deal: {powerDamage} DMG");

            // คำนวณ Monster Attack
            int counterDamage = Math.Max(0, monAtk - heroDef);
            Console.WriteLine($"Monster Counter Attack deal: {counterDamage} DMG");

            // คำนวณ Cri Chance
            Random rng = new Random();
            int roll = rng.Next(1, 101);    // สุ่ม Cri 1-100
            bool isCrit = roll <= 10; // 10%
            int critDamage = normalDamage + Convert.ToInt32(isCrit) * normalDamage; // โอกาส 10% ติดคริ เลขได้ 1 ไม่ติดได้ 0
            Console.WriteLine($"Critical hit roll: {roll} (critical: {isCrit})");
            Console.WriteLine($"Normal Attack would deal Critical: {critDamage} DMG");
        }
    }
}
