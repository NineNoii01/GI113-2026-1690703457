namespace Lab07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int command = 1;

            switch (command)
            {
                case 1:
                    Console.WriteLine("Hero swings the sword!");
                    // no break here
                case 2:
                    Console.WriteLine("Loading saved game...");
                    break;
            }   

        }
    }
}
