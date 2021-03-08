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

namespace Tournament
{
    public partial class InsertResultsWindow : Form
    {
        private HttpConnection httpConnection = new HttpConnection();

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

        private async void saveResultButton_Click(object sender, EventArgs e)
        {
            String selectedTeam1 = teamNameList1.SelectedItem.ToString();
            String selectedTeam2 = teamNameList2.SelectedItem.ToString();

            List<Team> teams = httpConnection.GetTeams();

            var teamResult1 = teams.FirstOrDefault(t => t.Name == selectedTeam1);
            var teamResult2 = teams.FirstOrDefault(t => t.Name == selectedTeam2);

            int totalPointsTeam1 = 0;
            int totalPointsTeam2 = 0;

            int totalWinPointsTeam1 = 0;
            int totalWinPointsTeam2 = 0;

            int totalLostPointsTeam1 = 0;
            int totalLostPointsTeam2 = 0;

            int totalDrawPointsTeam1 = 0;
            int totalDrawPointsTeam2 = 0;

            if (numberOfGoalsTextBox1 != null && numberOfGoalsTextBox2 != null)
            {
                int numberOfGoalsTeam1 = Int32.Parse(numberOfGoalsTextBox1.Text);
                int numberOfGoalsTeam2 = Int32.Parse(numberOfGoalsTextBox2.Text);

                if (numberOfGoalsTeam1 > numberOfGoalsTeam2)
                {                  
                    totalPointsTeam1 = teamResult1.PointsScored + 3;
                    totalWinPointsTeam1 = teamResult1.Win + 1;

                    var team = new Team() { Id = teamResult1.Id, PointsScored = totalPointsTeam1, Win = totalWinPointsTeam1, GroupId = teamResult1.GroupId };
                    await httpConnection.UpdateTeamAsync(team);

                    totalLostPointsTeam2 = teamResult2.Lost + 1;

                    team = new Team() { Id = teamResult2.Id, Lost = totalLostPointsTeam2, GroupId = teamResult2.GroupId };
                    await httpConnection.UpdateTeamAsync(team);
                }

                if (numberOfGoalsTeam1 == numberOfGoalsTeam2)
                {
                    totalPointsTeam1 = teamResult1.PointsScored + 1;
                    totalDrawPointsTeam1 = teamResult1.Draw + 1;

                    var team = new Team() { Id = teamResult1.Id, PointsScored = totalPointsTeam1, Draw = totalWinPointsTeam1, GroupId = teamResult1.GroupId };
                    await httpConnection.UpdateTeamAsync(team);

                    totalPointsTeam2 = teamResult2.PointsScored + 1;
                    totalDrawPointsTeam2 = teamResult2.Draw + 1;

                    team = new Team() { Id = teamResult2.Id, PointsScored = totalPointsTeam2, Draw = totalWinPointsTeam2, GroupId = teamResult2.GroupId };
                    await httpConnection.UpdateTeamAsync(team);
                }

                if (numberOfGoalsTeam2 > numberOfGoalsTeam1)
                {
                    totalPointsTeam2 = teamResult2.PointsScored + 3;
                    totalWinPointsTeam2 = teamResult2.Win + 1;

                    var team = new Team() { Id = teamResult2.Id, PointsScored = totalPointsTeam2, Win = totalWinPointsTeam2, GroupId = teamResult2.GroupId };
                    await httpConnection.UpdateTeamAsync(team);

                    totalLostPointsTeam1 = teamResult1.Lost + 1;

                    team = new Team() { Id = teamResult1.Id, Lost = totalLostPointsTeam1, GroupId = teamResult1.GroupId };
                    await httpConnection.UpdateTeamAsync(team);
                }

                MessageBox.Show("Added result !");
            } else
            {
                MessageBox.Show("Insert result !");
            }
        }

        private void updateList()
        {
            List<Team> teams = httpConnection.GetTeams();

            teamNameList1.BeginUpdate();
            teamNameList2.BeginUpdate();

            foreach (var team in teams)
            {
                teamNameList1.Items.Add(team.Name);
                teamNameList2.Items.Add(team.Name);
            }

            teamNameList1.EndUpdate();
            teamNameList2.EndUpdate();
        }
    }
}
