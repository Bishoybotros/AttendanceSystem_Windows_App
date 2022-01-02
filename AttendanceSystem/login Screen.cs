using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AttendanceSystem
{

    public partial class loginScreen : Form
    {
 
  
        public loginScreen()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.AcceptButton = this.button_woc1;



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
     
        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (UsernameBox.Text == "Username")
            {
                UsernameBox.Text = "";
                UsernameBox.ForeColor = Color.Black;

            }
        }

        private void UsernameBox_Leave(object sender, EventArgs e)
        {
            if (UsernameBox.Text == "")
            {
                UsernameBox.Text = "Username";
                UsernameBox.ForeColor = Color.Silver;

            }
        }

        private void PasswordBox_Enter(object sender, EventArgs e)
        {
            if (PasswordBox.Text == "Password")
            {
                PasswordBox.Text = "";
                PasswordBox.ForeColor = Color.Black;

            }
        }

        private void PasswordBox_Leave(object sender, EventArgs e)
        {
            if (PasswordBox.Text == "")
            {
                PasswordBox.Text = "Password";
                PasswordBox.ForeColor = Color.Silver;

            }
        }

       

        private void button_woc1_Click(object sender, EventArgs e)
        {
            
                Student temp = Global.GlobalLinked.Check_user_Pass(UsernameBox.Text, PasswordBox.Text);


            if (temp != null)
            {   
                if (temp.username ==  "admin" && temp.password == "admin")
                {


                    Inserting_ID next = new Inserting_ID();
                    this.Hide();
                    next.ShowDialog();


                }
                else if(temp.username == "doctor" && temp.password == "doctor")
                {


                    Attendance_sheet next = new Attendance_sheet();
                    this.Hide();
                    next.ShowDialog();


                }
                {
                    Global.GlobalVar = temp;
                    ST_attendance s10 = new ST_attendance();
                    this.Hide();
                    s10.ShowDialog();
                }

            }
            else {
                string message = "Wrong Username or Password";
                string title = "Warning !";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Error,
                                                      MessageBoxDefaultButton.Button2);
            }

            
        }

       

       

        private void button1_Click(object sender, EventArgs e)
        {
            string message = "Are You Sure ?";
            string title = "Close Application";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Question,
                                                  MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
           
        }

        private void button_woc1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void PasswordBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                button_woc1.PerformClick();
            }
        }
    }
}
