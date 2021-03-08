using Newtonsoft.Json;
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
        private HttpConnection httpConnection = new HttpConnection();

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

        private async void addTeamButton_Click(object sender, EventArgs e)
        {
            HttpConnection httpConnection = new HttpConnection();

            List<Team> teams = httpConnection.GetTeams();
            int amountOfTeams = teams.Count;

            if (amountOfTeams > 32)
            {
                MessageBox.Show("The number of teams is maximum!");

            } else
            {
                if (teamNameTextBox.Text != "" || teamNameTextBox.Text != "")
                {
                    var teamForCreation = new TeamForCreation() { Name = teamNameTextBox.Text, Description = teamDescriptionTextBox.Text };
                    await httpConnection.CreateTeam(teamForCreation);
                }
                else
                {
                    MessageBox.Show("You have to enter the team name.");
                }

                MessageBox.Show("Added the team!");
            }
        }

        private async void deleteTeamButton_Click(object sender, EventArgs e)
        {
            List<Team> teams = httpConnection.GetTeams();
            var team = teams.FirstOrDefault(t => t.Name == teamNameTextBox.Text);

            await httpConnection.DeleteTeamAsync(team.Id);

            MessageBox.Show("Deleted the team!");
        }

        private async void addMissingTeamsButton_Click(object sender, EventArgs e)
        {
            List<Team> teams = httpConnection.GetTeams();
            int amountOfTeams = teams.Count;

            if (amountOfTeams < 32)
            {
                for (int i = amountOfTeams + 1; i < 33; i++)
                {
                    var teamForCreation = new TeamForCreation() { Name = "TeamExample" + i, Description = "Description" + i};
                    await httpConnection.CreateTeam(teamForCreation);
                }

                MessageBox.Show("New teams have been created!");
            }
            else if (amountOfTeams == 32)
            {
                MessageBox.Show("There are already 32 teams!");
            }
        }

        private async void randomTeamsButton_Click(object sender, EventArgs e)
        {
            List<Team> teams = httpConnection.GetTeams();
            int amountOfTeams = teams.Count;

            string[] lettersTable = { "A", "B", "C", "D", "E", "F", "G", "H" };
            List<string> letters = new List<string>(lettersTable);

            Random random = new Random();
            List<Group> groups = new List<Group>();

            if (amountOfTeams == 32)
            {
                foreach (string letter in letters)
                {
                    var group = new Group() { Name = letter };
                    await httpConnection.CreateGroup(group);
                    teams = teams.OrderBy(item => random.Next()).ToList();
                    groups = httpConnection.GetGroups();
                    var groupForTeams = groups.FirstOrDefault(t => t.Name == letter);

                    for (int i = 0; i < 4; i++)
                    {
                        var team = new Team() { Id = teams[i].Id, GroupId = groupForTeams.Id };
                        await httpConnection.UpdateTeamAsync(team);

                        if (i == 3)
                        {
                            teams.Remove(teams[i]);
                            teams.Remove(teams[i-1]);
                            teams.Remove(teams[i-2]);
                            teams.Remove(teams[i-3]);
                        }
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
