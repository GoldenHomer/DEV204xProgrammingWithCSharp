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

namespace Mod_9_Homework
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
            public class Student {
                string firstName;
                string lastName;
                string birth;
            }
            
            List<Student> students = new List<Student>;
            
            void CreateStudentAddToListBtn_Click(Object sender, EventArgs e)
            {
                // When the button is clicked, create Student object and add to List.
        
                Button clickedButton = (Button)sender;
                
                //After the creation and submission, clear content of text boxes
                textbox1.Text = "";
                textbox2.Text = "";
                textbox3.Text = "";
                
                //submit
            }
        }
    }
}
