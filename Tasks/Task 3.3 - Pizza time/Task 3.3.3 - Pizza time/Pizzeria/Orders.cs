using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3._3._3___Pizza_time
{
    public class Orders
    {
        public bool confirmed;
        public List<string> orderList;
        private int number = 0;
        public int orderNumber;
        public int receipt;
        public int payment;

        public event Action OrderConfirmed;

        public Orders(string[] pizzaList)
        {
            number++;
            orderNumber = number;
            confirmed = false;
            payment = 0;

            foreach (var pizza in pizzaList)
            {
                orderList.Add(pizza);
            }
        }

        public void CheckPayment()
        {
            if (receipt == payment)
            {
                Pizzeria.CreatePizza(orderList, orderNumber);
            }
        }

        public void Confirm()
        {
            confirmed = true;
            OrderConfirmed?.Invoke();
        }
    }
}
