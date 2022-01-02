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
    public partial class Inserting_ID : Form
    {
        public Inserting_ID()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Inserting_ID_Load(object sender, EventArgs e)
        {

        }

        

        private void button_woc3_Click(object sender, EventArgs e)
        {
            loginScreen s10 = new loginScreen();
            this.Hide();
            s10.ShowDialog();
        }

        private void button_woc2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void button_woc1_Click(object sender, EventArgs e)
        {
            if (textBox3.Text!="" && textBox2.Text != "" 
                && comboBox1.Text!="" && textBox1.Text!="")
            {
                if (Global.GlobalLinked.Check_user(textBox1.Text) != null)
                {
                    MessageBox.Show("Username already taken");
                }
                else
                {
                    Global.GlobalLinked.insertAtEnd(new Student(textBox3.Text, comboBox1.Text, textBox1.Text, textBox2.Text));
                    MessageBox.Show("Account Created Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information,
                                                      MessageBoxDefaultButton.Button2);
                }
            }
            else
            {
                MessageBox.Show("Please Enter all Student Data", "",MessageBoxButtons.OK, MessageBoxIcon.Exclamation,
                                                      MessageBoxDefaultButton.Button2);
            }
        }
        

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
