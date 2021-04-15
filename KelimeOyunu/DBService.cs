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
    }
}
