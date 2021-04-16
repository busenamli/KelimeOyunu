using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KelimeOyunu
{
    public partial class Form1 : Form
    {
        public static string user_name;
        DBService dBService = new DBService();
        List<GamerModel> gamerModel = new List<GamerModel>();

        public Form1()
        {
            InitializeComponent();
            
            this.IsMdiContainer = true;

        }

        private void start_button_Click(object sender, EventArgs e)
        {
            if (!name_text.Text.Equals(""))
            {
                user_name = name_text.Text.ToString();
                Game startGame = new Game();
                getForm(startGame);
                back_picture.Visible = true;
                panel1.Visible = false;

            }
            else
            {
                MessageBox.Show("Lütfen adınızı giriniz", "Geçersiz Giriş", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            name_text.Text = "";

        }

        private void add_word_button_Click(object sender, EventArgs e)
        {
            AddWord addWord = new AddWord();
            getForm(addWord);
            back_picture.Visible = true;
            panel1.Visible = false;
        }

        private void getForm(Form form)
        {
            form.MdiParent = this;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gamerModel = dBService.fillList();

            listView1.Columns.Add("Ad",90);
            listView1.Columns.Add("Puan",90);
            listView1.Columns.Add("Kalan süre",90);

            listView1.View = View.Details;
            listView1.GridLines = false;

            ListViewItem item = new ListViewItem();

            for (int i = 0; i < 10; i++)
            {
                string sure = (gamerModel[i].Time/60).ToString() + ":" + (gamerModel[i].Time%60).ToString();
                item = listView1.Items.Add(gamerModel[i].Name);
                item.SubItems.Add(gamerModel[i].Score.ToString());
                item.SubItems.Add(sure);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            back_picture.Visible = false;
            panel1.Visible = true;
        }
    }
}
