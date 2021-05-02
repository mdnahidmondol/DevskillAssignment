using System;

namespace Question2
{
    class Program
    {
        static void Main(string[] args)
        {
            string numbers = "123, 343, 45, 45,47, 23, 58, 42, 96";
            var realNumber = numbers.Split(',');
            double sum = 0.00;
            foreach(var item in realNumber)
            {
                double number = Convert.ToDouble(item);
                sum = number + sum;

            }

            Console.WriteLine("sum of all values from realNumbers = " + sum);
        }
    }
}
