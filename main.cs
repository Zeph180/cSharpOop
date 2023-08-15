using System;
using RectangleApp;
using PolymorphismApplication;

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

namespace PolymorphismApplication {
    class PrintData {
        public void print(int i) {
            Console.WriteLine("Printing int: {0}", i);
        }
        
       public void print(double f) {
            Console.WriteLine("Printing float: {0}", f);
        }
        
        public void print(string s) {
            Console.WriteLine("Printing int: {0}", s);
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

        Console.WriteLine ("---------SQUARE APPLICATION-------");
        Square s = new Square();
        s.GetSDetails();
        s.DisplaySquare();
        s.SquareArea();

        //Polymorphism using Functional overloading 
        Console.WriteLine("--------POLYMORPHISM STARTS HERE----------");
        PrintData p = new PrintData();
        //print integer
        p.print(4);
        //print float
        p.print(4.9);
        //print string
        p.print("Hello there");
    }
  }
