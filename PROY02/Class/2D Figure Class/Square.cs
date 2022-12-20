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
        public float Lado // Propiedad
        {
            get{return _side;}
            set{_side=value;}
        }
        public override float getPerimeter()
        {
            _perimeter = _side *4;
            return _perimeter;
        }
        public override float getSize()
        {
            float Size = _side*_side;
            this.Size = Size;
            return Size;
        }

    }
}