using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    class Point
    {
        private int x;
        private int y;
        private static int objectCount = 0;
        
       // Default constructor
       public Point() {
           Console.WriteLine("default constructor called");
           objectCount++;
       }
       
       // Non-default
       public Point(int x, int y) {
           this.x = Point.x;
           this.y = Point.y;
       }
       
       public void PrintCoords() {
           Console.WriteLine(this.x);
           Console.WriteLine(this.y);
       }
       
       public static int ObjectCount() {
           return objectCount;
       }
    }
}
