using System.Runtime.Intrinsics.X86;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Geometry
{
    public class Circle : Figure2D
    {
        private float _radius;
        public Circle() { }
        public Circle(string name, float radius) : base(name)
        {
            _radius = radius;
        }
        public float Radio { set { _radius = value; } get { return _radius; } }
        public override float getPerimeter()
        {
            _perimeter = (float)(2 * Math.PI *_radius);
            return _perimeter;
        }
        public override float getSize()
        {
            this.Size = (float)(_radius * _radius * Math.PI);
            return this.Size;
        }
    }
}