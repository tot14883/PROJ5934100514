using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace คำนวณแปรค่า
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Long form = new Long();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Weight form1 = new Weight();
            form1.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
