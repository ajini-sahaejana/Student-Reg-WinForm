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
    public partial class Computing_Student : Form
    {
        public Computing_Student()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float m1 = float.Parse(mark1.Text);
            float m2 = float.Parse(mark2.Text);
            float m3 = float.Parse(mark3.Text);

            float avg = (m1 + m2 + m3) / 3;
            MessageBox.Show($"Marks\nComputing Networks: {m1}\nData Structures: {m2}\nTesting: {m3}\nAverage of the Subjects: {avg}");

        }
    }
}
