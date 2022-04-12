using System;

namespace A___B_True_or_False
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CheckNumbers checkNumbers = new CheckNumbers();
            checkNumbers.Reader();
            checkNumbers.Checker();
        }

        public class CheckNumbers
        {
            int a, b;
            public void Reader()
            {
                Console.WriteLine("Enter number A and press ENTER...");
                a  = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter number B and press ENTER...");
                b = Convert.ToInt32(Console.ReadLine());
            }

            public void Checker()
            {
                if (a == b)
                {
                    Console.WriteLine("A and B are the same numbers");
                } else
                {
                    Console.WriteLine("A and B are different numbers");
                }
            }
        }
    }
}
