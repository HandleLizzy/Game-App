using System;



namespace Game_App
{
    class Program
    {
        static void Main(string[] args)
        {
            string appName = "Number guesser";
              
            string appAuthor = "Elizabeth Sibambo";

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("Welcome to {0} game developed by {1}", appName, appAuthor);

            Console.ResetColor();

            //Get use name
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();

    
            Console.WriteLine("Hi {0}, let's play a game ...!", userName);

            while (true)
            {
                //Correct number init
                //int correctNumber = 7;

                //Create random object
                Random random = new Random();

                //init correct number
                int correctNumber = random.Next(1, 10);

                //Guesss init
                int guess = 0;

                //Ask user for number
                Console.WriteLine("Guess a number between 1 to 10");
              
                //Whie guess is not correct
                while (guess != correctNumber)
                {
                    //Get users input
                    string inputNumber = Console.ReadLine();

                    if (!int.TryParse(inputNumber, out guess))
                    {
                        //Change text color
                        Console.ForegroundColor = ConsoleColor.Red;

                        //Tell user its not a number
                        Console.WriteLine("Its not a number, please try again");
                      

                        //Reset text color
                        Console.ResetColor();

                        //Keep going
                        continue;

                    }

                    //Cast to int and put in guess
                    guess = Int32.Parse(inputNumber);

                    //Match guess to correct number
                    if (guess != correctNumber)
                    {
                        //Change text color
                        Console.ForegroundColor = ConsoleColor.Red;

                        //Tell user its the wrong number
                        Console.WriteLine("Wrong number, please try again");
                      
                        //Reset text color
                        Console.ResetColor();
                    }
                }
                    
                        //Change tect color
                        Console.ForegroundColor = ConsoleColor.Blue;

                        //Tell user its the right number
                        Console.WriteLine("You are CORRECT!!!");
                   



                //Reset text color
                Console.ResetColor();

                //Ask to play again
                Console.WriteLine("Play Again? [Y or N]");

                //Get answer
                string answer = Console.ReadLine().ToUpper();


                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    
                    return;
                }
                else
                {
                    return;
                }

            }

           
        }
    }
}
