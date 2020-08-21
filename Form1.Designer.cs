using System.Drawing;

namespace Practice_game_2
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pbPlayer = new System.Windows.Forms.PictureBox();
            this.tmrUp = new System.Windows.Forms.Timer(this.components);
            this.tmrRight = new System.Windows.Forms.Timer(this.components);
            this.tmrLeft = new System.Windows.Forms.Timer(this.components);
            this.tmrGravity = new System.Windows.Forms.Timer(this.components);
            this.tmrGameLoop = new System.Timers.Timer();
            this.lbScore = new System.Windows.Forms.Label();
            this.tmrHit = new System.Windows.Forms.Timer(this.components);
            this.lbHealth = new System.Windows.Forms.Label();
            this.pbHealth = new System.Windows.Forms.ProgressBar();
            this.lbLevel = new System.Windows.Forms.Label();
            this.lbInstructions = new System.Windows.Forms.Label();
            this.lbScoreChange = new System.Windows.Forms.Label();
            this.tmrScoreChange = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tmrGameLoop)).BeginInit();
            this.SuspendLayout();
            // 
            // pbPlayer
            // 
            this.pbPlayer.BackColor = System.Drawing.Color.Transparent;
            this.pbPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbPlayer.Image = ((System.Drawing.Image)(resources.GetObject("pbPlayer.Image")));
            this.pbPlayer.Location = new System.Drawing.Point(125, 527);
            this.pbPlayer.Name = "pbPlayer";
            this.pbPlayer.Size = new System.Drawing.Size(30, 30);
            this.pbPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPlayer.TabIndex = 0;
            this.pbPlayer.TabStop = false;
            // 
            // tmrUp
            // 
            this.tmrUp.Interval = 5;
            this.tmrUp.Tick += new System.EventHandler(this.tmrUp_Tick);
            // 
            // tmrRight
            // 
            this.tmrRight.Interval = 1;
            this.tmrRight.Tick += new System.EventHandler(this.tmrRight_Tick);
            // 
            // tmrLeft
            // 
            this.tmrLeft.Interval = 1;
            this.tmrLeft.Tick += new System.EventHandler(this.tmrLeft_Tick);
            // 
            // tmrGravity
            // 
            this.tmrGravity.Enabled = true;
            this.tmrGravity.Interval = 1;
            this.tmrGravity.Tick += new System.EventHandler(this.tmrGravity_Tick);
            // 
            // tmrGameLoop
            // 
            this.tmrGameLoop.Enabled = true;
            this.tmrGameLoop.Interval = 10D;
            this.tmrGameLoop.SynchronizingObject = this;
            this.tmrGameLoop.Elapsed += new System.Timers.ElapsedEventHandler(this.tmrGameLoop_Elapsed);
            // 
            // lbScore
            // 
            this.lbScore.AutoSize = true;
            this.lbScore.BackColor = System.Drawing.Color.Transparent;
            this.lbScore.Font = new System.Drawing.Font("Snap ITC", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbScore.Location = new System.Drawing.Point(12, 57);
            this.lbScore.MaximumSize = new System.Drawing.Size(190, 100);
            this.lbScore.MinimumSize = new System.Drawing.Size(130, 31);
            this.lbScore.Name = "lbScore";
            this.lbScore.Size = new System.Drawing.Size(130, 31);
            this.lbScore.TabIndex = 1;
            this.lbScore.Text = "Score: ";
            // 
            // tmrHit
            // 
            this.tmrHit.Interval = 1000;
            this.tmrHit.Tick += new System.EventHandler(this.tmrHit_Tick);
            // 
            // lbHealth
            // 
            this.lbHealth.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.lbHealth.AutoSize = true;
            this.lbHealth.BackColor = System.Drawing.Color.Transparent;
            this.lbHealth.Font = new System.Drawing.Font("Snap ITC", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHealth.Location = new System.Drawing.Point(12, 93);
            this.lbHealth.MaximumSize = new System.Drawing.Size(170, 100);
            this.lbHealth.Name = "lbHealth";
            this.lbHealth.Size = new System.Drawing.Size(98, 31);
            this.lbHealth.TabIndex = 3;
            this.lbHealth.Text = "Life: ";
            // 
            // pbHealth
            // 
            this.pbHealth.BackColor = System.Drawing.Color.Red;
            this.pbHealth.ForeColor = System.Drawing.Color.Black;
            this.pbHealth.Location = new System.Drawing.Point(154, 93);
            this.pbHealth.MarqueeAnimationSpeed = 10;
            this.pbHealth.Maximum = 5;
            this.pbHealth.Name = "pbHealth";
            this.pbHealth.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pbHealth.RightToLeftLayout = true;
            this.pbHealth.Size = new System.Drawing.Size(102, 31);
            this.pbHealth.Step = 1;
            this.pbHealth.TabIndex = 2;
            // 
            // lbLevel
            // 
            this.lbLevel.AutoSize = true;
            this.lbLevel.BackColor = System.Drawing.Color.Transparent;
            this.lbLevel.Font = new System.Drawing.Font("Snap ITC", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLevel.Location = new System.Drawing.Point(12, 20);
            this.lbLevel.MaximumSize = new System.Drawing.Size(190, 100);
            this.lbLevel.MinimumSize = new System.Drawing.Size(130, 31);
            this.lbLevel.Name = "lbLevel";
            this.lbLevel.Size = new System.Drawing.Size(130, 31);
            this.lbLevel.TabIndex = 4;
            this.lbLevel.Text = "Level: 1";
            // 
            // lbInstructions
            // 
            this.lbInstructions.AutoSize = true;
            this.lbInstructions.BackColor = System.Drawing.Color.Transparent;
            this.lbInstructions.Font = new System.Drawing.Font("Modern No. 20", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInstructions.ForeColor = System.Drawing.Color.ForestGreen;
            this.lbInstructions.Location = new System.Drawing.Point(389, 281);
            this.lbInstructions.MaximumSize = new System.Drawing.Size(400, 100);
            this.lbInstructions.MinimumSize = new System.Drawing.Size(400, 100);
            this.lbInstructions.Name = "lbInstructions";
            this.lbInstructions.Size = new System.Drawing.Size(400, 100);
            this.lbInstructions.TabIndex = 5;
            this.lbInstructions.Text = "Collect all Flames to reach next level!";
            // 
            // lbScoreChange
            // 
            this.lbScoreChange.AutoSize = true;
            this.lbScoreChange.BackColor = System.Drawing.Color.Transparent;
            this.lbScoreChange.Font = new System.Drawing.Font("Snap ITC", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbScoreChange.ForeColor = System.Drawing.Color.ForestGreen;
            this.lbScoreChange.Location = new System.Drawing.Point(189, 57);
            this.lbScoreChange.MaximumSize = new System.Drawing.Size(190, 100);
            this.lbScoreChange.MinimumSize = new System.Drawing.Size(130, 31);
            this.lbScoreChange.Name = "lbScoreChange";
            this.lbScoreChange.Size = new System.Drawing.Size(130, 31);
            this.lbScoreChange.TabIndex = 6;
            this.lbScoreChange.Text = "+1";
            this.lbScoreChange.Visible = false;
            // 
            // tmrScoreChange
            // 
            this.tmrScoreChange.Interval = 300;
            this.tmrScoreChange.Tick += new System.EventHandler(this.tmrScoreChange_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.lbScoreChange);
            this.Controls.Add(this.lbInstructions);
            this.Controls.Add(this.lbLevel);
            this.Controls.Add(this.lbHealth);
            this.Controls.Add(this.pbHealth);
            this.Controls.Add(this.lbScore);
            this.Controls.Add(this.pbPlayer);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1200, 800);
            this.MinimumSize = new System.Drawing.Size(1200, 800);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tmrGameLoop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPlayer;
        private System.Windows.Forms.Timer tmrUp;
        private System.Windows.Forms.Timer tmrRight;
        private System.Windows.Forms.Timer tmrLeft;
        private System.Windows.Forms.Timer tmrGravity;
        private System.Timers.Timer tmrGameLoop;
        private System.Windows.Forms.Label lbScore;
        private System.Windows.Forms.Timer tmrHit;
        private System.Windows.Forms.Label lbHealth;
        private System.Windows.Forms.ProgressBar pbHealth;
        private System.Windows.Forms.Label lbLevel;
        private System.Windows.Forms.Label lbInstructions;
        private System.Windows.Forms.Label lbScoreChange;
        private System.Windows.Forms.Timer tmrScoreChange;
    }
}

