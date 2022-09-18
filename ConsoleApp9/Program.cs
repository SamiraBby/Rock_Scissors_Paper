using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputPlayer;
            string inputCpu;
            int randomInt;

            bool playAgain = true;
            while (playAgain)
            {
                int scorePlayer = 0;
                int scoreCpu = 0;


                while (scorePlayer < 3 && scoreCpu < 3)
                {


                    Console.WriteLine(" Please choose on of them -- ROCK,  SCISSORS ,  PAPER  ");
                    inputPlayer = Console.ReadLine().ToUpper();

                    Random rndm = new Random();
                    randomInt = rndm.Next(1, 4);
                    switch (randomInt)
                    {
                        case 1:
                            inputCpu = "ROCK";
                            Console.WriteLine("CPU chose ROCK");
                            if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine("Draw!!");
                            }
                            else if (inputPlayer == "PAPER")
                            {
                                Console.WriteLine("User Won!!!!!)))))");
                                scorePlayer++;
                            }
                            else if (inputPlayer == "SCISSORS")
                            {
                                Console.WriteLine(" CPU WON (((((");
                                scoreCpu++;
                            }
                            break;
                        case 2:
                            inputCpu = "PAPER";
                            if (inputPlayer == "PAPER")
                            {
                                Console.WriteLine("DRAW!!!!!");
                            }
                            else if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine("CPU won");
                                scoreCpu++;
                            }
                            else if (inputPlayer == "SCISSORS")
                            {
                                Console.WriteLine("USER wonn!!!!!!!)))))");
                                scorePlayer++;
                            }

                            break;
                        case 3:
                            inputCpu = "SCISSORS";
                            if (inputPlayer == "SCISSORS")
                            {
                                Console.WriteLine("DRAW!!!!");
                            }
                            else if (inputPlayer == "PAPER")
                            {
                                Console.WriteLine("CPU won!!((((((");
                                scoreCpu++;
                            }
                            else if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine("USER won!!((((((");
                                scorePlayer++;
                            }

                            break;
                        default:
                            Console.WriteLine("Invalid operation");
                            break;
                    }
                    Console.WriteLine("\n\n SCORES :\tPLAYER:\t{0}\tCPU:\t{1}", scorePlayer, scoreCpu);
                }
                if (scorePlayer == 3)
                {
                    Console.WriteLine("User won");
                }
                else if (scoreCpu == 3)
                {
                    Console.WriteLine("CPU won");
                }

                Console.WriteLine("DO woy want to play again ?  y or n ");
                string loop = Console.ReadLine();
                if (loop == "y")
                {
                    playAgain = true;
                    Console.Clear();
                }
                else if (loop == "n")
                {
                    playAgain = false;
                }
            }
        }
    }
}
