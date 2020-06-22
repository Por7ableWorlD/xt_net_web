using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._1._2__Custom_paint_
{
    public class Circle : AbstractCircle
    {
        private int radius;

        public Circle() : base()
        {

        }

        public Circle(int center_X, int center_Y, int radius) : base (center_X, center_Y)
        {
            this.radius = radius;
        }

        protected override double Area
        {
            get => Math.Round(Math.PI * Math.Pow(radius, 2), 2);
        }

        protected override double Circumference
        {
            get => Math.Round(2 * Math.PI * radius, 2);
        }

        protected override string Info
        {
            get => $"\n\tКруг:\n\tПлощадь = {Area}\n\tДлина = {Circumference}\n";
        }

        public override string GetInfo() => flag == !false ? Info : "";
    }
}

