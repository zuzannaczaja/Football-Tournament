
namespace Turniej
{
    partial class InsertResultsWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.teamName1 = new System.Windows.Forms.Label();
            this.teamName2 = new System.Windows.Forms.Label();
            this.numberOfGoalsTextBox1 = new System.Windows.Forms.TextBox();
            this.numberOfGoalsTextBox2 = new System.Windows.Forms.TextBox();
            this.numberOfGoals1 = new System.Windows.Forms.Label();
            this.numberOfGoals2 = new System.Windows.Forms.Label();
            this.saveResultButton = new System.Windows.Forms.Button();
            this.teamNameList1 = new System.Windows.Forms.ListBox();
            this.teamNameList2 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // teamName1
            // 
            this.teamName1.AutoSize = true;
            this.teamName1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.teamName1.Location = new System.Drawing.Point(22, 29);
            this.teamName1.Name = "teamName1";
            this.teamName1.Size = new System.Drawing.Size(94, 18);
            this.teamName1.TabIndex = 0;
            this.teamName1.Text = "Team Name:";
            // 
            // teamName2
            // 
            this.teamName2.AutoSize = true;
            this.teamName2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.teamName2.Location = new System.Drawing.Point(445, 29);
            this.teamName2.Name = "teamName2";
            this.teamName2.Size = new System.Drawing.Size(94, 18);
            this.teamName2.TabIndex = 1;
            this.teamName2.Text = "Team Name:";
            // 
            // numberOfGoalsTextBox1
            // 
            this.numberOfGoalsTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.numberOfGoalsTextBox1.Location = new System.Drawing.Point(141, 60);
            this.numberOfGoalsTextBox1.Name = "numberOfGoalsTextBox1";
            this.numberOfGoalsTextBox1.Size = new System.Drawing.Size(126, 24);
            this.numberOfGoalsTextBox1.TabIndex = 2;
            // 
            // numberOfGoalsTextBox2
            // 
            this.numberOfGoalsTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.numberOfGoalsTextBox2.Location = new System.Drawing.Point(297, 60);
            this.numberOfGoalsTextBox2.Name = "numberOfGoalsTextBox2";
            this.numberOfGoalsTextBox2.Size = new System.Drawing.Size(126, 24);
            this.numberOfGoalsTextBox2.TabIndex = 3;
            // 
            // numberOfGoals1
            // 
            this.numberOfGoals1.AutoSize = true;
            this.numberOfGoals1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.numberOfGoals1.Location = new System.Drawing.Point(138, 29);
            this.numberOfGoals1.Name = "numberOfGoals1";
            this.numberOfGoals1.Size = new System.Drawing.Size(129, 18);
            this.numberOfGoals1.TabIndex = 4;
            this.numberOfGoals1.Text = "Number Of Goals:";
            // 
            // numberOfGoals2
            // 
            this.numberOfGoals2.AutoSize = true;
            this.numberOfGoals2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.numberOfGoals2.Location = new System.Drawing.Point(294, 29);
            this.numberOfGoals2.Name = "numberOfGoals2";
            this.numberOfGoals2.Size = new System.Drawing.Size(129, 18);
            this.numberOfGoals2.TabIndex = 5;
            this.numberOfGoals2.Text = "Number Of Goals:";
            this.numberOfGoals2.Click += new System.EventHandler(this.label1_Click);
            // 
            // saveResultButton
            // 
            this.saveResultButton.Location = new System.Drawing.Point(233, 102);
            this.saveResultButton.Name = "saveResultButton";
            this.saveResultButton.Size = new System.Drawing.Size(94, 53);
            this.saveResultButton.TabIndex = 6;
            this.saveResultButton.Text = "Save Result";
            this.saveResultButton.UseVisualStyleBackColor = true;
            this.saveResultButton.Click += new System.EventHandler(this.saveResultButton_Click);
            // 
            // teamNameList1
            // 
            this.teamNameList1.FormattingEnabled = true;
            this.teamNameList1.Location = new System.Drawing.Point(25, 60);
            this.teamNameList1.Name = "teamNameList1";
            this.teamNameList1.Size = new System.Drawing.Size(101, 95);
            this.teamNameList1.TabIndex = 7;
            this.teamNameList1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // teamNameList2
            // 
            this.teamNameList2.FormattingEnabled = true;
            this.teamNameList2.Location = new System.Drawing.Point(448, 60);
            this.teamNameList2.Name = "teamNameList2";
            this.teamNameList2.Size = new System.Drawing.Size(101, 95);
            this.teamNameList2.TabIndex = 8;
            // 
            // InsertResultsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 194);
            this.Controls.Add(this.teamNameList2);
            this.Controls.Add(this.teamNameList1);
            this.Controls.Add(this.saveResultButton);
            this.Controls.Add(this.numberOfGoals2);
            this.Controls.Add(this.numberOfGoals1);
            this.Controls.Add(this.numberOfGoalsTextBox2);
            this.Controls.Add(this.numberOfGoalsTextBox1);
            this.Controls.Add(this.teamName2);
            this.Controls.Add(this.teamName1);
            this.Name = "InsertResultsWindow";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label teamName1;
        private System.Windows.Forms.Label teamName2;
        private System.Windows.Forms.TextBox numberOfGoalsTextBox1;
        private System.Windows.Forms.TextBox numberOfGoalsTextBox2;
        private System.Windows.Forms.Label numberOfGoals1;
        private System.Windows.Forms.Label numberOfGoals2;
        private System.Windows.Forms.Button saveResultButton;
        private System.Windows.Forms.ListBox teamNameList1;
        private System.Windows.Forms.ListBox teamNameList2;
    }
}