using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;

namespace KelimeOyunu
{
    public partial class Game : Form
    {
        int second = 60;
        int minute = 4;
        int ten_seconds = 10;
        string answer = "evett";
        string question = "soru1";
        string question2 = "soru2";
        int soru_puan;
        int toplam_puan = 0;

        public Game()
        {
            InitializeComponent();
            timer1.Start();
            question_label.Text = question;

            getVisible(answer);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void question_label_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            second = second - 1;
            minute_label.Text = (minute - 1).ToString();

            if(second >= 0 && second < 10)
            {
                second_label.Text = "0" + second.ToString();
            }
            else {
                second_label.Text = second.ToString();
            }
           
            if (second == 0)
            {
                minute = minute - 1;
                minute_label.Text = minute.ToString();
                second = 60;
            }

            if(minute_label.Text == "-1")
            {
                timer1.Stop();
                minute_label.Text = "0";
                second_label.Text = "00";
                MessageBox.Show("Oyun bitti");
            }

        }

        private void time_label_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Start();

            get_letter_button.Enabled = false;
            answer_button.Enabled = false;
            okay_button.Visible = true;

            getEnable(answer,"enable");

            


            ten_seconds_label.Visible = true;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            ten_seconds = ten_seconds - 1;
            ten_seconds_label.Text = ten_seconds.ToString();

            if(ten_seconds == 0)
            {
                timer2.Stop();
                MessageBox.Show("Süre bitti");
                //SIRADAKİ SORU
                question_label.Text = question;
            }

        }

        private void okay_button_Click(object sender, EventArgs e)
        {
            timer2.Stop();
            timer1.Start();

            //char[] charArray = answer1.ToCharArray();

            checkAnswer(answer);
            okay_button.Visible = false;
            ten_seconds = 10;
            getVisible(answer);

        }

        public void getVisible(string a)
        {
            switch (a.Length)
            {
                case 4:
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = true;
                    soru_puan = 400;
                    question_score.Text = soru_puan.ToString();
                    break;
                case 5:
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = true;
                    textBox5.Visible = true;
                    soru_puan = 500;
                    question_score.Text = soru_puan.ToString();
                    break;
                case 6:
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = true;
                    textBox5.Visible = true;
                    textBox6.Visible = true;
                    soru_puan = 600;
                    question_score.Text = soru_puan.ToString();
                    break;
                default:
                    break;
            }
        }

        public void getEnable(string a,string e)
        {
            if (e == "enable") {
                switch (a.Length)
                {
                    case 4:
                        textBox1.Enabled = true;
                        textBox2.Enabled = true;
                        textBox3.Enabled = true;
                        textBox4.Enabled = true;
                        break;
                    case 5:
                        textBox1.Enabled = true;
                        textBox2.Enabled = true;
                        textBox3.Enabled = true;
                        textBox4.Enabled = true;
                        textBox5.Enabled = true;
                        break;
                    case 6:
                        textBox1.Enabled = true;
                        textBox2.Enabled = true;
                        textBox3.Enabled = true;
                        textBox4.Enabled = true;
                        textBox5.Enabled = true;
                        textBox6.Enabled = true;
                        break;
                    default:
                        break;
                }
            }
            else
            {
                switch (a.Length)
                {
                    case 4:
                        textBox1.Enabled = false;
                        textBox2.Enabled = false;
                        textBox3.Enabled = false;
                        textBox4.Enabled = false;
                        break;
                    case 5:
                        textBox1.Enabled = false;
                        textBox2.Enabled = false;
                        textBox3.Enabled = false;
                        textBox4.Enabled = false;
                        textBox5.Enabled = false;
                        break;
                    case 6:
                        textBox1.Enabled = false;
                        textBox2.Enabled = false;
                        textBox3.Enabled = false;
                        textBox4.Enabled = false;
                        textBox5.Enabled = false;
                        textBox6.Enabled = false;
                        break;
                    default:
                        break;
                }
            }
        }

