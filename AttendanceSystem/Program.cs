using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AttendanceSystem
{
     static class Program
    {

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]


        static void Main()
        {
            SingleStudentLinked StudentsList = new SingleStudentLinked();
            Global.GlobalLinked.insertAtEnd(new Student("Admin"," ", "admin", "admin"));
            Global.GlobalLinked.insertAtEnd(new Student("Doctor", " ", "doctor", "doctor"));
            Global.GlobalLinked.insertAtEnd(new Student("Peter Joseph", "First year", "pj", "pj"));
            Global.GlobalLinked.insertAtEnd(new Student("Bishoi Botros", "First year", "BishoiBotros", "bb"));
            Global.GlobalLinked.insertAtEnd(new Student("Samer Hany", "First year", "SamerHany", "sh"));
            Global.GlobalLinked.insertAtEnd(new Student("Jack Hany", "First year", "JackHany", "jh"));
            Global.GlobalLinked.insertAtEnd(new Student("Jan Kadry", "First year", "JanKadry", "jk"));
            

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new loginScreen());
        }
    }
}
