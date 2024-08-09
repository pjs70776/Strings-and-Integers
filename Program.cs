using System;
using System.Collections.Generic;


namespace Strings_and_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> listOfIntegers = new List<int>() { 20, 40, 60, 80 };
            Console.WriteLine("Here is a list of integers: 20, 40, 60, 80. \nSelect a number to divide every number on the list");
            int selectedInteger = Convert.ToInt32(Console.ReadLine());

            //try catch block
            try
            { //loop
                for (int i = 0; i < listOfIntegers.Count; i++)
                {
                    Console.WriteLine(listOfIntegers[i] / selectedInteger);
                    Console.ReadLine();
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            //catch for input that is 0
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Program cannot divide by zero.");
            }
            //general expection
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("The program has emerged from the try/catch block successfully.");
            Console.ReadLine();
        }
    }
}
