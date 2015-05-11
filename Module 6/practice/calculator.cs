using System;

// Constructor
public Calculator() 
{ 
    Console.WriteLine("Calculator being created");
    public void Dispose() {
        Console.WriteLine("Calculator being disposed");
    }
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

