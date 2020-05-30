namespace ProLab
{
    partial class Player
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelMovie = new System.Windows.Forms.Label();
            this.btnRating = new System.Windows.Forms.Button();
            this.movieRating = new System.Windows.Forms.TextBox();
            this.Rating = new System.Windows.Forms.Label();
            this.panelPlayer = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.timerMovie = new System.Windows.Forms.Timer(this.components);
            this.btnPlay = new System.Windows.Forms.PictureBox();
            this.btnPause = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panelPlayer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelMovie);
            this.panel1.Controls.Add(this.btnRating);
            this.panel1.Controls.Add(this.movieRating);
            this.panel1.Controls.Add(this.Rating);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(618, 65);
            this.panel1.TabIndex = 9;
            // 
            // labelMovie
            // 
            this.labelMovie.AutoSize = true;
            this.labelMovie.BackColor = System.Drawing.Color.Black;
            this.labelMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMovie.ForeColor = System.Drawing.Color.White;
            this.labelMovie.Location = new System.Drawing.Point(97, 24);
            this.labelMovie.Name = "labelMovie";
            this.labelMovie.Size = new System.Drawing.Size(125, 25);
            this.labelMovie.TabIndex = 14;
            this.labelMovie.Text = "movieName";
            // 
            // btnRating
            // 
            this.btnRating.Location = new System.Drawing.Point(535, 25);
            this.btnRating.Name = "btnRating";
            this.btnRating.Size = new System.Drawing.Size(58, 30);
            this.btnRating.TabIndex = 10;
            this.btnRating.Text = "Apply";
            this.btnRating.UseVisualStyleBackColor = true;
            this.btnRating.Click += new System.EventHandler(this.btnRating_Click);
            // 
            // movieRating
            // 
            this.movieRating.BackColor = System.Drawing.Color.Black;
            this.movieRating.ForeColor = System.Drawing.Color.White;
            this.movieRating.Location = new System.Drawing.Point(503, 30);
            this.movieRating.Name = "movieRating";
            this.movieRating.Size = new System.Drawing.Size(26, 20);
            this.movieRating.TabIndex = 9;
            // 
            // Rating
            // 
            this.Rating.AutoSize = true;
            this.Rating.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rating.ForeColor = System.Drawing.Color.White;
            this.Rating.Location = new System.Drawing.Point(423, 25);
            this.Rating.Name = "Rating";
            this.Rating.Size = new System.Drawing.Size(74, 25);
            this.Rating.TabIndex = 8;
            this.Rating.Text = "Rating";
            // 
            // panelPlayer
            // 
            this.panelPlayer.Controls.Add(this.label1);
            this.panelPlayer.Controls.Add(this.labelTime);
            this.panelPlayer.Controls.Add(this.btnPlay);
            this.panelPlayer.Controls.Add(this.btnPause);
            this.panelPlayer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelPlayer.Location = new System.Drawing.Point(0, 569);
            this.panelPlayer.Name = "panelPlayer";
            this.panelPlayer.Size = new System.Drawing.Size(618, 53);
            this.panelPlayer.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "label1";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.ForeColor = System.Drawing.Color.White;
            this.labelTime.Location = new System.Drawing.Point(456, 10);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(120, 31);
            this.labelTime.TabIndex = 12;
            this.labelTime.Text = "00:00:00";
            this.labelTime.Click += new System.EventHandler(this.labelTime_Click);
            // 
            // timerMovie
            // 
            this.timerMovie.Interval = 1000;
            this.timerMovie.Tick += new System.EventHandler(this.timerMovie_Tick);
            // 
            // btnPlay
            // 
            this.btnPlay.Image = global::ProLab.Properties.Resources.playButton;
            this.btnPlay.Location = new System.Drawing.Point(255, 0);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(50, 50);
            this.btnPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnPlay.TabIndex = 10;
            this.btnPlay.TabStop = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnPause
            // 
            this.btnPause.Image = global::ProLab.Properties.Resources.pauseButton;
            this.btnPause.Location = new System.Drawing.Point(311, 0);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(50, 50);
            this.btnPause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnPause.TabIndex = 11;
            this.btnPause.TabStop = false;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnBack
            // 
            this.btnBack.Image = global::ProLab.Properties.Resources.back;
            this.btnBack.Location = new System.Drawing.Point(12, 14);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(49, 41);
            this.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnBack.TabIndex = 7;
            this.btnBack.TabStop = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(618, 622);
            this.Controls.Add(this.panelPlayer);
            this.Controls.Add(this.panel1);
            this.Name = "Player";
            this.Text = "Player";
            this.Load += new System.EventHandler(this.Player_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelPlayer.ResumeLayout(false);
            this.panelPlayer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnBack;
        private System.Windows.Forms.PictureBox btnPlay;
        private System.Windows.Forms.PictureBox btnPause;
        private System.Windows.Forms.Panel panelPlayer;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelMovie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Rating;
        private System.Windows.Forms.Button btnRating;
        private System.Windows.Forms.TextBox movieRating;
        private System.Windows.Forms.Timer timerMovie;
    }
}