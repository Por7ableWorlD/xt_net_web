using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._1._2__Custom_paint_
{
    public abstract class AbstractFigure
    {
        protected double first_Side;

        // I use this "flag" in the override GetInfo methods.
        // Cause I always call GetInfo for all instances of classes in the Draw_in_console class, 
        // I need to check the creation of an instance of the class with specific parameters
        protected bool flag = true;

        protected AbstractFigure() => flag = false;

        protected AbstractFigure(double first_Side)
        {
            this.first_Side = first_Side;
            flag = true;
        }

        protected abstract double Area { get; }
        protected abstract string Info { get; }

        public abstract string GetInfo();
    }
}
