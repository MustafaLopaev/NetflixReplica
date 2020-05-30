namespace ProLab
{
    partial class Drama
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelDrama = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnBiziHatirla = new System.Windows.Forms.PictureBox();
            this.btnDangal = new System.Windows.Forms.PictureBox();
            this.btnDelibal = new System.Windows.Forms.PictureBox();
            this.btnKardesimBenim = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBiziHatirla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDangal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelibal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnKardesimBenim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelDrama);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(618, 69);
            this.panel1.TabIndex = 8;
            // 
            // labelDrama
            // 
            this.labelDrama.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDrama.AutoSize = true;
            this.labelDrama.BackColor = System.Drawing.Color.Black;
            this.labelDrama.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelDrama.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDrama.ForeColor = System.Drawing.Color.Red;
            this.labelDrama.Location = new System.Drawing.Point(257, 19);
            this.labelDrama.Name = "labelDrama";
            this.labelDrama.Size = new System.Drawing.Size(95, 31);
            this.labelDrama.TabIndex = 8;
            this.labelDrama.Text = "Drama";
            this.labelDrama.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnBiziHatirla);
            this.flowLayoutPanel1.Controls.Add(this.btnDangal);
            this.flowLayoutPanel1.Controls.Add(this.btnDelibal);
            this.flowLayoutPanel1.Controls.Add(this.btnKardesimBenim);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 69);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(618, 553);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // btnBiziHatirla
            // 
            this.btnBiziHatirla.Image = global::ProLab.Properties.Resources.BiziHatirla;
            this.btnBiziHatirla.Location = new System.Drawing.Point(3, 3);
            this.btnBiziHatirla.Name = "btnBiziHatirla";
            this.btnBiziHatirla.Size = new System.Drawing.Size(200, 200);
            this.btnBiziHatirla.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnBiziHatirla.TabIndex = 0;
            this.btnBiziHatirla.TabStop = false;
            this.btnBiziHatirla.Click += new System.EventHandler(this.btnBiziHatirla_Click);
            // 
            // btnDangal
            // 
            this.btnDangal.Image = global::ProLab.Properties.Resources.Dangal;
            this.btnDangal.Location = new System.Drawing.Point(209, 3);
            this.btnDangal.Name = "btnDangal";
            this.btnDangal.Size = new System.Drawing.Size(200, 200);
            this.btnDangal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnDangal.TabIndex = 1;
            this.btnDangal.TabStop = false;
            this.btnDangal.Click += new System.EventHandler(this.btnDangal_Click);
            // 
            // btnDelibal
            // 
            this.btnDelibal.Image = global::ProLab.Properties.Resources.Delibal;
            this.btnDelibal.Location = new System.Drawing.Point(415, 3);
            this.btnDelibal.Name = "btnDelibal";
            this.btnDelibal.Size = new System.Drawing.Size(200, 200);
            this.btnDelibal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnDelibal.TabIndex = 2;
            this.btnDelibal.TabStop = false;
            this.btnDelibal.Click += new System.EventHandler(this.btnDelibal_Click);
            // 
            // btnKardesimBenim
            // 
            this.btnKardesimBenim.Image = global::ProLab.Properties.Resources.KardesimBenim;
            this.btnKardesimBenim.Location = new System.Drawing.Point(3, 209);
            this.btnKardesimBenim.Name = "btnKardesimBenim";
            this.btnKardesimBenim.Size = new System.Drawing.Size(200, 200);
            this.btnKardesimBenim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnKardesimBenim.TabIndex = 3;
            this.btnKardesimBenim.TabStop = false;
            this.btnKardesimBenim.Click += new System.EventHandler(this.btnKardesimBenim_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProLab.Properties.Resources.back;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Drama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(618, 622);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "Drama";
            this.Text = "Drama";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnBiziHatirla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDangal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelibal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnKardesimBenim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelDrama;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox btnBiziHatirla;
        private System.Windows.Forms.PictureBox btnDangal;
        private System.Windows.Forms.PictureBox btnDelibal;
        private System.Windows.Forms.PictureBox btnKardesimBenim;
    }
}