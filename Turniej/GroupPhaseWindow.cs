using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System;

namespace Turniej
{
    public partial class GroupPhaseWindow : Form
    {
        private DataGridView dataGridViewQ1 = new DataGridView();
        private BindingSource bindingSourceQ1 = new BindingSource();

        private DataGridView dataGridViewQ2 = new DataGridView();
        private BindingSource bindingSourceQ2 = new BindingSource();

        private DataGridView dataGridViewQ3 = new DataGridView();
        private BindingSource bindingSourceQ3 = new BindingSource();

        private DataGridView dataGridViewQ4 = new DataGridView();
        private BindingSource bindingSourceQ4 = new BindingSource();

        private DataGridView dataGridViewQ5 = new DataGridView();
        private BindingSource bindingSourceQ5 = new BindingSource();

        private DataGridView dataGridViewQ6 = new DataGridView();
        private BindingSource bindingSourceQ6 = new BindingSource();

        private DataGridView dataGridViewQ7 = new DataGridView();
        private BindingSource bindingSourceQ7 = new BindingSource();

        private DataGridView dataGridViewQ8 = new DataGridView();
        private BindingSource bindingSourceQ8 = new BindingSource();

        public GroupPhaseWindow()
        {
            InitializeComponent();
            InitializeGroupBox();
            InitializeDataGridView();

            this.Text = "Football Torunament";
            this.Size = new Size(600, 500);
            this.AutoScroll = true;
        }

        private void InitializeGroupBox()
        {
            GroupBox groupBoxQ1 = new GroupBox();
            groupBoxQ1.Size = new Size(550, 125);
            groupBoxQ1.Location = new Point(20, 20);
            groupBoxQ1.Text = "Q1 Group";
            groupBoxQ1.Controls.Add(dataGridViewQ1);
            Controls.Add(groupBoxQ1);

            GroupBox groupBoxQ2 = new GroupBox();
            groupBoxQ2.Size = new Size(550, 125);
            groupBoxQ2.Location = new Point(20, 200);
            groupBoxQ2.Text = "Q2 Group";
            groupBoxQ2.Controls.Add(dataGridViewQ2);
            Controls.Add(groupBoxQ2);

            GroupBox groupBoxQ3 = new GroupBox();
            groupBoxQ3.Size = new Size(550, 125);
            groupBoxQ3.Location = new Point(20, 380);
            groupBoxQ3.Text = "Q3 Group";
            groupBoxQ3.Controls.Add(dataGridViewQ3);
            Controls.Add(groupBoxQ3);

            GroupBox groupBoxQ4 = new GroupBox();
            groupBoxQ4.Size = new Size(550, 125);
            groupBoxQ4.Location = new Point(20, 560);
            groupBoxQ4.Text = "Q4 Group";
            groupBoxQ4.Controls.Add(dataGridViewQ4);
            Controls.Add(groupBoxQ4);

            GroupBox groupBoxQ5 = new GroupBox();
            groupBoxQ5.Size = new Size(550, 125);
            groupBoxQ5.Location = new Point(20, 740);
            groupBoxQ5.Text = "Q5 Group";
            groupBoxQ5.Controls.Add(dataGridViewQ5);
            Controls.Add(groupBoxQ5);

            GroupBox groupBoxQ6 = new GroupBox();
            groupBoxQ6.Size = new Size(550, 125);
            groupBoxQ6.Location = new Point(20, 920);
            groupBoxQ6.Text = "Q6 Group";
            groupBoxQ6.Controls.Add(dataGridViewQ6);
            Controls.Add(groupBoxQ6);

            GroupBox groupBoxQ7 = new GroupBox();
            groupBoxQ7.Size = new Size(550, 125);
            groupBoxQ7.Location = new Point(20, 1100);
            groupBoxQ7.Text = "Q7 Group";
            groupBoxQ7.Controls.Add(dataGridViewQ7);
            Controls.Add(groupBoxQ7);

            GroupBox groupBoxQ8 = new GroupBox();
            groupBoxQ8.Size = new Size(550, 125);
            groupBoxQ8.Location = new Point(20, 1280);
            groupBoxQ8.Text = "Q8 Group";
            groupBoxQ8.Controls.Add(dataGridViewQ8);
            Controls.Add(groupBoxQ8);
        }

