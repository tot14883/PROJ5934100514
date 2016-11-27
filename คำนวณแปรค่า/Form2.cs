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
    public partial class Long : Form
    {     //นาย นพัทธ์  ศรีจันทพงศ์  รหัสนักศึกษา 593410051-4
         public void text2()//สร้างMethod ชื่อ text2 เพื่อที่จะทำการดึงเข้าคำสั่งต่างๆใน Method มาใช่โดยจะกำหนดคำสั่งต่างๆ ดังนี้
        {           
            button3.Hide();//Hide คือ ซ้อน
            button16.Show();//Show คือ โชว์ เมื่อทำการเลือกเมธอน นี้ก็จะทำการซ่อน และโชว์ ปุ่มที่กำหนดไว้ และแต่ล่ะปุ่มจะมีการทำงานโดยจะอธิบายในหัวข้อถัดไป
            button4.Hide();
            button17.Show();
            button15.Hide();
            button23.Show();
            button5.Hide();
            button18.Show();
            button6.Hide();
            button19.Show();
            button7.Hide();
            button20.Show();
            button8.Hide();
            button21.Show();
            button9.Hide();
            button22.Show();
            button10.Hide();
            button24.Show();
            button11.Hide();
            button25.Show();
            button12.Hide();
            button26.Show();
            button13.Hide();
            button27.Show();
        }
         public void text1()//สร้างเมธอน text1 และจะคล้าย Method text2 ซึ่งจะทำการ โชว์และซ่อนปุ่มตรงกันข้ามกัน เมธฮน text2
        {
            button3.Show();
            button16.Hide();
            button4.Show();
            button17.Hide();
            button15.Show();
            button23.Hide();
            button5.Show();
            button18.Hide();
            button6.Show();
            button19.Hide();
            button7.Show();
            button20.Hide();
            button8.Show();
            button21.Hide();
            button9.Show();
            button22.Hide();
            button10.Show();
            button24.Hide();
            button11.Show();
            button25.Hide();
            button12.Show();
            button26.Hide();
            button13.Show();
            button27.Hide();
        }
        public Long()//โปรแกรมแปรงความยาว
        {
            InitializeComponent();
            button1.Hide();//โดยจะกำหนดให้ซ่อนปุ่ม1 ตั้งแต่ตอนรันโปรแกรมและจะไม่ใช่ในกรณี text1 และ text2 เพราะจะซ่อนโดนที่ไม่ได้อยู่ในเมธอนทั้งสองและจะถูกเรียกใช้ในกรณีอื่นแทน
            button14.Hide();//เหมือน ปุ่ม1 ซึ่งจะทำการซ่อน ปุ่
            richTextBox1.Hide();//จะทำการซ่อนrichtextและจะไม่ถูกเรียกใช่ถ้ายังไม่ตรงตามเงือนไข
            button28.Hide();//ซ่อนปุ่ม28
            button29.Hide();//ซ่อมปุ่ม 29
        }

        private void Long_Load(object sender, EventArgs e)
        {

        }//เมธอนว่าง

        private void button2_Click(object sender, EventArgs e)//ปุ่มที่ จะเป็นปุ่ม Clear หรือปุ่มล้าง ซึ่งจะทำการล้างในtextbox1 และ textbox2 ให้เป็นtext ว่าง
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }       
        private void button3_Click(object sender, EventArgs e)//นี้คือการกำหนดเมื่อเรียกใช้ปุ่ม 3 จะเป็นปุ่มเลขซึ่งแทนด้วยเลข1 
        {
            textBox1.Text = textBox1.Text + 1;      //คำสั่งคือให้ textbox1 +1 เมื่อทำการกดปุ่มนี้
        }

        private void button4_Click(object sender, EventArgs e)//นี้คือการกำหนดเมื่อเรียกใช้ปุ่ม 4 จะเป็นปุ่มเลขซึ่งแทนด้วยเลข2 
        {
            textBox1.Text = textBox1.Text + 2; //คำสั่งคือให้ textbox1 +2 เมื่อทำการกดปุ่มนี้
        }

        private void button5_Click(object sender, EventArgs e)//นี้คือการกำหนดเมื่อเรียกใช้ปุ่ม 5 จะเป็นปุ่มเลขซึ่งแทนด้วยเลข3
        {
            textBox1.Text = textBox1.Text + 3;//คำสั่งคือให้ textbox1 +3 เมื่อทำการกดปุ่มนี้
        }

        private void button6_Click(object sender, EventArgs e)//นี้คือการกำหนดเมื่อเรียกใช้ปุ่ม 6 จะเป็นปุ่มเลขซึ่งแทนด้วยเลข4
        {
            textBox1.Text = textBox1.Text + 4;//คำสั่งคือให้ textbox1 +4 เมื่อทำการกดปุ่มนี้
        }

        private void button7_Click(object sender, EventArgs e)//นี้คือการกำหนดเมื่อเรียกใช้ปุ่ม 7 จะเป็นปุ่มเลขซึ่งแทนด้วยเลข5
        {
            textBox1.Text = textBox1.Text + 5;//คำสั่งคือให้ textbox1 +5 เมื่อทำการกดปุ่มนี้
        }

        private void button8_Click(object sender, EventArgs e)//นี้คือการกำหนดเมื่อเรียกใช้ปุ่ม 8 จะเป็นปุ่มเลขซึ่งแทนด้วยเลข6
        {
            textBox1.Text = textBox1.Text + 6;//คำสั่งคือให้ textbox1 +6 เมื่อทำการกดปุ่มนี้
        }

        private void button9_Click(object sender, EventArgs e)//นี้คือการกำหนดเมื่อเรียกใช้ปุ่ม 9 จะเป็นปุ่มเลขซึ่งแทนด้วยเลข7
        {
            textBox1.Text = textBox1.Text + 7;//คำสั่งคือให้ textbox1 +7เมื่อทำการกดปุ่มนี้
        }

        private void button10_Click(object sender, EventArgs e)//นี้คือการกำหนดเมื่อเรียกใช้ปุ่ม 10 จะเป็นปุ่มเลขซึ่งแทนด้วยเลข8
        {
            textBox1.Text = textBox1.Text + 8;//คำสั่งคือให้ textbox1 +8 เมื่อทำการกดปุ่มนี้
        }

        private void button11_Click(object sender, EventArgs e)//นี้คือการกำหนดเมื่อเรียกใช้ปุ่ม 11 จะเป็นปุ่มเลขซึ่งแทนด้วยเลข9
        {
            textBox1.Text = textBox1.Text + 9;//คำสั่งคือให้ textbox1 +9 เมื่อทำการกดปุ่มนี้
        }

        private void button12_Click(object sender, EventArgs e)//นี้คือการกำหนดเมื่อเรียกใช้ปุ่ม 12 จะเป็นปุ่มเลขซึ่งแทนด้วยเลข0
        {
            textBox1.Text = textBox1.Text + 0;//คำสั่งคือให้ textbox1 +0 เมื่อทำการกดปุ่มนี้
        }

        private void button13_Click(object sender, EventArgs e)//นี้คือการกำหนดเมื่อเรียกใช้ปุ่ม 13 จะเป็นปุ่มเลขซึ่งแทนด้วยเครื่องหมายทศนิยม 
        {
            textBox1.Text = textBox1.Text+".";//คำสั่งคือให้ textbox1 +ทศนิยมเมื่อทำการกดปุ่มนี้
        }
        //และจะสังเกตุว่าปุ่มพวกนี้จะทำงานในtextbox1เท่านั้น และจำอธิบายว่าทำไหมถึงได้ทำงานในtextbox1 เท่านั้น
        private void button1_Click(object sender, EventArgs e)
        {
            
            
        }//เมธอนว่าง

        private void textBox2_TextChanged(object sender, EventArgs e)//ใช่คำสั่งtextbox2_textChanged ซึ่งจะแปลง ค่า รับค่าโดยที่แค่พิมพ์ตัวเลขเข้าไปแล้วจะเป็นการแปลงให้เองอัตโนมัติ
        {
            try//ดัก error ใช่คำสั่งนี้ทุกครั้งเพื่อการดัก error
            {

                double x = double.Parse(textBox2.Text);    //ป้อนค่าตัวเลขที่ต้องการพิมพ์หรือใช่ปุ่มตัวเลขได้            
                if(textBox2.Text != "")//นี้้คือการเรียกใช่ปุ่ม 1และ28 ที่กำหนดไว้นอกเมธอน จะมีเงือนไขว่าถ้าtextbox2 ไม่เท่ากับว่างจะทำการโชว์ button1 และbutton 28 ทันที
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

        private void button14_Click(object sender, EventArgs e)
        {
        }//เมธอนว่าง

        private void textBox1_TextChanged(object sender, EventArgs e)//ใช่คำสั่งtextbox1_textChanged ซึ่งจะแปลง ค่า รับค่าโดยที่แค่พิมพ์ตัวเลขเข้าไปแล้วจะเป็นการแปลงให้เองอัตโนมัติ
        {
            try//ดัก error ใช่คำสั่งนี้ทุกครั้งเพื่อการดัก error
            {
                double x = double.Parse(textBox1.Text);//ป้อนค่าตัวเลขที่ต้องการพิมพ์หรือใช่ปุ่มตัวเลขได้    
                if (textBox1.Text != "")//นี้้คือการเรียกใช่ปุ่ม 1และ28 ที่กำหนดไว้นอกเมธอน จะมีเงือนไขว่าถ้าtextbox1 ไม่เท่ากับว่างจะทำการโชว์ button1 และbutton 28 ทันที
                {
                    button1.Show();
                    button28.Show();

                }
                Text1(x); //รับค่าของ x และให้ไปคำนวณในเมธอนที่เรากำหนดโดยจะอธิบายรายละเอียดอีกทีในเมธอนText1         
            }
            catch//จับerror และส่งค่าคืน
            {
                return ;
            }
        }

        private void button15_Click(object sender, EventArgs e)//คำสั่งโดยกำหนดให้เมื่อเรียกใช้ button15 จะเป็นการลบ โดยจะทำการลบทีล่ะตัวเลขไม่เหมือนกันปุ่ม ล้างซึ่งจะล้างหมดทันที
        {
            try//ดักerror
            {
                int lenght = textBox1.TextLength - 1;//ทำการลบโดยให้ textbox1 -1 คือลบไปทีล่ะตัวเลข
                string text = textBox1.Text;//ให้ string text = textbox1.text 
                textBox1.Clear();//และให้textbox1 Clear คือการลบไปทีล่ะตัว
                for (int i = 0; i < lenght; i++)//ใช้คำสั่งfor เข้ามาช่วย
                textBox1.Text = textBox1.Text + text[i];//กำหนดให้textbox1.text = ลบไปทีล่ะตัวโดนที ให้ลบโดบเท่ากับ text[i]
            }
            catch//จับerror
            {

            }
            }

        private void button23_Click(object sender, EventArgs e)//คำสั่งโดยกำหนดให้เมื่อเรียกใช้ button23 จะเป็นการลบ โดยจะทำการลบทีล่ะตัวเลขไม่เหมือนกันปุ่ม ล้างซึ่งจะล้างหมดทันที
        {
            try//ดักerror
            {
                int l = textBox2.TextLength - 1;//ทำการลบโดยให้ textbox2 -1 คือลบไปทีล่ะตัวเลข
                string m = textBox2.Text;//ให้ string m = textbox2.text 
                textBox2.Clear();//และให้textbox2 Clear คือการลบไปทีล่ะตัว
                for (int i = 0; i < l; i++)//ใช้คำสั่งfor เข้ามาช่วย
                    textBox2.Text = textBox2.Text + m[i];//กำหนดให้textbox2.text = ลบไปทีล่ะตัวโดนที ให้ลบโดบเท่ากับ text[i]
            }
            catch//จับerror
            {

            }
            }

        private void button16_Click(object sender, EventArgs e)//นี้คือการกำหนดเมื่อเรียกใช้ปุ่ม 16 จะเป็นปุ่มเลขซึ่งแทนด้วยเลข1 
        {
            textBox2.Text = textBox2.Text + 1;//คำสั่งคือให้ textbox2 +1 เมื่อทำการกดปุ่มนี้
        }

        private void button17_Click(object sender, EventArgs e)//นี้คือการกำหนดเมื่อเรียกใช้ปุ่ม 17 จะเป็นปุ่มเลขซึ่งแทนด้วยเลข1 
        {
            textBox2.Text = textBox2.Text + 2;//คำสั่งคือให้ textbox2 +2 เมื่อทำการกดปุ่มนี้
        }

        private void button18_Click(object sender, EventArgs e)//นี้คือการกำหนดเมื่อเรียกใช้ปุ่ม 18 จะเป็นปุ่มเลขซึ่งแทนด้วยเลข1 
        {
            textBox2.Text = textBox2.Text + 3;//คำสั่งคือให้ textbox2 +3 เมื่อทำการกดปุ่มนี้
        }

        private void button19_Click(object sender, EventArgs e)//นี้คือการกำหนดเมื่อเรียกใช้ปุ่ม 19 จะเป็นปุ่มเลขซึ่งแทนด้วยเลข1 
        {
            textBox2.Text = textBox2.Text + 4;//คำสั่งคือให้ textbox2 +4 เมื่อทำการกดปุ่มนี้
        }

        private void button20_Click(object sender, EventArgs e)//นี้คือการกำหนดเมื่อเรียกใช้ปุ่ม 20 จะเป็นปุ่มเลขซึ่งแทนด้วยเลข1 
        {
            textBox2.Text = textBox2.Text + 5;//คำสั่งคือให้ textbox2 +5 เมื่อทำการกดปุ่มนี้
        }

        private void button21_Click(object sender, EventArgs e)//นี้คือการกำหนดเมื่อเรียกใช้ปุ่ม 21 จะเป็นปุ่มเลขซึ่งแทนด้วยเลข1 
        {
            textBox2.Text = textBox2.Text + 6;//คำสั่งคือให้ textbox2 +6 เมื่อทำการกดปุ่มนี้
        }

        private void button22_Click(object sender, EventArgs e)//นี้คือการกำหนดเมื่อเรียกใช้ปุ่ม 22 จะเป็นปุ่มเลขซึ่งแทนด้วยเลข1 
        {
            textBox2.Text = textBox2.Text + 7;//คำสั่งคือให้ textbox2 +7 เมื่อทำการกดปุ่มนี้
        }

        private void button24_Click(object sender, EventArgs e)//นี้คือการกำหนดเมื่อเรียกใช้ปุ่ม 24 จะเป็นปุ่มเลขซึ่งแทนด้วยเลข1 
        {
            textBox2.Text = textBox2.Text + 8;//คำสั่งคือให้ textbox2 +8 เมื่อทำการกดปุ่มนี้
        }

        private void button25_Click(object sender, EventArgs e)//นี้คือการกำหนดเมื่อเรียกใช้ปุ่ม 25 จะเป็นปุ่มเลขซึ่งแทนด้วยเลข1 
        {
            textBox2.Text = textBox2.Text + 9;//คำสั่งคือให้ textbox2 +9 เมื่อทำการกดปุ่มนี้
        }

        private void button26_Click(object sender, EventArgs e)//นี้คือการกำหนดเมื่อเรียกใช้ปุ่ม 26 จะเป็นปุ่มเลขซึ่งแทนด้วยเลข1 
        {
            textBox2.Text = textBox2.Text + 0;//คำสั่งคือให้ textbox2 +0 เมื่อทำการกดปุ่มนี้
        }

        private void button27_Click(object sender, EventArgs e)//นี้คือการกำหนดเมื่อเรียกใช้ปุ่ม 27 จะเป็นปุ่มเลขซึ่งแทนด้วยเครื่องหมายทศนิยม 
        {
            textBox2.Text =textBox1.Text+".";//คำสั่งคือให้ textbox2 +ทศนิยมเมื่อทำการกดปุ่มนี้
        }
        //จะแสดงในtextbox2 เท่านั้น
        private void textBox1_Click(object sender, EventArgs e)//นี้คือการจะอธิบายว่าทำไหมต้องใช้คำสั่งซ้อนปุ่มและโชว์ปุ่มในเมธอน text1 เมื่อทำการกด Clickที่textbox1 จะถุกกำหนดเงือนไขไว้ดังนี้
        {
            text1();//เรียกใช้เมธอน text1 โดนการคลิกที่ textbox1 และจำทำจามเงือนไขในเมธอน text1 จากที่เรากำหนดไว้
            button29.Hide();//และเมื่อคลิกก็จะทำการซ่อนbutton29 
            button1.Show();//โชว์ปุ่ม1
            button14.Hide();//ซ่อนปุ่ม14
        }

        private void textBox2_Click(object sender, EventArgs e)//เรียกใช้เมธอน text2 โดนการคลิกที่ textbox2 และจำทำจามเงือนไขในเมธอน text2 จากที่เรากำหนดไว้
        {
            text2();//เรียกใช้เมธอน text2 โดนการคลิกที่ textbox2 และจำทำจามเงือนไขในเมธอน text2 จากที่เรากำหนดไว้
            button1.Hide();//และเมื่อคลิกก็จะทำการซ่อนbutton1
            button29.Show();//โชว์ปุ่ม29
            button14.Hide();//โชว์ปุ่ม14              
        }
        private void button1_Click_1(object sender, EventArgs e)//และนี้คือคำสั่งเมื่อทำการกดbutton1 จะเป็นปุ่มคำสั่งโชว์ค่าที่เราเคยแปรงและไปเก็บไว้ในrichtextbox1 จะแสดงเงื่อนไขต่างๆดังนี้
        {
            richTextBox1.Show();//โชว์ richboxtextbox1
            button14.Show();//โชว์ button14 แทนชื่อปุ่มคือ back
            button1.Hide();//ซ่อน button1 แทนชื่อปุ่มคือ history
            button28.Show();//โชว์ button28 แทนชื่อปุ่มคือ clear
            button29.Hide();//ซ่อน button29 แทนชื่อปุ่มคือ history
            richTextBox1.Text += "แปลงจาก" + "\r\n" + textBox1.Text.ToString() + "  " + Combobox1.Text + " == >" + textBox2.Text.ToString() + "  " + comboBox.Text + "\r\n";//เมื่อทำการกดปุ่ม1 จะไปเก็บค่าไว้ในrichboxtextbox1 โดยจะแสดงตามที่เราป้อนค่าและกำหนดหน่วยเข้าไปโดยจะแสดง text2 ไป text1
        }
        private void button14_Click_1(object sender, EventArgs e)//และนี้คือปุ่มคำสั่งที่จะแสดงเงื่อนไขดังนี้
        {
            richTextBox1.Hide();//ทำการซ่อน richboxtextbox1
            button1.Show();//โชว์  button1 แทนชื่อปุ่มคือ history
            button14.Hide();//ซ่อน button14  แทนชื่อปุ่มคือ back
            button28.Hide();//ซ่อน button28 แทนชื่อปุ่มคือ Clear
            button29.Hide();//ซ่อน button29 แทนชื่อปุ่มคือ history
        }
        private void Text2(double x)//และนี้คือ เมธอนคำนวณโดยจะนำไปหาค่าดังนี้ในtextbox2_changed โดยจะแปลงจาก textbox2 ไปเป็น textbox1ดังนี้
        {
            double s;//กำหนดค่าตัวแปลง
            switch (comboBox.SelectedIndex)//จะทำการเลือกหน่วยที่จะแปรงโดยจะใช่เงื่อนไขตำแหน่ง array ดังนี้
            {
                case 0://ตำแหน่งที 0
                    switch (Combobox1.SelectedIndex)//และเมื่อเลือกcombobox ทีเราจะแปลงจะทำการคำนวณดังนี้
                    {
                        case 0: s = x; textBox1.Text = s.ToString(); break;
                        case 1: s = x * 0.001; ; textBox1.Text = s.ToString("#.###"); break;
                        case 2: s = x * 0.000001; textBox1.Text = s.ToString("#.######"); break;
                        case 3: s = x * 0.0000001; textBox1.Text = s.ToString("#.#######"); break;
                        case 4: s = x * 0.000000001; textBox1.Text = s.ToString("#.#########"); break;
                        case 5: s = x * 0.000000000001; textBox1.Text = s.ToString("#.############"); break;
                        case 6: s = x / 25400000; textBox1.Text = s.ToString(); break;
                        case 7: s = x / 304800000; textBox1.Text = s.ToString(); break;
                        case 8: s = x / 914400000; textBox1.Text = s.ToString(); break;
                        case 9: s = x / 1609344000000; textBox1.Text = s.ToString(); break;
                        case 10: s = x / 1852000000000; textBox1.Text = s.ToString(); break;
                    }
                    break;
                    //และมีเงือนไขแสดงไปเรื่อยตามด้านล่าง
            }
            switch (comboBox.SelectedIndex)
            {
                case 1:
                    switch (Combobox1.SelectedIndex)
                    {
                        case 0: s = x * 1000; textBox1.Text = s.ToString(); break;
                        case 1: s = x; ; textBox1.Text = s.ToString(); break;
                        case 2: s = x / 1000; textBox1.Text = s.ToString(); break;
                        case 3: s = x / 10000; textBox1.Text = s.ToString(); break;
                        case 4: s = x / 1000000; textBox1.Text = s.ToString("#.######"); break;
                        case 5: s = x / 1000000000; textBox1.Text = s.ToString("#.############"); break;
                        case 6: s = x / 25400; textBox1.Text = s.ToString(); break;
                        case 7: s = x / 304800; textBox1.Text = s.ToString(); break;
                        case 8: s = x / 914400; textBox1.Text = s.ToString(); break;
                        case 9: s = x / 1609344000000; textBox1.Text = s.ToString(); break;
                        case 10: s = x / 1852000000000; textBox1.Text = s.ToString(); break;
                    }
                    break;
            }
            switch (comboBox.SelectedIndex)
            {
                case 2:
                    switch (Combobox1.SelectedIndex)
                    {
                        case 0: s = x * 1000000; textBox1.Text = s.ToString(); break;
                        case 1: s = x * 1000; ; textBox1.Text = s.ToString(); break;
                        case 2: s = x; textBox1.Text = s.ToString(); break;
                        case 3: s = x * 0.1; textBox1.Text = s.ToString(); break;
                        case 4: s = x * 0.001; textBox1.Text = s.ToString(); break;
                        case 5: s = x * 0.000001; textBox1.Text = s.ToString("#.######"); break;
                        case 6: s = x / 25.4; textBox1.Text = s.ToString(); break;
                        case 7: s = x / 304.8; textBox1.Text = s.ToString(); break;
                        case 8: s = x / 914.4; textBox1.Text = s.ToString(); break;
                        case 9: s = x / 1609344; textBox1.Text = s.ToString(); break;
                        case 10: s = x / 1852000; textBox1.Text = s.ToString(); break;
                    }
                    break;
            }
            switch (comboBox.SelectedIndex)
            {
                case 3:
                    switch (Combobox1.SelectedIndex)
                    {
                        case 0: s = x * 10000000; textBox1.Text = s.ToString(); break;
                        case 1: s = x * 10000; ; textBox1.Text = s.ToString(); break;
                        case 2: s = x * 10; ; textBox1.Text = s.ToString(); break;
                        case 3: s = x; textBox1.Text = s.ToString(); break;
                        case 4: s = x * 0.01; textBox1.Text = s.ToString(); break;
                        case 5: s = x * 0.00001; textBox1.Text = s.ToString("#.#####"); break;
                        case 6: s = x / 2.54; textBox1.Text = s.ToString(); break;
                        case 7: s = x / 30.48; textBox1.Text = s.ToString(); break;
                        case 8: s = x / 91.44; textBox1.Text = s.ToString(); break;
                        case 9: s = x / 160934.4; textBox1.Text = s.ToString(); break;
                        case 10: s = x / 185200; textBox1.Text = s.ToString(); break;
                    }
                    break;
            }
            switch (comboBox.SelectedIndex)
            {
                case 4:
                    switch (Combobox1.SelectedIndex)
                    {
                        case 0: s = x * 1000000000; textBox1.Text = s.ToString(); break;
                        case 1: s = x * 1000000; ; textBox1.Text = s.ToString(); break;
                        case 2: s = x * 1000; ; textBox1.Text = s.ToString(); break;
                        case 3: s = x * 100; textBox1.Text = s.ToString(); break;
                        case 4: s = x; textBox1.Text = s.ToString(); break;
                        case 5: s = x * 0.001; textBox1.Text = s.ToString(); break;
                        case 6: s = x / 0.0254; textBox1.Text = s.ToString(); break;
                        case 7: s = x / 0.3048; textBox1.Text = s.ToString(); break;
                        case 8: s = x / 0.9144; textBox1.Text = s.ToString(); break;
                        case 9: s = x / 1609.344; textBox1.Text = s.ToString(); break;
                        case 10: s = x * 0.00054; textBox1.Text = s.ToString(); break;
                    }
                    break;
            }
            switch (comboBox.SelectedIndex)
            {
                case 5:
                    switch (Combobox1.SelectedIndex)
                    {
                        case 0: s = x * 1000000000000; textBox1.Text = s.ToString(); break;
                        case 1: s = x * 1000000000; ; textBox1.Text = s.ToString(); break;
                        case 2: s = x * 1000000; ; textBox1.Text = s.ToString(); break;
                        case 3: s = x * 100000; textBox1.Text = s.ToString(); break;
                        case 4: s = x * 1000; textBox1.Text = s.ToString(); break;
                        case 5: s = x; textBox1.Text = s.ToString(); break;
                        case 6: s = x * 39370.08; textBox1.Text = s.ToString(); break;
                        case 7: s = x * 3280.84; textBox1.Text = s.ToString(); break;
                        case 8: s = x * 1093.613; textBox1.Text = s.ToString(); break;
                        case 9: s = x / 1.609344; textBox1.Text = s.ToString(); break;
                        case 10: s = x / 1.852; textBox1.Text = s.ToString(); break;
                    }
                    break;
            }
            switch (comboBox.SelectedIndex)
            {
                case 6:
                    switch (Combobox1.SelectedIndex)
                    {
                        case 0: s = x * 25400000; textBox1.Text = s.ToString(); break;
                        case 1: s = x * 25400; ; textBox1.Text = s.ToString(); break;
                        case 2: s = x * 25.4; ; textBox1.Text = s.ToString(); break;
                        case 3: s = x * 2.54; textBox1.Text = s.ToString(); break;
                        case 4: s = x / 39.37008; textBox1.Text = s.ToString(); break;
                        case 5: s = x / 39370.08; textBox1.Text = s.ToString(); break;
                        case 6: s = x; textBox1.Text = s.ToString(); break;
                        case 7: s = x / 12; textBox1.Text = s.ToString(); break;
                        case 8: s = x * 0.027778; textBox1.Text = s.ToString(); break;
                        case 9: s = x / 63360; textBox1.Text = s.ToString(); break;
                        case 10: s = x / 72913.39; textBox1.Text = s.ToString(); break;
                    }
                    break;
            }
            switch (comboBox.SelectedIndex)
            {
                case 7:
                    switch (Combobox1.SelectedIndex)
                    {
                        case 0: s = x * 304800000; textBox1.Text = s.ToString(); break;
                        case 1: s = x * 304800; ; textBox1.Text = s.ToString(); break;
                        case 2: s = x * 304.8; ; textBox1.Text = s.ToString(); break;
                        case 3: s = x * 30.48; textBox1.Text = s.ToString(); break;
                        case 4: s = x / 3.28084; textBox1.Text = s.ToString(); break;
                        case 5: s = x / 3280.84; textBox1.Text = s.ToString(); break;
                        case 6: s = x * 12; textBox1.Text = s.ToString(); break;
                        case 7: s = x; textBox1.Text = s.ToString(); break;
                        case 8: s = x / 3; ; textBox1.Text = s.ToString(); break;
                        case 9: s = x / 5280; textBox1.Text = s.ToString(); break;
                        case 10: s = x / 6076.115; textBox1.Text = s.ToString(); break;
                    }
                    break;
            }
            switch (comboBox.SelectedIndex)
            {
                case 8:
                    switch (Combobox1.SelectedIndex)
                    {
                        case 0: s = x / 0.00000000109361; textBox1.Text = s.ToString(); break;
                        case 1: s = x * 914400; ; textBox1.Text = s.ToString(); break;
                        case 2: s = x * 914.4; ; textBox1.Text = s.ToString(); break;
                        case 3: s = x * 91.44; textBox1.Text = s.ToString(); break;
                        case 4: s = x * 0.9144; textBox1.Text = s.ToString(); break;
                        case 5: s = x / 1093.613; textBox1.Text = s.ToString(); break;
                        case 6: s = x * 36; textBox1.Text = s.ToString(); break;
                        case 7: s = x * 3; textBox1.Text = s.ToString(); break;
                        case 8: s = x; ; textBox1.Text = s.ToString(); break;
                        case 9: s = x / 1760; textBox1.Text = s.ToString(); break;
                        case 10: s = x / 2025.372; textBox1.Text = s.ToString(); break;
                    }
                    break;
            }
            switch (comboBox.SelectedIndex)
            {
                case 9:
                    switch (Combobox1.SelectedIndex)
                    {
                        case 0: s = x * 1609344000000; textBox1.Text = s.ToString(); break;
                        case 1: s = x * 1609344000; ; textBox1.Text = s.ToString(); break;
                        case 2: s = x * 1609344; ; textBox1.Text = s.ToString(); break;
                        case 3: s = x * 160934.4; textBox1.Text = s.ToString(); break;
                        case 4: s = x * 1609.344; textBox1.Text = s.ToString(); break;
                        case 5: s = x / 0.621371; textBox1.Text = s.ToString(); break;
                        case 6: s = x * 63360; textBox1.Text = s.ToString(); break;
                        case 7: s = x * 5280; textBox1.Text = s.ToString(); break;
                        case 8: s = x * 1760; ; textBox1.Text = s.ToString(); break;
                        case 9: s = x; textBox1.Text = s.ToString(); break;
                        case 10: s = x / 1.150779; textBox1.Text = s.ToString(); break;
                    }
                    break;
            }
            switch (comboBox.SelectedIndex)
            {
                case 10:
                    switch (Combobox1.SelectedIndex)
                    {
                        case 0: s = x * 1852000000000; textBox1.Text = s.ToString(); break;
                        case 1: s = x * 1852000000; ; textBox1.Text = s.ToString(); break;
                        case 2: s = x * 1852000; ; textBox1.Text = s.ToString(); break;
                        case 3: s = x * 185200; textBox1.Text = s.ToString(); break;
                        case 4: s = x * 1852; textBox1.Text = s.ToString(); break;
                        case 5: s = x * 1.852; textBox1.Text = s.ToString(); break;
                        case 6: s = x * 72913.39; textBox1.Text = s.ToString(); break;
                        case 7: s = x * 6076.115; textBox1.Text = s.ToString(); break;
                        case 8: s = x * 2025.372; ; textBox1.Text = s.ToString(); break;
                        case 9: s = x / 0.868976; textBox1.Text = s.ToString(); break;
                        case 10: s = x; textBox1.Text = s.ToString(); break;
                    }
                    break;
            }
        }
        private void Text1(double x)//และนี้คือ เมธอนคำนวณโดยจะนำไปหาค่าดังนี้ในtextbox1_changed โดยจะแปลงจาก textbox1 ไปเป็น textbox2ดังนี้
        {
            double s;//กำหนดค่าตัวแปลง
            switch (Combobox1.SelectedIndex)//จะทำการเลือกหน่วยที่จะแปรงโดยจะใช่เงื่อนไขตำแหน่ง array ดังนี้
            {   
                case 0://ตำแหน่งที 0
                    switch (comboBox.SelectedIndex)//และเมื่อเลือกcombobox ทีเราจะแปลงจะทำการคำนวณดังนี้
                    {
                        case 0: s = x; textBox2.Text = s.ToString(); break;
                        case 1: s = x / 1000; textBox2.Text = s.ToString(); break;
                        case 2: s = x / 1000000; textBox2.Text = s.ToString("#.######"); break;
                        case 3: s = x / 10000000; textBox2.Text = s.ToString("#.#######"); break;
                        case 4: s = x / 1000000000; textBox2.Text = s.ToString("#.#########"); break;
                        case 5: s = x / 1000000000000; textBox2.Text = s.ToString("#.############"); break;
                        case 6: s = x / 25400000; textBox2.Text = s.ToString(); break;
                        case 7: s = x / 304800000; textBox2.Text = s.ToString(); break;
                        case 8: s = x * 0.00000000109361; textBox2.Text = s.ToString(); break;
                        case 9: s = x / 1609344000000; textBox2.Text = s.ToString(); break;
                        case 10: s = x / 1852000000000; textBox2.Text = s.ToString(); break;

                    }
                    break;
                    //และมีเงือนไขแสดงไปเรื่อยตามด้านล่าง
            }
            switch (Combobox1.SelectedIndex)
            {
                case 1:
                    switch (comboBox.SelectedIndex)
                    {
                        case 0: s = x * 1000; textBox2.Text = s.ToString(); break;
                        case 1: s = x; textBox2.Text = s.ToString(); break;
                        case 2: s = x / 1000; textBox2.Text = s.ToString(); break;
                        case 3: s = x / 10000; textBox2.Text = s.ToString(); break;
                        case 4: s = x / 1000000; textBox2.Text = s.ToString(); break;
                        case 5: s = x / 1000000000; textBox2.Text = s.ToString(); break;
                        case 6: s = x / 25400; textBox2.Text = s.ToString(); break;
                        case 7: s = x / 304800; textBox2.Text = s.ToString(); break;
                        case 8: s = x / 914400; textBox2.Text = s.ToString(); break;
                        case 9: s = x / 1609344000; textBox2.Text = s.ToString(); break;
                        case 10: s = x / 1852000000; textBox2.Text = s.ToString(); break;
                    }
                    break;
            }
            switch (Combobox1.SelectedIndex)
            {
                case 2:
                    switch (comboBox.SelectedIndex)
                    {
                        case 0: s = x * 1000000; textBox2.Text = s.ToString(); break;
                        case 1: s = x * 1000; textBox2.Text = s.ToString(); break;
                        case 2: s = x; textBox2.Text = s.ToString(); break;
                        case 3: s = x * 0.1; textBox2.Text = s.ToString(); break;
                        case 4: s = x * 0.001; textBox2.Text = s.ToString(); break;
                        case 5: s = x * 0.000001; textBox2.Text = s.ToString(); break;
                        case 6: s = x / 25.4; textBox2.Text = s.ToString(); break;
                        case 7: s = x / 304.8; textBox2.Text = s.ToString(); break;
                        case 8: s = x / 914.4; textBox2.Text = s.ToString(); break;
                        case 9: s = x / 1609344; textBox2.Text = s.ToString(); break;
                        case 10: s = x / 1852000; textBox2.Text = s.ToString(); break;
                    }
                    break;
            }
            switch (Combobox1.SelectedIndex)
            {
                case 3:
                    switch (comboBox.SelectedIndex)
                    {
                        case 0: s = x * 10000000; textBox2.Text = s.ToString(); break;
                        case 1: s = x * 10000; textBox2.Text = s.ToString(); break;
                        case 2: s = x * 10; textBox2.Text = s.ToString(); break;
                        case 3: s = x; textBox2.Text = s.ToString(); break;
                        case 4: s = x / 100; textBox2.Text = s.ToString(); break;
                        case 5: s = x / 100000; textBox2.Text = s.ToString(); break;
                        case 6: s = x / 2.54; textBox2.Text = s.ToString(); break;
                        case 7: s = x / 30.48; textBox2.Text = s.ToString(); break;
                        case 8: s = x / 91.44; textBox2.Text = s.ToString(); break;
                        case 9: s = x / 160934.4; textBox2.Text = s.ToString(); break;
                        case 10: s = x / 185200; textBox2.Text = s.ToString(); break;
                    }
                    break;
            }
            switch (Combobox1.SelectedIndex)
            {
                case 4:
                    switch (comboBox.SelectedIndex)
                    {
                        case 0: s = x * 1000000000; textBox2.Text = s.ToString(); break;
                        case 1: s = x * 1000000; textBox2.Text = s.ToString(); break;
                        case 2: s = x * 1000; textBox2.Text = s.ToString(); break;
                        case 3: s = x * 100; textBox2.Text = s.ToString(); break;
                        case 4: s = x; textBox2.Text = s.ToString(); break;
                        case 5: s = x / 1000; textBox2.Text = s.ToString(); break;
                        case 6: s = x * 39.37008; textBox2.Text = s.ToString(); break;
                        case 7: s = x * 3.28084; textBox2.Text = s.ToString(); break;
                        case 8: s = x / 0.9144; textBox2.Text = s.ToString(); break;
                        case 9: s = x / 1609.344; textBox2.Text = s.ToString(); break;
                        case 10: s = x / 1852; textBox2.Text = s.ToString(); break;
                    }
                    break;
            }
            switch (Combobox1.SelectedIndex)
            {
                case 5:
                    switch (comboBox.SelectedIndex)
                    {
                        case 0: s = x * 1000000000000; textBox2.Text = s.ToString(); break;
                        case 1: s = x * 1000000000; textBox2.Text = s.ToString(); break;
                        case 2: s = x * 1000000; textBox2.Text = s.ToString(); break;
                        case 3: s = x * 100000; textBox2.Text = s.ToString(); break;
                        case 4: s = x * 1000; textBox2.Text = s.ToString(); break;
                        case 5: s = x; textBox2.Text = s.ToString(); break;
                        case 6: s = x * 39370.08; textBox2.Text = s.ToString(); break;
                        case 7: s = x * 3280.84; textBox2.Text = s.ToString(); break;
                        case 8: s = x * 1093.613; textBox2.Text = s.ToString(); break;
                        case 9: s = x * 0.621371; textBox2.Text = s.ToString(); break;
                        case 10: s = x / 1.852; textBox2.Text = s.ToString(); break;
                    }
                    break;
            }
            switch (Combobox1.SelectedIndex)
            {
                case 6:
                    switch (comboBox.SelectedIndex)
                    {
                        case 0: s = x * 25400000; textBox2.Text = s.ToString(); break;
                        case 1: s = x * 25400; textBox2.Text = s.ToString(); break;
                        case 2: s = x * 25.4; textBox2.Text = s.ToString(); break;
                        case 3: s = x * 2.54; textBox2.Text = s.ToString(); break;
                        case 4: s = x * 0.0254; textBox2.Text = s.ToString(); break;
                        case 5: s = x / 39370.08; textBox2.Text = s.ToString(); break;
                        case 6: s = x; textBox2.Text = s.ToString(); break;
                        case 7: s = x / 12; textBox2.Text = s.ToString(); break;
                        case 8: s = x / 36; textBox2.Text = s.ToString(); break;
                        case 9: s = x / 63360; textBox2.Text = s.ToString(); break;
                        case 10: s = x / 72913.39; textBox2.Text = s.ToString(); break;
                    }
                    break;
            }
            switch (Combobox1.SelectedIndex)
            {
                case 7:
                    switch (comboBox.SelectedIndex)
                    {
                        case 0: s = x * 304800000; textBox2.Text = s.ToString(); break;
                        case 1: s = x * 304800; textBox2.Text = s.ToString(); break;
                        case 2: s = x * 304.8; textBox2.Text = s.ToString(); break;
                        case 3: s = x * 30.48; textBox2.Text = s.ToString(); break;
                        case 4: s = x * 0.3048; textBox2.Text = s.ToString(); break;
                        case 5: s = x / 3280.84; textBox2.Text = s.ToString(); break;
                        case 6: s = x * 12; textBox2.Text = s.ToString(); break;
                        case 7: s = x; textBox2.Text = s.ToString(); break;
                        case 8: s = x / 3; textBox2.Text = s.ToString(); break;
                        case 9: s = x / 5280; textBox2.Text = s.ToString(); break;
                        case 10: s = x / 6076.115; textBox2.Text = s.ToString(); break;
                    }
                    break;
            }
            switch (Combobox1.SelectedIndex)
            {
                case 8:
                    switch (comboBox.SelectedIndex)
                    {
                        case 0: s = x * 914400000; textBox2.Text = s.ToString(); break;
                        case 1: s = x * 914400; textBox2.Text = s.ToString(); break;
                        case 2: s = x * 914.4; textBox2.Text = s.ToString(); break;
                        case 3: s = x * 91.44; textBox2.Text = s.ToString(); break;
                        case 4: s = x * 0.9144; textBox2.Text = s.ToString(); break;
                        case 5: s = x / 1093.613; textBox2.Text = s.ToString(); break;
                        case 6: s = x * 36; textBox2.Text = s.ToString(); break;
                        case 7: s = x * 3; textBox2.Text = s.ToString(); break;
                        case 8: s = x; textBox2.Text = s.ToString(); break;
                        case 9: s = x / 1760; textBox2.Text = s.ToString(); break;
                        case 10: s = x / 2025.372; textBox2.Text = s.ToString(); break;
                    }
                    break;
            }
            switch (Combobox1.SelectedIndex)
            {
                case 9:
                    switch (comboBox.SelectedIndex)
                    {
                        case 0: s = x * 1609344000000; textBox2.Text = s.ToString(); break;
                        case 1: s = x * 1609344000; textBox2.Text = s.ToString(); break;
                        case 2: s = x * 1609344; textBox2.Text = s.ToString(); break;
                        case 3: s = x * 160934.4; textBox2.Text = s.ToString(); break;
                        case 4: s = x * 1609.344; textBox2.Text = s.ToString(); break;
                        case 5: s = x * 1.609344; textBox2.Text = s.ToString(); break;
                        case 6: s = x * 63360; textBox2.Text = s.ToString(); break;
                        case 7: s = x * 5280; textBox2.Text = s.ToString(); break;
                        case 8: s = x * 1760; textBox2.Text = s.ToString(); break;
                        case 9: s = x; textBox2.Text = s.ToString(); break;
                        case 10: s = x * 0.868976; textBox2.Text = s.ToString(); break;
                    }
                    break;
            }
            switch (Combobox1.SelectedIndex)
            {
                case 10:
                    switch (comboBox.SelectedIndex)
                    {
                        case 0: s = x * 1852000000000; textBox2.Text = s.ToString(); break;
                        case 1: s = x * 1852000000; textBox2.Text = s.ToString(); break;
                        case 2: s = x * 1852000; textBox2.Text = s.ToString(); break;
                        case 3: s = x * 185200; textBox2.Text = s.ToString(); break;
                        case 4: s = x * 1852; textBox2.Text = s.ToString(); break;
                        case 5: s = x * 1.852; textBox2.Text = s.ToString(); break;
                        case 6: s = x * 72913.39; textBox2.Text = s.ToString(); break;
                        case 7: s = x * 6076.115; textBox2.Text = s.ToString(); break;
                        case 8: s = x * 2025.372; textBox2.Text = s.ToString(); break;
                        case 9: s = x * 1.150779; textBox2.Text = s.ToString(); break;
                        case 10: s = x; textBox2.Text = s.ToString(); break;
                    }
                    break;
            }
        }

        private void button28_Click(object sender, EventArgs e)//เงือนไขปุ่มที่28 แทนด้วยปุ่มClear ซึ่งจะClear ข้อมูลในrichtextbox1 ทัังหมดให้ว่าง
        {
            richTextBox1.Text = "";
        }

        private void button29_Click(object sender, EventArgs e)//และนี้คือคำสั่งเมื่อทำการกดbutton29 จะเป็นปุ่มคำสั่งโชว์ค่าที่เราเคยแปรงและไปเก็บไว้ในrichtextbox1 จะแสดงเงื่อนไขต่างๆดังนี้
        {
            richTextBox1.Show();//โชว์ richboxtextbox1
            button14.Show();//โชว์ button14 แทนชื่อปุ่มคือ back
            button1.Hide();//ซ่อน button1 แทนชื่อปุ่มคือ history
            button28.Show();//โชว์ button28 แทนชื่อปุ่มคือ clear
            button29.Hide();//ซ่อน button29 แทนชื่อปุ่มคือ history
            richTextBox1.Text += "แปลงจาก" + "\r\n" + textBox2.Text.ToString() + "  " + comboBox.Text + "  ==>  " + textBox1.Text.ToString() + "  " + Combobox1.Text + "\r\n";//เมื่อทำการกดปุ่ม29 จะไปเก็บค่าไว้ในrichboxtextbox1 โดยจะแสดงตามที่เราป้อนค่าและกำหนดหน่วยเข้าไปโดยใหแสดง ค่าแปลงจากtext2ไปtext1
        }

        private void button30_Click(object sender, EventArgs e)//ปุ่มคำสั่งปิดโปรแกรม
        {
            this.Close();
        }
    }
}
