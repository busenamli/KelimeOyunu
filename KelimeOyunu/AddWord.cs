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
    public partial class AddWord : Form
    {
        public AddWord()
        {
            InitializeComponent();
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            runQuery();
        }

        private void runQuery()
        {

            if (soru_text.Text == "" || cevap_text.Text == "" || cevap_uzunluk_text.Text == "")
            {
                MessageBox.Show("Boş alan bırakmayınız", "Geçersiz Giriş", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }
            else
            {
                string soru = soru_text.Text;
                string cevap = cevap_text.Text;
                int cevap_uzunluk = Convert.ToInt16(cevap_uzunluk_text.Text);

                DBService dBService = new DBService();

                if (dBService.wordExists(cevap))
                {
                    if (dBService.insertQuestion(soru, cevap, cevap_uzunluk))
                    {
                        MessageBox.Show("Ekleme başarılı", "Soru Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Ekleme başarısız", "Soru Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Bu kelime zaten var.", "Soru Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                clearText();
            }

        }
        public void clearText()
        {
            soru_text.Clear();
            cevap_text.Clear();
            cevap_uzunluk_text.Clear();
        }
    }
}
