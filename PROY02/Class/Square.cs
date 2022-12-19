using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Geometry
{
    public class Square : Figure2D
    {
        private float _side;
        public Square() { }
        public Square(string name, float side) : base(name)
        {
            _side = side;
        }
        public override float getPerimeter()
        {
            return _side * _side;
        }

    }
}