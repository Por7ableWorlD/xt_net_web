using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._1._2__Custom_paint_
{
    class Rectangle : AbstractFigure
    {
        private double second_Side;

        public Rectangle() : base()
        {

        }

        public Rectangle(double first_Side, double second_Side) : base (first_Side)
        {
            this.second_Side = second_Side;
        }

        protected override double Area
        {
            get => Math.Round(first_Side * second_Side, 2);
        }

        public override string GetInfo()
        {
            if (flag == !false)
            {
                string info = $"\n\tПрямоугольник:\n\tПлощадь = {Area}\n";
                return info;
            }
            else
            {
                return "";
            }
        }
    }
}
