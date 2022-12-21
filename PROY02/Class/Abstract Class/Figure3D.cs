using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Geometry
{
    public abstract class Figure3D : Figure
    {
        public float _volume;
        public Figure3D(){}
        public Figure3D(string name) : base(name) { }
        public Figure3D(string name, string type, string lineColor, string fillColor) : base(name, type, lineColor, fillColor) { }
        
    }
}