using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystem
{
    
    class Student
    {
        public static int id = 1000;
        public int Studentid;
        public String name;
        public String username; //Email
        public String password;
        public String Grade;
        public List<History> HistoryList = new List<History>();


        public Student(String n,String g,String u, String p)
        {
            Studentid = id++;
            name = n;
            password = p;
            username = u;
            Grade = g;


        }

    }
}
