
namespace Tournament
{
    partial class InsertTeamsWindow
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
            this.teamName = new System.Windows.Forms.Label();
            this.teamDescription = new System.Windows.Forms.Label();
            this.teamPhoto = new System.Windows.Forms.Label();
            this.teamNameTextBox = new System.Windows.Forms.TextBox();
            this.teamDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.teamPhotoTextBox = new System.Windows.Forms.TextBox();
            this.addTeamButton = new System.Windows.Forms.Button();
            this.deleteTeamButton = new System.Windows.Forms.Button();
            this.browseButton = new System.Windows.Forms.Button();
            this.addMissingTeamsButton = new System.Windows.Forms.Button();
            this.randomTeamsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // teamName
            // 
            this.teamName.AutoSize = true;
            this.teamName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.teamName.Location = new System.Drawing.Point(28, 41);
            this.teamName.Name = "teamName";
            this.teamName.Size = new System.Drawing.Size(94, 18);
            this.teamName.TabIndex = 0;
            this.teamName.Text = "Team Name:";
            // 
            // teamDescription
            // 
            this.teamDescription.AutoSize = true;
            this.teamDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.teamDescription.Location = new System.Drawing.Point(28, 86);
            this.teamDescription.Name = "teamDescription";
            this.teamDescription.Size = new System.Drawing.Size(129, 18);
            this.teamDescription.TabIndex = 1;
            this.teamDescription.Text = "Team Description:";
            // 
            // teamPhoto
            // 
            this.teamPhoto.AutoSize = true;
            this.teamPhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.teamPhoto.Location = new System.Drawing.Point(28, 132);
            this.teamPhoto.Name = "teamPhoto";
            this.teamPhoto.Size = new System.Drawing.Size(94, 18);
            this.teamPhoto.TabIndex = 2;
            this.teamPhoto.Text = "Team Photo:";
            this.teamPhoto.Click += new System.EventHandler(this.teamPhoto_Click);
            // 
            // teamNameTextBox
            // 
            this.teamNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.teamNameTextBox.Location = new System.Drawing.Point(173, 38);
            this.teamNameTextBox.Name = "teamNameTextBox";
            this.teamNameTextBox.Size = new System.Drawing.Size(308, 24);
            this.teamNameTextBox.TabIndex = 3;
            this.teamNameTextBox.TextChanged += new System.EventHandler(this.teamNameTextBox_TextChanged);
            // 
            // teamDescriptionTextBox
            // 
            this.teamDescriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.teamDescriptionTextBox.Location = new System.Drawing.Point(173, 83);
            this.teamDescriptionTextBox.Name = "teamDescriptionTextBox";
            this.teamDescriptionTextBox.Size = new System.Drawing.Size(308, 24);
            this.teamDescriptionTextBox.TabIndex = 4;
            // 
            // teamPhotoTextBox
            // 
            this.teamPhotoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.teamPhotoTextBox.Location = new System.Drawing.Point(173, 129);
            this.teamPhotoTextBox.Name = "teamPhotoTextBox";
            this.teamPhotoTextBox.Size = new System.Drawing.Size(308, 24);
            this.teamPhotoTextBox.TabIndex = 5;
            // 
            // addTeamButton
            // 
            this.addTeamButton.Location = new System.Drawing.Point(31, 177);
            this.addTeamButton.Name = "addTeamButton";
            this.addTeamButton.Size = new System.Drawing.Size(105, 35);
            this.addTeamButton.TabIndex = 6;
            this.addTeamButton.Text = "Add Team";
            this.addTeamButton.UseVisualStyleBackColor = true;
            this.addTeamButton.Click += new System.EventHandler(this.addTeamButton_Click);
            // 
            // deleteTeamButton
            // 
            this.deleteTeamButton.Location = new System.Drawing.Point(142, 177);
            this.deleteTeamButton.Name = "deleteTeamButton";
            this.deleteTeamButton.Size = new System.Drawing.Size(105, 35);
            this.deleteTeamButton.TabIndex = 7;
            this.deleteTeamButton.Text = "Delete Team";
            this.deleteTeamButton.UseVisualStyleBackColor = true;
            this.deleteTeamButton.Click += new System.EventHandler(this.deleteTeamButton_Click);
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(513, 125);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(105, 35);
            this.browseButton.TabIndex = 8;
            this.browseButton.Text = "Browse...";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // addMissingTeamsButton
            // 
            this.addMissingTeamsButton.Location = new System.Drawing.Point(253, 177);
            this.addMissingTeamsButton.Name = "addMissingTeamsButton";
            this.addMissingTeamsButton.Size = new System.Drawing.Size(105, 35);
            this.addMissingTeamsButton.TabIndex = 9;
            this.addMissingTeamsButton.Text = "Add MissingTeams";
            this.addMissingTeamsButton.UseVisualStyleBackColor = true;
            this.addMissingTeamsButton.Click += new System.EventHandler(this.addMissingTeamsButton_Click);
            // 
            // randomTeamsButton
            // 
            this.randomTeamsButton.Location = new System.Drawing.Point(364, 177);
            this.randomTeamsButton.Name = "randomTeamsButton";
            this.randomTeamsButton.Size = new System.Drawing.Size(105, 35);
            this.randomTeamsButton.TabIndex = 10;
            this.randomTeamsButton.Text = "Random Teams to Group";
            this.randomTeamsButton.UseVisualStyleBackColor = true;
            this.randomTeamsButton.Click += new System.EventHandler(this.randomTeamsButton_Click);
            // 
            // InsertTeamsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 252);
            this.Controls.Add(this.randomTeamsButton);
            this.Controls.Add(this.addMissingTeamsButton);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.deleteTeamButton);
            this.Controls.Add(this.addTeamButton);
            this.Controls.Add(this.teamPhotoTextBox);
            this.Controls.Add(this.teamDescriptionTextBox);
            this.Controls.Add(this.teamNameTextBox);
            this.Controls.Add(this.teamPhoto);
            this.Controls.Add(this.teamDescription);
            this.Controls.Add(this.teamName);
            this.Name = "InsertTeamsWindow";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label teamName;
        private System.Windows.Forms.Label teamDescription;
        private System.Windows.Forms.Label teamPhoto;
        private System.Windows.Forms.TextBox teamNameTextBox;
        private System.Windows.Forms.TextBox teamDescriptionTextBox;
        private System.Windows.Forms.TextBox teamPhotoTextBox;
        private System.Windows.Forms.Button addTeamButton;
        private System.Windows.Forms.Button deleteTeamButton;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Button addMissingTeamsButton;
        private System.Windows.Forms.Button randomTeamsButton;
    }
}