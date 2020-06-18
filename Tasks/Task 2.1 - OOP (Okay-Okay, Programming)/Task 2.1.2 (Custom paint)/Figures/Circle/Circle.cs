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
        private bool flag = true;

        public Circle()
        {
            flag = false;
        }

        public Circle(int center_x, int center_y, int radius)
        {
            this.center_x = center_x;
            this.center_y = center_y;
            this.radius = radius;
            flag = true;
        }

        protected override double Area
        {
            get => Math.Round(Math.PI * Math.Pow(radius, 2), 2);
        }

        protected override double Circumference
        {
            get => Math.Round(2 * Math.PI * radius, 2);
        }

        public override void GetInfo()
        {
            if (flag == !false)
            {
                Console.WriteLine($"\n\tКруг:\n\tПлощадь = {Area}\n\tДлина = {Circumference}\n");
            }
        }
    }
}

