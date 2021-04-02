using System;


namespace Test
{
    class RandomNumber
    {
        static void Main(string[] args)
        {
            Random r = new Random();
        nextTurn:
            int randomNumber = r.Next(1, 10);
            int turn = 0;
 
            while (true)
            {
            reType:
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Enter your guess: ");
                String guess = Console.ReadLine();
                int num;
                bool check = int.TryParse(guess, out num);
                if (check)
                {
                    if (num == randomNumber)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Congrad!! Correct number is {0}", num);
                        Console.WriteLine("Do you want contine ? Y/N:");

                        if (Console.ReadLine().Equals("Y"))
                        {
                            goto nextTurn;
                        }
                        else
                        {
                            break;
                        }

                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Wrong Answer, Try Again!");
                        turn++;
                        if (turn == 3)
                        {
                            Console.WriteLine("You guess fail 3 times");
                            Console.WriteLine("Do you want contine ? Y/N:");

                            if (Console.ReadLine().Equals("Y"))
                            {
                                Console.ForegroundColor = ConsoleColor.White;
                                goto nextTurn;
                            }
                            else
                            {
                                break;
                            }
                        }
                    }
                } else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Is not number try again!!!");
                    Console.ForegroundColor = ConsoleColor.White;
                    goto reType;
                }
                
            }
        }
    }
}
