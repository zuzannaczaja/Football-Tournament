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
using Tournament.Data;

/*
 * Insert teams window
 */

namespace Tournament
{
    public partial class InsertTeamsWindow : Form
    {
        public int amountOfTeams = 0;

        public InsertTeamsWindow()
        {
            InitializeComponent();

            this.Text = "Football Torunament";
        }

        private void teamPhoto_Click(object sender, EventArgs e)
        {

        }

        private void teamNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void addTeamButton_Click(object sender, EventArgs e)
        {
            ConnectionData connectionData = new ConnectionData();

            String query1 = "SELECT COUNT(*) FROM teams";

            SqlDataReader sqlDataReader = connectionData.SendInquiry(query1);

            int amountOfTeams = sqlDataReader.GetInt32(0);

            amountOfTeams++;

            if (amountOfTeams > 32)
            {
                MessageBox.Show("The number of teams is maximum!");

            } else
            {
                if (teamNameTextBox.Text != "")
                {
                    String query2 = "INSERT into teams (id_team, name, description, photo) VALUES('" + amountOfTeams + "','" +
                            teamNameTextBox.Text + "','" + teamDescriptionTextBox.Text + "','" + teamPhotoTextBox.Text + "')";

                    connectionData.closeConnection();
                    connectionData.setData(query2);
                    connectionData.closeReader();

                    MessageBox.Show("Added the team");
                } else
                {
                    MessageBox.Show("You have to enter the team name.");
                }
            }         
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            openFileDialog.Filter = "Image Files(*.BMP;*.JPG;*.PNG)|*.BMP;*.JPG;*.PNG";
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = System.IO.Path.GetFullPath(openFileDialog.FileName);
                teamPhotoTextBox.Text = filePath;
            }
        }

        private void deleteTeamButton_Click(object sender, EventArgs e)
        {
            String query = "DELETE from teams WHERE name_team = '" + teamName.Text + "'";

            ConnectionData connectionData = new ConnectionData();

            connectionData.setData(query);
        }

        private void addMissingTeamsButton_Click(object sender, EventArgs e)
        {
            ConnectionData connectionData = new ConnectionData();

            String query1 = "SELECT COUNT(*) FROM teams";

            SqlDataReader sqlDataReader = connectionData.SendInquiry(query1);

            int amountOfTeams = sqlDataReader.GetInt32(0);

            if (amountOfTeams < 32)
            {
                int amountOfTeamsToCreate = 32 - amountOfTeams;

                for (int i = 0; i < amountOfTeamsToCreate; i++)
                {
                    amountOfTeams++;
                    String query = "INSERT into teams (id_team, name) VALUES('" + amountOfTeams + "','" + "Team" + amountOfTeams + "')";

                    connectionData.closeConnection();
                    connectionData.setData(query);
                }
                connectionData.closeReader();

                MessageBox.Show("New teams have been created!");

            } else if (amountOfTeams == 32)
            {
                MessageBox.Show("There are already 32 teams!");
            }
        }

        private void randomTeamsButton_Click(object sender, EventArgs e)
        {
            ConnectionData connectionData = new ConnectionData();

            String query1 = "SELECT COUNT(*) FROM teams";
            SqlDataReader sqlDataReader1 = connectionData.SendInquiry(query1);

            int amountOfTeams = sqlDataReader1.GetInt32(0);
            connectionData.closeConnection();

            if (amountOfTeams == 32)
            {
                String query2 = "SELECT * FROM teams";
                SqlDataReader sqlDataReader2 = connectionData.SendInquiry(query2);

                List<int> idTeamsList = new List<int>();

                do
                {
                    idTeamsList.Add(sqlDataReader2.GetInt32(0));

                } while (sqlDataReader2.Read());

                Random random = new Random();

 
                for (int i = 1; i < 9; i++)
                {
                    for (int j = 1; j < 5; j++)
                    {
                        int randomlyTeam = random.Next(idTeamsList.Count);

                        String query = "INSERT into q" + i + " (id_q" + i + ", id_team) VALUES('" + j + "','" + idTeamsList[randomlyTeam] + "')";

                        connectionData.closeConnection();
                        connectionData.setData(query);

                        idTeamsList.RemoveAt(randomlyTeam);
                    }
                }

                MessageBox.Show("Teams for each group were drawn at random!");

            } else
            {
                MessageBox.Show("No 32 teams added!");
            }
        }
    }
}
