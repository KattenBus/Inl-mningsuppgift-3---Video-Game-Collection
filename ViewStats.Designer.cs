namespace Video_Game_collection___Inlämning_3
{
    partial class ViewStats
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
            platformStatsLabel = new Label();
            plattformStatsTotalLabel = new Label();
            SuspendLayout();
            // 
            // platformStatsLabel
            // 
            platformStatsLabel.AutoSize = true;
            platformStatsLabel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            platformStatsLabel.Location = new Point(36, 25);
            platformStatsLabel.Name = "platformStatsLabel";
            platformStatsLabel.Size = new Size(211, 30);
            platformStatsLabel.TabIndex = 0;
            platformStatsLabel.Text = "Games Per Plattform";
            // 
            // plattformStatsTotalLabel
            // 
            plattformStatsTotalLabel.AutoSize = true;
            plattformStatsTotalLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            plattformStatsTotalLabel.Location = new Point(642, 452);
            plattformStatsTotalLabel.Name = "plattformStatsTotalLabel";
            plattformStatsTotalLabel.Size = new Size(94, 21);
            plattformStatsTotalLabel.TabIndex = 1;
            plattformStatsTotalLabel.Text = "Total Games";
            // 
            // ViewStats
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(792, 501);
            Controls.Add(plattformStatsTotalLabel);
            Controls.Add(platformStatsLabel);
            Name = "ViewStats";
            Text = "ViewStats";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label platformStatsLabel;
        private Label plattformStatsTotalLabel;
    }
}