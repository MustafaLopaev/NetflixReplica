namespace ProLab
{
    partial class Thriller
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelThriller = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.PictureBox();
            this.btnCriminal = new System.Windows.Forms.PictureBox();
            this.btnBlacklist = new System.Windows.Forms.PictureBox();
            this.btnJaws = new System.Windows.Forms.PictureBox();
            this.btnDaVinciSifresi = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCriminal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBlacklist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnJaws)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDaVinciSifresi)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.btnCriminal);
            this.flowLayoutPanel1.Controls.Add(this.btnBlacklist);
            this.flowLayoutPanel1.Controls.Add(this.btnJaws);
            this.flowLayoutPanel1.Controls.Add(this.btnDaVinciSifresi);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(618, 622);
            this.flowLayoutPanel1.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelThriller);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(618, 69);
            this.panel1.TabIndex = 9;
            // 
            // labelThriller
            // 
            this.labelThriller.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelThriller.AutoSize = true;
            this.labelThriller.BackColor = System.Drawing.Color.Black;
            this.labelThriller.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelThriller.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelThriller.ForeColor = System.Drawing.Color.Red;
            this.labelThriller.Location = new System.Drawing.Point(257, 19);
            this.labelThriller.Name = "labelThriller";
            this.labelThriller.Size = new System.Drawing.Size(97, 31);
            this.labelThriller.TabIndex = 8;
            this.labelThriller.Text = "Thriller";
            this.labelThriller.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // btnCriminal
            // 
            this.btnCriminal.Image = global::ProLab.Properties.Resources.Criminal;
            this.btnCriminal.Location = new System.Drawing.Point(2, 77);
            this.btnCriminal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCriminal.Name = "btnCriminal";
            this.btnCriminal.Size = new System.Drawing.Size(200, 200);
            this.btnCriminal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCriminal.TabIndex = 11;
            this.btnCriminal.TabStop = false;
            this.btnCriminal.Click += new System.EventHandler(this.btnCriminal_Click);
            // 
            // btnBlacklist
            // 
            this.btnBlacklist.Image = global::ProLab.Properties.Resources.BlackList;
            this.btnBlacklist.Location = new System.Drawing.Point(206, 77);
            this.btnBlacklist.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBlacklist.Name = "btnBlacklist";
            this.btnBlacklist.Size = new System.Drawing.Size(200, 200);
            this.btnBlacklist.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnBlacklist.TabIndex = 12;
            this.btnBlacklist.TabStop = false;
            this.btnBlacklist.Click += new System.EventHandler(this.btnBlacklist_Click);
            // 
            // btnJaws
            // 
            this.btnJaws.Image = global::ProLab.Properties.Resources.Jaws;
            this.btnJaws.Location = new System.Drawing.Point(410, 77);
            this.btnJaws.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnJaws.Name = "btnJaws";
            this.btnJaws.Size = new System.Drawing.Size(200, 200);
            this.btnJaws.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnJaws.TabIndex = 13;
            this.btnJaws.TabStop = false;
            this.btnJaws.Click += new System.EventHandler(this.btnJaws_Click);
            // 
            // btnDaVinciSifresi
            // 
            this.btnDaVinciSifresi.Image = global::ProLab.Properties.Resources.DaVinciSifresi;
            this.btnDaVinciSifresi.Location = new System.Drawing.Point(2, 281);
            this.btnDaVinciSifresi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDaVinciSifresi.Name = "btnDaVinciSifresi";
            this.btnDaVinciSifresi.Size = new System.Drawing.Size(200, 200);
            this.btnDaVinciSifresi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnDaVinciSifresi.TabIndex = 14;
            this.btnDaVinciSifresi.TabStop = false;
            this.btnDaVinciSifresi.Click += new System.EventHandler(this.btnDaVinciSifresi_Click);
            // 
            // Thriller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 622);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Thriller";
            this.Text = "Thriller";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCriminal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBlacklist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnJaws)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDaVinciSifresi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelThriller;
        private System.Windows.Forms.PictureBox btnBack;
        private System.Windows.Forms.PictureBox btnCriminal;
        private System.Windows.Forms.PictureBox btnBlacklist;
        private System.Windows.Forms.PictureBox btnJaws;
        private System.Windows.Forms.PictureBox btnDaVinciSifresi;
    }
}