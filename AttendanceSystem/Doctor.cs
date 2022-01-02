using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystem
{
    class Doctor
    {
        public String name;
        public String username; //Email
        public String password;
        static int doctorID = 2000;
        public  Doctor(String n, String u, String p)
        {
            doctorID++;
            name = n;
            password = p;
            username = u;

        }

    }
}
