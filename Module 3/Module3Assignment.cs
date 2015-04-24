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

  static void PrintStudentDetails(string first, string last, string birthday) {
    Console.WriteLine("{0} {1} was born on: {2}", first, last, birthday);
  }
  
  static void GetProfInfo() {
    Console.WriteLine("Enter the professor's first name: ");
      string firstProfName = Console.ReadLine();
  }
  static void PrintProfDetails(string first, string) {
    
  }
  
  static void Main(string[] args) {
    
  }
}
