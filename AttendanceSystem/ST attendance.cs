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
    public partial class ST_attendance : Form
    {
        public ST_attendance()
        {

            InitializeComponent();
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

        private void Form2_Load(object sender, EventArgs e)
        {
           
            button3.Text = Global.GlobalVar.Studentid.ToString();
            button4.Text = Global.GlobalVar.name;
            dataGridView1.DataSource = Global.GlobalVar.HistoryList;

        }


        
        private void button2_Click(object sender, EventArgs e)
        {
            loginScreen s4 = new loginScreen();
            this.Hide();
            s4.ShowDialog();
        }

      

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
    }
}
