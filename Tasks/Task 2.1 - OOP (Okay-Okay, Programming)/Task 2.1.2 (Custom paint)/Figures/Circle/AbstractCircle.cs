using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._1._2__Custom_paint_
{
    public abstract class AbstractCircle
    {
        protected int center_x, center_y;
        protected abstract double Area { get; }
        protected abstract double Circumference { get; }
        public abstract void GetInfo();
    }
}
