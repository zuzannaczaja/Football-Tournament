using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Tournament.Data
{
    class ConnectionData
    {
        SqlConnection sqlConnection;
        SqlDataReader reader;

        public ConnectionData()
        {
            string connetionString;
            connetionString = @"Data Source=DESKTOP-C1F6DDM;Initial Catalog=Football;Integrated Security=True";
            sqlConnection = new SqlConnection(connetionString);
            sqlConnection.Open();

            //String createTeams = "CREATE TABLE [teams] (id_team Int NOT NULL, name varchar(255) NOT NULL, description varchar(255), photo varchar(255), Primary Key (id_team))";
            //String createQ1 = "CREATE TABLE [q1] (id_q1 Int NOT NULL, id_team Int NOT NULL, points_scored Int, goals_scored Int, goals_conceded Int, Primary Key (id_q1), FOREIGN KEY (id_team) REFERENCES teams(id_team))";

            //SqlCommand createQ1SqlCommand = new SqlCommand(createQ1, sqlConnection);
            //createQ1SqlCommand.ExecuteNonQuery();
            sqlConnection.Close();

        }

        public SqlDataReader SendInquiry(String query)
        {
            SqlCommand sqlCommand = new SqlCommand(query);

            sqlCommand.Connection = sqlConnection;

            sqlConnection.Open();

            reader = sqlCommand.ExecuteReader();
            reader.Read();

            return reader;
        }

        public void setData(String query)
        {
            sqlConnection.Open();
            
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

            sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();
        }

        public void openConnection()
        {
            sqlConnection.Open();
        }

        public void closeConnection()
        {
            sqlConnection.Close();
        }

        public void closeReader()
        {
            reader.Close();
        }
    }
}
