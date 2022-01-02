using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystem
{
    class StudentNode
    {
       public Student data;
        public StudentNode next;
    }

    class SingleStudentLinked
    {
        StudentNode head;

        public Student Check_user_Pass(String user_in,String pass_in)
        {
            
            StudentNode p = head;
            while (p != null)
            {
                if (p.data.username == user_in)
                {
                    if (p.data.password == pass_in)
                    {
                        return p.data;
                    }
                }

                p = p.next;

            }
            return null;

        }

        public Student Check_user(String user_in)
        {

            StudentNode p = head;
            while (p != null)
            {
                if (p.data.username == user_in)
                {
                 
                   return p.data;
                    
                }

                p = p.next;

            }
            return null;

        }


        public Student Search_Student(int i)
        {
            StudentNode p = head;
            while (p != null)
            {
                if (p.data.Studentid == i)
                {
                    return p.data;
                }
                p = p.next;
            }
            return null;
        }

        public void insertAtEnd(Student data)
        {
            StudentNode temp = new StudentNode();
            temp.data = data;
            if (head == null)
            {
                head = temp;
                return;
            }

            StudentNode p = head;
            while (p.next != null)
                p = p.next;

            p.next = temp;
            temp.next = null;
        }

    }
}
