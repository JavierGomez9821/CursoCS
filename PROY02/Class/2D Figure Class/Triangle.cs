using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Geometry
{
    public class Triangle : Figure2D
    {
        private float _side1;
        private float _side2;
        private float _side3;
        public Triangle() { }
        public Triangle(string name, float Lado1, float Lado2, float Lado3) : base(name)
        {

        }
        public float Lado1 { set { _side1 = value; } get { return _side1; } }
        public float Lado2 { set { _side2 = value; } get { return _side2; } }
        public float Lado3 { set { _side3 = value; } get { return _side3; } }
        public override float getSize()
        {
            float SemiP = this._perimeter/2;
            float Size = (float)Math.Sqrt(SemiP*(SemiP-_side1)*(SemiP - _side2)*(SemiP - _side3));
            this.Size = Size;
            return Size;
        }
        public override float getPerimeter()
        {
            _perimeter = _side1 + _side2 + _side3;
            return _perimeter;
        }
    }
}