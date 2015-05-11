using System;

// Constructor
public Calculator() 
{ 
    Console.WriteLine("Calculator being created");
    
    public void Dispose() {
        Console.WriteLine("Calculator being disposed");
        if (!this.disposed){
            Console.WriteLine("Calcualtor being disposed.");
        }
        this.disposed = true;
        GC.SuppressFinalize(this);
    }
    
    private bool disposed = false;
}

public int Divide(int first, int second) 
{ 
     return first / second; 
}

// Destructor
~Calculator() 
{ 
     Console.WriteLine("Calculator being finalized");
     this.Dispose();
}

