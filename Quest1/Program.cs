using System;

namespace Quest1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            int age;

                Console.Write($"Please enter your name: ");
                name =Console.ReadLine();
                 Console.WriteLine($"The name of the user is {name}");

                 Console.Write($"Please enter your age: ");
                age = Convert.ToInt32 (Console.ReadLine());
                 Console.WriteLine($"The age of the user is {age}");


        }
    }
}
