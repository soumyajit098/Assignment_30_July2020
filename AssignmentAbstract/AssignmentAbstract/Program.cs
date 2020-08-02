using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentAbstract
{
    abstract class Quadrilateral
    {
        public int length;
        
        public abstract double Area();
    }

    class Square : Quadrilateral
    {
        public Square(int _length)
        {
            length = _length;
        }
        public override double Area()
        {
            return length* length;
        }
    }

    class Rectangle : Quadrilateral
    {
        public int breadth;

        public bool IsSquare
        {

            get
            {
                if (breadth == length)
                {
                    return true;

                }
                return false;
            }
        }

        public Rectangle(int _length, int _breadth)
        {
            breadth = _breadth;
            length = _length;
                
        }
        public override double Area()
        {
            return length * breadth;
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Quadrilateral sq = new Square(4);
            Console.WriteLine("Area of the square is {0} ",sq.Area());
            Rectangle re = new Rectangle(5, 6);
            Console.WriteLine("Area of the Rectangle is {0} ",re.Area());
           
            if(sq.Area() > re.Area())
            {
               Console.WriteLine("Square area is greater than Rectangle area");
            }
            else
            {
                Console.WriteLine("Rectangle area is greater than the Square area");
            }
            if (re.IsSquare)
            {
                Console.WriteLine("Reactangle is a square for given length & breadth");
            }
        }
    }
}


    

