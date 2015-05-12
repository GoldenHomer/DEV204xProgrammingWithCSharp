using System;

namespace Person
{
    class Program
    {
        static void Main()
        {
          string firstName;
          string lastName;
          int weight;
          string height;
          string birthday;
        }
        
        public void StartEngine(string noiseToMakeWhenStarting) {
          Console.WriteLine("Starting engine: {0}", noiseToMakeWhenStarting);
        }
        
        public void StopEngine(string noiseToMakeWhenStopping) {
          Console.WriteLine("Stopping engine: {0}", noiseToMakeWhenStopping);
        }
        
        public virtual void Drive() 
        {
            Console.WriteLine("Default implementation of the Drive method");
        }
    }
  
  class Student:Person {
    public override void Drive() {
        Console.WriteLine("Flying");
    }
    public void TakeOff() {
      Console.WriteLine("Take off");
    }
    
    public void land() {
      Console.WriteLine("Landing");
    }
  }
  
  class Professor:Person {
    public override void Drive() {
        Console.WriteLine("Motoring");
    }
    
    public void Accelerate() { 
        Console.WriteLine("Accelerating"); 
    } 

    public void Brake() { 
        Console.WriteLine("Braking"); 
    }
  }
}
