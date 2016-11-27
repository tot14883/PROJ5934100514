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
    public partial class Select : Form
    {   //นาย นพัทธ์ ศรีจันทพงศ์ รหัสนักศึกษา 593410051-4
        public Select()
        {
            InitializeComponent();
        }
        //นี้คือหน้าจอหลักจะมีให้เลือก2ปุ่มคือแปรค่าควายาวกับนำหนัก
        private void button1_Click(object sender, EventArgs e)//นี้คือปุ่มเมื่อทำการกดจะเปิดหน้าคำนวณความยาวขึ้นมาให้
        {
            Long form = new Long();//สร้างฟอม
            form.Show();//โชว์ฟอม
        }

        private void button2_Click(object sender, EventArgs e)//นี้คือปุ่มเมื่อทำการกดจะเปิดหน้าคำนวณความนํ้าหนักขึ้นมาให้
        {
            Weight form1 = new Weight();//สร้างฟอม
            form1.Show();//โชว์ฟอม
        }

        private void label1_Click(object sender, EventArgs e)//เมธอนว่าง
        {

        }
    }
}
