using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {       int num1, num2, num3, num4, num5;
                int sum1=0, sum2=0, sum3=0, sum4=0, sum5=0;

            Console.Write("ENTER NO 1:");
            num1 = Convert.ToInt32(Console.ReadLine());


            Console.Write("ENTER NO 2:");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("ENTER NO 3:");
            num3 = Convert.ToInt32(Console.ReadLine());

            Console.Write("ENTER NO 4:");
            num4 = Convert.ToInt32(Console.ReadLine());

            Console.Write("ENTER NO 5:");
            num5 = Convert.ToInt32(Console.ReadLine());

            // checking value of num1 against the other fourth values
                if (num1 < num2 && num1 < num3 && num1 < num4 && num1 < num5)
                   sum1 = num1;

                if (num1 > num2 && num1 < num3 && num1 < num4 && num1 < num5)
                   sum1 = num2;

                if (num1 > num2 && num1 > num3 && num1 < num4 && num1 < num5)
                   sum1 = num3;

                if (num1 > num2 && num1 > num3 && num1 > num4 && num1 < num5)
                   sum1 = num4;

                if (num1 > num2 && num1 > num3 && num1 > num4 && num1 > num5)
                   sum1 = num5;


                // checking value of num2 against the other fourth values
                if (num2 < num1 && num2 < num3 && num2 < num4 && num2 < num5)
                    sum2 = num1;

                if (num2 > num1 && num2 < num3 && num2 < num4 && num2 < num5)
                    sum2 = num2;

                if (num2 > num1 && num2 > num3 && num2 < num4 && num2 < num5)
                    sum2 = num3;

                if (num2 > num1 && num2 > num3 && num2 > num4 && num2 < num5)
                    sum2 = num4;

                if (num2 > num1 && num2 > num3 && num2 > num4 && num2 > num5)
                    sum2 = num5;

                // checking value of num3 against the other fourth values
                if (num3 < num1 && num3 < num2 && num3 < num4 && num3 < num5)
                    sum3 = num1;

                if (num3 > num1 && num3 < num2 && num3 < num4 && num3 < num5)
                    sum3 = num2;

                if (num3 > num1 && num3 > num2 && num3 < num4 && num3 < num5)
                    sum3 = num3;

                if (num3 > num1 && num3 > num2 && num3 > num4 && num3 < num5)
                    sum3 = num4;

                if (num3 > num1 && num3 > num2 && num3 > num4 && num3 > num5)
                    sum3 = num5;

                     // checking value of num4 against the other fourth values
                if (num4 < num1 && num4 < num2 && num4 < num3 && num4 < num5)
                    sum4 = num1;

                if (num4 > num1 && num4 < num2 && num4 < num3 && num4 < num5)
                    sum4 = num2;

                if (num4 > num1 && num4 > num2 && num4 < num3 && num4 < num5)
                    sum4 = num3;

                if (num4 > num1 && num4 > num2 && num4 > num3 && num4 < num5)
                    sum4 = num4;

                if (num4 > num1 && num4 > num2 && num4 > num3 && num4 > num5)
                    sum4 = num5;

                            // checking value of E against the other fourth values
                        if (num5 < num1 && num5 < num2 && num5 < num3 && num5 < num4)
                            sum5 = num1;

                        if (num5 > num1 && num5 < num2 && num5 < num3 && num5 < num4)
                            sum5 = num2;

                        if (num5 > num1 && num5 > num2 && num5 < num3 && num5 < num4)
                            sum5 = num3;

                        if (num5 > num1 && num5 > num2 && num5 > num3 && num5 < num4)
                            sum5 = num4;

                        if (num5 > num1 && num5 > num2 && num5 > num3 && num5 > num4)
                            sum5 = num5;
                 Console.WriteLine("Ranks from Lowest to Highest" + sum1 + " " + sum2 + " " + sum3 + " " + sum4 + " " + sum5);
                 Console.ReadKey();

                                            

    } }
}
