using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KelimeOyunu
{
    class DBService
    {
        DBConnection dbConnection = new DBConnection();

        public bool wordExists(string cevap)
        {
            string query = "SELECT * FROM `sorular` WHERE `cevap`=@cevap";
            MySqlCommand command = new MySqlCommand(query, dbConnection.getConnection);

            command.Parameters.Add("@cevap", MySqlDbType.VarChar).Value = cevap;

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);

            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            if(dataTable.Rows.Count > 0)
            {
                return false;
            }
            else
            {
                return true;
            }


        }
        public bool insertQuestion(string soru, string cevap, int cevap_uzunluk)
        {
            string query = "INSERT INTO `sorular`(`soru`, `cevap`, `cevap_uzunluk`) VALUES (@soru,@cevap,@cevap_uzunluk)";
            MySqlCommand command = new MySqlCommand(query, dbConnection.getConnection);

            command.Parameters.Add("@soru", MySqlDbType.VarChar).Value = soru;
            command.Parameters.Add("@cevap", MySqlDbType.VarChar).Value = cevap;
            command.Parameters.Add("@cevap_uzunluk", MySqlDbType.Int16).Value = cevap_uzunluk;

            dbConnection.openConnection();

            if(command.ExecuteNonQuery() == 1)
            {
                dbConnection.closeConnection();
                return true;
            }
            else
            {
                dbConnection.closeConnection();
                return false;
            }
        }

        public List<QuestionModel> getQuestion(int cevap_uzunluk)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();
            List<QuestionModel> questions = new List<QuestionModel>();


            //string query = "SELECT `soru`,`cevap` FROM `sorular` WHERE `cevap_uzunluk`=4";
            string query = "SELECT `soru`,`cevap` FROM `sorular` WHERE `cevap_uzunluk`=@cvp";
            MySqlCommand command = new MySqlCommand(query, dbConnection.getConnection);

            command.Parameters.AddWithValue("@cvp", cevap_uzunluk);
            dbConnection.openConnection();

            MySqlDataReader oku = command.ExecuteReader();

            
            while (oku.Read())
            {
                questions.Add(new QuestionModel(oku["soru"].ToString(), oku["cevap"].ToString()));
            }
            dbConnection.closeConnection();
            return questions;

        }

        public bool insertGamer(string ad, int puan, int kalan_sure, DateTime tarih)
        {
            string query = "INSERT INTO `oyuncular`(`oyuncu_ad`, `oyuncu_puan`, `oyuncu_sure`, `oynama_zamanı`) VALUES(@ad, @puan, @sure, @zaman)";
            MySqlCommand command = new MySqlCommand(query, dbConnection.getConnection);

            command.Parameters.Add("@ad", MySqlDbType.VarChar).Value = ad;
            command.Parameters.Add("@puan", MySqlDbType.Int32).Value = puan;
            command.Parameters.Add("@sure", MySqlDbType.Int32).Value = kalan_sure;
            command.Parameters.Add("@zaman", MySqlDbType.DateTime).Value = tarih;

            dbConnection.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                dbConnection.closeConnection();
                return true;
            }
            else
            {
                dbConnection.closeConnection();
                return false;
            }
        }

        public List<GamerModel> fillList()
        {
            List<GamerModel> gamerModels = new List<GamerModel>();
            string query = "SELECT `oyuncu_ad`,`oyuncu_puan`,`oyuncu_sure` FROM `oyuncular` ORDER BY `oyuncu_puan` DESC";
            MySqlCommand command = new MySqlCommand(query, dbConnection.getConnection);

            //MySqlDataAdapter adapter = new MySqlDataAdapter(command);

            dbConnection.openConnection();

            MySqlDataReader oku = command.ExecuteReader();


            while (oku.Read())
            {
                gamerModels.Add(new GamerModel(oku["oyuncu_ad"].ToString(), Convert.ToInt32(oku["oyuncu_puan"]), Convert.ToInt32(oku["oyuncu_sure"].ToString())));
            }
            dbConnection.closeConnection();

            /*DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);*/

            return gamerModels;
        }
    }
}
