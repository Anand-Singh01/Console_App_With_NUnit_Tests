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
            if (length < 1 || width < 1)
            {
                throw new ArgumentException("Error, length or width cannot be less than 1");
            }
            _length = length;
            _width = width;
        }

        public int GetLength()
        {
            return _length;
        }

        public void SetLength(int length)
        {
            if (length < 1)
            {
                throw new ArgumentException("Error, Length cannot be less than 1");
            }
            _length = length;
        }

        public int GetWidth()
        {
            return _width;
        }

        public void SetWidth(int width)
        {
            if (width < 1)
            {
                throw new ArgumentException("Error, Width cannot be less than 1");
            }
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
