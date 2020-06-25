using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E6
{
    public partial class Student : Form
    {
        public Student()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int regNo = int.Parse(regno.Text);
            string stName = name.Text;
            string faculty = facname.Text;

            if (faculty.Equals("SOC"))
            {
                MessageBox.Show($"Registration Number: {regNo}\nStudent Name: {stName}\nFaculty: {faculty}");
                this.Hide();

                Computing_Student cs1 = new Computing_Student();
                cs1.Show();
            }
            else
            {
                MessageBox.Show($"Registration Number: {regNo}\nStudent Name: {stName}\nFaculty: {faculty}");
                this.Hide();

                Engineering_Student es1 = new Engineering_Student();
                es1.Show();
            }
        }
    }
}
