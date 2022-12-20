using System.Drawing;
using System.Xml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Geometry
{
    public abstract class Figure
    {
        private string _name;
        private string _id;
        private string _type;
        private float _size;
        private string _lineColor;
        private string _fillColor;
        protected float _perimeter;
        const string BLACK = "#000000";
        const string WHITE = "#FFFFFFF";
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public string Id {get{return _id;}}
        public float Size { get { return _size; } set { _size = value; } }
        public string LineColor
        {
            get
            {
                return _lineColor;
            }
            set
            {
                string strRegex = @"^#([A-Fa-f0-9]{6}|[A-Fa-f0-9]{3})$";
                Match re = Regex.Match(value, strRegex);
                if (re.Success)
                    _lineColor = value;
                else
                    throw new ArgumentException("Color no aceptado. Defina uno nuevo.");
            }
        }

        public abstract float getSize();

        public Figure()
        {
            _id = Guid.NewGuid().ToString();
        }

        public Figure(string name, string type, string lineColor, string fillColor)
        {
            _name = name;
            _type = type;
            _lineColor = lineColor;
            _fillColor = fillColor;
            _id = Guid.NewGuid().ToString();
        }

        public Figure(string name)
        {
            _name = name;
            _lineColor = BLACK;
            _fillColor = WHITE;
            _type = "";
            _id = Guid.NewGuid().ToString();
        }



        public void Paint() { }


    }
}