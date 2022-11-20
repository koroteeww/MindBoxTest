using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBoxTestLibraryClass
{
    internal class Rectangle : Figure
    {
        double sideA, sideB;

        public Rectangle(double sideA, double sideB)
        {
            this.sideA = sideA;
            this.sideB = sideB;
        }

        public override double AreaCount()
        {
            double areaResult = sideA * sideB;
            return areaResult;
        }
    }
}
