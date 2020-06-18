using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._1._2__Custom_paint_
{
    class Square : AbstractFigure
    {
        private bool flag = true;

        public Square()
        {
            flag = false;
        }

        public Square(double first_side)
        {
            this.first_side = first_side;
            flag = true;
        }

        protected override double Area
        {
            get => Math.Pow(first_side, 2);
        }

        protected override double Perimeter
        {
            get => first_side * 4;
        }

        public override void GetInfo()
        {
            if (flag == !false)
            {
                Console.WriteLine($"\n\tКвадрат:\n\tПлощадь = {Area}\n\tПериметр = {Perimeter}\n");
            }
        }
    }
}