        private void InitializeDataGridView()
        {
            try
            {
                // Group Q1
                dataGridViewQ1.Dock = DockStyle.Fill;
                dataGridViewQ1.AutoGenerateColumns = true;
                dataGridViewQ1.ReadOnly = true;
                dataGridViewQ1.AllowUserToAddRows = false;

                bindingSourceQ1.DataSource = GetData("SELECT teams.name AS Team, q1.points_scored AS Points, q1.win AS Win, q1.draw AS Draw, q1.lost AS Lost FROM teams INNER JOIN q1 ON teams.id_team = q1.id_team ORDER BY q1.points_scored");
                dataGridViewQ1.DataSource = bindingSourceQ1;

                dataGridViewQ1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
                dataGridViewQ1.BorderStyle = BorderStyle.Fixed3D;
                dataGridViewQ1.EditMode = DataGridViewEditMode.EditOnEnter;

                // Group Q2
                dataGridViewQ2.Dock = DockStyle.Fill;
                dataGridViewQ2.AutoGenerateColumns = true;
                dataGridViewQ2.ReadOnly = true;
                dataGridViewQ2.AllowUserToAddRows = false;

                bindingSourceQ2.DataSource = GetData("SELECT teams.name AS Team, q2.points_scored AS Points, q2.win AS Win, q2.draw AS Draw, q2.lost AS Lost FROM teams INNER JOIN q2 ON teams.id_team = q2.id_team ORDER BY q2.points_scored");
                dataGridViewQ2.DataSource = bindingSourceQ2;

                dataGridViewQ2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
                dataGridViewQ2.BorderStyle = BorderStyle.Fixed3D;
                dataGridViewQ2.EditMode = DataGridViewEditMode.EditOnEnter;

                // Group Q3
                dataGridViewQ3.Dock = DockStyle.Fill;
                dataGridViewQ3.AutoGenerateColumns = true;
                dataGridViewQ3.ReadOnly = true;
                dataGridViewQ3.AllowUserToAddRows = false;

                bindingSourceQ3.DataSource = GetData("SELECT teams.name AS Team, q3.points_scored AS Points, q3.win AS Win, q3.draw AS Draw, q3.lost AS Lost FROM teams INNER JOIN q3 ON teams.id_team = q3.id_team ORDER BY q3.points_scored");
                dataGridViewQ3.DataSource = bindingSourceQ3;

                dataGridViewQ3.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
                dataGridViewQ3.BorderStyle = BorderStyle.Fixed3D;
                dataGridViewQ3.EditMode = DataGridViewEditMode.EditOnEnter;

                // Group Q4
                dataGridViewQ4.Dock = DockStyle.Fill;
                dataGridViewQ4.AutoGenerateColumns = true;
                dataGridViewQ4.ReadOnly = true;
                dataGridViewQ4.AllowUserToAddRows = false;

                bindingSourceQ4.DataSource = GetData("SELECT teams.name AS Team, q4.points_scored AS Points, q4.win AS Win, q4.draw AS Draw, q4.lost AS Lost FROM teams INNER JOIN q4 ON teams.id_team = q4.id_team ORDER BY q4.points_scored");
                dataGridViewQ4.DataSource = bindingSourceQ4;

                dataGridViewQ4.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
                dataGridViewQ4.BorderStyle = BorderStyle.Fixed3D;
                dataGridViewQ4.EditMode = DataGridViewEditMode.EditOnEnter;

                // Group Q5
                dataGridViewQ5.Dock = DockStyle.Fill;
                dataGridViewQ5.AutoGenerateColumns = true;
                dataGridViewQ5.ReadOnly = true;
                dataGridViewQ5.AllowUserToAddRows = false;

                bindingSourceQ5.DataSource = GetData("SELECT teams.name AS Team, q5.points_scored AS Points, q5.win AS Win, q5.draw AS Draw, q5.lost AS Lost FROM teams INNER JOIN q5 ON teams.id_team = q5.id_team ORDER BY q5.points_scored");
                dataGridViewQ5.DataSource = bindingSourceQ5;

                dataGridViewQ5.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
                dataGridViewQ5.BorderStyle = BorderStyle.Fixed3D;
                dataGridViewQ5.EditMode = DataGridViewEditMode.EditOnEnter;

                // Group Q6
                dataGridViewQ6.Dock = DockStyle.Fill;
                dataGridViewQ6.AutoGenerateColumns = true;
                dataGridViewQ6.ReadOnly = true;
                dataGridViewQ6.AllowUserToAddRows = false;

                bindingSourceQ6.DataSource = GetData("SELECT teams.name AS Team, q6.points_scored AS Points, q6.win AS Win, q6.draw AS Draw, q6.lost AS Lost FROM teams INNER JOIN q6 ON teams.id_team = q6.id_team ORDER BY q6.points_scored");
                dataGridViewQ6.DataSource = bindingSourceQ6;

                dataGridViewQ6.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
                dataGridViewQ6.BorderStyle = BorderStyle.Fixed3D;
                dataGridViewQ6.EditMode = DataGridViewEditMode.EditOnEnter;

                // Group Q7
                dataGridViewQ7.Dock = DockStyle.Fill;
                dataGridViewQ7.AutoGenerateColumns = true;
                dataGridViewQ7.ReadOnly = true;
                dataGridViewQ7.AllowUserToAddRows = false;

                bindingSourceQ7.DataSource = GetData("SELECT teams.name AS Team, q7.points_scored AS Points, q7.win AS Win, q7.draw AS Draw, q7.lost AS Lost FROM teams INNER JOIN q7 ON teams.id_team = q7.id_team ORDER BY q7.points_scored");
                dataGridViewQ7.DataSource = bindingSourceQ7;

                dataGridViewQ7.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
                dataGridViewQ7.BorderStyle = BorderStyle.Fixed3D;
                dataGridViewQ7.EditMode = DataGridViewEditMode.EditOnEnter;

                // Group Q8
                dataGridViewQ8.Dock = DockStyle.Fill;
                dataGridViewQ8.AutoGenerateColumns = true;
                dataGridViewQ8.ReadOnly = true;
                dataGridViewQ8.AllowUserToAddRows = false;

                bindingSourceQ8.DataSource = GetData("SELECT teams.name AS Team, q8.points_scored AS Points, q8.win AS Win, q8.draw AS Draw, q8.lost AS Lost FROM teams INNER JOIN q8 ON teams.id_team = q8.id_team ORDER BY q8.points_scored");
                dataGridViewQ8.DataSource = bindingSourceQ8;

                dataGridViewQ8.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
                dataGridViewQ8.BorderStyle = BorderStyle.Fixed3D;
                dataGridViewQ8.EditMode = DataGridViewEditMode.EditOnEnter;
            }
            catch (SqlException)
            {
                MessageBox.Show("To run this sample replace connection.ConnectionString" +
                    " with a valid connection string to a Northwind" +
                    " database accessible to your system.", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                System.Threading.Thread.CurrentThread.Abort();
            }
        }

        private static DataTable GetData(string sqlCommand)
        {
            string connectionString = @"Data Source=DESKTOP-C1F6DDM;Initial Catalog=Football;Integrated Security=True";

            SqlConnection northwindConnection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(sqlCommand, northwindConnection);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;

            DataTable table = new DataTable();
            table.Locale = System.Globalization.CultureInfo.InvariantCulture;
            adapter.Fill(table);
            adapter.Update(table);

            return table;
        }
    }
}
