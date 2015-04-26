using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Program {
  static void GetStudentInfo() {
      Console.WriteLine("Enter the student's first name: ");
      string firstName = Console.ReadLine();
      Console.WriteLine("Enter the student's last name");
      string lastName = Console.ReadLine();
      
      Console.WriteLine("Enter student's birthday: ");
      DateTime studentBirthday = Console.ReadLine();
      
      Console.WriteLine("Enter address, Line 1");
      string addressLine1 = Console.ReadLine();
      
      Console.WriteLine("Enter address, line 2");
      string addressLine2 = Console.ReadLine();
      
      Console.WriteLine("Enter city: ");
      string city = Console.ReadLine();
      
      Console.WriteLine("Enter state: ")
      string state = Console.ReadLine();
      
      Console.WriteLine("Enter zipcode: ");
      int zip;
      
      Console.WriteLine("Enter country: ");
      string country;
  }
  
  static void ValidateBirthday(){
    NotImplementedException("Could not validate birthday.");
  }

  static void PrintStudentDetails(string first, string last, string birthday) {
    Console.WriteLine("{0} {1} was born on: {2}", first, last, birthday);
  }
  
  
  static void GetProfInfo() {
    Console.WriteLine("Enter the professor's first name: ");
    string firstProfName = Console.ReadLine();
    Console.WriteLine("Enter last name of professor: ");
    string lastProfName = Console.ReadLine();
    Console.WriteLine("Enter birthday: ");
    DateTime profBirth = Console.ReadLine();
  }
  static void Print ProfDetails(string last, string degree, string school) {
    Console.WriteLine("Dr. {0} received a {1} from {2}", last, degree, school);
  }
  
  static void Main(string[] args) {
    ValidateBirthday();
  }
}
