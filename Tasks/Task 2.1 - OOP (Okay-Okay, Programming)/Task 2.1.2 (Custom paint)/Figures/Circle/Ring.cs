using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._1._2__Custom_paint_
{
    public class Ring : AbstractCircle
    {
        private int outer_radius, inner_radius;
        private bool flag = true;

        public Ring()
        {
            flag = false;
        }

        public Ring(int center_x, int center_y, int inner_radius, int outer_radius)
        {
            this.center_x = center_x;
            this.center_y = center_y;
            this.inner_radius = inner_radius;
            this.outer_radius = outer_radius;
            flag = true;
        }

        protected override double Area
        {
            get => Math.Round((Math.PI * Math.Pow(outer_radius, 2)) - (Math.PI * Math.Pow(inner_radius, 2)), 2);
        }

        protected override double Circumference
        {
            get => Math.Round((2 * Math.PI * outer_radius) + (2 * Math.PI * inner_radius), 2);
        }

        public override void GetInfo()
        {
            if (flag == !false)
            {
                Console.WriteLine($"\n\tКольцо:\n\tПлощадь = {Area}\n\tДлина = {Circumference}\n");
            }
        }
    }
}
