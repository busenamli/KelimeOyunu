using MySql.Data.MySqlClient;
using System;
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
    }
}
