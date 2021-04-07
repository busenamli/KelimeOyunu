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
        public Form1()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            SetBackGroundColorOfMDIForm();

        }

        private void SetBackGroundColorOfMDIForm()
        {
            foreach (Control ctl in this.Controls)
            {
                if ((ctl) is MdiClient)

                // If the control is the correct type,
                // change the color.
                {
                    ctl.BackColor = System.Drawing.Color.CadetBlue;
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void start_button_Click(object sender, EventArgs e)
        {
            Game startGame = new Game();
            getForm(startGame);
            panel1.Visible = false;
            //startGame.Show(this);
            //this.Hide();
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void add_word_button_Click(object sender, EventArgs e)
        {
            AddWord addWord = new AddWord();
            getForm(addWord);
            /*addWord.MdiParent = this;
            addWord.Show();*/
            panel1.Visible = false;
        }

        private void getForm(Form form)
        {
            //panel2.Controls.Clear();
            form.MdiParent = this;
            form.FormBorderStyle = FormBorderStyle.None;
            //panel2.Controls.Add(form);
            form.Show();
        }
    }
}
