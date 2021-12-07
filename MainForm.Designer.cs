
namespace ValorantRankedLeaderboardTracker
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.leaderBoardGroupBox = new System.Windows.Forms.GroupBox();
            this.playerDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.leaderBoardPlayersListBox = new System.Windows.Forms.ListView();
            this.playerRankLabel = new System.Windows.Forms.Label();
            this.playerRankTextBox = new System.Windows.Forms.TextBox();
            this.playerGameNameLabel = new System.Windows.Forms.Label();
            this.playerGameNameTextBox = new System.Windows.Forms.TextBox();
            this.playerPuuidLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.playerTagLineLabel = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.playerRankedRatingLabel = new System.Windows.Forms.Label();
            this.playerRankedRatingTextBox = new System.Windows.Forms.TextBox();
            this.playerNumberOfWinsLabel = new System.Windows.Forms.Label();
            this.playerNumberOfWinsTextBox = new System.Windows.Forms.TextBox();
            this.leaderBoardGroupBox.SuspendLayout();
            this.playerDetailsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // leaderBoardGroupBox
            // 
            this.leaderBoardGroupBox.Controls.Add(this.leaderBoardPlayersListBox);
            this.leaderBoardGroupBox.Location = new System.Drawing.Point(12, 83);
            this.leaderBoardGroupBox.Name = "leaderBoardGroupBox";
            this.leaderBoardGroupBox.Size = new System.Drawing.Size(260, 355);
            this.leaderBoardGroupBox.TabIndex = 0;
            this.leaderBoardGroupBox.TabStop = false;
            this.leaderBoardGroupBox.Text = "Leaderboard";
            // 
            // playerDetailsGroupBox
            // 
            this.playerDetailsGroupBox.Controls.Add(this.playerNumberOfWinsTextBox);
            this.playerDetailsGroupBox.Controls.Add(this.playerNumberOfWinsLabel);
            this.playerDetailsGroupBox.Controls.Add(this.playerRankedRatingTextBox);
            this.playerDetailsGroupBox.Controls.Add(this.playerRankedRatingLabel);
            this.playerDetailsGroupBox.Controls.Add(this.textBox2);
            this.playerDetailsGroupBox.Controls.Add(this.playerTagLineLabel);
            this.playerDetailsGroupBox.Controls.Add(this.textBox1);
            this.playerDetailsGroupBox.Controls.Add(this.playerPuuidLabel);
            this.playerDetailsGroupBox.Controls.Add(this.playerGameNameTextBox);
            this.playerDetailsGroupBox.Controls.Add(this.playerGameNameLabel);
            this.playerDetailsGroupBox.Controls.Add(this.playerRankTextBox);
            this.playerDetailsGroupBox.Controls.Add(this.playerRankLabel);
            this.playerDetailsGroupBox.Location = new System.Drawing.Point(278, 83);
            this.playerDetailsGroupBox.Name = "playerDetailsGroupBox";
            this.playerDetailsGroupBox.Size = new System.Drawing.Size(510, 355);
            this.playerDetailsGroupBox.TabIndex = 1;
            this.playerDetailsGroupBox.TabStop = false;
            this.playerDetailsGroupBox.Text = "Player Details";
            // 
            // leaderBoardPlayersListBox
            // 
            this.leaderBoardPlayersListBox.HideSelection = false;
            this.leaderBoardPlayersListBox.Location = new System.Drawing.Point(6, 22);
            this.leaderBoardPlayersListBox.Name = "leaderBoardPlayersListBox";
            this.leaderBoardPlayersListBox.Size = new System.Drawing.Size(248, 327);
            this.leaderBoardPlayersListBox.TabIndex = 0;
            this.leaderBoardPlayersListBox.UseCompatibleStateImageBehavior = false;
            // 
            // playerRankLabel
            // 
            this.playerRankLabel.AutoSize = true;
            this.playerRankLabel.Location = new System.Drawing.Point(6, 40);
            this.playerRankLabel.Name = "playerRankLabel";
            this.playerRankLabel.Size = new System.Drawing.Size(36, 15);
            this.playerRankLabel.TabIndex = 0;
            this.playerRankLabel.Text = "Rank:";
            // 
            // playerRankTextBox
            // 
            this.playerRankTextBox.Location = new System.Drawing.Point(110, 40);
            this.playerRankTextBox.Name = "playerRankTextBox";
            this.playerRankTextBox.Size = new System.Drawing.Size(100, 23);
            this.playerRankTextBox.TabIndex = 1;
            // 
            // playerGameNameLabel
            // 
            this.playerGameNameLabel.AutoSize = true;
            this.playerGameNameLabel.Location = new System.Drawing.Point(7, 89);
            this.playerGameNameLabel.Name = "playerGameNameLabel";
            this.playerGameNameLabel.Size = new System.Drawing.Size(76, 15);
            this.playerGameNameLabel.TabIndex = 2;
            this.playerGameNameLabel.Text = "Game Name:";
            // 
            // playerGameNameTextBox
            // 
            this.playerGameNameTextBox.Location = new System.Drawing.Point(110, 86);
            this.playerGameNameTextBox.Name = "playerGameNameTextBox";
            this.playerGameNameTextBox.Size = new System.Drawing.Size(349, 23);
            this.playerGameNameTextBox.TabIndex = 3;
            // 
            // playerPuuidLabel
            // 
            this.playerPuuidLabel.AutoSize = true;
            this.playerPuuidLabel.Location = new System.Drawing.Point(6, 136);
            this.playerPuuidLabel.Name = "playerPuuidLabel";
            this.playerPuuidLabel.Size = new System.Drawing.Size(41, 15);
            this.playerPuuidLabel.TabIndex = 4;
            this.playerPuuidLabel.Text = "Puuid:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(110, 133);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(349, 23);
            this.textBox1.TabIndex = 5;
            // 
            // playerTagLineLabel
            // 
            this.playerTagLineLabel.AutoSize = true;
            this.playerTagLineLabel.Location = new System.Drawing.Point(7, 188);
            this.playerTagLineLabel.Name = "playerTagLineLabel";
            this.playerTagLineLabel.Size = new System.Drawing.Size(53, 15);
            this.playerTagLineLabel.TabIndex = 6;
            this.playerTagLineLabel.Text = "Tag Line:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(110, 185);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(349, 23);
            this.textBox2.TabIndex = 7;
            // 
            // playerRankedRatingLabel
            // 
            this.playerRankedRatingLabel.AutoSize = true;
            this.playerRankedRatingLabel.Location = new System.Drawing.Point(7, 246);
            this.playerRankedRatingLabel.Name = "playerRankedRatingLabel";
            this.playerRankedRatingLabel.Size = new System.Drawing.Size(86, 15);
            this.playerRankedRatingLabel.TabIndex = 8;
            this.playerRankedRatingLabel.Text = "Ranked Rating:";
            // 
            // playerRankedRatingTextBox
            // 
            this.playerRankedRatingTextBox.Location = new System.Drawing.Point(110, 243);
            this.playerRankedRatingTextBox.Name = "playerRankedRatingTextBox";
            this.playerRankedRatingTextBox.Size = new System.Drawing.Size(349, 23);
            this.playerRankedRatingTextBox.TabIndex = 9;
            // 
            // playerNumberOfWinsLabel
            // 
            this.playerNumberOfWinsLabel.AutoSize = true;
            this.playerNumberOfWinsLabel.Location = new System.Drawing.Point(7, 298);
            this.playerNumberOfWinsLabel.Name = "playerNumberOfWinsLabel";
            this.playerNumberOfWinsLabel.Size = new System.Drawing.Size(97, 15);
            this.playerNumberOfWinsLabel.TabIndex = 10;
            this.playerNumberOfWinsLabel.Text = "Number of Wins:";
            // 
            // playerNumberOfWinsTextBox
            // 
            this.playerNumberOfWinsTextBox.Location = new System.Drawing.Point(110, 295);
            this.playerNumberOfWinsTextBox.Name = "playerNumberOfWinsTextBox";
            this.playerNumberOfWinsTextBox.Size = new System.Drawing.Size(349, 23);
            this.playerNumberOfWinsTextBox.TabIndex = 11;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.playerDetailsGroupBox);
            this.Controls.Add(this.leaderBoardGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "ValorantRankedLeaderboardTracker";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.leaderBoardGroupBox.ResumeLayout(false);
            this.playerDetailsGroupBox.ResumeLayout(false);
            this.playerDetailsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox leaderBoardGroupBox;
        private System.Windows.Forms.ListView leaderBoardPlayersListBox;
        private System.Windows.Forms.GroupBox playerDetailsGroupBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label playerPuuidLabel;
        private System.Windows.Forms.TextBox playerGameNameTextBox;
        private System.Windows.Forms.Label playerGameNameLabel;
        private System.Windows.Forms.TextBox playerRankTextBox;
        private System.Windows.Forms.Label playerRankLabel;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label playerTagLineLabel;
        private System.Windows.Forms.TextBox playerRankedRatingTextBox;
        private System.Windows.Forms.Label playerRankedRatingLabel;
        private System.Windows.Forms.TextBox playerNumberOfWinsTextBox;
        private System.Windows.Forms.Label playerNumberOfWinsLabel;
    }
}