        public void checkAnswer(string a)
        {
            switch (a.Length)
            {
                case 4:
                    if (textBox1.Text.ToLower().Equals(a[0].ToString().ToLower()) &&
                        textBox2.Text.ToLower().Equals(a[1].ToString().ToLower()) &&
                        textBox3.Text.ToLower().Equals(a[2].ToString().ToLower()) &&
                        textBox4.Text.ToLower().Equals(a[3].ToString().ToLower()))
                    {
                        toplam_puan = toplam_puan + soru_puan;
                    }
                    break;

                case 5:
                    if (textBox1.Text.ToLower().Equals(a[0].ToString().ToLower()) &&
                        textBox2.Text.ToLower().Equals(a[1].ToString().ToLower()) &&
                        textBox3.Text.ToLower().Equals(a[2].ToString().ToLower()) &&
                        textBox4.Text.ToLower().Equals(a[3].ToString().ToLower()) &&
                        textBox5.Text.ToLower().Equals(a[4].ToString().ToLower()))
                    {
                        toplam_puan = toplam_puan + soru_puan;
                    }
                    break;

                case 6:
                    if (textBox1.Text.ToLower().Equals(a[0].ToString().ToLower()) &&
                        textBox2.Text.ToLower().Equals(a[1].ToString().ToLower()) &&
                        textBox3.Text.ToLower().Equals(a[2].ToString().ToLower()) &&
                        textBox4.Text.ToLower().Equals(a[3].ToString().ToLower()) &&
                        textBox5.Text.ToLower().Equals(a[4].ToString().ToLower()) &&
                        textBox6.Text.ToLower().Equals(a[5].ToString().ToLower()))
                    {
                        toplam_puan = toplam_puan + soru_puan;
                    }
                    break;

                case 7:
                    if (textBox1.Text.ToLower().Equals(a[0].ToString().ToLower()) &&
                        textBox2.Text.ToLower().Equals(a[1].ToString().ToLower()) &&
                        textBox3.Text.ToLower().Equals(a[2].ToString().ToLower()) &&
                        textBox4.Text.ToLower().Equals(a[3].ToString().ToLower()) &&
                        textBox5.Text.ToLower().Equals(a[4].ToString().ToLower()) &&
                        textBox6.Text.ToLower().Equals(a[5].ToString().ToLower()) &&
                        textBox7.Text.ToLower().Equals(a[6].ToString().ToLower()))
                    {
                        toplam_puan = toplam_puan + soru_puan;
                    }
                    break;

                case 8:
                    if (textBox1.Text.ToLower().Equals(a[0].ToString().ToLower()) &&
                        textBox2.Text.ToLower().Equals(a[1].ToString().ToLower()) &&
                        textBox3.Text.ToLower().Equals(a[2].ToString().ToLower()) &&
                        textBox4.Text.ToLower().Equals(a[3].ToString().ToLower()) &&
                        textBox5.Text.ToLower().Equals(a[4].ToString().ToLower()) &&
                        textBox6.Text.ToLower().Equals(a[5].ToString().ToLower()) &&
                        textBox7.Text.ToLower().Equals(a[6].ToString().ToLower()) &&
                        textBox8.Text.ToLower().Equals(a[7].ToString().ToLower()))
                    {
                        toplam_puan = toplam_puan + soru_puan;
                    }
                    break;

                case 9:
                    if (textBox1.Text.ToLower().Equals(a[0].ToString().ToLower()) &&
                        textBox2.Text.ToLower().Equals(a[1].ToString().ToLower()) &&
                        textBox3.Text.ToLower().Equals(a[2].ToString().ToLower()) &&
                        textBox4.Text.ToLower().Equals(a[3].ToString().ToLower()) &&
                        textBox5.Text.ToLower().Equals(a[4].ToString().ToLower()) &&
                        textBox6.Text.ToLower().Equals(a[5].ToString().ToLower()) &&
                        textBox7.Text.ToLower().Equals(a[6].ToString().ToLower()) &&
                        textBox8.Text.ToLower().Equals(a[7].ToString().ToLower()) &&
                        textBox9.Text.ToLower().Equals(a[8].ToString().ToLower()))
                    {
                        toplam_puan = toplam_puan + soru_puan;
                    }
                    break;

                case 10:
                    if (textBox1.Text.ToLower().Equals(a[0].ToString().ToLower()) &&
                        textBox2.Text.ToLower().Equals(a[1].ToString().ToLower()) &&
                        textBox3.Text.ToLower().Equals(a[2].ToString().ToLower()) &&
                        textBox4.Text.ToLower().Equals(a[3].ToString().ToLower()) &&
                        textBox5.Text.ToLower().Equals(a[4].ToString().ToLower()) &&
                        textBox6.Text.ToLower().Equals(a[5].ToString().ToLower()) &&
                        textBox7.Text.ToLower().Equals(a[6].ToString().ToLower()) &&
                        textBox8.Text.ToLower().Equals(a[7].ToString().ToLower()) &&
                        textBox9.Text.ToLower().Equals(a[8].ToString().ToLower()) &&
                        textBox10.Text.ToLower().Equals(a[9].ToString().ToLower()))
                    {
                        toplam_puan = toplam_puan + soru_puan;
                    }
                    break;


                default:
                    break;
            }

            get_letter_button.Enabled = true;
            answer_button.Enabled = true;
            ten_seconds_label.Visible = false;
            question_label.Text = answer;
            total_score.Text = toplam_puan.ToString();
            

        }

        //textBox1.Text = textBox1.Text.ToUpper();
        //textBox1.SelectionStart = textBox1.Text.Length;
    }
}
