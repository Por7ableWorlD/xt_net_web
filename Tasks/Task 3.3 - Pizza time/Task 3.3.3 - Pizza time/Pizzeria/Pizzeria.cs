using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3._3._3___Pizza_time
{
    public static class Pizzeria
    {
        public static void CreatePizza(List<string> listPizzas, int number)
        {
            foreach (var pizza in listPizzas)
            {
                var type = (PizzaTypes)Enum.Parse(typeof(PizzaTypes), pizza);

                switch (type)
                {
                    case PizzaTypes.Pepperoni: new Pepperoni(); break;
                    case PizzaTypes.Sardinia: new Sardinia(); break;
                    case PizzaTypes.Carbonara: new Carbonara(); break;
                    default: throw new ArgumentException("Unknown type of pizza", "type");
                }
            }

            Console.WriteLine($"Order number {number} is ready!");
        }
    }

    public enum PizzaTypes
    {
        None,
        Pepperoni,
        Sardinia,
        Carbonara
    }
}
