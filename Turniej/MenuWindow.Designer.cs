
namespace Tournament
{
    partial class MenuWindow
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.insertTeamsButton = new System.Windows.Forms.Button();
            this.insertResultsButton = new System.Windows.Forms.Button();
            this.groupPhaseButton = new System.Windows.Forms.Button();
            this.knockoutStageButton = new System.Windows.Forms.Button();
            this.deleteAllTournamentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label1.Location = new System.Drawing.Point(78, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Football tournament";
            // 
            // insertTeamsButton
            // 
            this.insertTeamsButton.Location = new System.Drawing.Point(160, 155);
            this.insertTeamsButton.Name = "insertTeamsButton";
            this.insertTeamsButton.Size = new System.Drawing.Size(146, 37);
            this.insertTeamsButton.TabIndex = 1;
            this.insertTeamsButton.Text = "Insert Teams";
            this.insertTeamsButton.UseVisualStyleBackColor = true;
            this.insertTeamsButton.Click += new System.EventHandler(this.insertTeamsButton_Click);
            // 
            // insertResultsButton
            // 
            this.insertResultsButton.Location = new System.Drawing.Point(160, 198);
            this.insertResultsButton.Name = "insertResultsButton";
            this.insertResultsButton.Size = new System.Drawing.Size(146, 37);
            this.insertResultsButton.TabIndex = 2;
            this.insertResultsButton.Text = "Insert Results";
            this.insertResultsButton.UseVisualStyleBackColor = true;
            this.insertResultsButton.Click += new System.EventHandler(this.insertResultsButton_Click);
            // 
            // groupPhaseButton
            // 
            this.groupPhaseButton.Location = new System.Drawing.Point(160, 241);
            this.groupPhaseButton.Name = "groupPhaseButton";
            this.groupPhaseButton.Size = new System.Drawing.Size(146, 37);
            this.groupPhaseButton.TabIndex = 3;
            this.groupPhaseButton.Text = "Group Phase";
            this.groupPhaseButton.UseVisualStyleBackColor = true;
            this.groupPhaseButton.Click += new System.EventHandler(this.groupPhaseButton_Click);
            // 
            // knockoutStageButton
            // 
            this.knockoutStageButton.Location = new System.Drawing.Point(160, 284);
            this.knockoutStageButton.Name = "knockoutStageButton";
            this.knockoutStageButton.Size = new System.Drawing.Size(146, 37);
            this.knockoutStageButton.TabIndex = 4;
            this.knockoutStageButton.Text = "Knockout Stage";
            this.knockoutStageButton.UseVisualStyleBackColor = true;
            this.knockoutStageButton.Click += new System.EventHandler(this.knockoutStageButton_Click);
            // 
            // deleteAllTournamentButton
            // 
            this.deleteAllTournamentButton.Location = new System.Drawing.Point(160, 327);
            this.deleteAllTournamentButton.Name = "deleteAllTournamentButton";
            this.deleteAllTournamentButton.Size = new System.Drawing.Size(146, 37);
            this.deleteAllTournamentButton.TabIndex = 5;
            this.deleteAllTournamentButton.Text = "Delete All Tournament";
            this.deleteAllTournamentButton.UseVisualStyleBackColor = true;
            this.deleteAllTournamentButton.Click += new System.EventHandler(this.deleteAllTournamentButton_Click);
            // 
            // MenuWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 448);
            this.Controls.Add(this.deleteAllTournamentButton);
            this.Controls.Add(this.knockoutStageButton);
            this.Controls.Add(this.groupPhaseButton);
            this.Controls.Add(this.insertResultsButton);
            this.Controls.Add(this.insertTeamsButton);
            this.Controls.Add(this.label1);
            this.Name = "MenuWindow";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button insertTeamsButton;
        private System.Windows.Forms.Button insertResultsButton;
        private System.Windows.Forms.Button groupPhaseButton;
        private System.Windows.Forms.Button knockoutStageButton;
        private System.Windows.Forms.Button deleteAllTournamentButton;
    }
}

