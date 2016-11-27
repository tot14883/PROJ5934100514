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

    public partial class Weight : Form
    { //นาย นพัทธ์  ศรีจันทพงศ์  รหัสนักศึกษา 593410051-4
        public void text2()//สร้างMethod ชื่อ text2 เพื่อที่จะทำการดึงเข้าคำสั่งต่างๆใน Method มาใช่โดยจะกำหนดคำสั่งต่างๆ ดังนี้
        {
            button15.Hide();//Hide คือ ซ้อน
            button16.Show();//Show คือ โชว์ เมื่อทำการเลือกเมธอน นี้ก็จะทำการซ่อน และโชว์ ปุ่มที่กำหนดไว้ และแต่ล่ะปุ่มจะมีการทำงานโดยจะอธิบายในหัวข้อถัดไป
            button4.Hide();
            button17.Show();
            button5.Hide();
            button19.Show();
            button6.Hide();
            button20.Show();
            button7.Hide();
            button18.Show();
            button8.Hide();
            button21.Show();
            button9.Hide();
            button22.Show();
            button10.Hide();
            button23.Show();
            button11.Hide();
            button24.Show();
            button12.Hide();
            button25.Show();
            button13.Hide();
            button26.Show();
            button14.Hide();
            button27.Show();
            button1.Hide();
            button2.Hide();
        }
        public void text1()//สร้างเมธอน text1 และจะคล้าย Method text2 ซึ่งจะทำการ โชว์และซ่อนปุ่มตรงกันข้ามกัน เมธฮน text2
        {
            button15.Show();
            button16.Hide();
            button4.Show();
            button17.Hide();
            button5.Show();
            button19.Hide();
            button6.Show();
            button20.Hide();
            button7.Show();
            button18.Hide();
            button8.Show();
            button21.Hide();
            button9.Show();
            button22.Hide();
            button10.Show();
            button23.Hide();
            button11.Show();
            button24.Hide();
            button12.Show();
            button25.Hide();
            button13.Show();
            button26.Hide();
            button14.Show();
            button27.Hide();         
        }
        public Weight()//แปลงค่านำหนัก
        {
            InitializeComponent();
            richTextBox1.Hide();//จะทำการซ่อนrichtextและจะไม่ถูกเรียกใช่ถ้ายังไม่ตรงตามเงือนไข
            button2.Hide();//โดยจะกำหนดให้ซ่อนปุ่ม2 ตั้งแต่ตอนรันโปรแกรมและจะไม่ใช่ในกรณี text1 และ text2 เพราะจะซ่อนโดนที่ไม่ได้อยู่ในเมธอนทั้งสองและจะถูกเรียกใช้ในกรณีอื่นแทน
            button1.Hide();//โดยจะกำหนดให้ซ่อนปุ่ม1 ตั้งแต่ตอนรันโปรแกรมและจะไม่ใช่ในกรณี text1 และ text2 เพราะจะซ่อนโดนที่ไม่ได้อยู่ในเมธอนทั้งสองและจะถูกเรียกใช้ในกรณีอื่นแทน
            button28.Hide();//โดยจะกำหนดให้ซ่อนปุ่ม28 ตั้งแต่ตอนรันโปรแกรมและจะไม่ใช่ในกรณี text1 และ text2 เพราะจะซ่อนโดนที่ไม่ได้อยู่ในเมธอนทั้งสองและจะถูกเรียกใช้ในกรณีอื่นแทน
            button29.Hide(); //โดยจะกำหนดให้ซ่อนปุ่ม29 ตั้งแต่ตอนรันโปรแกรมและจะไม่ใช่ในกรณี text1 และ text2 เพราะจะซ่อนโดนที่ไม่ได้อยู่ในเมธอนทั้งสองและจะถูกเรียกใช้ในกรณีอื่นแทน  
        }
        private void Weight_Load(object sender, EventArgs e)
        {

        }//เมธอนว่าง
        private void button3_Click(object sender, EventArgs e)//ปุ่มที่ จะเป็นปุ่ม Clear หรือปุ่มล้าง ซึ่งจะทำการล้างในtextbox1 และ textbox2 ให้เป็นtext ว่าง
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }
        private void button4_Click(object sender, EventArgs e)//นี้คือการกำหนดเมื่อเรียกใช้ปุ่ม 4 จะเป็นปุ่มเลขซึ่งแทนด้วยเลข1 
        {
            textBox1.Text = textBox1.Text + 1; //คำสั่งคือให้ textbox1 +1 เมื่อทำการกดปุ่มนี้
        }

        private void button5_Click(object sender, EventArgs e)//นี้คือการกำหนดเมื่อเรียกใช้ปุ่ม 5 จะเป็นปุ่มเลขซึ่งแทนด้วยเลข2
        {
            textBox1.Text = textBox1.Text + 2; //คำสั่งคือให้ textbox1 +2 เมื่อทำการกดปุ่มนี้
        }

        private void button6_Click(object sender, EventArgs e)//นี้คือการกำหนดเมื่อเรียกใช้ปุ่ม 6 จะเป็นปุ่มเลขซึ่งแทนด้วยเลข3
        {
            textBox1.Text = textBox1.Text + 3; //คำสั่งคือให้ textbox1 +3 เมื่อทำการกดปุ่มนี้
        }

        private void button7_Click(object sender, EventArgs e)//นี้คือการกำหนดเมื่อเรียกใช้ปุ่ม 7 จะเป็นปุ่มเลขซึ่งแทนด้วยเลข4 
        {
            textBox1.Text = textBox1.Text + 4; //คำสั่งคือให้ textbox1 +4 เมื่อทำการกดปุ่มนี้
        }

        private void button8_Click(object sender, EventArgs e)//นี้คือการกำหนดเมื่อเรียกใช้ปุ่ม 8 จะเป็นปุ่มเลขซึ่งแทนด้วยเลข5 
        {
            textBox1.Text = textBox1.Text + 5; //คำสั่งคือให้ textbox1 +5 เมื่อทำการกดปุ่มนี้
        }

        private void button9_Click(object sender, EventArgs e)//นี้คือการกำหนดเมื่อเรียกใช้ปุ่ม 9 จะเป็นปุ่มเลขซึ่งแทนด้วยเลข6 
        {
            textBox1.Text = textBox1.Text + 6; //คำสั่งคือให้ textbox1 +6 เมื่อทำการกดปุ่มนี้
        }

        private void button10_Click(object sender, EventArgs e)//นี้คือการกำหนดเมื่อเรียกใช้ปุ่ม 10 จะเป็นปุ่มเลขซึ่งแทนด้วยเลข7 
        {
            textBox1.Text = textBox1.Text + 7; //คำสั่งคือให้ textbox1 +7 เมื่อทำการกดปุ่มนี้
        }

        private void button11_Click(object sender, EventArgs e)//นี้คือการกำหนดเมื่อเรียกใช้ปุ่ม 11 จะเป็นปุ่มเลขซึ่งแทนด้วยเลข8 
        {
            textBox1.Text = textBox1.Text + 8; //คำสั่งคือให้ textbox1 +8 เมื่อทำการกดปุ่มนี้
        }

        private void button12_Click(object sender, EventArgs e)//นี้คือการกำหนดเมื่อเรียกใช้ปุ่ม 12 จะเป็นปุ่มเลขซึ่งแทนด้วยเลข9
        {
            textBox1.Text = textBox1.Text + 9; //คำสั่งคือให้ textbox1 +9 เมื่อทำการกดปุ่มนี้
        }

        private void button13_Click(object sender, EventArgs e)//นี้คือการกำหนดเมื่อเรียกใช้ปุ่ม 13 จะเป็นปุ่มเลขซึ่งแทนด้วยเลข0
        {
            textBox1.Text = textBox1.Text + 0; //คำสั่งคือให้ textbox1 +0 เมื่อทำการกดปุ่มนี้
        }
        private void button14_Click(object sender, EventArgs e)//นี้คือการกำหนดเมื่อเรียกใช้ปุ่ม 13 จะเป็นปุ่มเลขซึ่งแทนด้วยเครื่องหมายทศนิยม 
        {
            textBox1.Text = textBox1.Text + ".";//คำสั่งคือให้ textbox1 +ทศนิยมเมื่อทำการกดปุ่มนี้
        }
        //และจะสังเกตุว่าปุ่มพวกนี้จะทำงานในtextbox1เท่านั้น และจำอธิบายว่าทำไหมถึงได้ทำงานในtextbox1 เท่านั้น
        private void button1_Click(object sender, EventArgs e)
        {
        }//เมธอนว่าง

        private void button2_Click(object sender, EventArgs e)
        {

        }//เมธอนว่าง

        private void textBox2_MouseDown(object sender, MouseEventArgs e)
        {


        }//เมธอนว่าง

        private void button4_MouseDown(object sender, MouseEventArgs e)
        {

        }//เมธอนว่าง

        private void button15_Click(object sender, EventArgs e)//คำสั่งโดยกำหนดให้เมื่อเรียกใช้ button15 จะเป็นการลบ โดยจะทำการลบทีล่ะตัวเลขไม่เหมือนกันปุ่ม ล้างซึ่งจะล้างหมดทันที
        {
            try//ดักerror
            {
                double lenght = textBox1.TextLength - 1;//ทำการลบโดยให้ textbox1 -1 คือลบไปทีล่ะตัวเลข
                string text = textBox1.Text;//ให้ string text = textbox1.text 
                textBox1.Clear();//และให้textbox1 Clear คือการลบไปทีล่ะตัว
                for (int i = 0; i < lenght; i++)//ใช้คำสั่งfor เข้ามาช่วย
                    textBox1.Text = textBox1.Text + text[i];//กำหนดให้textbox1.text = ลบไปทีล่ะตัวโดนที ให้ลบโดบเท่ากับ text[i]         
            }
            catch//จับerror
            {
                return;
            }
            if (textBox1.Text == "")//และเงื่อนไขถ้าtextbox1 ว่าง textbox2 ก็เท่ากับว่าง
            {
                textBox2.Text = "";
            }
        }

        private void button16_Click(object sender, EventArgs e)//คำสั่งโดยกำหนดให้เมื่อเรียกใช้ button16 จะเป็นการลบ โดยจะทำการลบทีล่ะตัวเลขไม่เหมือนกันปุ่ม ล้างซึ่งจะล้างหมดทันที
        {
            try//ดักerror
            {
                double l = textBox2.TextLength - 1;//ทำการลบโดยให้ textbox2 -1 คือลบไปทีล่ะตัวเลข
                string m = textBox2.Text;//ให้ string m = textbox2.text 
                textBox2.Clear();//และให้textbox2 Clear คือการลบไปทีล่ะตัว
                for (int i = 1; i < l; i++)//ใช้คำสั่งfor เข้ามาช่วย
                    textBox2.Text = textBox2.Text + m[i];//กำหนดให้textbox2.text = ลบไปทีล่ะตัวโดนที ให้ลบโดบเท่ากับ text[i]
            }
            catch// จับerror
            {
                return;
            }
            if (textBox2.Text == "")//และเงื่อนไขถ้าtextbox2 ว่าง textbox1 ก็เท่ากับว่าง
            {
                textBox1.Text = "";
            }
        }

        private void button17_Click(object sender, EventArgs e)//นี้คือการกำหนดเมื่อเรียกใช้ปุ่ม 17 จะเป็นปุ่มเลขซึ่งแทนด้วยเลข1 
        {
            textBox2.Text = textBox2.Text + 1;//คำสั่งคือให้ textbox2 +1 เมื่อทำการกดปุ่มนี้
        }
        private void button19_Click(object sender, EventArgs e)//นี้คือการกำหนดเมื่อเรียกใช้ปุ่ม 19 จะเป็นปุ่มเลขซึ่งแทนด้วยเลข2
        {
            textBox2.Text = textBox2.Text + 2;//คำสั่งคือให้ textbox2 +2 เมื่อทำการกดปุ่มนี้
        }

        private void button20_Click(object sender, EventArgs e)//นี้คือการกำหนดเมื่อเรียกใช้ปุ่ม 20 จะเป็นปุ่มเลขซึ่งแทนด้วยเลข3 
        {
            textBox2.Text = textBox2.Text + 3;//คำสั่งคือให้ textbox2 +3 เมื่อทำการกดปุ่มนี้
        }

        private void button18_Click(object sender, EventArgs e)//นี้คือการกำหนดเมื่อเรียกใช้ปุ่ม 18 จะเป็นปุ่มเลขซึ่งแทนด้วยเลข4 
        {
            textBox2.Text = textBox2.Text + 4;//คำสั่งคือให้ textbox2 +4 เมื่อทำการกดปุ่มนี้
        }

        private void button21_Click(object sender, EventArgs e)//นี้คือการกำหนดเมื่อเรียกใช้ปุ่ม 21 จะเป็นปุ่มเลขซึ่งแทนด้วยเลข5 
        {
            textBox2.Text = textBox2.Text + 5;//คำสั่งคือให้ textbox2 +5 เมื่อทำการกดปุ่มนี้
        }

        private void button22_Click(object sender, EventArgs e)//นี้คือการกำหนดเมื่อเรียกใช้ปุ่ม 22 จะเป็นปุ่มเลขซึ่งแทนด้วยเลข6 
        {
            textBox2.Text = textBox2.Text + 6;//คำสั่งคือให้ textbox2 +6 เมื่อทำการกดปุ่มนี้
        }

        private void button23_Click(object sender, EventArgs e)//นี้คือการกำหนดเมื่อเรียกใช้ปุ่ม 23 จะเป็นปุ่มเลขซึ่งแทนด้วยเลข7
        {
            textBox2.Text = textBox2.Text + 7;//คำสั่งคือให้ textbox2 +7 เมื่อทำการกดปุ่มนี้
        }

        private void button24_Click(object sender, EventArgs e)//นี้คือการกำหนดเมื่อเรียกใช้ปุ่ม 24 จะเป็นปุ่มเลขซึ่งแทนด้วยเลข8 
        {
            textBox2.Text = textBox2.Text + 8;//คำสั่งคือให้ textbox2 +8 เมื่อทำการกดปุ่มนี้
        }

        private void button25_Click(object sender, EventArgs e)//นี้คือการกำหนดเมื่อเรียกใช้ปุ่ม 25 จะเป็นปุ่มเลขซึ่งแทนด้วยเลข9 
        {
            textBox2.Text = textBox2.Text + 9;//คำสั่งคือให้ textbox2 +9 เมื่อทำการกดปุ่มนี้
        }

        private void button26_Click(object sender, EventArgs e)//นี้คือการกำหนดเมื่อเรียกใช้ปุ่ม 26 จะเป็นปุ่มเลขซึ่งแทนด้วยเลข0 
        {
            textBox2.Text = textBox2.Text + 0;//คำสั่งคือให้ textbox2 +0 เมื่อทำการกดปุ่มนี้
        }

        private void button27_Click(object sender, EventArgs e)//นี้คือการกำหนดเมื่อเรียกใช้ปุ่ม 27 จะเป็นปุ่มเลขซึ่งแทนด้วยเครื่องหมายทศนิยม 
        {
            textBox2.Text = textBox2.Text + ".";//คำสั่งคือให้ textbox2 +ทศนิยมเมื่อทำการกดปุ่มนี้
        }
        //จะแสดงในtextbox2 เท่านั้น
        private void textBox1_Click(object sender, EventArgs e)//นี้คือการจะอธิบายว่าทำไหมต้องใช้คำสั่งซ้อนปุ่มและโชว์ปุ่มในเมธอน text1 เมื่อทำการกด Clickที่textbox1 จะถุกกำหนดเงือนไขไว้ดังนี้
        {
            text1();      //เรียกใช้เมธอน text1 โดนการคลิกที่ textbox1 และจำทำจามเงือนไขในเมธอน text1 จากที่เรากำหนดไว้     
            if (textBox1.Text == "" || textBox2.Text == "")//เงื่อนไขถ้าtext1 หรือ text2 ว่างจะเท่ากับ text1 ว่าง
            {
                textBox1.Text = "";
            }         
        }

        public void textBox2_TextChanged(object sender, EventArgs e)//ใช่คำสั่งtextbox2_textChanged ซึ่งจะแปลง ค่า รับค่าโดยที่แค่พิมพ์ตัวเลขเข้าไปแล้วจะเป็นการแปลงให้เองอัตโนมัติ
        {
            try//ดัก error ใช่คำสั่งนี้ทุกครั้งเพื่อการดัก error
            {
                
                double x = double.Parse(textBox2.Text); //ป้อนค่าตัวเลขที่ต้องการพิมพ์หรือใช่ปุ่มตัวเลขได้ 
                if (textBox2.Text != "")//นี้้คือการเรียกใช่ปุ่ม 1และ28 ที่กำหนดไว้นอกเมธอน จะมีเงือนไขว่าถ้าtextbox2 ไม่เท่ากับว่างจะทำการโชว์ button1 และbutton 28 ทันที
                {
                    button1.Show();
                    button28.Show();
                }
                Text2(x);//รับค่าของ x และให้ไปคำนวณในเมธอนที่เรากำหนดโดยจะอธิบายรายละเอียดอีกทีในเมธอนText2   


            }
            catch//จับerror และส่งค่าคืน
            {
                return;
            }
        }

        private void textBox2_Click(object sender, EventArgs e)//เรียกใช้เมธอน text2 โดนการคลิกที่ textbox2 และจำทำจามเงือนไขในเมธอน text2 จากที่เรากำหนดไว้
        {
            text2();//เรียกใช้เมธอน text2 โดนการคลิกที่ textbox2 และจำทำจามเงือนไขในเมธอน text2 จากที่เรากำหนดไว้
            button29.Show();//โชว์ปุ่ม29
            button1.Hide();//และเมื่อคลิกก็จะทำการซ่อนbutton1
        }

        public void textBox1_TextChanged(object sender, EventArgs e)//ใช่คำสั่งtextbox1_textChanged ซึ่งจะแปลง ค่า รับค่าโดยที่แค่พิมพ์ตัวเลขเข้าไปแล้วจะเป็นการแปลงให้เองอัตโนมัติ
        {
            try//ดัก error ใช่คำสั่งนี้ทุกครั้งเพื่อการดัก error
            {

                double x = double.Parse(textBox1.Text);//ป้อนค่าตัวเลขที่ต้องการพิมพ์หรือใช่ปุ่มตัวเลขได้ 
                if (textBox1.Text != "")//นี้้คือการเรียกใช่ปุ่ม 1และ28 ที่กำหนดไว้นอกเมธอน จะมีเงือนไขว่าถ้าtextbox1 ไม่เท่ากับว่างจะทำการโชว์ button1 และbutton 28 ทันที
                {
                    button1.Show();
                    button28.Show();
                }
                Text1(x);//รับค่าของ x และให้ไปคำนวณในเมธอนที่เรากำหนดโดยจะอธิบายรายละเอียดอีกทีในเมธอนText1 

            }
            catch//จับerror และส่งค่าคืน
            {
                return;
            }

        }

        private void button1_Click_1(object sender, EventArgs e)//และนี้คือคำสั่งเมื่อทำการกดbutton1 จะเป็นปุ่มคำสั่งโชว์ค่าที่เราเคยแปรงและไปเก็บไว้ในrichtextbox1 จะแสดงเงื่อนไขต่างๆดังนี้
        {
            richTextBox1.Show();//โชว์ richboxtextbox1
            button2.Show();//โชว์ button2 แทนชื่อปุ่มคือ back
            button1.Hide();//ซ่อน button1 แทนชื่อปุ่มคือ History
            button28.Show();//โชว์ butto28 แทนชื่อปุ่มคือ clear
            richTextBox1.Text += "แปลงจาก" + "\r\n" + textBox1.Text.ToString() + "  " + comboBox1.Text + "  ==>   " + textBox2.Text.ToString() + "  " + comboBox2.Text + "\r\n";//เมื่อทำการกดปุ่ม1 จะไปเก็บค่าไว้ในrichboxtextbox1 โดยจะแสดงตามที่เราป้อนค่าและกำหนดหน่วยเข้าไปโดยจะแสดง text1 ไป text2
        }

        private void button2_Click_1(object sender, EventArgs e)//และนี้คือปุ่มคำสั่งที่จะแสดงเงื่อนไขดังนี้
        {
            richTextBox1.Hide();//ทำการซ่อน richboxtextbox1
            button1.Show();//โชว์  button1 แทนชื่อปุ่มคือ history
            button2.Hide();//ซ่อน button2 แทนชื่อปุ่มคือ back
            button28.Hide();//ซ่อน butto28 แทนชื่อปุ่มคือ clear
            button29.Hide();//ซ่อน butto29 แทนชื่อปุ่มคือ history
        }
        private void Text1(double x)//และนี้คือ เมธอนคำนวณโดยจะนำไปหาค่าดังนี้ในtextbox1_changed โดยจะแปลงจาก textbox1 ไปเป็น textbox2ดังนี้
        {
            double z;//กำหนดค่าตัวแปลง
            switch (comboBox1.SelectedIndex)//จะทำการเลือกหน่วยที่จะแปรงโดยจะใช่เงื่อนไขตำแหน่ง array ดังนี้
            {
                case 0://ตำแหน่งที 0
                    switch (comboBox2.SelectedIndex)//และเมื่อเลือกcombobox ทีเราจะแปลงจะทำการคำนวณดังนี้
                    {
                        case 0: z = x; textBox2.Text = z.ToString(); break;
                        case 1: z = x * 200; textBox2.Text = z.ToString(); break;
                        case 2: z = x * 20; textBox2.Text = z.ToString(); break;
                        case 3: z = x * 2; textBox2.Text = z.ToString(); break;
                        case 4: z = x / 5; textBox2.Text = z.ToString(); break;
                        case 5: z = x / 50; textBox2.Text = z.ToString(); break;
                        case 6: z = x / 500; textBox2.Text = z.ToString(); break;
                        case 7: z = x / 5000; textBox2.Text = z.ToString(); break;
                        case 8: z = x / 5000000; textBox2.Text = z.ToString(); break;
                        case 9: z = x / 141.7476; textBox2.Text = z.ToString(); break;
                        case 10: z = x / 2267.962; textBox2.Text = z.ToString(); break;
                        case 11: z = x / 31751.47; textBox2.Text = z.ToString(); break;
                        case 12: z = x / 4535924; textBox2.Text = z.ToString(); break;
                        case 13: z = x / 5080235; textBox2.Text = z.ToString(); break;
                    }
                    break;
                    //และมีเงือนไขแสดงไปเรื่อยตามด้านล่าง
            }
            switch (comboBox1.SelectedIndex)
            {
                case 1:
                    switch (comboBox2.SelectedIndex)
                    {
                        case 0: z = x / 200; textBox2.Text = z.ToString(); break;
                        case 1: z = x; textBox2.Text = z.ToString(); break;
                        case 2: z = x / 10; textBox2.Text = z.ToString(); break;
                        case 3: z = x / 100; textBox2.Text = z.ToString(); break;
                        case 4: z = x / 1000; textBox2.Text = z.ToString(); break;
                        case 5: z = x / 10000; textBox2.Text = z.ToString(); break;
                        case 6: z = x / 100000; textBox2.Text = z.ToString(); break;
                        case 7: z = x / 1000000; textBox2.Text = z.ToString(); break;
                        case 8: z = x / 1000000000; textBox2.Text = z.ToString(); break;
                        case 9: z = x / 28349.52; textBox2.Text = z.ToString(); break;
                        case 10: z = x / 453592.4; textBox2.Text = z.ToString(); break;
                        case 11: z = x / 6350293; textBox2.Text = z.ToString(); break;
                        case 12: z = x / 907184740; textBox2.Text = z.ToString(); break;
                        case 13: z = x / 1016046909; textBox2.Text = z.ToString(); break;
                    }
                    break;
            }
            switch (comboBox1.SelectedIndex)
            {
                case 2:
                    switch (comboBox2.SelectedIndex)
                    {
                        case 0: z = x / 20; textBox2.Text = z.ToString(); break;
                        case 1: z = x * 10; textBox2.Text = z.ToString(); break;
                        case 2: z = x; textBox2.Text = z.ToString(); break;
                        case 3: z = x / 10; textBox2.Text = z.ToString(); break;
                        case 4: z = x / 100; textBox2.Text = z.ToString(); break;
                        case 5: z = x / 1000; textBox2.Text = z.ToString(); break;
                        case 6: z = x / 10000; textBox2.Text = z.ToString(); break;
                        case 7: z = x / 100000; textBox2.Text = z.ToString(); break;
                        case 8: z = x / 100000000; textBox2.Text = z.ToString(); break;
                        case 9: z = x / 2834.952; textBox2.Text = z.ToString(); break;
                        case 10: z = x / 45359.24; textBox2.Text = z.ToString(); break;
                        case 11: z = x / 635029.3; textBox2.Text = z.ToString(); break;
                        case 12: z = x / 90718474; textBox2.Text = z.ToString(); break;
                        case 13: z = x / 101604691; textBox2.Text = z.ToString(); break;
                    }
                    break;
            }
            switch (comboBox1.SelectedIndex)
            {
                case 3:
                    switch (comboBox2.SelectedIndex)
                    {
                        case 0: z = x / 2; textBox2.Text = z.ToString(); break;
                        case 1: z = x * 100; textBox2.Text = z.ToString(); break;
                        case 2: z = x * 10; textBox2.Text = z.ToString(); break;
                        case 3: z = x; textBox2.Text = z.ToString(); break;
                        case 4: z = x / 10; textBox2.Text = z.ToString(); break;
                        case 5: z = x / 100; textBox2.Text = z.ToString(); break;
                        case 6: z = x / 10000; textBox2.Text = z.ToString(); break;
                        case 7: z = x / 100000; textBox2.Text = z.ToString(); break;
                        case 8: z = x / 10000000; textBox2.Text = z.ToString(); break;
                        case 9: z = x / 283.4952; textBox2.Text = z.ToString(); break;
                        case 10: z = x / 4535.924; textBox2.Text = z.ToString(); break;
                        case 11: z = x / 63502.93; textBox2.Text = z.ToString(); break;
                        case 12: z = x / 9071847; textBox2.Text = z.ToString(); break;
                        case 13: z = x / 10160469; textBox2.Text = z.ToString(); break;
                    }
                    break;
            }
            switch (comboBox1.SelectedIndex)
            {
                case 4:
                    switch (comboBox2.SelectedIndex)
                    {
                        case 0: z = x * 2; textBox2.Text = z.ToString(); break;
                        case 1: z = x * 1000; textBox2.Text = z.ToString(); break;
                        case 2: z = x * 100; textBox2.Text = z.ToString(); break;
                        case 3: z = x * 10; textBox2.Text = z.ToString(); break;
                        case 4: z = x; textBox2.Text = z.ToString(); break;
                        case 5: z = x / 10; textBox2.Text = z.ToString(); break;
                        case 6: z = x / 100; textBox2.Text = z.ToString(); break;
                        case 7: z = x / 1000; textBox2.Text = z.ToString(); break;
                        case 8: z = x / 1000000; textBox2.Text = z.ToString(); break;
                        case 9: z = x / 28.34952; textBox2.Text = z.ToString(); break;
                        case 10: z = x / 453.5924; textBox2.Text = z.ToString(); break;
                        case 11: z = x / 6350.293; textBox2.Text = z.ToString(); break;
                        case 12: z = x / 907184.7; textBox2.Text = z.ToString(); break;
                        case 13: z = x / 1016047; textBox2.Text = z.ToString(); break;
                    }
                    break;
            }
            switch (comboBox1.SelectedIndex)
            {
                case 5:
                    switch (comboBox2.SelectedIndex)
                    {
                        case 0: z = x * 50; textBox2.Text = z.ToString(); break;
                        case 1: z = x * 10000; textBox2.Text = z.ToString(); break;
                        case 2: z = x * 1000; textBox2.Text = z.ToString(); break;
                        case 3: z = x * 100; textBox2.Text = z.ToString(); break;
                        case 4: z = x * 10; textBox2.Text = z.ToString(); break;
                        case 5: z = x; textBox2.Text = z.ToString(); break;
                        case 6: z = x / 10; textBox2.Text = z.ToString(); break;
                        case 7: z = x / 100; textBox2.Text = z.ToString(); break;
                        case 8: z = x / 100000; textBox2.Text = z.ToString(); break;
                        case 9: z = x / 2.834952; textBox2.Text = z.ToString(); break;
                        case 10: z = x / 45.35924; textBox2.Text = z.ToString(); break;
                        case 11: z = x / 635.0293; textBox2.Text = z.ToString(); break;
                        case 12: z = x / 90718.47; textBox2.Text = z.ToString(); break;
                        case 13: z = x / 101604.7; textBox2.Text = z.ToString(); break;
                    }
                    break;
            }
            switch (comboBox1.SelectedIndex)
            {
                case 6:
                    switch (comboBox2.SelectedIndex)
                    {
                        case 0: z = x * 500; textBox2.Text = z.ToString(); break;
                        case 1: z = x * 100000; textBox2.Text = z.ToString(); break;
                        case 2: z = x * 10000; textBox2.Text = z.ToString(); break;
                        case 3: z = x * 1000; textBox2.Text = z.ToString(); break;
                        case 4: z = x * 100; textBox2.Text = z.ToString(); break;
                        case 5: z = x * 10; textBox2.Text = z.ToString(); break;
                        case 6: z = x; textBox2.Text = z.ToString(); break;
                        case 7: z = x / 10; textBox2.Text = z.ToString(); break;
                        case 8: z = x / 10000; textBox2.Text = z.ToString(); break;
                        case 9: z = x * 3.527396; textBox2.Text = z.ToString(); break;
                        case 10: z = x / 4.535924; textBox2.Text = z.ToString(); break;
                        case 11: z = x / 63.50293; textBox2.Text = z.ToString(); break;
                        case 12: z = x / 9071.847; textBox2.Text = z.ToString(); break;
                        case 13: z = x / 10160.47; textBox2.Text = z.ToString(); break;
                    }
                    break;
            }
            switch (comboBox1.SelectedIndex)
            {
                case 7:
                    switch (comboBox2.SelectedIndex)
                    {
                        case 0: z = x * 5000; textBox2.Text = z.ToString(); break;
                        case 1: z = x * 1000000; textBox2.Text = z.ToString(); break;
                        case 2: z = x * 100000; textBox2.Text = z.ToString(); break;
                        case 3: z = x * 10000; textBox2.Text = z.ToString(); break;
                        case 4: z = x * 1000; textBox2.Text = z.ToString(); break;
                        case 5: z = x * 100; textBox2.Text = z.ToString(); break;
                        case 6: z = x * 10; textBox2.Text = z.ToString(); break;
                        case 7: z = x; textBox2.Text = z.ToString(); break;
                        case 8: z = x / 1000; textBox2.Text = z.ToString(); break;
                        case 9: z = x * 35.27396; textBox2.Text = z.ToString(); break;
                        case 10: z = x * 2.204623; textBox2.Text = z.ToString(); break;
                        case 11: z = x / 6.350293; textBox2.Text = z.ToString(); break;
                        case 12: z = x / 907.1847; textBox2.Text = z.ToString(); break;
                        case 13: z = x / 1016.047; textBox2.Text = z.ToString(); break;
                    }
                    break;
            }
            switch (comboBox1.SelectedIndex)
            {
                case 8:
                    switch (comboBox2.SelectedIndex)
                    {
                        case 0: z = x * 5000000; textBox2.Text = z.ToString(); break;
                        case 1: z = x * 1000000000; textBox2.Text = z.ToString(); break;
                        case 2: z = x * 100000000; textBox2.Text = z.ToString(); break;
                        case 3: z = x * 10000000; textBox2.Text = z.ToString(); break;
                        case 4: z = x * 1000000; textBox2.Text = z.ToString(); break;
                        case 5: z = x * 100000; textBox2.Text = z.ToString(); break;
                        case 6: z = x * 10000; textBox2.Text = z.ToString(); break;
                        case 7: z = x * 1000; textBox2.Text = z.ToString(); break;
                        case 8: z = x; textBox2.Text = z.ToString(); break;
                        case 9: z = x * 35273.96; textBox2.Text = z.ToString(); break;
                        case 10: z = x * 2204.623; textBox2.Text = z.ToString(); break;
                        case 11: z = x * 157.473; textBox2.Text = z.ToString(); break;
                        case 12: z = x * 1.102311; textBox2.Text = z.ToString(); break;
                        case 13: z = x * 0.984207; textBox2.Text = z.ToString(); break;
                    }
                    break;
            }
            switch (comboBox1.SelectedIndex)
            {
                case 9:
                    switch (comboBox2.SelectedIndex)
                    {
                        case 0: z = x * 141.7476; textBox2.Text = z.ToString(); break;
                        case 1: z = x * 28349.52; textBox2.Text = z.ToString(); break;
                        case 2: z = x * 2834.952; textBox2.Text = z.ToString(); break;
                        case 3: z = x * 283.4952; textBox2.Text = z.ToString(); break;
                        case 4: z = x * 28.34952; textBox2.Text = z.ToString(); break;
                        case 5: z = x * 2.834952; textBox2.Text = z.ToString(); break;
                        case 6: z = x / 3.527396; textBox2.Text = z.ToString(); break;
                        case 7: z = x / 35.27396; textBox2.Text = z.ToString(); break;
                        case 8: z = x / 35273.96; textBox2.Text = z.ToString(); break;
                        case 9: z = x; textBox2.Text = z.ToString(); break;
                        case 10: z = x / 16; textBox2.Text = z.ToString(); break;
                        case 11: z = x / 224; textBox2.Text = z.ToString(); break;
                        case 12: z = x / 32000; textBox2.Text = z.ToString(); break;
                        case 13: z = x / 35840; textBox2.Text = z.ToString(); break;
                    }
                    break;
            }
            switch (comboBox1.SelectedIndex)
            {
                case 10:
                    switch (comboBox2.SelectedIndex)
                    {
                        case 0: z = x * 2267.962; textBox2.Text = z.ToString(); break;
                        case 1: z = x * 453592.4; textBox2.Text = z.ToString(); break;
                        case 2: z = x * 45359.24; textBox2.Text = z.ToString(); break;
                        case 3: z = x * 4535.924; textBox2.Text = z.ToString(); break;
                        case 4: z = x * 453.5924; textBox2.Text = z.ToString(); break;
                        case 5: z = x * 45.35924; textBox2.Text = z.ToString(); break;
                        case 6: z = x * 4.535924; textBox2.Text = z.ToString(); break;
                        case 7: z = x / 2.204623; textBox2.Text = z.ToString(); break;
                        case 8: z = x / 2204.623; textBox2.Text = z.ToString(); break;
                        case 9: z = x * 16; textBox2.Text = z.ToString(); break;
                        case 10: z = x; textBox2.Text = z.ToString(); break;
                        case 11: z = x / 14; textBox2.Text = z.ToString(); break;
                        case 12: z = x / 2000; textBox2.Text = z.ToString(); break;
                        case 13: z = x / 2240; textBox2.Text = z.ToString(); break;
                    }
                    break;
            }
            switch (comboBox1.SelectedIndex)
            {
                case 11:
                    switch (comboBox2.SelectedIndex)
                    {
                        case 0: z = x * 31751.47; textBox2.Text = z.ToString(); break;
                        case 1: z = x * 6350293; textBox2.Text = z.ToString(); break;
                        case 2: z = x * 635029.3; textBox2.Text = z.ToString(); break;
                        case 3: z = x * 63502.93; textBox2.Text = z.ToString(); break;
                        case 4: z = x * 6350.293; textBox2.Text = z.ToString(); break;
                        case 5: z = x * 635.0293; textBox2.Text = z.ToString(); break;
                        case 6: z = x * 63.50293; textBox2.Text = z.ToString(); break;
                        case 7: z = x * 6.350293; textBox2.Text = z.ToString(); break;
                        case 8: z = x / 157.473; textBox2.Text = z.ToString(); break;
                        case 9: z = x * 224; textBox2.Text = z.ToString(); break;
                        case 10: z = x * 14; textBox2.Text = z.ToString(); break;
                        case 11: z = x; textBox2.Text = z.ToString(); break;
                        case 12: z = x * 0.007; textBox2.Text = z.ToString(); break;
                        case 13: z = x / 160; textBox2.Text = z.ToString(); break;
                    }
                    break;
            }
            switch (comboBox1.SelectedIndex)
            {
                case 12:
                    switch (comboBox2.SelectedIndex)
                    {
                        case 0: z = x * 4535924; textBox2.Text = z.ToString(); break;
                        case 1: z = x * 907184740; textBox2.Text = z.ToString(); break;
                        case 2: z = x * 90718474; textBox2.Text = z.ToString(); break;
                        case 3: z = x * 9071847; textBox2.Text = z.ToString(); break;
                        case 4: z = x * 907184.7; textBox2.Text = z.ToString(); break;
                        case 5: z = x * 90718.47; textBox2.Text = z.ToString(); break;
                        case 6: z = x * 9071.847; textBox2.Text = z.ToString(); break;
                        case 7: z = x * 907.1847; textBox2.Text = z.ToString(); break;
                        case 8: z = x / 1.102311; textBox2.Text = z.ToString(); break;
                        case 9: z = x * 32000; textBox2.Text = z.ToString(); break;
                        case 10: z = x * 2000; textBox2.Text = z.ToString(); break;
                        case 11: z = x / 0.007; textBox2.Text = z.ToString(); break;
                        case 12: z = x; textBox2.Text = z.ToString(); break;
                        case 13: z = x / 1.12; textBox2.Text = z.ToString(); break;
                    }
                    break;
            }
            switch (comboBox1.SelectedIndex)
            {
                case 13:
                    switch (comboBox2.SelectedIndex)
                    {
                        case 0: z = x * 5080235; textBox2.Text = z.ToString(); break;
                        case 1: z = x * 1016046909; textBox2.Text = z.ToString(); break;
                        case 2: z = x * 101604691; textBox2.Text = z.ToString(); break;
                        case 3: z = x * 10160469; textBox2.Text = z.ToString(); break;
                        case 4: z = x * 1016047; textBox2.Text = z.ToString(); break;
                        case 5: z = x * 101604.7; textBox2.Text = z.ToString(); break;
                        case 6: z = x * 10160.47; textBox2.Text = z.ToString(); break;
                        case 7: z = x * 1016.047; textBox2.Text = z.ToString(); break;
                        case 8: z = x * 1.016047; textBox2.Text = z.ToString(); break;
                        case 9: z = x * 35840; textBox2.Text = z.ToString(); break;
                        case 10: z = x * 2240; textBox2.Text = z.ToString(); break;
                        case 11: z = x * 160; textBox2.Text = z.ToString(); break;
                        case 12: z = x * 1.12; textBox2.Text = z.ToString(); break;
                        case 13: z = x; textBox2.Text = z.ToString(); break;
                    }
                    break;
            }
        }
        private void Text2(double x)//และนี้คือ เมธอนคำนวณโดยจะนำไปหาค่าดังนี้ในtextbox2_changed โดยจะแปลงจาก textbox2 ไปเป็น textbox1ดังนี้
        {
            double a;//กำหนดค่าตัวแปลง
            switch (comboBox2.SelectedIndex)//จะทำการเลือกหน่วยที่จะแปรงโดยจะใช่เงื่อนไขตำแหน่ง array ดังนี้
            {
                case 0://ตำแหน่งที 0
                    switch (comboBox1.SelectedIndex)//และเมื่อเลือกcombobox ทีเราจะแปลงจะทำการคำนวณดังนี้
                    {
                        case 0: a = x; textBox1.Text = a.ToString(); break;
                        case 1: a = x * 200; textBox1.Text = a.ToString(); break;
                        case 2: a = x * 20; textBox1.Text = a.ToString(); break;
                        case 3: a = x * 2; textBox1.Text = a.ToString(); break;
                        case 4: a = x / 5; textBox1.Text = a.ToString(); break;
                        case 5: a = x / 50; textBox1.Text = a.ToString(); break;
                        case 6: a = x / 500; textBox1.Text = a.ToString(); break;
                        case 7: a = x / 5000; textBox1.Text = a.ToString(); break;
                        case 8: a = x / 5000000; textBox1.Text = a.ToString(); break;
                        case 9: a = x / 141.7476; textBox1.Text = a.ToString(); break;
                        case 10: a = x / 2267.962; textBox1.Text = a.ToString(); break;
                        case 11: a = x / 31751.47; textBox1.Text = a.ToString(); break;
                        case 12: a = x / 4535924; textBox1.Text = a.ToString(); break;
                        case 13: a = x / 5080235; textBox1.Text = a.ToString(); break;
                    }
                    break;
                    //และมีเงือนไขแสดงไปเรื่อยตามด้านล่าง
            }
            switch (comboBox2.SelectedIndex)
            {
                case 1:
                    switch (comboBox1.SelectedIndex)
                    {
                        case 0: a = x * 0.005; textBox1.Text = a.ToString(); break;
                        case 1: a = x; textBox1.Text = a.ToString(); break;
                        case 2: a = x / 10; textBox1.Text = a.ToString(); break;
                        case 3: a = x / 100; textBox1.Text = a.ToString(); break;
                        case 4: a = x / 1000; textBox1.Text = a.ToString(); break;
                        case 5: a = x / 10000; textBox1.Text = a.ToString(); break;
                        case 6: a = x / 100000; textBox1.Text = a.ToString(); break;
                        case 7: a = x / 1000000; textBox1.Text = a.ToString(); break;
                        case 8: a = x / 1000000000; textBox1.Text = a.ToString(); break;
                        case 9: a = x / 28349.52; textBox1.Text = a.ToString(); break;
                        case 10: a = x / 453592.4; textBox1.Text = a.ToString(); break;
                        case 11: a = x / 6350293; textBox1.Text = a.ToString(); break;
                        case 12: a = x / 907184740; textBox1.Text = a.ToString(); break;
                        case 13: a = x / 1016046909; textBox1.Text = a.ToString(); break;
                    }
                    break;
            }
            switch (comboBox2.SelectedIndex)
            {
                case 2:
                    switch (comboBox1.SelectedIndex)
                    {
                        case 0: a = x / 20; textBox1.Text = a.ToString(); break;
                        case 1: a = x * 10; textBox1.Text = a.ToString(); break;
                        case 2: a = x; textBox1.Text = a.ToString(); break;
                        case 3: a = x / 10; ; textBox1.Text = a.ToString(); break;
                        case 4: a = x / 100; textBox1.Text = a.ToString(); break;
                        case 5: a = x / 1000; textBox1.Text = a.ToString(); break;
                        case 6: a = x / 10000; textBox1.Text = a.ToString(); break;
                        case 7: a = x / 100000; textBox1.Text = a.ToString(); break;
                        case 8: a = x / 100000000; textBox1.Text = a.ToString(); break;
                        case 9: a = x / 2834.952; textBox1.Text = a.ToString(); break;
                        case 10: a = x / 45359.24; textBox1.Text = a.ToString(); break;
                        case 11: a = x / 635029.3; textBox1.Text = a.ToString(); break;
                        case 12: a = x / 90718474; textBox1.Text = a.ToString(); break;
                        case 13: a = x / 101604691; textBox1.Text = a.ToString(); break;
                    }
                    break;
            }
            switch (comboBox2.SelectedIndex)
            {
                case 3:
                    switch (comboBox1.SelectedIndex)
                    {
                        case 0: a = x / 2; textBox1.Text = a.ToString(); break;
                        case 1: a = x * 100; textBox1.Text = a.ToString(); break;
                        case 2: a = x * 10; textBox1.Text = a.ToString(); break;
                        case 3: a = x; ; textBox1.Text = a.ToString(); break;
                        case 4: a = x / 10; textBox1.Text = a.ToString(); break;
                        case 5: a = x / 100; textBox1.Text = a.ToString(); break;
                        case 6: a = x / 1000; textBox1.Text = a.ToString(); break;
                        case 7: a = x / 10000; textBox1.Text = a.ToString(); break;
                        case 8: a = x / 10000000; textBox1.Text = a.ToString(); break;
                        case 9: a = x / 283.4952; textBox1.Text = a.ToString(); break;
                        case 10: a = x / 4535.924; textBox1.Text = a.ToString(); break;
                        case 11: a = x / 63502.93; textBox1.Text = a.ToString(); break;
                        case 12: a = x / 9071847; textBox1.Text = a.ToString(); break;
                        case 13: a = x / 10160469; textBox1.Text = a.ToString(); break;
                    }
                    break;
            }
            switch (comboBox2.SelectedIndex)
            {
                case 4:
                    switch (comboBox1.SelectedIndex)
                    {
                        case 0: a = x * 5; textBox1.Text = a.ToString(); break;
                        case 1: a = x * 1000; textBox1.Text = a.ToString(); break;
                        case 2: a = x * 100; textBox1.Text = a.ToString(); break;
                        case 3: a = x * 10; textBox1.Text = a.ToString(); break;
                        case 4: a = x; textBox1.Text = a.ToString(); break;
                        case 5: a = x / 10; textBox1.Text = a.ToString(); break;
                        case 6: a = x / 100; textBox1.Text = a.ToString(); break;
                        case 7: a = x / 1000; textBox1.Text = a.ToString(); break;
                        case 8: a = x / 1000000; textBox1.Text = a.ToString(); break;
                        case 9: a = x / 28.34952; textBox1.Text = a.ToString(); break;
                        case 10: a = x / 453.5924; textBox1.Text = a.ToString(); break;
                        case 11: a = x / 6350.293; textBox1.Text = a.ToString(); break;
                        case 12: a = x / 907184.7; textBox1.Text = a.ToString(); break;
                        case 13: a = x / 1016047; textBox1.Text = a.ToString(); break;
                    }
                    break;
            }
            switch (comboBox2.SelectedIndex)
            {
                case 5:
                    switch (comboBox1.SelectedIndex)
                    {
                        case 0: a = x * 50; textBox1.Text = a.ToString(); break;
                        case 1: a = x * 10000; textBox1.Text = a.ToString(); break;
                        case 2: a = x * 1000; textBox1.Text = a.ToString(); break;
                        case 3: a = x * 100; textBox1.Text = a.ToString(); break;
                        case 4: a = x * 10; textBox1.Text = a.ToString(); break;
                        case 5: a = x; textBox1.Text = a.ToString(); break;
                        case 6: a = x / 10; textBox1.Text = a.ToString(); break;
                        case 7: a = x / 100; textBox1.Text = a.ToString(); break;
                        case 8: a = x / 100000; textBox1.Text = a.ToString(); break;
                        case 9: a = x / 2.834952; textBox1.Text = a.ToString(); break;
                        case 10: a = x / 45.35924; textBox1.Text = a.ToString(); break;
                        case 11: a = x / 635.0293; textBox1.Text = a.ToString(); break;
                        case 12: a = x / 90718.47; textBox1.Text = a.ToString(); break;
                        case 13: a = x / 101604.7; textBox1.Text = a.ToString(); break;
                    }
                    break;
            }
            switch (comboBox2.SelectedIndex)
            {
                case 6:
                    switch (comboBox1.SelectedIndex)
                    {
                        case 0: a = x * 500; textBox1.Text = a.ToString(); break;
                        case 1: a = x * 100000; textBox1.Text = a.ToString(); break;
                        case 2: a = x * 10000; textBox1.Text = a.ToString(); break;
                        case 3: a = x * 1000; textBox1.Text = a.ToString(); break;
                        case 4: a = x * 100; textBox1.Text = a.ToString(); break;
                        case 5: a = x * 10; textBox1.Text = a.ToString(); break;
                        case 6: a = x; textBox1.Text = a.ToString(); break;
                        case 7: a = x / 10; textBox1.Text = a.ToString(); break;
                        case 8: a = x / 10000; textBox1.Text = a.ToString(); break;
                        case 9: a = x * 3.527396; textBox1.Text = a.ToString(); break;
                        case 10: a = x / 4.535924; textBox1.Text = a.ToString(); break;
                        case 11: a = x / 63.50293; textBox1.Text = a.ToString(); break;
                        case 12: a = x / 9071.847; textBox1.Text = a.ToString(); break;
                        case 13: a = x / 10160.47; textBox1.Text = a.ToString(); break;
                    }
                    break;
            }
            switch (comboBox2.SelectedIndex)
            {
                case 7:
                    switch (comboBox1.SelectedIndex)
                    {
                        case 0: a = x * 5000; textBox1.Text = a.ToString(); break;
                        case 1: a = x * 1000000; textBox1.Text = a.ToString(); break;
                        case 2: a = x * 1000000; textBox1.Text = a.ToString(); break;
                        case 3: a = x * 10000; textBox1.Text = a.ToString(); break;
                        case 4: a = x * 1000; textBox1.Text = a.ToString(); break;
                        case 5: a = x * 100; textBox1.Text = a.ToString(); break;
                        case 6: a = x * 10; textBox1.Text = a.ToString(); break;
                        case 7: a = x; textBox1.Text = a.ToString(); break;
                        case 8: a = x / 1000; textBox1.Text = a.ToString(); break;
                        case 9: a = x * 35.27396; textBox1.Text = a.ToString(); break;
                        case 10: a = x * 2.204623; textBox1.Text = a.ToString(); break;
                        case 11: a = x / 6.350293; textBox1.Text = a.ToString(); break;
                        case 12: a = x / 907.1847; textBox1.Text = a.ToString(); break;
                        case 13: a = x / 1016.047; textBox1.Text = a.ToString(); break;
                    }
                    break;
            }
            switch (comboBox2.SelectedIndex)
            {
                case 8:
                    switch (comboBox1.SelectedIndex)
                    {
                        case 0: a = x * 5000000; textBox1.Text = a.ToString(); break;
                        case 1: a = x * 1000000000; textBox1.Text = a.ToString(); break;
                        case 2: a = x * 100000000; textBox1.Text = a.ToString(); break;
                        case 3: a = x * 10000000; textBox1.Text = a.ToString(); break;
                        case 4: a = x * 1000000; textBox1.Text = a.ToString(); break;
                        case 5: a = x * 100000; textBox1.Text = a.ToString(); break;
                        case 6: a = x * 10000; textBox1.Text = a.ToString(); break;
                        case 7: a = x * 1000; textBox1.Text = a.ToString(); break;
                        case 8: a = x; textBox1.Text = a.ToString(); break;
                        case 9: a = x * 35273.96; textBox1.Text = a.ToString(); break;
                        case 10: a = x * 2204.623; textBox1.Text = a.ToString(); break;
                        case 11: a = x * 157.473; textBox1.Text = a.ToString(); break;
                        case 12: a = x * 1.102311; textBox1.Text = a.ToString(); break;
                        case 13: a = x * 0.984207; textBox1.Text = a.ToString(); break;
                    }
                    break;
            }
            switch (comboBox2.SelectedIndex)
            {
                case 9:
                    switch (comboBox1.SelectedIndex)
                    {
                        case 0: a = x * 141.7476; textBox1.Text = a.ToString(); break;
                        case 1: a = x * 28349.52; textBox1.Text = a.ToString(); break;
                        case 2: a = x * 2834.952; textBox1.Text = a.ToString(); break;
                        case 3: a = x * 283.4952; textBox1.Text = a.ToString(); break;
                        case 4: a = x * 28.34952; textBox1.Text = a.ToString(); break;
                        case 5: a = x * 2.834952; textBox1.Text = a.ToString(); break;
                        case 6: a = x / 3.527396; textBox1.Text = a.ToString(); break;
                        case 7: a = x / 35.27396; textBox1.Text = a.ToString(); break;
                        case 8: a = x / 35273.96; textBox1.Text = a.ToString(); break;
                        case 9: a = x; textBox1.Text = a.ToString(); break;
                        case 10: a = x / 16; textBox1.Text = a.ToString(); break;
                        case 11: a = x / 224; textBox1.Text = a.ToString(); break;
                        case 12: a = x / 32000; textBox1.Text = a.ToString(); break;
                        case 13: a = x / 35840; ; textBox1.Text = a.ToString(); break;
                    }
                    break;
            }
            switch (comboBox2.SelectedIndex)
            {
                case 10:
                    switch (comboBox1.SelectedIndex)
                    {
                        case 0: a = x * 2267.962; textBox1.Text = a.ToString(); break;
                        case 1: a = x * 453592.4; textBox1.Text = a.ToString(); break;
                        case 2: a = x * 45359.24; textBox1.Text = a.ToString(); break;
                        case 3: a = x * 4535.924; textBox1.Text = a.ToString(); break;
                        case 4: a = x * 453.5924; textBox1.Text = a.ToString(); break;
                        case 5: a = x * 45.35924; textBox1.Text = a.ToString(); break;
                        case 6: a = x * 4.535924; textBox1.Text = a.ToString(); break;
                        case 7: a = x / 2.204623; textBox1.Text = a.ToString(); break;
                        case 8: a = x / 2204.623; textBox1.Text = a.ToString(); break;
                        case 9: a = x * 16; textBox1.Text = a.ToString(); break;
                        case 10: a = x; textBox1.Text = a.ToString(); break;
                        case 11: a = x / 14; textBox1.Text = a.ToString(); break;
                        case 12: a = x / 2000; textBox1.Text = a.ToString(); break;
                        case 13: a = x / 2240; ; textBox1.Text = a.ToString(); break;
                    }
                    break;
            }
            switch (comboBox2.SelectedIndex)
            {
                case 11:
                    switch (comboBox1.SelectedIndex)
                    {
                        case 0: a = x * 31751.47; textBox1.Text = a.ToString(); break;
                        case 1: a = x * 6350293; textBox1.Text = a.ToString(); break;
                        case 2: a = x * 635029.3; textBox1.Text = a.ToString(); break;
                        case 3: a = x * 63502.93; textBox1.Text = a.ToString(); break;
                        case 4: a = x * 6350.293; textBox1.Text = a.ToString(); break;
                        case 5: a = x * 635.0293; textBox1.Text = a.ToString(); break;
                        case 6: a = x * 63.50293; textBox1.Text = a.ToString(); break;
                        case 7: a = x * 6.350293; textBox1.Text = a.ToString(); break;
                        case 8: a = x / 157.473; textBox1.Text = a.ToString(); break;
                        case 9: a = x * 224; textBox1.Text = a.ToString(); break;
                        case 10: a = x * 14; textBox1.Text = a.ToString(); break;
                        case 11: a = x; textBox1.Text = a.ToString(); break;
                        case 12: a = x * 0.007; textBox1.Text = a.ToString(); break;
                        case 13: a = x / 160; ; textBox1.Text = a.ToString(); break;
                    }
                    break;
            }
            switch (comboBox2.SelectedIndex)
            {
                case 12:
                    switch (comboBox1.SelectedIndex)
                    {
                        case 0: a = x * 4535924; textBox1.Text = a.ToString(); break;
                        case 1: a = x * 907184740; textBox1.Text = a.ToString(); break;
                        case 2: a = x * 90718474; textBox1.Text = a.ToString(); break;
                        case 3: a = x * 9071847; textBox1.Text = a.ToString(); break;
                        case 4: a = x * 907184.7; textBox1.Text = a.ToString(); break;
                        case 5: a = x * 90718.47; textBox1.Text = a.ToString(); break;
                        case 6: a = x * 9071.847; textBox1.Text = a.ToString(); break;
                        case 7: a = x * 907.1847; textBox1.Text = a.ToString(); break;
                        case 8: a = x / 1.102311; textBox1.Text = a.ToString(); break;
                        case 9: a = x * 32000; textBox1.Text = a.ToString(); break;
                        case 10: a = x * 2000; textBox1.Text = a.ToString(); break;
                        case 11: a = x / 0.007; textBox1.Text = a.ToString(); break;
                        case 12: a = x; textBox1.Text = a.ToString(); break;
                        case 13: a = x / 1.12; ; textBox1.Text = a.ToString(); break;
                    }
                    break;
            }
            switch (comboBox2.SelectedIndex)
            {
                case 13:
                    switch (comboBox1.SelectedIndex)
                    {
                        case 0: a = x * 5080235; textBox1.Text = a.ToString(); break;
                        case 1: a = x * 1016046909; textBox1.Text = a.ToString(); break;
                        case 2: a = x * 101604691; textBox1.Text = a.ToString(); break;
                        case 3: a = x * 10160469; textBox1.Text = a.ToString(); break;
                        case 4: a = x * 1016047; textBox1.Text = a.ToString(); break;
                        case 5: a = x * 101604.7; textBox1.Text = a.ToString(); break;
                        case 6: a = x * 10160.47; textBox1.Text = a.ToString(); break;
                        case 7: a = x * 1016.047; textBox1.Text = a.ToString(); break;
                        case 8: a = x * 1.016047; textBox1.Text = a.ToString(); break;
                        case 9: a = x * 35840; textBox1.Text = a.ToString(); break;
                        case 10: a = x * 2240; textBox1.Text = a.ToString(); break;
                        case 11: a = x * 160; textBox1.Text = a.ToString(); break;
                        case 12: a = x * 1.12; textBox1.Text = a.ToString(); break;
                        case 13: a = x; textBox1.Text = a.ToString(); break;
                    }
                    break;
            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
        }//เมธอนว่าง

        private void button28_Click(object sender, EventArgs e)//เงือนไขปุ่มที่28 แทนด้วยปุ่มClear ซึ่งจะClear ข้อมูลในrichtextbox1 ทัังหมดให้ว่าง
        {
            richTextBox1.Text = "";
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)//เมธอนว่าง
        {
            
        }

        private void button29_Click_1(object sender, EventArgs e)//และนี้คือคำสั่งเมื่อทำการกดbutton29 จะเป็นปุ่มคำสั่งโชว์ค่าที่เราเคยแปรงและไปเก็บไว้ในrichtextbox1 จะแสดงเงื่อนไขต่างๆดังนี้
        {

            richTextBox1.Show();//โชว์ richboxtextbox1
            button2.Show();//โชว์ button2 แทนชื่อปุ่มคือ back
            button1.Hide();//ซ่อน button1 แทนชื่อปุ่มคือ History
            button28.Show();//โชว์ butto28 แทนชื่อปุ่มคือ clear
            richTextBox1.Text += "แปลงจาก" + "\r\n" + textBox2.Text.ToString() + "  " + comboBox2.Text + "  ==>   " + textBox1.Text.ToString() + "  " + comboBox1.Text + "\r\n";//เมื่อทำการกดปุ่ม1 จะไปเก็บค่าไว้ในrichboxtextbox1 โดยจะแสดงตามที่เราป้อนค่าและกำหนดหน่วยเข้าไปโดยจะแสดง text2 ไป text1
            button29.Hide();//ซ่อน button29 แทนชื่อปุ่มคือ History
        }

        private void button30_Click(object sender, EventArgs e)//ปุ่มคำสั่งปิดโปรแกรม
        {
            this.Close();
        }
    }
}
