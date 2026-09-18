/*
* Student ID : 1690703457
* Name       : Kittipop Mongkol
* Section    : 129A
* No.        : 
* Course     : GI113 Computer Programming (GI)
*/

namespace Lab04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("+_+_+ NEW ADVENTURE +_+_+"); // Print ธรรมดา Title
            Console.Write("Name your hero: ");  //Writeline พิมพ์บรรทัดใหม่, Write พิมพ์ต่อบรรทัดเดิม

            string playerName = Console.ReadLine(); // เมื่อผู้เล่นกรอกชื่อ จากน้ันชื่อจะเข้าไปเก็บใน playerName

            Console.WriteLine($"\n\"Welcome, {playerName}. Your journey begins...\"");

            Console.WriteLine("\n++++++++++++++++++++++++" +
                "\n+ Difficulty Selection +" +
                "\n++++++++++++++++++++++++");

            Console.Write("Choose Difficulty (1-3): ");
            //string choice = Console.ReadLine(); // รับ Input และเก็บใส่ choice

            int difficulty = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Difficulty set to {difficulty}");

            Console.WriteLine("\\\\\\\\ ITEM SHOP ////////");
            Console.Write("How many potions?: ");
            bool isValid = int.TryParse(Console.ReadLine(), out int quantity);
            Console.WriteLine($">>Valid input: {isValid}");
            Console.WriteLine($">>Quantity: {quantity} potions");

            Console.WriteLine("Welcome to the Adventure Game!");
            Console.Write("+-------------------------------------+" +
                "\n[         Character Creation         ]" +
                "\n+-------------------------------------+");
            Console.Write("\nName your character: ");
            string charName = Console.ReadLine();
            Console.Write("Choose your class (1-3): ");
            bool classValid = int.TryParse(Console.ReadLine(), out int classNum);
            Console.Write("Starting luck (0.0-10.0): ");
            bool luckValid = double.TryParse(Console.ReadLine(), out double luckNum);
            Console.WriteLine($"\n{charName} the Class-{classNum} adventurer enters the dungeon. Luck: {luckNum}");

            Console.WriteLine("+------------------------------+");
            Console.WriteLine("|          SET VOLUME           |");
            Console.WriteLine("+------------------------------+");
            Console.Write("Set music volume (0.0-1.0): ");
            bool volumeOk = double.TryParse(Console.ReadLine(), out double volume);
            Console.WriteLine($"Valid input: {volumeOk}");
            Console.WriteLine($"Volume: {volume}");

            Console.WriteLine("+------------------------------+");
            Console.WriteLine("|         NEW SAVE FILE         |");
            Console.WriteLine("+------------------------------+");
            Console.Write("Enter save name: ");
            string saveName = Console.ReadLine();
            Console.Write("Choose save slot (1-3): ");
            bool slotOk = int.TryParse(Console.ReadLine(), out int slot);
            Console.WriteLine($"Save name: {saveName}");
            Console.WriteLine($"Valid input: {slotOk}");
            Console.WriteLine($"Slot: {slot}");
        }
    }
}
