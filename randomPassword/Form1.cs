using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace randomPassword
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        { 
            Random rand = new Random();
            int nun = rand.Next(0,10);
            label2.Text= nun.ToString();
            

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Visible = false;
            button21.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            label15.Visible = false;
            label16.Visible = false;
            label17.Visible = false;
            label18.Visible = false;
            label19.Visible = false;
            label20.Visible = false;
            label21.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;

            button10.Visible = false;
            button11.Visible = false;
            button12.Visible = false;
            button13.Visible = false;
            button14.Visible = false;
            button15.Visible = false;
            button16.Visible = false;
            button17.Visible = false;

            button18.Visible = false;
            button19.Visible = false;
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int nun1 = rand.Next(0, 10);
            label3.Text = nun1.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int nun = rand.Next(0, 10);
            label4.Text = nun.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int nun = rand.Next(0, 10);
            label5.Text = nun.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int nun = rand.Next(0, 10);
            label6.Text = nun.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int nun = rand.Next(0, 10);
            label7.Text = nun.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int nun = rand.Next(0, 10);
            label8.Text = nun.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int nun = rand.Next(0, 10);
            label9.Text = nun.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            String we = label2.Text;
            String we1 = label3.Text;
            String we2 = label4.Text;
            String we3= label5.Text;
            String we4 = label6.Text;
            String we5 = label7.Text;
            String we6 = label8.Text;
            String we7 = label9.Text;
            String we8 = label10.Text;
            String we9 = label19.Text;
            String we10 = label18.Text;
            String we11= label17.Text;
            String we12 = label16.Text;
            String we13 = label15.Text;
            String we14 = label14.Text;
            String we15 = label13.Text; 
            String we16 = label12.Text;
            String we17 = label11.Text;
            //troll code below
            //label21.Text=("Haha dumbass. Nice Time waster huh");
            label21.Text=("Your username is: "+we9+we10+we11+we12+we13+we14+we15+we16+we17+ " and your password is: " + we + we1 + we2+we3+we4+we5+we6+we7+we8);
        }


        private void button10_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int nun = rand.Next(0, 10);
            label10.Text = nun.ToString();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {
            //copy this into each button
            Random rand = new Random();
            int nun = rand.Next(1, 26);
            label19.Text = nun.ToString();
            if (nun == 1)
            {
               
                label19.Text = "A";
            }
            else if (nun == 2)
            {
                label19.Text = "B";
            }
            else if (nun== 3)
            {
                label19.Text = "C";
            }
            else if (nun == 4)
            {
                label19.Text = "D";
            }    
            else if (nun==5)
            {
                label19.Text = "E";
            }
            else if (nun==6)
            {
                label19.Text = "F";
            }
            else if (nun == 7)
            {
                label19.Text = "G";
            }
            else if (nun==8)
            {
                label19.Text = "H";
            }
            else if (nun==9)
            {
                label19.Text = "I";
            }
            else if (nun ==10)
            {
                label19.Text = "J";
            }
            else if (nun == 11)
            {
                label19.Text = "K";
            }
            else if (nun == 12)
            {
                label19.Text = "L";
            }
            else if (nun == 13)
            {
                label19.Text = "M";
            }
            else if (nun == 14)
            {
                label19.Text = "N";
            }
            else if (nun == 15)
            {
                label19.Text = "O";
            }
            else if (nun == 16)
            {
                label19.Text = "P";
            }
            else if (nun == 17)
            {
                label19.Text = "Q";
                
            }
            else if (nun == 18)
            {
                label19.Text = "R";
            }
            else if (nun == 19)
            {
                label19.Text = "S";
            }
            else if (nun == 20)
            {
                label19.Text = "T";
            }
            else if (nun == 21)
            {
                label19.Text = "U";
            }
            else if (nun == 22)
            {
                label19.Text = "V";
            }
            else if (nun == 23)
            {
                label19.Text = "W";
                
            }
            else if (nun == 24)
            {
                label19.Text = "X";
            }
            else if (nun == 25)
            {
                label19.Text = "Y";
            }
            else if (nun == 26)
            {
                label19.Text = "Z";
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int nun = rand.Next(1, 26);
            label18.Text = nun.ToString();
            if (nun == 1)
            {

                label18.Text = "A";
            }
            else if (nun == 2)
            {
                label18.Text = "B";
            }
            else if (nun == 3)
            {
                label18.Text = "C";
            }
            else if (nun == 4)
            {
                label18.Text = "D";
            }
            else if (nun == 5)
            {
                label18.Text = "E";
            }
            else if (nun == 6)
            {
                label18.Text = "F";
            }
            else if (nun == 7)
            {
                label18.Text = "G";
            }
            else if (nun == 8)
            {
                label18.Text = "H";
            }
            else if (nun == 9)
            {
                label18.Text = "I";
            }
            else if (nun == 10)
            {
                label18.Text = "J";
            }
            else if (nun == 11)
            {
                label18.Text = "K";
            }
            else if (nun == 12)
            {
                label18.Text = "L";
            }
            else if (nun == 13)
            {
                label18.Text = "M";
            }
            else if (nun == 14)
            {
                label18.Text = "N";
            }
            else if (nun == 15)
            {
                label18.Text = "O";
            }
            else if (nun == 16)
            {
                label18.Text = "P";
            }
            else if (nun == 17)
            {
                label18.Text = "Q";

            }
            else if (nun == 18)
            {
                label18.Text = "R";
            }
            else if (nun == 19)
            {
                label18.Text = "S";
            }
            else if (nun == 20)
            {
                label18.Text = "T";
            }
            else if (nun == 21)
            {
                label18.Text = "U";
            }
            else if (nun == 22)
            {
                label18.Text = "V";
            }
            else if (nun == 23)
            {
                label18.Text = "W";

            }
            else if (nun == 24)
            {
                label18.Text = "X";
            }
            else if (nun == 25)
            {
                label18.Text = "Y";
            }
            else if (nun == 26)
            {
                label18.Text = "Z";
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int nun = rand.Next(1, 26);
            label17.Text = nun.ToString();
            if (nun == 1)
            {

                label17.Text = "A";
            }
            else if (nun == 2)
            {
                label17.Text = "B";
            }
            else if (nun == 3)
            {
                label17.Text = "C";
            }
            else if (nun == 4)
            {
                label17.Text = "D";
            }
            else if (nun == 5)
            {
                label17.Text = "E";
            }
            else if (nun == 6)
            {
                label17.Text = "F";
            }
            else if (nun == 7)
            {
                label17.Text = "G";
            }
            else if (nun == 8)
            {
                label17.Text = "H";
            }
            else if (nun == 9)
            {
                label17.Text = "I";
            }
            else if (nun == 10)
            {
                label17.Text = "J";
            }
            else if (nun == 11)
            {
                label17.Text = "K";
            }
            else if (nun == 12)
            {
                label17.Text = "L";
            }
            else if (nun == 13)
            {
                label17.Text = "M";
            }
            else if (nun == 14)
            {
                label17.Text = "N";
            }
            else if (nun == 15)
            {
                label17.Text = "O";
            }
            else if (nun == 16)
            {
                label17.Text = "P";
            }
            else if (nun == 17)
            {
                label17.Text = "Q";

            }
            else if (nun == 18)
            {
                label17.Text = "R";
            }
            else if (nun == 19)
            {
                label17.Text = "S";
            }
            else if (nun == 20)
            {
                label17.Text = "T";
            }
            else if (nun == 21)
            {
                label17.Text = "U";
            }
            else if (nun == 22)
            {
                label17.Text = "V";
            }
            else if (nun == 23)
            {
                label17.Text = "W";

            }
            else if (nun == 24)
            {
                label17.Text = "X";
            }
            else if (nun == 25)
            {
                label17.Text = "Y";
            }
            else if (nun == 26)
            {
                label17.Text = "Z";
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int nun = rand.Next(1, 26);
            label16.Text = nun.ToString();
            if (nun == 1)
            {

                label16.Text = "A";
            }
            else if (nun == 2)
            {
                label16.Text = "B";
            }
            else if (nun == 3)
            {
                label16.Text = "C";
            }
            else if (nun == 4)
            {
                label16.Text = "D";
            }
            else if (nun == 5)
            {
                label16.Text = "E";
            }
            else if (nun == 6)
            {
                label16.Text = "F";
            }
            else if (nun == 7)
            {
                label16.Text = "G";
            }
            else if (nun == 8)
            {
                label16.Text = "H";
            }
            else if (nun == 9)
            {
                label16.Text = "I";
            }
            else if (nun == 10)
            {
                label16.Text = "J";
            }
            else if (nun == 11)
            {
                label16.Text = "K";
            }
            else if (nun == 12)
            {
                label16.Text = "L";
            }
            else if (nun == 13)
            {
                label16.Text = "M";
            }
            else if (nun == 14)
            {
                label16.Text = "N";
            }
            else if (nun == 15)
            {
                label16.Text = "O";
            }
            else if (nun == 16)
            {
                label16.Text = "P";
            }
            else if (nun == 17)
            {
                label16.Text = "Q";

            }
            else if (nun == 18)
            {
                label16.Text = "R";
            }
            else if (nun == 19)
            {
                label16.Text = "S";
            }
            else if (nun == 20)
            {
                label16.Text = "T";
            }
            else if (nun == 21)
            {
                label16.Text = "U";
            }
            else if (nun == 22)
            {
                label16.Text = "V";
            }
            else if (nun == 23)
            {
                label16.Text = "W";

            }
            else if (nun == 24)
            {
                label16.Text = "X";
            }
            else if (nun == 25)
            {
                label16.Text = "Y";
            }
            else if (nun == 26)
            {
                label16.Text = "Z";
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int nun = rand.Next(1, 26);
            label15.Text = nun.ToString();
            if (nun == 1)
            {

                label15.Text = "A";
            }
            else if (nun == 2)
            {
                label15.Text = "B";
            }
            else if (nun == 3)
            {
                label15.Text = "C";
            }
            else if (nun == 4)
            {
                label15.Text = "D";
            }
            else if (nun == 5)
            {
                label15.Text = "E";
            }
            else if (nun == 6)
            {
                label15.Text = "F";
            }
            else if (nun == 7)
            {
                label15.Text = "G";
            }
            else if (nun == 8)
            {
                label15.Text = "H";
            }
            else if (nun == 9)
            {
                label15.Text = "I";
            }
            else if (nun == 10)
            {
                label15.Text = "J";
            }
            else if (nun == 11)
            {
                label15.Text = "K";
            }
            else if (nun == 12)
            {
                label15.Text = "L";
            }
            else if (nun == 13)
            {
                label15.Text = "M";
            }
            else if (nun == 14)
            {
                label15.Text = "N";
            }
            else if (nun == 15)
            {
                label15.Text = "O";
            }
            else if (nun == 16)
            {
                label15.Text = "P";
            }
            else if (nun == 17)
            {
                label15.Text = "Q";

            }
            else if (nun == 18)
            {
                label15.Text = "R";
            }
            else if (nun == 19)
            {
                label15.Text = "S";
            }
            else if (nun == 20)
            {
                label15.Text = "T";
            }
            else if (nun == 21)
            {
                label15.Text = "U";
            }
            else if (nun == 22)
            {
                label15.Text = "V";
            }
            else if (nun == 23)
            {
                label15.Text = "W";

            }
            else if (nun == 24)
            {
                label15.Text = "X";
            }
            else if (nun == 25)
            {
                label15.Text = "Y";
            }
            else if (nun == 26)
            {
                label15.Text = "Z";
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int nun = rand.Next(1, 26);
            label14.Text = nun.ToString();
            if (nun == 1)
            {

                label14.Text = "A";
            }
            else if (nun == 2)
            {
                label14.Text = "B";
            }
            else if (nun == 3)
            {
                label14.Text = "C";
            }
            else if (nun == 4)
            {
                label14.Text = "D";
            }
            else if (nun == 5)
            {
                label14.Text = "E";
            }
            else if (nun == 6)
            {
                label14.Text = "F";
            }
            else if (nun == 7)
            {
                label14.Text = "G";
            }
            else if (nun == 8)
            {
                label14.Text = "H";
            }
            else if (nun == 9)
            {
                label14.Text = "I";
            }
            else if (nun == 10)
            {
                label14.Text = "J";
            }
            else if (nun == 11)
            {
                label14.Text = "K";
            }
            else if (nun == 12)
            {
                label14.Text = "L";
            }
            else if (nun == 13)
            {
                label14.Text = "M";
            }
            else if (nun == 14)
            {
                label14.Text = "N";
            }
            else if (nun == 15)
            {
                label14.Text = "O";
            }
            else if (nun == 16)
            {
                label14.Text = "P";
            }
            else if (nun == 17)
            {
                label14.Text = "Q";

            }
            else if (nun == 18)
            {
                label14.Text = "R";
            }
            else if (nun == 19)
            {
                label14.Text = "S";
            }
            else if (nun == 20)
            {
                label14.Text = "T";
            }
            else if (nun == 21)
            {
                label14.Text = "U";
            }
            else if (nun == 22)
            {
                label14.Text = "V";
            }
            else if (nun == 23)
            {
                label14.Text = "W";

            }
            else if (nun == 24)
            {
                label14.Text = "X";
            }
            else if (nun == 25)
            {
                label14.Text = "Y";
            }
            else if (nun == 26)
            {
                label14.Text = "Z";
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int nun = rand.Next(1, 26);
            label13.Text = nun.ToString();
            if (nun == 1)
            {

                label13.Text = "A";
            }
            else if (nun == 2)
            {
                label13.Text = "B";
            }
            else if (nun == 3)
            {
                label13.Text = "C";
            }
            else if (nun == 4)
            {
                label13.Text = "D";
            }
            else if (nun == 5)
            {
                label13.Text = "E";
            }
            else if (nun == 6)
            {
                label13.Text = "F";
            }
            else if (nun == 7)
            {
                label13.Text = "G";
            }
            else if (nun == 8)
            {
                label13.Text = "H";
            }
            else if (nun == 9)
            {
                label13.Text = "I";
            }
            else if (nun == 10)
            {
                label13.Text = "J";
            }
            else if (nun == 11)
            {
                label13.Text = "K";
            }
            else if (nun == 12)
            {
                label13.Text = "L";
            }
            else if (nun == 13)
            {
                label13.Text = "M";
            }
            else if (nun == 14)
            {
                label13.Text = "N";
            }
            else if (nun == 15)
            {
                label13.Text = "O";
            }
            else if (nun == 16)
            {
                label13.Text = "P";
            }
            else if (nun == 17)
            {
                label13.Text = "Q";

            }
            else if (nun == 18)
            {
                label13.Text = "R";
            }
            else if (nun == 19)
            {
                label13.Text = "S";
            }
            else if (nun == 20)
            {
                label13.Text = "T";
            }
            else if (nun == 21)
            {
                label13.Text = "U";
            }
            else if (nun == 22)
            {
                label13.Text = "V";
            }
            else if (nun == 23)
            {
                label13.Text = "W";

            }
            else if (nun == 24)
            {
                label13.Text = "X";
            }
            else if (nun == 25)
            {
                label13.Text = "Y";
            }
            else if (nun == 26)
            {
                label13.Text = "Z";
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int nun = rand.Next(1, 26);
            label11.Text = nun.ToString();
            if (nun == 1)
            {

                label11.Text = "A";
            }
            else if (nun == 2)
            {
                label11.Text = "B";
            }
            else if (nun == 3)
            {
                label11.Text = "C";
            }
            else if (nun == 4)
            {
                label11.Text = "D";
            }
            else if (nun == 5)
            {
                label11.Text = "E";
            }
            else if (nun == 6)
            {
                label11.Text = "F";
            }
            else if (nun == 7)
            {
                label11.Text = "G";
            }
            else if (nun == 8)
            {
                label11.Text = "H";
            }
            else if (nun == 9)
            {
                label11.Text = "I";
            }
            else if (nun == 10)
            {
                label11.Text = "J";
            }
            else if (nun == 11)
            {
                label11.Text = "K";
            }
            else if (nun == 12)
            {
                label11.Text = "L";
            }
            else if (nun == 13)
            {
                label11.Text = "M";
            }
            else if (nun == 14)
            {
                label11.Text = "N";
            }
            else if (nun == 15)
            {
                label19.Text = "O";
            }
            else if (nun == 16)
            {
                label11.Text = "P";
            }
            else if (nun == 17)
            {
                label11.Text = "Q";

            }
            else if (nun == 18)
            {
                label11.Text = "R";
            }
            else if (nun == 19)
            {
                label11.Text = "S";
            }
            else if (nun == 20)
            {
                label11.Text = "T";
            }
            else if (nun == 21)
            {
                label11.Text = "U";
            }
            else if (nun == 22)
            {
                label11.Text = "V";
            }
            else if (nun == 23)
            {
                label11.Text = "W";

            }
            else if (nun == 24)
            {
                label11.Text = "X";
            }
            else if (nun == 25)
            {
                label11.Text = "Y";
            }
            else if (nun == 26)
            {
                label11.Text = "Z";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int nun = rand.Next(1, 26);
            label12.Text = nun.ToString();
            if (nun == 1)
            {

                label12.Text = "A";
            }
            else if (nun == 2)
            {
                label12.Text = "B";
            }
            else if (nun == 3)
            {
                label12.Text = "C";
            }
            else if (nun == 4)
            {
                label12.Text = "D";
            }
            else if (nun == 5)
            {
                label12.Text = "E";
            }
            else if (nun == 6)
            {
                label12.Text = "F";
            }
            else if (nun == 7)
            {
                label12.Text = "G";
            }
            else if (nun == 8)
            {
                label12.Text = "H";
            }
            else if (nun == 9)
            {
                label12.Text = "I";
            }
            else if (nun == 10)
            {
                label12.Text = "J";
            }
            else if (nun == 11)
            {
                label12.Text = "K";
            }
            else if (nun == 12)
            {
                label12.Text = "L";
            }
            else if (nun == 13)
            {
                label12.Text = "M";
            }
            else if (nun == 14)
            {
                label12.Text = "N";
            }
            else if (nun == 15)
            {
                label12.Text = "O";
            }
            else if (nun == 16)
            {
                label12.Text = "P";
            }
            else if (nun == 17)
            {
                label12.Text = "Q";

            }
            else if (nun == 18)
            {
                label12.Text = "R";
            }
            else if (nun == 19)
            {
                label12.Text = "S";
            }
            else if (nun == 20)
            {
                label12.Text = "T";
            }
            else if (nun == 21)
            {
                label12.Text = "U";
            }
            else if (nun == 22)
            {
                label12.Text = "V";
            }
            else if (nun == 23)
            {
                label12.Text = "W";

            }
            else if (nun == 24)
            {
                label12.Text = "X";
            }
            else if (nun == 25)
            {
                label12.Text = "Y";
            }
            else if (nun == 26)
            {
                label12.Text = "Z";
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            button20.Visible = false;
            label1.Visible = true;
            label2.Visible = true;
            pictureBox1.Visible = false;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
            label11.Visible = true;
            label12.Visible = true;
            label13.Visible = true;
            label14.Visible = true;
            label15.Visible = true;
            label16.Visible = true;
            label17.Visible = true;
            label18.Visible = true;
            label19.Visible = true;
            label20.Visible = true;
            label21.Visible = true;
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            button7.Visible = true;
            button8.Visible = true;
            button9.Visible = true;

            button10.Visible = true;
            button11.Visible = true;
            button12.Visible = true;
            button13.Visible = true;
            button14.Visible = true;
            button15.Visible = true;
            button16.Visible = true;
            button17.Visible = true;

            button18.Visible = true;
            button19.Visible = true;
            button21.Visible = true;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            button21.Visible = false;
            pictureBox1.Visible = true;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            label15.Visible = false;
            label16.Visible = false;
            label17.Visible = false;
            label18.Visible = false;
            label19.Visible = false;
            label20.Visible = false;
            label21.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;

            button10.Visible = false;
            button11.Visible = false;
            button12.Visible = false;
            button13.Visible = false;
            button14.Visible = false;
            button15.Visible = false;
            button16.Visible = false;
            button17.Visible = false;

            button18.Visible = false;
            button19.Visible = false;
            button20.Visible = true;

        }
    }
}
