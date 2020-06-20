using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._1._2__Custom_paint_
{
    class Triangle : AbstractFigure
    {
        private double second_Side;
        private double third_Side;

        public Triangle() : base()
        {

        }

        public Triangle(double first_Side, double second_Side, double third_Side) : base (first_Side)
        {
            this.second_Side = second_Side;
            this.third_Side = third_Side;
        }

        protected double Perimeter
        {
            get => first_Side + second_Side + third_Side;
        }

        protected override double Area
        {
            get => Math.Round(Math.Sqrt(Perimeter/2*(((Perimeter/2) - first_Side) * ((Perimeter / 2) - second_Side) * ((Perimeter / 2) - third_Side))),2);
        }

        public override string GetInfo()
        {
            if (flag == !false)
            {
                string info = $"\n\tТреугольник:\n\tПлощадь = {Area}\n";
                return info;
            }
            else
            {
                return "";
            }
        }
    }
}
