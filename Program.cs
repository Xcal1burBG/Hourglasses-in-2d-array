using System;

namespace HourglassIn2dArray
{
    class Program
    {
        static void Main(string[] args)
        {

            int finalResult = 0;

            //creating 2 dimensional array 

            int[,] myMatrix = new int[6, 6];

            for (int i = 0; i < 6; i++)
            {

                Console.WriteLine("Please, enter 6 numbers divided by space for the next array: ");
                String[] stringArray = Console.ReadLine().Split(" ");
                int[] intArray = new int[6];

                for (int j = 0; j < 6; j++)
                {
                    intArray[j] = int.Parse(stringArray[j]);
                }

                for (int k = 0; k < 6; k++)
                {
                    myMatrix[i, k] = intArray[k];
                }


            }



            //printing 2 dimensional array
            Console.WriteLine("You have entered the 2 dimentional array below:");

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Console.Write(myMatrix[i, j] + " ");
                }

                Console.WriteLine();
            }

            finalResult = MaxHourGlassCount(myMatrix);

            Console.WriteLine($"The highest hourglass sum is {finalResult}");


        }

        public static int MaxHourGlassCount(int[,] matrix)
        {
            int maxCount = 0;

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {

                    int tempCount = matrix[i, j] + matrix[i, j + 1] + matrix[i, j + 2] + matrix[i + 1, j + 1] + matrix[i + 2, j] + matrix[i + 2, j + 1] + matrix[i + 2, j + 2];

                    if (tempCount > maxCount)
                    {
                        maxCount = tempCount;
                    }
                }
            }




            return maxCount;
        }
    }
}
