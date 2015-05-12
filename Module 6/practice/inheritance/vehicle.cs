using System;

namespace Vehicles
{
    class Program
    {
        static void doWork()
        {
            // TODO:
        }

        static void Main()
        {
            try
            {
                doWork();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: {0}", ex.Message);
            }
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
  
  class Airplane:Vehicle {
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
  
  class Car:Vehicle {
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
