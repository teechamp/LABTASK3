using System;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
           Task task = new Task();

            Console.Write("Please Enter First Number: ");
            task.FirstNumber = Convert.ToDouble(Console.ReadLine());

            Console.Write("Please Enter Second Number: ");
            task.SecondNumber = Convert.ToDouble(Console.ReadLine());

             int operation = Convert.ToInt32(Console.ReadLine());

             switch(operation)
             {
             case 1:
    Console.WriteLine($"The Result is {task.Add()}");
    break;
             }

        }
    }
}
