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
}
