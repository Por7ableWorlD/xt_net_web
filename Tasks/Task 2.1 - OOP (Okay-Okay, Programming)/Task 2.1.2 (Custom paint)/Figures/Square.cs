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

        protected override string Info
        {
            get => $"\n\tКвадрат:\n\tПлощадь = {Area}\n";
        }

        public override string GetInfo() => flag == !false ? Info : "";
    }
}
