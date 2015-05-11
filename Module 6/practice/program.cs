using System;

class Program {
  public static void Main(string[] args) {
   Calculator calculator = new Calculator();
   Console.WriteLine("{0} / {1} = {2}", 120, 15, calculator.Divide(120, 15)); 
   Console.WriteLine("Program finishing");
  }
}
