using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lucky_Numbers__Felton_
{
    class Program
    {
        static void Main(string[] args)
        {
            int minNum = 0;
            int maxNum = 0;

            int[] randArray = new int[6];
            int[] pickArray = new int[6];
            int numPick = 0;
            int count = 0;
            string jackpot = "384,256.87";
            decimal totalAmt = 384256.87m;
            int correctNum = 0;

            Random random = new Random();
            random.Next(minNum, maxNum);

            string exitResponse;

            Console.WriteLine("Welcome to the Lucky Numbers game!");
            Console.WriteLine("Today's jackpot is: $" + jackpot);
            Console.WriteLine("Win by matching the six randomly selected Lucky Numbers. You can also win by matching fewer than six numbers.");
            Console.Write("Do you want to play Lucky Numbers? Type \"yes\" or \"no\": ");
            exitResponse = Console.ReadLine().ToLower();            

            while (exitResponse.Equals("yes"))
            {

                    Console.Write("Please enter a starting number as the lowest number of your six numbers: ");
                    minNum = int.Parse(Console.ReadLine());
                Console.WriteLine();
                    Console.Write("Please enter an ending number as the highest number of your six numbers: ");
                    maxNum = int.Parse(Console.ReadLine());
                Console.WriteLine();

                    for (int i = 0; i < pickArray.Length; i++)
                    {
                        Console.Write("Please enter a number within your selected range: ");
                        numPick = int.Parse(Console.ReadLine());
                        if (numPick < minNum || numPick >= maxNum)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Sorry. The number you have picked is not between " + minNum + " and " + maxNum + '.');
                            i = i - 1; //resets the index for a valid number (within the range)
                            Console.WriteLine();
                        }
                        else
                            pickArray[i] = numPick;
                        //Console.WriteLine(i); //checks the current index number
                        //Console.WriteLine(pickArray[i]); //checks the value of the current index number
                }

                Random r = new Random();
                for (int index = 0; index < randArray.Length; index++)
                {
                    randArray[index] = r.Next(minNum, maxNum);
                    Console.WriteLine(index);
                    Console.WriteLine("Lucky Number: " + randArray[index]);
                }

                for (int i = 0; i < pickArray.Length; i++)
                {
                    Console.WriteLine(i);
                    for (int j = 0; j < randArray.Length; j++)
                        Console.WriteLine(j);
                    {
                        int j = 0;
                        if (pickArray[i] == randArray[j])
                        {
                            count += 1;
                            Console.WriteLine(count);




                        }


                    }
                            Console.Write("Type correct number guessed here: ");
                            correctNum = int.Parse(Console.ReadLine());
                            decimal matchPot = totalAmt;
                    decimal fractionCorrect = correctNum / 6;
                            Console.WriteLine("You guessed " + correctNum + " correctly!");
                            Console.WriteLine("You won $" + correctNum * totalAmt / 6 + "!");
                            Console.WriteLine();
                            Console.WriteLine();

                Console.Write("Would you like to play again? Enter \"yes\" or \"no\": ");
                string playAgainResponse = Console.ReadLine();

                }









                //}
                //while (exitResponse.Equals("no"))
                //{
                //Console.WriteLine("Are you sure you really want to quit? Type \"yes\" or \"no\", but remember, nobody likes a quitter.");
                //exitResponse = Console.ReadLine().ToLower();
                exitResponse = "no";
            }



        }//Main
    }//class
}//namespace
