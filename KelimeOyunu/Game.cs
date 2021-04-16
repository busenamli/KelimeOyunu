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
        int twenty_seconds = 20;
        int soru_no = 1;
        int r1, r2;
        string userName = Form1.user_name.ToString();
        string answer;
        string question;
        char[] charArray;
        Random rnd = new Random();
        QuestionModel questionModel;
        List<QuestionModel> questions;
        List<QuestionModel> questions4;
        List<QuestionModel> questions5;
        List<QuestionModel> questions6;
        List<QuestionModel> questions7;
        List<QuestionModel> questions8;
        List<QuestionModel> questions9;
        List<QuestionModel> questions10;
        DBService dbService = new DBService();
        int soru_puan;
        int toplam_puan = 0;

        public Game()
        {
            InitializeComponent();

            questions4 = getQuestions(4);
            questions5 = getQuestions(5);
            questions6 = getQuestions(6);
            questions7 = getQuestions(7);
            questions8 = getQuestions(8);
            questions9 = getQuestions(9);
            questions10 = getQuestions(10);

        }

        public List<QuestionModel> getQuestions(int cevap_uzunluk)
        {
            questions = dbService.getQuestion(cevap_uzunluk);

            return questions;
        }

        private void Game_Load(object sender, EventArgs e)
        {
            timer1.Start();
           
            r2 = getRandom(questions4.Count());
            questionModel = questions4[r2];
            questions4.Remove(questionModel);

            question = questionModel.Question;
            answer = questionModel.Answer.ToLower();

            question_label.Text = question;
            getVisible(soru_no);
            soru_no++;
        }


        public void getLetter(string cevap)
        {
            char letter;
            charArray = cevap.ToCharArray();
            r1 = rnd.Next(0, charArray.Length);

            switch (r1)
            {
                case 0:
                    if (!checkTextBox(textBox1))
                    {
                        getLetter(cevap);
                    }
                    else
                    {
                        letter = charArray[r1];
                        textBox1.Text = letter.ToString();
                    }
                    break;
                case 1:
                    if (!checkTextBox(textBox2))
                    {
                        getLetter(cevap);
                    }
                    else
                    {
                        letter = charArray[r1];
                        textBox2.Text = letter.ToString();
                    }
                    break;
                case 2:
                    if (!checkTextBox(textBox3))
                    {
                        getLetter(cevap);
                    }
                    else
                    {
                        letter = charArray[r1];
                        textBox3.Text = letter.ToString();
                    }
                    break;
                case 3:
                    if (!checkTextBox(textBox4))
                    {
                        getLetter(cevap);
                    }
                    else
                    {
                        letter = charArray[r1];
                        textBox4.Text = letter.ToString();
                    }
                    break;
                case 4:
                    if (!checkTextBox(textBox5))
                    {
                        getLetter(cevap);
                    }
                    else
                    {
                        letter = charArray[r1];
                        textBox5.Text = letter.ToString();
                    }
                    break;
                case 5:
                    if (!checkTextBox(textBox6))
                    {
                        getLetter(cevap);
                    }
                    else
                    {
                        letter = charArray[r1];
                        textBox6.Text = letter.ToString();
                    }
                    break;
                case 6:
                    if (!checkTextBox(textBox7))
                    {
                        getLetter(cevap);
                    }
                    else
                    {
                        letter = charArray[r1];
                        textBox7.Text = letter.ToString();
                    }
                    break;
                case 7:
                    if (!checkTextBox(textBox8))
                    {
                        getLetter(cevap);
                    }
                    else
                    {
                        letter = charArray[r1];
                        textBox8.Text = letter.ToString();
                    }
                    break;
                case 8:
                    if (!checkTextBox(textBox9))
                    {
                        getLetter(cevap);
                    }
                    else
                    {
                        letter = charArray[r1];
                        textBox9.Text = letter.ToString();
                    }
                    break;
                case 9:
                    if (!checkTextBox(textBox10))
                    {
                        getLetter(cevap);
                    }
                    else
                    {
                        letter = charArray[r1];
                        textBox10.Text = letter.ToString();
                    }
                    break;
                default:
                    break;
            }
        }

        public bool checkTextBox(TextBox textBox)
        {
            if (textBox.Text.Equals(""))
            {
                return true;
            }
            return false;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (soru_puan != 100)
            {
                
                getLetter(answer);

                soru_puan = soru_puan - 100;
                question_score.Text = soru_puan.ToString();
            }
            else
            {
                getModel(soru_no);
                nextQuestion();
                question = questionModel.Question;
                answer = questionModel.Answer.ToLower();
                question_label.Text = question;
                getVisible(soru_no);
                soru_no++;
            }
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
                finishGame();
                
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Start();

            get_letter_button.Enabled = false;
            answer_button.Enabled = false;
            okay_button.Visible = true;

            getEnable(questionModel.Answer, "enable");
            twenty_seconds = 20;
            ten_seconds_label.Visible = true;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            twenty_seconds = twenty_seconds - 1;
            ten_seconds_label.Text = twenty_seconds.ToString();

            if(twenty_seconds == 0)
            {
                timer2.Stop();
                MessageBox.Show("Süre bitti");

                getModel(soru_no);
                nextQuestion();
                timer1.Start();
                question = questionModel.Question;
                answer = questionModel.Answer.ToLower();
                question_label.Text = question;
                getVisible(soru_no);
                soru_no++;

            }

        }

        private void okay_button_Click(object sender, EventArgs e)
        {
            timer2.Stop();
            timer1.Start();

            checkAnswer(answer);
            
            getModel(soru_no);
            
            nextQuestion();

            question = questionModel.Question;
            answer = questionModel.Answer.ToLower();
            question_label.Text = question;

            getVisible(soru_no);
            soru_no++;
            
        }

        public void nextQuestion()
        {

            clearTextBox();
            okay_button.Visible = false;
            answer_button.Visible = true;
            answer_button.Enabled = true;
            get_letter_button.Visible = true;
            get_letter_button.Enabled = true;
            ten_seconds_label.Visible = false;
            getEnable(questionModel.Answer, "notenable");
        }

        public void finishGame()
        {
            timer1.Stop();
            int kalan_zaman = Convert.ToInt32(minute_label.Text)*60 + Convert.ToInt32(second_label.Text);
            DateTime tarih = DateTime.Now;
            dbService.insertGamer(userName, toplam_puan,kalan_zaman,tarih);
            MessageBox.Show("Ad: " + userName + "\nPuan: " + toplam_puan +"\nKalan süre: " + minute_label.Text + ":" + second_label.Text + "\nOynama tarihi: " + tarih, "Oyun Bitti",MessageBoxButtons.OK);

            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
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

        public int getRandom(int c)
        {
            r1 = rnd.Next(0, c);

            return r1;
        }

        public void getModel(int soruNo)
        {
            soru_no_label.Text = soruNo.ToString() + "-";

            if (soruNo == 2)
            {
                r2 = getRandom(questions4.Count());
                questionModel =  questions4[r2];
                
                questions4.Remove(questionModel);

            }
            else if (soruNo == 3 || soruNo == 4)
            {

                r2 = getRandom(questions5.Count());
                questionModel = questions5[r2];

                questions5.Remove(questionModel);
                
            }

            else if (soruNo == 5 || soruNo == 6)
            {

                r2 = getRandom(questions6.Count());
                questionModel = questions6[r2];

                questions6.Remove(questionModel);

            }

            else if (soruNo == 7 || soruNo == 8)
            {

                r2 = getRandom(questions7.Count());
                questionModel = questions7[r2];

                questions7.Remove(questionModel);

            }

            else if (soruNo == 9 || soruNo == 10)
            {

                r2 = getRandom(questions8.Count());
                questionModel = questions8[r2];

                questions8.Remove(questionModel);

            }

            else if (soruNo == 11 || soruNo == 12)
            {

                r2 = getRandom(questions9.Count());
                questionModel = questions9[r2];

                questions9.Remove(questionModel);

            }

            else if (soruNo == 13 || soruNo == 14)
            {

                r2 = getRandom(questions10.Count());
                questionModel = questions10[r2];

                questions10.Remove(questionModel);

            }
            else
            {
                finishGame();
            }

        }

        public void clearTextBox()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();

        }

        public void getVisible(int soruNo)
        {
            if(soruNo == 1 || soruNo == 2)
            {
                soru_puan = 400;
                question_score.Text = soru_puan.ToString();
            }

            else if (soruNo == 3 || soruNo == 4)
            {
                textBox5.Visible = true;
                soru_puan = 500;
                question_score.Text = soru_puan.ToString();
            }

            else if (soruNo == 5 || soruNo == 6)
            {
                textBox5.Visible = true;
                textBox6.Visible = true;
                soru_puan = 600;
                question_score.Text = soru_puan.ToString();
            }

            else if (soruNo == 7 || soruNo == 8)
            {
                textBox5.Visible = true;
                textBox6.Visible = true;
                textBox7.Visible = true;
                soru_puan = 700;
                question_score.Text = soru_puan.ToString();
            }

            else if (soruNo == 9 || soruNo == 10)
            {
                textBox5.Visible = true;
                textBox6.Visible = true;
                textBox7.Visible = true;
                textBox8.Visible = true;
                soru_puan = 800;
                question_score.Text = soru_puan.ToString();
            }

            else if (soruNo == 11 || soruNo == 12)
            {
                textBox5.Visible = true;
                textBox6.Visible = true;
                textBox7.Visible = true;
                textBox8.Visible = true;
                textBox9.Visible = true;
                soru_puan = 900;
                question_score.Text = soru_puan.ToString();
            }

            else if (soruNo == 13 || soruNo == 14)
            {
                textBox5.Visible = true;
                textBox6.Visible = true;
                textBox7.Visible = true;
                textBox8.Visible = true;
                textBox9.Visible = true;
                textBox10.Visible = true;
                soru_puan = 1000;
                question_score.Text = soru_puan.ToString();
            }

            else
            {
                soru_puan = 0;
                question_score.Text = soru_puan.ToString();
            }

        }

        public void getEnable(string a, string e)
        {
            if (e == "enable")
            {
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
                    case 7:
                        textBox1.Enabled = true;
                        textBox2.Enabled = true;
                        textBox3.Enabled = true;
                        textBox4.Enabled = true;
                        textBox5.Enabled = true;
                        textBox6.Enabled = true;
                        textBox7.Enabled = true;
                        break;
                    case 8:
                        textBox1.Enabled = true;
                        textBox2.Enabled = true;
                        textBox3.Enabled = true;
                        textBox4.Enabled = true;
                        textBox5.Enabled = true;
                        textBox6.Enabled = true;
                        textBox7.Enabled = true;
                        textBox8.Enabled = true;
                        break;
                    case 9:
                        textBox1.Enabled = true;
                        textBox2.Enabled = true;
                        textBox3.Enabled = true;
                        textBox4.Enabled = true;
                        textBox5.Enabled = true;
                        textBox6.Enabled = true;
                        textBox7.Enabled = true;
                        textBox8.Enabled = true;
                        textBox9.Enabled = true;
                        break;
                    case 10:
                        textBox1.Enabled = true;
                        textBox2.Enabled = true;
                        textBox3.Enabled = true;
                        textBox4.Enabled = true;
                        textBox5.Enabled = true;
                        textBox6.Enabled = true;
                        textBox7.Enabled = true;
                        textBox8.Enabled = true;
                        textBox9.Enabled = true;
                        textBox10.Enabled = true;
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
                    case 7:
                        textBox1.Enabled = false;
                        textBox2.Enabled = false;
                        textBox3.Enabled = false;
                        textBox4.Enabled = false;
                        textBox5.Enabled = false;
                        textBox6.Enabled = false;
                        textBox7.Enabled = false;
                        break;
                    case 8:
                        textBox1.Enabled = false;
                        textBox2.Enabled = false;
                        textBox3.Enabled = false;
                        textBox4.Enabled = false;
                        textBox5.Enabled = false;
                        textBox6.Enabled = false;
                        textBox7.Enabled = false;
                        textBox8.Enabled = false;
                        break;
                    case 9:
                        textBox1.Enabled = false;
                        textBox2.Enabled = false;
                        textBox3.Enabled = false;
                        textBox4.Enabled = false;
                        textBox5.Enabled = false;
                        textBox6.Enabled = false;
                        textBox7.Enabled = false;
                        textBox8.Enabled = false;
                        textBox9.Enabled = false;
                        break;
                    case 10:
                        textBox1.Enabled = false;
                        textBox2.Enabled = false;
                        textBox3.Enabled = false;
                        textBox4.Enabled = false;
                        textBox5.Enabled = false;
                        textBox6.Enabled = false;
                        textBox7.Enabled = false;
                        textBox8.Enabled = false;
                        textBox9.Enabled = false;
                        textBox10.Enabled = false;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
