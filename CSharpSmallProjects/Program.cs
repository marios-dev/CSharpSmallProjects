using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSmallProjects
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputPlayer, inputCPU;
            int randomInt;
            
            bool playAgain = true;


            while (playAgain)
            {
                int scorePlayer = 0;
                int scoreCPU = 0;
                while (scorePlayer < 5 && scoreCPU < 5)
                {
                    Console.WriteLine("Choose between ROCK,PAPER and SCISSORS:     ");
                    inputPlayer = Console.ReadLine().ToUpper();
                    Random rnd = new Random();
                    randomInt = rnd.Next(1, 4);
                    switch (randomInt)
                    {
                        case 1:
                            inputCPU = "ROCK";
                            Console.WriteLine("Computer chose ROCK");
                            if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine("DRAW!!\n\n");
                            }
                            else if (inputPlayer == "PAPER")
                            {
                                Console.WriteLine("PLAYER WINS!!\n\n");
                                scorePlayer++;
                            }
                            else if (inputPlayer == "SCISSORS")
                            {
                                Console.WriteLine("THE COMPUTER WON!!\n\n");
                                scoreCPU++;
                            }
                            break;
                        case 2:
                            inputCPU = "PAPER";
                            Console.WriteLine("Computer chose PAPER");
                            if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine("THE COMPUTER WON!!\n\n");
                            }
                            else if (inputPlayer == "PAPER")
                            {
                                Console.WriteLine("DRAW!!\n\n");
                                scorePlayer++;
                            }
                            else if (inputPlayer == "SCISSORS")
                            {
                                Console.WriteLine("THE PLAYER WON!!\n\n");
                                scoreCPU++;
                            }
                            break;
                        case 3:
                            inputCPU = "SCISSORS";
                            Console.WriteLine("Computer chose SCISSORS");
                            if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine("THE PLAYER WINS!!\n\n");
                                scorePlayer++;
                            }
                            else if (inputPlayer == "PAPER")
                            {
                                Console.WriteLine("THE COMPUTER WINS!!\n\n");
                                scoreCPU++;
                            }
                            else if (inputPlayer == "SCISSORS")
                            {
                                Console.WriteLine("DRAW!!\n\n");
                            }
                            break;
                        default:
                            Console.WriteLine("Invalid Entry");
                            break;
                    }
                    Console.WriteLine($"\n\n SCORES -> \tPLAYER:{scorePlayer}\tCPU:\t{scoreCPU}");
                }
                if (scorePlayer == 3)
                {
                    Console.WriteLine("Player WON!");
                }
                else if (scoreCPU == 3)
                {
                    Console.WriteLine("The Computer WON");
                }
                Console.WriteLine("Do you want to play again (Y/N)?");
                string loop = Console.ReadLine();
                if (loop == "y".ToUpper())
                {
                    playAgain = true;
                    Console.Clear();
                }
                else if (loop == "n".ToUpper())
                {
                    playAgain = false;
                }
                else
                {
                    playAgain = false;
                }

            }
        }
    }
}
