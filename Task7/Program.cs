using System;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.Write("Enter Hourly Rate: ");
            double hourlyRate = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Work Hour: ");
            int workHour = Convert.ToInt32(Console.ReadLine());
            decimal grossPay = 0;
            int extraHour = workHour - 40;
            if(workHour <= 40){
                grossPay = (decimal)hourlyRate * (decimal)workHour;
            } else if(workHour > 40){
                grossPay = ((decimal)hourlyRate * 40M) + ((decimal)hourlyRate *1.5M* extraHour);
            }
            Console.WriteLine($"Pay for employee is {grossPay:C}");
        }
    }
}
