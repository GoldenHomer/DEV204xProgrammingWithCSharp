using System;

public class DegreeProgram {
  string programName;
  string offeredDegree;
  string programAdmin;
  Degree BS;
}

public class Degree {
    string typeOfDegree;
    string degreeName;
    int creditsRequired;
    string course;
    Course ProgrammingWithC#;
}

public class student {
  string first;
  string last;
  string birthday;
  string address1;
  string address2;
  string city;
  string state;
  int zip;
  static int studentsEnrolled;
}

public class Professor {
    string profFirst;
    string profLast;
    string profBirth;
    string profAddress1;
    string profAddress2;
    string profCity;
    string profState;
    int profZip;
    string profCountry
  }
  
  public class Course {
    string name;
    string profName;
    int courseNumber;
    string days;
    DateTime start;
    string[] students = new string[3];
    string[] instructors = new string[3];
    
    Student Huey;
    Student Dewey;
    Student Louie;
    Professor Munsley;
    // Need a way to increment when a new Student is instanciated.
  }

class Program {  
  static void Main(string[] args) {
    Student Huey = new student();
    Student Dewey = new student();
    Student Louie = new student();
    
    Course ProgrammingWithC# = new Course();
    ProgrammingWithC#.name = "Programming with C#";
    
    Professor Munsley = new Prof();
    
    DegreeProgram IT = new DegreeProgram();
    IT.programName = "Information Technology";
    
    Degree BS = new Degree();
    BS.degreeName = "Computer Science";
    
    Console.WriteLine("The {0] program contains the {1} degree.", IT.programName, BS.degreeName);
    Console.WriteLine("The {0] contains the {1}", BS.degreeName, ProgrammingWithC#.name);
    Console.WriteLine("The {0} has {1} students.", ProgrammingWithC#.name, student.studentsEnrolled);
  }
}
