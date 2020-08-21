namespace Practice_game_2
{
    partial class End_Screen
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
            this.lbEndText = new System.Windows.Forms.Label();
            this.btnRestartLevel = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnRestartGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbEndText
            // 
            this.lbEndText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbEndText.AutoEllipsis = true;
            this.lbEndText.AutoSize = true;
            this.lbEndText.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEndText.Location = new System.Drawing.Point(70, 30);
            this.lbEndText.MinimumSize = new System.Drawing.Size(600, 200);
            this.lbEndText.Name = "lbEndText";
            this.lbEndText.Size = new System.Drawing.Size(600, 200);
            this.lbEndText.TabIndex = 0;
            this.lbEndText.Text = "Game Over!";
            this.lbEndText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRestartLevel
            // 
            this.btnRestartLevel.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnRestartLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestartLevel.Location = new System.Drawing.Point(12, 253);
            this.btnRestartLevel.Name = "btnRestartLevel";
            this.btnRestartLevel.Size = new System.Drawing.Size(224, 62);
            this.btnRestartLevel.TabIndex = 0;
            this.btnRestartLevel.Text = "Restart Level";
            this.btnRestartLevel.UseVisualStyleBackColor = false;
            this.btnRestartLevel.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.Color.Red;
            this.btnQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnQuit.Location = new System.Drawing.Point(551, 253);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(172, 62);
            this.btnQuit.TabIndex = 2;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnRestartGame
            // 
            this.btnRestartGame.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnRestartGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestartGame.Location = new System.Drawing.Point(280, 253);
            this.btnRestartGame.Name = "btnRestartGame";
            this.btnRestartGame.Size = new System.Drawing.Size(224, 62);
            this.btnRestartGame.TabIndex = 1;
            this.btnRestartGame.Text = "Restart Game";
            this.btnRestartGame.UseVisualStyleBackColor = false;
            this.btnRestartGame.Click += new System.EventHandler(this.btnRestartGame_Click);
            // 
            // End_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 350);
            this.Controls.Add(this.btnRestartGame);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnRestartLevel);
            this.Controls.Add(this.lbEndText);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "End_Screen";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Game Over";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbEndText;
        private System.Windows.Forms.Button btnRestartLevel;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnRestartGame;
    }
}