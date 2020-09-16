using System;

namespace blinMaker3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int eggsAmount;
            int eggsMin = 1;
            int milksAmount;
            int milksMin = 200; //ml
            int floursAmount;
            int floursMin = 100; //gram


            Console.WriteLine("Pancake maker is starting...");

            Console.WriteLine("How many eggs do you have? ");
            eggsAmount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("you have " + eggsAmount + " eggs");

            Console.WriteLine("How much milks do you have? ");
            milksAmount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("you have " + milksAmount + " ml of milks");

            Console.WriteLine("How much flours do you have? ");

                        floursAmount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("you have " + floursAmount + " gram of flours");

            //msin code here

            if (eggsAmount < eggsMin || milksAmount < milksMin || floursAmount < floursMin)
            {
                Console.WriteLine("no pancake today :(");
            }
            else
            {
                //calculation
                floursAmount = floursAmount / floursMin;
                Console.WriteLine("you have " + floursAmount + " Portition of flours");

                milksAmount = milksAmount / milksMin;
                Console.WriteLine("you have " + milksAmount + " Portition of milks");

                //find smallest number
                int smallest;
                if (eggsAmount <= milksAmount && milksAmount <= floursAmount)
                {
                    smallest = eggsAmount;
                }else if (milksAmount <= floursAmount && milksAmount <= eggsAmount)
                {
                    smallest = milksAmount;
                }
                else
                {
                    smallest = floursAmount;
                }
                Console.WriteLine(" ");
                Console.WriteLine("you can make " + smallest*4 + " portition of Pancakes");
                Console.WriteLine(" ");
                Console.WriteLine("you will need " + smallest*eggsMin + " eggs");
                Console.WriteLine("you will need " + smallest*floursMin + " flours");
                Console.WriteLine("you will need " + smallest*milksMin + " milks");
                Console.WriteLine(" ");
                Console.WriteLine("Pancake maker is shutting down... ");
            }
        }
    }
}

//Created by Muhamad Zibran