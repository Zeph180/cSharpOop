using System;
using RectangleApp;

namespace RectangleApp
{
    
    class Rectangle {
        public double length;
        public double width;
        
        public double GetArea () {
            return length * width;
        }
        
        public void Display () {
            Console.WriteLine("Lenght: {0}", length);
            Console.WriteLine("Width: {0}", width);
            Console.WriteLine("Area: {0}", GetArea());
            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();
        }
    }
    
    class Square {
        private double Slength;
        private double Swidth;
        
        public double SquareArea () {
            return Slength * Swidth;
        }
        
        public void GetSDetails () {
            Console.WriteLine("Enter length: {0}", Slength);
            Slength = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter width: {0}", Swidth);
            Swidth = Convert.ToDouble(Console.ReadLine());
        }
        
        public void DisplaySquare () {
            Console.WriteLine("Square area: {0}", SquareArea());
        }
    }
}

  public class MyApp {
        public static void Main(string[] args)
    {
        Console.WriteLine ("---------RECTANGLE APPLICATION-------");
        
        Rectangle MyRec = new Rectangle();
        MyRec.length = 3.1;
        MyRec.width = 4.1;
        MyRec.Display();
        
        Square s = new Square();
        s.GetSDetails();
        s.DisplaySquare();
        s.SquareArea();
    }
  }
