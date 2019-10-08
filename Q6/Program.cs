using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q6
{
    class Program
    {
        static void Main(string[] args)
        {
            Lunch lunch1, lunch2, lunch3, lunch4, lunch5;
            lunch1 = new Lunch();
            lunch2 = new Lunch();
            lunch3 = new Lunch();
            lunch4 = new Lunch();
            lunch5 = new Lunch();

            lunch1.Entree = "Hamburger";
            lunch1.Side = "Fries";
            lunch1.Drink = "Cola";

            lunch2.Entree = "Pizza";
            lunch2.Side = "salad";
            lunch2.Drink = "water";

            lunch3.Entree = "steak";
            lunch3.Side = "chips";
            lunch3.Drink = "pint";

            lunch4.Entree = "Fish";
            lunch4.Side = "cookie";
            lunch4.Drink = "Tea";

            lunch5.Entree = "sandwich";
            lunch5.Side = "Fruit salad";
            lunch5.Drink = "water";

            Display(lunch1, lunch2, lunch3);
            Console.WriteLine();
            Display(lunch1, lunch2, lunch3, lunch4);
            Console.WriteLine();
            Display(lunch1, lunch2, lunch3, lunch4, lunch5);

        }


        static void Display(params Lunch[] lunches)
        {
            Console.WriteLine("{0, -24}{1, -12}{2, -10}", "Entree", "Side", "Drink");
            foreach (Lunch lunch in lunches)
            {
                Console.WriteLine("{0, -24}{1, -12}{2, -10}", lunch.Entree, lunch.Side, lunch.Drink);
            }
        }
    }

  

    public class Lunch
    {
        public string Entree { get; set; }
        public string Side { get; set; }
        public string Drink { get; set; }
    }
}
