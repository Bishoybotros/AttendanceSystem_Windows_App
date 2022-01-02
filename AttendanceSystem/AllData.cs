using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystem
{
    static class Global
    {
        private static Student _globalVar = new Student("","","","");

        public static Student GlobalVar
        {
            get { return _globalVar; }
            set { _globalVar = value; }
        }
        private static SingleStudentLinked _globalLinked = new SingleStudentLinked();

        public static SingleStudentLinked GlobalLinked
        {
            get { return _globalLinked; }
            set { _globalLinked = value; }
        }

        static void close()
        {

            





        }

    }
}
