using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._1._2__Custom_paint_
{
    public abstract class AbstractCircle : AbstractFigure
    {
        protected int center_X;
        protected int center_Y;

        protected AbstractCircle () : base()
        {

        }

        protected AbstractCircle (int center_X, int center_Y)
        {
            this.center_X = center_X;
            this.center_Y = center_Y;
            flag = true;
        }

        protected abstract double Circumference { get; }
    }
}
