using System;

// Constructor
public Calculator() 
{ 
    Console.WriteLine("Calculator being created"); 
}

public int Divide(int first, int second) 
{ 
     return first / second; 
}

// Destructor
~Calculator() 
{ 
     Console.WriteLine("Calculator being finalized"); 
}

