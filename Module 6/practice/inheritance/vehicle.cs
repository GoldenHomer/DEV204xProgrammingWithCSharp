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
    }
  
  class Airplane:Vehicle {
    public void TakeOff() {
      Console.WriteLine("Take off");
    }
    
    public void land() {
      Console.WriteLine("Landing");
    }
  }
}
