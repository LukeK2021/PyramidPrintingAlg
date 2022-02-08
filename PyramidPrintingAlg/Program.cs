using System;

namespace PyramidPrintingAlg
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, n;
            //n=number of rows to appear in the pattern
            //
            //
            Console.Write("\n\n");
            Console.Write("Display a Pyramid pattern based on rows:\n");
            Console.Write("****************************************");
            Console.Write("\n\n");

            Console.WriteLine("input number of rows for this pattern");
            n = Convert.ToInt32(Console.ReadLine());
            //for loop that takes the row num as a parameter
            for(i=0;i<=n;i++)
            {
                //Calculate how many spaces for each row
                // Total number of rows -row number

                for (j = 1; j <=n - i; j++)
                    Console.Write(" ");
                //Calculate number of stars to print
                //(2 * row number) -1


                for (j = 1; j <=((2 * i) - 1); j++)
                    Console.Write("*");
                Console.Write("\n");
            }

        }

    }
}
