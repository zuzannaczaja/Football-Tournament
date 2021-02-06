using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Turniej.Data;

/*
 * Main Menu
 */

namespace Turniej
{
    public partial class MenuWindow : Form
    {
        public MenuWindow()
        {
            InitializeComponent();
            ConnectionData conn = new ConnectionData();

            this.Text = "Football Torunament";
        }

        private void insertTeamsButton_Click(object sender, EventArgs e)
        {
            var openWindow = new InsertTeamsWindow();
            openWindow.Show();
        }

        private void insertResultsButton_Click(object sender, EventArgs e)
        {
            var openWindow = new InsertResultsWindow();
            openWindow.Show();
        }

        private void groupPhaseButton_Click(object sender, EventArgs e)
        {
            var openWindow = new GroupPhaseWindow();
            openWindow.Show();
        }

        private void knockoutStageButton_Click(object sender, EventArgs e)
        {

        }

        private void deleteAllTournamentButton_Click(object sender, EventArgs e)
        {

        }
    }
}
