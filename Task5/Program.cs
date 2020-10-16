using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
           
                int counter = 1;
                int index = 0;
                int smallest = 0;
                int value = 0;

                Console.WriteLine("How many numbers will you enter: ");
                index = Convert.ToInt32(Console.ReadLine());

                for (counter = 1;counter <= index; counter++)
                {
                    Console.WriteLine("Please input an integer: ");
                    value = Convert.ToInt32(Console.ReadLine());

                    if (counter == 1)
                        smallest = value;

                        else if (value < smallest)
                            smallest = value;
                }

                Console.WriteLine("The smallest number you entered was {0}", smallest);
                Console.ReadLine();
            
        }
    }
}