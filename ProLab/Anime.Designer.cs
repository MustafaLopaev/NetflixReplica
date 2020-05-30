namespace ProLab
{
    partial class Anime
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnBeyblade = new System.Windows.Forms.PictureBox();
            this.btnSonic = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelAnime = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBeyblade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSonic)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnBeyblade);
            this.flowLayoutPanel1.Controls.Add(this.btnSonic);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 69);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(618, 553);
            this.flowLayoutPanel1.TabIndex = 13;
            // 
            // btnBeyblade
            // 
            this.btnBeyblade.Image = global::ProLab.Properties.Resources.Beyblade;
            this.btnBeyblade.Location = new System.Drawing.Point(3, 3);
            this.btnBeyblade.Name = "btnBeyblade";
            this.btnBeyblade.Size = new System.Drawing.Size(200, 200);
            this.btnBeyblade.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnBeyblade.TabIndex = 0;
            this.btnBeyblade.TabStop = false;
            this.btnBeyblade.Click += new System.EventHandler(this.btnBeyblade_Click);
            // 
            // btnSonic
            // 
            this.btnSonic.Image = global::ProLab.Properties.Resources.SonicX;
            this.btnSonic.Location = new System.Drawing.Point(209, 3);
            this.btnSonic.Name = "btnSonic";
            this.btnSonic.Size = new System.Drawing.Size(200, 200);
            this.btnSonic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSonic.TabIndex = 1;
            this.btnSonic.TabStop = false;
            this.btnSonic.Click += new System.EventHandler(this.btnSonic_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelAnime);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(618, 69);
            this.panel1.TabIndex = 12;
            // 
            // labelAnime
            // 
            this.labelAnime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAnime.AutoSize = true;
            this.labelAnime.BackColor = System.Drawing.Color.Black;
            this.labelAnime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelAnime.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAnime.ForeColor = System.Drawing.Color.Red;
            this.labelAnime.Location = new System.Drawing.Point(253, 19);
            this.labelAnime.Name = "labelAnime";
            this.labelAnime.Size = new System.Drawing.Size(90, 31);
            this.labelAnime.TabIndex = 8;
            this.labelAnime.Text = "Anime";
            this.labelAnime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBack
            // 
            this.btnBack.Image = global::ProLab.Properties.Resources.back;
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(59, 38);
            this.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnBack.TabIndex = 7;
            this.btnBack.TabStop = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Anime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(618, 622);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "Anime";
            this.Text = "Anime";
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnBeyblade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSonic)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelAnime;
        private System.Windows.Forms.PictureBox btnBack;
        private System.Windows.Forms.PictureBox btnBeyblade;
        private System.Windows.Forms.PictureBox btnSonic;
    }
}