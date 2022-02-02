using System;

namespace CItest2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(String.Format("{0:N}", ConvertMilesToKilometers(130000)));
        }

        static double ConvertMilesToKilometers(double miles) => (miles * 1.609);
    }
}
