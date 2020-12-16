using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Turniej.Data;

namespace Turniej
{
    public partial class InsertResultsWindow : Form
    {
        public InsertResultsWindow()
        {
            InitializeComponent();

            this.Text = "Football Torunament";

            updateList();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void saveResultButton_Click(object sender, EventArgs e)
        {
            string selectedTeam1 = teamNameList1.SelectedItem.ToString();
            string selectedTeam2 = teamNameList2.SelectedItem.ToString();

            ConnectionData connectionData = new ConnectionData();

            Console.WriteLine(selectedTeam1);

            String query1 = "SELECT * FROM teams WHERE name = '" + selectedTeam1 + "'";
            String query2 = "SELECT * FROM teams WHERE name = '" + selectedTeam2 + "'";

            SqlDataReader sqlDataReader1 = connectionData.SendInquiry(query1);
            int idTeam1 = sqlDataReader1.GetInt32(0);
            connectionData.closeConnection();

            SqlDataReader sqlDataReader2 = connectionData.SendInquiry(query2);
            int idTeam2 = sqlDataReader2.GetInt32(0);
            connectionData.closeConnection();
          
            int numberTable1 = 0;
            int numberTable2 = 0;

            for (int i = 1; i < 9; i++)
            {
                String query3 = "SELECT * FROM q" + i + " WHERE id_team = " + idTeam1;
                String query4 = "SELECT * FROM q" + i + " WHERE id_team = " + idTeam2;

                SqlDataReader sqlDataReader3 = connectionData.SendInquiry(query3);
                int idInTable1 = sqlDataReader3.GetInt32(0);
                connectionData.closeConnection();

                SqlDataReader sqlDataReader4 = connectionData.SendInquiry(query4);
                int idInTable2 = sqlDataReader4.GetInt32(0);
                connectionData.closeConnection();

                if (numberTable1 != 0)
                {
                    if (idInTable1 != null)
                    {
                        numberTable1 = i;
                    }
                }

                if (numberTable2 != 0)
                {
                    if (idInTable2 != null)
                    {
                        numberTable1 = i;
                    }
                }

                if (numberTable1 != 0 && numberTable2 != 0)
                {
                    break;
                }
            }

            Console.WriteLine(numberTable1);
            Console.WriteLine(numberTable2);
        }

        private void updateList()
        {
            ConnectionData connectionData = new ConnectionData();

            String query = "SELECT * FROM teams";

            SqlDataReader sqlDataReader = connectionData.SendInquiry(query);

            if (sqlDataReader.HasRows)
            {
                teamNameList1.BeginUpdate();
                teamNameList2.BeginUpdate();
               
                do
                {
                    teamNameList1.Items.Add(sqlDataReader.GetString(1));
                    teamNameList2.Items.Add(sqlDataReader.GetString(1));

                } while (sqlDataReader.Read());

                teamNameList1.EndUpdate();
                teamNameList2.EndUpdate();
            }
        }
    }
}
