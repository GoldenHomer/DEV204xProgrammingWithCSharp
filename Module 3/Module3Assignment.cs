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
      string addressLine1;
      string addressLine2;
      string city;
      string state;
      int zip;
      string country;
  }

  static void PrintStudentDetails(string first, string last, string birthday) {
    Console.WriteLine("{0} {1} was born on: {2}", first, last, birthday);
  }
}
