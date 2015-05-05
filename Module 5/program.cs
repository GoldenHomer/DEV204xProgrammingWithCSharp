#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace Classes
{
    class Program
    {
        static void doWork()
        {
            Point origin = new Point();
            Point coord1 = new Point();
            Point coord2 = new Point();
        }

        static void Main(string[] args)
        {
            try
            {
                doWork();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            Point bottomRight = new Point(1366, 768);
        }
    }
}
