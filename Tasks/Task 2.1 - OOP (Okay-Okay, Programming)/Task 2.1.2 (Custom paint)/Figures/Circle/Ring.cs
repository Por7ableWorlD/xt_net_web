using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._1._2__Custom_paint_
{
    public class Ring : AbstractCircle
    {
        private int outer_Radius;
        private int inner_Radius;

        public Ring() : base()
        {

        }

        public Ring(int center_X, int center_Y, int inner_Radius, int outer_Radius) : base (center_X, center_Y)
        {
            this.inner_Radius = inner_Radius;
            this.outer_Radius = outer_Radius;
        }

        protected override double Area
        {
            get => Math.Round((Math.PI * Math.Pow(outer_Radius, 2)) - (Math.PI * Math.Pow(inner_Radius, 2)), 2);
        }

        protected override double Circumference
        {
            get => Math.Round((2 * Math.PI * outer_Radius) + (2 * Math.PI * inner_Radius), 2);
        }

        public override string GetInfo()
        {
            if (flag == !false)
            {
                info = $"\n\tКольцо:\n\tПлощадь = {Area}\n\tДлина = {Circumference}\n";
                return info;
            }
            else
            {
                return "";
            }
        }
    }
}
