using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystem
{
    class History
    {
        String date = "date";
        String grade = "grade";
        String subject = "subject" ;

        public History(String d, String g,String s) {

            date = d;
            grade = g;
            subject = s;

        }

        public string Date { get => date; set => date = value; }
        public string Grade { get => grade; set => grade = value; }
        public string Subject { get => subject; set => subject = value; }
    }

}
