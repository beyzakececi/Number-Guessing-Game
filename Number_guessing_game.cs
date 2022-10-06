
namespace NumberGuessingGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Generates random numbers between 1 and 100
            Random randomNumber = new Random(); 
            int winNumber = randomNumber.Next(1,100);

            bool win = false;

            do
            {
                Console.WriteLine("Guess a number inbetween 1 and 100");
                string s = Console.ReadLine();
                int number = int.Parse(s);

                if (number > winNumber)
                {
                    Console.WriteLine("LOWER!!!");
                }
                else if (number < winNumber)
                {
                    Console.WriteLine("HIGHER!!!");
                }
                else if (number < 1 && number > 100)
                {
                    Console.WriteLine("Invalid range");
                }
                else if (number == winNumber)
                {
                    Console.WriteLine("YOU WIN!!!");

                    Console.WriteLine(" Would you like to play again?(YES/NO)");
                    string answer = Console.ReadLine();
                    if (answer == "YES")
                    {
                        win = false;
                    }
                    if (answer == "NO")
                    {
                        win = true;
                        Console.WriteLine("Press any key to finish");
                        Console.ReadKey(true);

                    }
                }

            } while (win == false); // make guesses until the correct number is found

            Console.WriteLine();

            Console.WriteLine("Thank you for playing the game :) ");
            

        }
    }
}