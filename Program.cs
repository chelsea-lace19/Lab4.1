using System;

namespace Lab4._1
{
    class Program
    {
        static void DiceCombos(int x, int y)
        {
            if (x == 1 && y == 1)
            {
                Console.WriteLine("Snake Eyes!");
            }
            if (x == 1 && y == 2 || x == 2 && y == 1)
            {
                Console.WriteLine("Ace Deuce!");
            }
            if (x == 6 && y == 6)
            {
                Console.WriteLine("Box Cars!");
            }
            if (x+y == 7 || x+y == 11)
            {
                Console.WriteLine("You Win!!!");
            }
            if (x+y == 2 || x+y == 3 || x+y == 12)
            {
                Console.WriteLine("CRAPS!");
            }


        }
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to the Grand Circus Casino!");
            Console.WriteLine("How many sides should each die have?");
            int sides = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Would you like to roll the dice? (y/n): ");
            string answer = Console.ReadLine();
            int rollNum = 1;

            bool done = false;

            while (!done)
            {
      
                if (answer == "y")
                {
                    Random roll = new Random();
                    int dieOne = roll.Next(1, sides+1);
                    int dieTwo = roll.Next(1, sides+1);
                    Console.WriteLine($"\nRoll {rollNum}:");
                    Console.WriteLine($"You rolled a {dieOne} and a {dieTwo} ({dieOne + dieTwo} total)");
                    DiceCombos(dieOne, dieTwo);
                    rollNum++;
                    bool validResponse = false;

                    while (!validResponse)
                    {
                        Console.Write("Would you like to roll again? (y/n): ");
                        string response = Console.ReadLine();

                        if (response != "Y" && response != "y" && response != "N" && response != "n")
                        {
                            Console.Write("Please only enter \"y\" or \"n\". \n");
                        }
                        else
                        {
                            validResponse = true;
                            if (response == "N" || response =="n")
                            {
                                done = true;
                            }
                        }
                    }
                }
                else if (answer == "n")
                {
                    Console.WriteLine("Thank you for playing, goodbye!");
                    done = true;
                }

            }




        }
    }
}
