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
    public partial class Attendance_sheet : Form
    {
        public Attendance_sheet()
        {
            InitializeComponent();
        }

        String SubChecked()
        {

            if (radioButton1.Checked)

            {
                return "OOP";
            }

            else if (radioButton2.Checked)
            {
                return "Data Structure";
            }
            else if (radioButton3.Checked)
            {
                return "Math3";
            }
            else if (radioButton4.Checked)
            {
                return  "Logic Design";
            }
            else if (radioButton5.Checked)
            {
                return "Accounting";
            }
            return "";
        }


        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        

        private void button3_Click(object sender, EventArgs e)
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

       

        private void button1_Click(object sender, EventArgs e)
        {
          
             if ((SubChecked() != ""))
               {
                if (textBox1.Text!="")
                {
                    iderror.Visible = false;
                    
                        Student temp = Global.GlobalLinked.Search_Student(int.Parse(textBox1.Text));
                        if (temp != null)
                        {
                            dataGridView1.Rows.Add(temp.name, temp.Studentid, temp.Grade, dateTimePicker1.Text);
                            temp.HistoryList.Add(new History(dateTimePicker1.Text, temp.Grade, SubChecked()));
                        }
                        else
                        {
                            MessageBox.Show("Student Not Found try Again");
                        }
                   
                }
                else
                {
                    iderror.Visible = true;

                }

             }
                else
                {
                string message = "Please Select Subject";
                string title = "Warning";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning,
                                                      MessageBoxDefaultButton.Button2);
               

                }
            
        }
        

        private void Attendance_sheet_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            loginScreen s0 = new loginScreen();
            s0.ShowDialog();
        }
    }
}
