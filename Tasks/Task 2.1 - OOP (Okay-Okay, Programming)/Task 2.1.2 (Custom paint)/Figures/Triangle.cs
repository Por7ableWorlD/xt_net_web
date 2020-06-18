using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._1._2__Custom_paint_
{
    class Triangle : AbstractFigure
    {
        private bool flag = true;
        private double second_side, third_side;

        public Triangle()
        {
            flag = false;
        }

        public Triangle(double first_side, double second_side, double third_side)
        {
            this.first_side = first_side;
            this.second_side = second_side;
            this.third_side = third_side;
            flag = true;
        }

        protected override double Perimeter
        {
            get => first_side + second_side + third_side;
        }

        protected override double Area
        {
            get => Math.Sqrt(Perimeter/2*(((Perimeter/2) - first_side) * ((Perimeter / 2) - second_side) * ((Perimeter / 2) - third_side)));
        }

        public override void GetInfo()
        {
            if (flag == !false)
            {
                Console.WriteLine($"\n\tТреугольник:\n\tПлощадь = {Area}\n\tПериметр = {Perimeter}\n");
            }
        }
    }
}
