using System;

namespace exercise_6._4_number_detector
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, please enter a number");
            try
            {
                string prompt = Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            while (prompt != "x")
            {
                Console.WriteLine("enter a new number");
            }
            
        }
        
    }
}