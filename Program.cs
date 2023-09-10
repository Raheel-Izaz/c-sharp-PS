using System;

namespace Arrays_in_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            string[] cars =
            {
                "BMW",
                "Supra",
                "Odi",
                "GTR",
                "Civic",
                "Sonata"
            };
            Array.Sort(cars);
            foreach (string i in cars)
            {
                Console.WriteLine(i);
            }

            int[] sections =
            {
                4,
                2,
                8,
                7,
                3
            };
            Array.Sort (sections);
            foreach (int sec in sections)
            {
                Console.WriteLine(sec);
            }

            // MultiDimensional Arrays

            string[,] cars =
            {
                {"BMW", "Supra","GTR"},
                {"Nissan","Sonata","Elantra" }
            };

            Console.WriteLine(cars[0,2]);
            Console.WriteLine("This is all cars");
            foreach (string i in cars)
              {
                  Console.WriteLine(i);
              }
             */
            Console.WriteLine("Enter Array Lenght ");
            int length = Convert.ToInt32(Console.ReadLine());
            int[] myAry = new int[length];
            for (int i=1;  i<=length; i++) {
                Console.WriteLine("Enter Array Value");
                int userInput = Convert.ToInt32(Console.ReadLine());
                myAry[i] = userInput;
            }
            Console.WriteLine("Your Array values");
            for(int j=1; j<=length;j++) {
                Console.Write($"{myAry[j]} \n");

            }
            //Console.WriteLine(" ");
            Console.WriteLine("MultiPlication");
            for (int z=1;z<=length;z++)
            {
                int multiplication = myAry[z] * z;
                Console.WriteLine($"{myAry[z]} x {z} = {multiplication}");

            }


            Console.ReadKey();
        }
    }
}
