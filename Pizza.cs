using System;
namespace Lab
{
    public class Pizza
    {
        private int size;
        private int cheeseToppings;
        private int pepperoniToppings;
        private int hamToppings;

        public Pizza(int size, int cheeseToppings, int pepperoniToppings, int hamToppings)
        {
            this.size = size;
            this.cheeseToppings = cheeseToppings;
            this.pepperoniToppings = pepperoniToppings;
            this.hamToppings = hamToppings;
        }

        public double CalculateCost()
        {
            double cost = 0;
            if (size == 0) cost += 10;
            if (size == 1) cost += 12;
            if (size == 2) cost += 14;
            cost += (cheeseToppings * 2);
            cost += (pepperoniToppings * 2);
            cost += (hamToppings * 2);
            return cost;
        }

        public override string ToString()
        {
            return $"Pizza[size={size} cheeseToppings={cheeseToppings} pepperoniToppings={pepperoniToppings} hamToppings={hamToppings} cost={CalculateCost()}]";
        }
    }
}
