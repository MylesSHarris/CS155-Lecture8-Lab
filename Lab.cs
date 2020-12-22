using System;
namespace Lab
{
    public class Lab
    {
        static void Main(string[] arguments)
        {
            Pizza pizza = new Pizza(1, 0, 2, 1);

            Console.WriteLine(pizza.CalculateCost());
            Console.WriteLine(pizza);
        }
    }
}
