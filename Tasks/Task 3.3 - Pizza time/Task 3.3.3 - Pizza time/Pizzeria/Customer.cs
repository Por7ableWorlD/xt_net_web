using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3._3._3___Pizza_time
{
    public class Customer
    {
        private int money;
        public string[] listPizzas;

        Action Pay;
        Orders Order;

        public Customer(int money)
        {
            this.money = money;
            listPizzas = new string[] { "Pepperoni", "Carbonara" };
            Pay += PayReceipt;
            Order.OrderConfirmed += Pay;
        }

        public void ConfirmOrder()
        {
            Order.Confirm();
        }

        public void CustomerNewOrder()
        {
            Order = new Orders(listPizzas);
        }

        private void PayReceipt()
        {
            int payment = Order.receipt;

            if (money > payment)
            {
                money = -payment;
                Order.payment = +payment;
            }
            else
            {
                Console.WriteLine("You don't have enough money!");
            }
        }
    }
}
