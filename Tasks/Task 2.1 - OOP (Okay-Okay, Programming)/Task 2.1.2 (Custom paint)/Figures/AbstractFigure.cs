using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._1._2__Custom_paint_
{
    abstract class AbstractFigure
    {
        protected double first_side;
        protected abstract double Area { get; }
        protected abstract double Perimeter { get; }
        public abstract void GetInfo();
    }
}
