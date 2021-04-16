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

            if (soru_text.Text == "" || cevap_text.Text == "" )
            {
                MessageBox.Show("Boş alan bırakmayınız", "Geçersiz Giriş", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                string soru = soru_text.Text;
                string cevap = cevap_text.Text.Trim().ToLower();
                int cevap_uzunluk = Convert.ToInt32(cevap_uzunluk_upDown.Value);

                if (cevap.Length != cevap_uzunluk)
                {
                    MessageBox.Show("Kelimedeki harf sayısı ve girdiğiniz kategori uyuşmuyor", "Soru Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else
                {
                    DBService dBService = new DBService();


                    //Kelime veritabanında yoksa
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

        }
        public void clearText()
        {
            soru_text.Clear();
            cevap_text.Clear();
            cevap_uzunluk_upDown.Value = 4;
        }

        private void soru_text_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
