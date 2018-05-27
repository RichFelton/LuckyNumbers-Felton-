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

            Random random = new Random();
            random.Next(minNum, maxNum);


            string exitResponse;

            Console.WriteLine("Welcome to the Lucky Numbers game!");
            Console.WriteLine("Win by matching the six randomly selected Lucky Numbers. You can also win by matching fewer than six numbers.");
            Console.Write("Do you want to play Lucky Numbers? Type \"yes\" or \"no\": ");
            exitResponse = Console.ReadLine().ToLower();
            


            while (exitResponse.Equals("yes"))
            {               
                Console.WriteLine("Please enter a starting number as the lowest number of your six numbers: ");
                minNum = int.Parse(Console.ReadLine());
                Console.WriteLine("Please enter an ending number as the highest number of your six numbers: ");
                maxNum = int.Parse(Console.ReadLine());

                Console.Write("Please enter your guess of one of the 6 Lucky Numbers within your selected range: ");
                numPick = int.Parse(Console.ReadLine());
                
                if (numPick < minNum || numPick >= maxNum)
                {
                    Console.WriteLine("Sorry. The number you have picked is not between " + minNum + " and " + maxNum + '.');
                    Console.Write("Please enter a number between " + minNum + " and " + maxNum + ": ");
                }
                else
                    Console.Write("Please enter another number: ");
                {  
                

                }


                for (int i = 0; i < pickArray.Length; i++)
                {
                    for (int j = 0; j < randArray.Length; j++)
                    {
                        if (pickArray[i] == randArray[j])
                            {
                            count += 1;
                        }
                    }
                }
                








            }
            while (exitResponse.Equals("no"))
            {
            Console.WriteLine("Are you sure you really want to quit? Type \"yes\" or \"no\", but remember, nobody likes a quitter.");
            exitResponse = Console.ReadLine().ToLower();
            
            }
            


        }//Main
    }//class
}//namespace
