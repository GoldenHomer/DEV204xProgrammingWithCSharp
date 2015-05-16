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
          
          ListStudents();
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
    public void Complain() {
      Console.WriteLine("When will I ever use this again?!");
    }
    
    public class Stack {
        Student Huey = new student();
        Student Dewey = new student();
        Student Louie = new student();
          
        Student Huey.firstName = "Huey";
        Student Dewey.firstName = "Dewey";
        Student Dewey.firstName = "Louie";
        
        
    }
    Stack<int> grades = new Stack<int>();
    grades.Push(95);
    grades.Push(77);
    grades.Push(82);
    grades.Push(89);
    grades.Push(97);
  }
  
  class Professor:Person {
    // public override void Drive() {
    //     Console.WriteLine("Motoring");
    // }
    
    public void Done() { 
        Console.WriteLine("I'm failing you."); 
    } 
  }
  
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
        
        public class Course {
            string name;
            string profName;
            int courseNumber;
            string days;
            string start;
            List<Student> students = new List<Student>();
            string[] instructors = new string[3];
            
            Professor Munsley;
            // Need a way to increment when a new Student is instanciated.
            
            // Adding students to list
            students.Add(Huey);
            students.Add(Dewey);
            students.Add(Louie);
            
            public void ListStudents(){
              foreach (Student student in students) {
                Console.WriteLine("Student's first name is {0}", student.firstName);
              }
            }
        }
}
