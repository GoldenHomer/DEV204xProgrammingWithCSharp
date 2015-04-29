using System;

public struct Student {
  public string firstName;
  public string lastName;
  public string degree;
} 

public struct Professor {
  
}

public struct Program {
  
}

public struct Course {
  
}


class Program {
  static void Main(string[] args) {
    Student[] students = new Student[5];
    students[0].firstName = "Encino";
    students[0].lastName = "Man";
    students[0].degree = "Women's Studies";
  }
  Console.WriteLine(students[0].firstName);
  Console.WriteLine(students[0].lastName);
  Console.WriteLine(students[0].degree);
  
  for(int i = 0; i < students.Length; i++) {
    Console.WriteLine("Enter student's first name");
    arr[i].firstName = Console.ReadLine();
    Console.WriteLine("Enter student's last name");
    arr[i].lastName = Console.ReadLine();
    Console.WriteLine("and choice of major.");
    arr[i].degree = Console.ReadLine();
  }

for (int j = 0; j < students.Length; j++) {
  Console.WriteLine(students[j].firstName);
  Console.WriteLine(students[j].lastName);
  Console.WriteLine(students[j].degree);
}


