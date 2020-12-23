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
            String selectedTeam1 = teamNameList1.SelectedItem.ToString();
            String selectedTeam2 = teamNameList2.SelectedItem.ToString();

            ConnectionData connectionData = new ConnectionData();

            String query1 = "SELECT * FROM teams WHERE name = '" + selectedTeam1 + "'";
            String query2 = "SELECT * FROM teams WHERE name = '" + selectedTeam2 + "'";

            SqlDataReader sqlDataReader1 = connectionData.SendInquiry(query1);
            int idTeam1 = sqlDataReader1.GetInt32(0);
            connectionData.closeConnection();

            sqlDataReader1 = connectionData.SendInquiry(query2);
            int idTeam2 = sqlDataReader1.GetInt32(0);
            connectionData.closeConnection();
          
            int numberTable1 = 0;
            int numberTable2 = 0;

            for (int i = 1; i < 9; i++)
            {
                String query3 = "SELECT * FROM q" + i + " WHERE id_team = " + idTeam1;
                String query4 = "SELECT * FROM q" + i + " WHERE id_team = " + idTeam2;

                sqlDataReader1 = connectionData.SendInquiry(query3);
                int idInTable1 = 0;
                int idInTable2 = 0;

                if (sqlDataReader1.HasRows)
                {
                    idInTable1 = sqlDataReader1.GetInt32(0);

                    if (idInTable1 != 0)
                    {
                        numberTable1 = i;
                    }
                }
                connectionData.closeConnection();

                sqlDataReader1 = connectionData.SendInquiry(query4);

                if (sqlDataReader1.HasRows)
                { 
                    idInTable2 = sqlDataReader1.GetInt32(0);

                    if (idInTable2 != 0)
                    {
                        numberTable2 = i;
                    }
                }
                connectionData.closeConnection();

                if (numberTable1 != 0 && numberTable2 != 0)
                {             
                    break;
                }
            }

            Console.WriteLine("numberTable1: " + numberTable1);
            Console.WriteLine("numberTable2: " + numberTable2);

            // Adding results

            if (numberOfGoalsTextBox1 != null && numberOfGoalsTextBox2 != null)
            {
                // 3 points for win, 1 point for draw and 0 for lost
                int totalPointsTeam1 = 0;
                int totalPointsTeam2 = 0;

                int totalWinPointsTeam1 = 0;
                int totalWinPointsTeam2 = 0;

                int totalLostPointsTeam1 = 0;
                int totalLostPointsTeam2 = 0;

                int totalDrawPointsTeam1 = 0;
                int totalDrawPointsTeam2 = 0;

                int numberOfGoalsTeam1 = Int32.Parse(numberOfGoalsTextBox1.Text);
                int numberOfGoalsTeam2 = Int32.Parse(numberOfGoalsTextBox2.Text);
  
                if (numberOfGoalsTeam1 > numberOfGoalsTeam2)
                {
                    String query5 = "SELECT * FROM q" + numberTable1 + " WHERE id_team = " + idTeam1;

                    sqlDataReader1 = connectionData.SendInquiry(query5);
                    
                    if (sqlDataReader1.IsDBNull(2))
                    {
                        totalPointsTeam1 = 3;

                    } else
                    {
                        totalPointsTeam1 = sqlDataReader1.GetInt32(2) + 3;
                    }

                    if (sqlDataReader1.IsDBNull(3))
                    {
                        totalWinPointsTeam1 = 1;

                    } else
                    {
                        totalWinPointsTeam1 = sqlDataReader1.GetInt32(3) + 1;
                    }

                    connectionData.closeConnection();

                    String query6 = "SELECT * FROM q" + numberTable2 + " WHERE id_team = " + idTeam2;

                    sqlDataReader1 = connectionData.SendInquiry(query6);

                    if (sqlDataReader1.IsDBNull(5))
                    {
                        totalLostPointsTeam2 = 1;
                    }
                    else
                    {
                        totalLostPointsTeam2 = sqlDataReader1.GetInt32(5) + 1;
                    }

                    connectionData.closeConnection();

                    String query7 = "UPDATE q" + numberTable1 + " SET points_scored = " + totalPointsTeam1 + ", win = " + totalWinPointsTeam1 + " WHERE id_team = " + idTeam1;
                    String query8 = "UPDATE q" + numberTable2 + " SET lost = " + totalLostPointsTeam2 + " WHERE id_team = " + idTeam2;

                    connectionData.setData(query7);
                    connectionData.setData(query8);
                }

                if (numberOfGoalsTeam1 == numberOfGoalsTeam2)
                {
                    String query9 = "SELECT * FROM q" + numberTable1 + " WHERE id_team = " + idTeam1;

                    sqlDataReader1 = connectionData.SendInquiry(query9);

                    if (sqlDataReader1.IsDBNull(2))
                    {
                        totalPointsTeam1 = 1;
                    }
                    else
                    {
                        totalPointsTeam1 = sqlDataReader1.GetInt32(2) + 1;
                    }

                    if (sqlDataReader1.IsDBNull(4))
                    {
                        totalDrawPointsTeam1 = 1;
                    }
                    else
                    {
                        totalDrawPointsTeam1 = sqlDataReader1.GetInt32(4) + 1;
                    }

                    connectionData.closeConnection();

                    String query10 = "SELECT * FROM q" + numberTable2 + " WHERE id_team = " + idTeam2;

                    sqlDataReader1 = connectionData.SendInquiry(query10);

                    if (sqlDataReader1.IsDBNull(2))
                    {
                        totalPointsTeam2 = 1;
                    }
                    else
                    {
                        totalPointsTeam2 = sqlDataReader1.GetInt32(2) + 1;
                    }

                    if (sqlDataReader1.IsDBNull(4))
                    {
                        totalDrawPointsTeam2 = 1;
                    }
                    else
                    {
                        totalDrawPointsTeam2 = sqlDataReader1.GetInt32(4) + 1;
                    }

                    connectionData.closeConnection();

                    String query11 = "UPDATE q" + numberTable1 + " SET points_scored = " + totalPointsTeam1 + ", draw = " + totalDrawPointsTeam1 + " WHERE id_team = " + idTeam1;
                    String query12 = "UPDATE q" + numberTable2 + " SET points_scored = " + totalPointsTeam2 + ", draw = " + totalDrawPointsTeam2 + " WHERE id_team = " + idTeam2;

                    connectionData.setData(query11);
                    connectionData.setData(query12);
                }

                if (numberOfGoalsTeam1 < numberOfGoalsTeam2)
                {
                    String query13 = "SELECT * FROM q" + numberTable2 + " WHERE id_team = " + idTeam2;

                    sqlDataReader1 = connectionData.SendInquiry(query13);

                    if (sqlDataReader1.IsDBNull(2))
                    {
                        totalPointsTeam2 = 3;
                        Console.WriteLine("hehehe"+totalPointsTeam2);
                    }
                    else
                    {
                        totalPointsTeam2 = sqlDataReader1.GetInt32(2) + 3;
                    }

                    if (sqlDataReader1.IsDBNull(3))
                    {
                        totalWinPointsTeam2 = 1;

                    }
                    else
                    {
                        totalWinPointsTeam2 = sqlDataReader1.GetInt32(3) + 1;
                    }

                    connectionData.closeConnection();

                    String query14 = "SELECT * FROM q" + numberTable1 + " WHERE id_team = " + idTeam1;

                    sqlDataReader1 = connectionData.SendInquiry(query14);

                    if (sqlDataReader1.IsDBNull(5))
                    {
                        totalLostPointsTeam1 = 1;
                    }
                    else
                    {
                        totalLostPointsTeam1 = sqlDataReader1.GetInt32(5) + 1;
                    }

                    connectionData.closeConnection();

                    String query15 = "UPDATE q" + numberTable2 + " SET points_scored = " + totalPointsTeam2 + ", win = " + totalWinPointsTeam2 + " WHERE id_team = " + idTeam2;
                    String query16 = "UPDATE q" + numberTable1 + " SET lost = " + totalLostPointsTeam1 + " WHERE id_team = " + idTeam1;

                    connectionData.setData(query15);
                    connectionData.setData(query16);
                }

                MessageBox.Show("Added result !");

            } else
            {
                MessageBox.Show("Insert goals !");
            }
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
