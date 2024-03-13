using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleAssignment2
{
    public class Rectangle
    {
        private int _length;
        private int _width;

        //Default Constructor
        public Rectangle()
        {
            _length = 1;
            _width = 1;
        }

        //Non default constructor
        public Rectangle(int length, int width)
        {
            _length = length;
            _width = width;
        }

        public int GetLength()
        {
            return _length;
        }

        public void SetLength(int length)
        {
            _length = length;
        }

        public int GetWidth()
        {
            return _width;
        }

        public void SetWidth(int width)
        {
            _width = width;
        }

        public int GetPerimeter()
        {
            return 2 * (_length + _width);
        }

        public int GetArea()
        {
            return _length * _width;
        }
    }
}
