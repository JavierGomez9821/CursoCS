using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Geometry
{
    public abstract class Figure2D : Figure
    {
        private float _perimeter;

        public abstract float getPerimeter();
        public Figure2D(){ }
        public Figure2D(string name) : base(name) { }
        public Figure2D(string name, string type, string lineColor, string fillColor) : base(name,type,lineColor,fillColor) { }
    }
}