using System;

public namespace Program {
  public struct Student {
    public string firstName;
    public string lastName;
    public string address;
    DateTime birth;
  }
  
  public static void Main(string[] args) {
    enum Days {Sat, Sun, Mon, Tue, Wed, Thu, Fri};
    enum Months {Jan, Feb, Mar, Apr, May, Jun, Jul, Aug, Sep, Oct, Nov, Dec};
    int[] Numbers = new int[5];
    
    for(int i = 0; Numbers.Length; i++){
      Numbers[i] = i;
    }
    
    while(i < Numbers.Length) {
      Console.WriteLine("Element in index {0} of Numbers array is {1}", i, Numbers[i]);
    }
  }
}
