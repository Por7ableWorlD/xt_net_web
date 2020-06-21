using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._1._2__Custom_paint_
{
    class Square : AbstractFigure
    {
        public Square() : base()
        {

        }

        public Square(double first_Side) : base (first_Side)
        {

        }

        protected override double Area
        {
            get => Math.Round(Math.Pow(first_Side, 2), 2);
        }

        public override string GetInfo()
        {
            if (flag == !false)
            {
                info = $"\n\tКвадрат:\n\tПлощадь = {Area}\n";
                return info;
            }
            else
            {
                return "";
            }
        }
    }
}
