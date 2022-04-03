using System;

namespace Delegate_Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] Product = { 1.5, 0.7, 2.3, 7.2, 3.4 };
            Action<double[]> TotalAndCount = ProductTotalAndPrice;
            ProductTotalAndPrice(Product);
        }
        public static void ProductTotalAndPrice(double[] arr)
        {
            int count = default(int);
            double price = default(double);
            foreach (double item in arr)
            {
                count++;
                price += item;
            }
            Console.WriteLine($"Count: {count}, Price:{ price}");

        }
    }
}
