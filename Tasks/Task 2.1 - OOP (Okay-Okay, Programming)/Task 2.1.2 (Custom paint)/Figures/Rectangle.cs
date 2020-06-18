using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._1._2__Custom_paint_
{
    class Rectangle : AbstractFigure
    {
        private bool flag = true;
        private double second_side;

        public Rectangle()
        {
            flag = false;
        }

        public Rectangle(double first_side, double second_side)
        {
            this.first_side = first_side;
            this.second_side = second_side;
            flag = true;
        }

        protected override double Area
        {
            get => first_side * second_side;
        }

        protected override double Perimeter
        {
            get => 2 * (first_side + second_side);
        }

        public override void GetInfo()
        {
            if (flag == !false)
            {
                Console.WriteLine($"\n\tПрямоугольник:\n\tПлощадь = {Area}\n\tПериметр = {Perimeter}\n");
            }
        }
    }
}
