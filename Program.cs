using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleAssignment2
{
    public class Program
    {
        static void Main(string[] args)
        {
            int length = 0;
            int width = 0;

            while (length == 0)
            {
                Console.Write("Please enter the length of the rectangle: ");
                string tempLength = Console.ReadLine();
                bool isLengthValid = CheckLength(tempLength);
                if (!isLengthValid)
                {
                    length = 0;
                }
                else
                {
                    length = int.Parse(tempLength);
                }
            }
            while (width == 0)
            {
                Console.Write("Please enter the width of the rectangle: ");
                string tempWidth = Console.ReadLine();
                bool isWidthValid = CheckWidth(tempWidth);
                if (!isWidthValid)
                {
                    width = 0;
                }
                else
                {
                    width = int.Parse(tempWidth);
                }

            }
            Rectangle rectangle = new Rectangle(length, width);

            bool exit = false;
            while(!exit)
            {
                int selection = ShowOptions();

                switch (selection)
                {
                    case 1:
                        Console.WriteLine($"\nLength: {rectangle.GetLength()}");
                        break;
                    case 2:
                        Console.Write("Please enter new Length: ");
                        string tempLength = Console.ReadLine();
                        bool isLengthValid = CheckLength(tempLength);
                        if (isLengthValid)
                        {
                            rectangle.SetLength(int.Parse(tempLength));
                            Console.WriteLine($"\nLength changed to {tempLength} successfully.");
                        }
                        break;
                    case 3:
                        Console.WriteLine($"\nWidth: {rectangle.GetWidth()}");
                        break;
                    case 4:
                        Console.Write("Please enter new Width: ");
                        string tempWidth = Console.ReadLine();
                        bool isWidthValid = CheckWidth(tempWidth);
                        if (isWidthValid)
                        {
                            rectangle.SetWidth(int.Parse(tempWidth));
                            Console.WriteLine($"\nWidth changed to {tempWidth} successfully.");
                        }
                        break;
                    case 5:
                        Console.WriteLine($"\nPerimeter: {rectangle.GetPerimeter()}");
                        break;
                    case 6:
                        Console.WriteLine($"\nArea: {rectangle.GetArea()}");
                        break;
                    case 7:
                        exit = true;
                        break;
                }
            }

            if (!exit)
            {
                Console.ReadLine();
            } 
        }

        public static bool CheckLength(string tempLength)
        {
            if (!int.TryParse(tempLength, out int length) || length <= 0)
            {
                Console.WriteLine("\nError, Length must be a valid integer.\n");
                return false;
            }
            return true;
        }

        public static bool CheckWidth(string tempWidth)
        {
            if (!int.TryParse(tempWidth, out int width) || width <= 0)
            {
                Console.WriteLine("\nError, Width must be a valid integer.\n");
                return false;
            }
            return true;
        }

        public static int ShowOptions()
        {
            int selection = 0;
            while (selection == 0)
            {
                Console.WriteLine("\nSelect one option:\n");
                Console.WriteLine("1. Get Rectangle Length");
                Console.WriteLine("2. Change Rectangle Length");
                Console.WriteLine("3. Get Rectangle Width");
                Console.WriteLine("4. Change Rectangle Width");
                Console.WriteLine("5. Get Rectangle Perimeter");
                Console.WriteLine("6. Get Rectangle Area");
                Console.WriteLine("7. Exit");
                string tempSelection = Console.ReadLine();
                if (!int.TryParse(tempSelection, out selection) || selection <= 0 || selection > 7)
                {
                    Console.WriteLine("\nError, Invalid selection.");
                    selection = 0;
                }
            }
            return selection;
        }
    }
}
