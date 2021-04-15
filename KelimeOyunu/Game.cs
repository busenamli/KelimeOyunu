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
        Random rnd = new Random();
        QuestionModel questionModel;
        QuestionModel nextQuestionModel;
        LetterModel letterModel;
        List<QuestionModel> questions;
        DBService dbService = new DBService();
        int soru_puan;
        int toplam_puan = 0;

        public Game()
        {
            InitializeComponent();
            
        }

        private void Game_Load(object sender, EventArgs e)
        {
            timer1.Start();

            q4();
            question = questionModel.Question;
            answer = questionModel.Answer;

            question_label.Text = question;
            getVisible(answer);
            soru_no++;
        }


        public LetterModel getLetter(string cevap)
        {
            char[] charArray = cevap.ToCharArray();
            r1 = rnd.Next(0, charArray.Length);
            char letter = charArray[r1];
            letterModel = new LetterModel(letter, r1);
            return letterModel;
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

            if (soru_puan != 0)
            {
                
                getLetter(answer);
                int index = letterModel.Index;
                char a = letterModel.Letter;

                switch (index)
                {
                    case 0:
                        if (checkTextBox(textBox1))
                        {
                            textBox1.Text = a.ToString();
                        }
                        break;
                    case 1:
                        if (checkTextBox(textBox2))
                        {
                            textBox2.Text = a.ToString();
                        }
                        break;
                    case 2:
                        if (checkTextBox(textBox3))
                        {
                            textBox3.Text = a.ToString();
                        }
                        break;
                    case 3:
                        if (checkTextBox(textBox4))
                        {
                            textBox4.Text = a.ToString();
                        }
                        break;
                    case 4:
                        if (checkTextBox(textBox5))
                        {
                            textBox5.Text = a.ToString();
                        }
                        break;
                    case 5:
                        if (checkTextBox(textBox6))
                        {
                            textBox6.Text = a.ToString();
                        }
                        break;
                    case 6:
                        if (checkTextBox(textBox7))
                        {
                            textBox7.Text = a.ToString();
                        }
                        break;
                    case 7:
                        if (checkTextBox(textBox8))
                        {
                            textBox8.Text = a.ToString();
                        }
                        break;
                    case 8:
                        if (checkTextBox(textBox9))
                        {
                            textBox9.Text = a.ToString();
                        }
                        break;
                    case 9:
                        if (checkTextBox(textBox10))
                        {
                            textBox10.Text = a.ToString();
                        }
                        break;
                    default:
                        break;
                }

                soru_puan = soru_puan - 100;
                question_score.Text = soru_puan.ToString();
            }
            else
            {
                getModel(soru_no);
                nextQuestion();
                question = questionModel.Question;
                answer = questionModel.Answer;
                question_label.Text = question;
                getVisible(answer);
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
                answer = questionModel.Answer;
                question_label.Text = question;
                getVisible(answer);
                soru_no++;

            }

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

        private void okay_button_Click(object sender, EventArgs e)
        {
            timer2.Stop();
            timer1.Start();

            checkAnswer(answer);
            
            getModel(soru_no);
            
            nextQuestion();

            question = questionModel.Question;
            answer = questionModel.Answer;
            question_label.Text = question;

            getVisible(answer);
            soru_no++;
            
        }

        public void finishGame()
        {
            timer1.Stop();
            int kalan_zaman = Convert.ToInt32(minute_label.Text)*60 + Convert.ToInt32(second_label.Text);
            DateTime tarih = DateTime.Now;
            dbService.insertGamer(userName, toplam_puan,kalan_zaman,tarih);
            MessageBox.Show("Ad: " + userName + "\nPuan: " + toplam_puan +"\nKalan süre: " + minute_label.Text + ":" + second_label.Text + "\nOynama tarihi: " + tarih, "Oyun Bitti",MessageBoxButtons.OK);
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();
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

        public void getModel(int soruNo)
        {
            soru_no_label.Text = soruNo.ToString() + "-";
            if (soruNo == 2)
            {
                q4();
                questionModel = nextQuestionModel;
            }
            else if (soruNo == 3 || soruNo == 4)
            {
                q5();
                if (soruNo == 4)
                {
                    questionModel = nextQuestionModel;
                }
            }

            else if (soruNo == 5 || soruNo == 6)
            {
                q6();
                if (soruNo == 6)
                {
                    questionModel = nextQuestionModel;
                }
            }

            else if (soruNo == 7 || soruNo == 8)
            {
                q7();
                if (soruNo == 8)
                {
                    questionModel = nextQuestionModel;
                }
            }

            else if (soruNo == 9 || soruNo == 10)
            {
                q8();
                if (soruNo == 10)
                {
                    questionModel = nextQuestionModel;
                }
            }

            else if (soruNo == 11 || soruNo == 12)
            {
                q9();
                if (soruNo == 12)
                {
                    questionModel = nextQuestionModel;
                }
            }

            else if (soruNo == 13 || soruNo == 14)
            {
                q10();
                if (soruNo == 14)
                {
                    questionModel = nextQuestionModel;
                }
            }
            else
            {
                finishGame();
            }

        }

        public QuestionModel getQuestion(int cevap_uzunluk, int r)
        {
            questions = dbService.getQuestion(cevap_uzunluk);

            QuestionModel model = questions[r];

            return model;
        }

        public int listCount(int cevap_uzunluk)
        {
            questions = dbService.getQuestion(cevap_uzunluk);
            return questions.Count;
        }


        public void q4()
        {
           
            r1 = rnd.Next(0, listCount(4));
            r2 = rnd.Next(0, listCount(4));

            if(r1 == r2)
            {
                while (r1 == r2)
                {
                    r2 = rnd.Next(0, listCount(4));
                }
            }

            questionModel = getQuestion(4, r1);
            nextQuestionModel = getQuestion(4, r2);

        }
        public void q5()
        {
  
            r1 = rnd.Next(0, listCount(5));
            r2 = rnd.Next(0, listCount(5));

            if (r1 == r2)
            {
                while (r1 == r2)
                {
                    r2 = rnd.Next(0, listCount(5));
                }
            }

            questionModel = getQuestion(5, r1);
            nextQuestionModel = getQuestion(5, r2);

        }
        public void q6()
        {

            r1 = rnd.Next(0, listCount(6));
            r2 = rnd.Next(0, listCount(6));

            if (r1 == r2)
            {
                while (r1 == r2)
                {
                    r2 = rnd.Next(0, listCount(6));
                }
            }

            questionModel = getQuestion(6, r1);
            nextQuestionModel = getQuestion(6, r2);
        }
        public void q7()
        {

            r1 = rnd.Next(0, listCount(7));
            r2 = rnd.Next(0, listCount(7));

            if (r1 == r2)
            {
                while (r1 == r2)
                {
                    r2 = rnd.Next(0, listCount(7));
                }
            }

            questionModel = getQuestion(7, r1);
            nextQuestionModel = getQuestion(7, r2);
        }

        public void q8()
        {

            r1 = rnd.Next(0, listCount(8));
            r2 = rnd.Next(0, listCount(8));

            if (r1 == r2)
            {
                while (r1 == r2)
                {
                    r2 = rnd.Next(0, listCount(8));
                }
            }

            questionModel = getQuestion(8, r1);
            nextQuestionModel = getQuestion(8, r2);
        }

        public void q9()
        {

            r1 = rnd.Next(0, listCount(9));
            r2 = rnd.Next(0, listCount(9));

            if (r1 == r2)
            {
                while (r1 == r2)
                {
                    r2 = rnd.Next(0, listCount(9));
                }
            }

            questionModel = getQuestion(9, r1);
            nextQuestionModel = getQuestion(9, r2);
        }

        public void q10()
        {

            r1 = rnd.Next(0, listCount(10));
            r2 = rnd.Next(0, listCount(10));

            if (r1 == r2)
            {
                while (r1 == r2)
                {
                    r2 = rnd.Next(0, listCount(10));
                }
            }

            questionModel = getQuestion(10, r1);
            nextQuestionModel = getQuestion(10, r2);
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

        public void getVisible(string a)
        {
            switch (a.Length)
            {
                case 4:
                    soru_puan = 400;
                    question_score.Text = soru_puan.ToString();
                    break;
                case 5:
                    textBox5.Visible = true;
                    soru_puan = 500;
                    question_score.Text = soru_puan.ToString();
                    break;
                case 6:
                    textBox5.Visible = true;
                    textBox6.Visible = true;
                    soru_puan = 600;
                    question_score.Text = soru_puan.ToString();
                    break;
                case 7:
                    textBox5.Visible = true;
                    textBox6.Visible = true;
                    textBox7.Visible = true;
                    soru_puan = 700;
                    question_score.Text = soru_puan.ToString();
                    break;
                case 8:
                    textBox5.Visible = true;
                    textBox6.Visible = true;
                    textBox7.Visible = true;
                    textBox8.Visible = true;
                    soru_puan = 800;
                    question_score.Text = soru_puan.ToString();
                    break;
                case 9:
                    textBox5.Visible = true;
                    textBox6.Visible = true;
                    textBox7.Visible = true;
                    textBox8.Visible = true;
                    textBox9.Visible = true;
                    soru_puan = 900;
                    question_score.Text = soru_puan.ToString();
                    break;
                case 10:
                    textBox5.Visible = true;
                    textBox6.Visible = true;
                    textBox7.Visible = true;
                    textBox8.Visible = true;
                    textBox9.Visible = true;
                    textBox10.Visible = true;
                    soru_puan = 1000;
                    question_score.Text = soru_puan.ToString();
                    break;
                default:
                    break;
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
