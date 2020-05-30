namespace ProLab
{
    partial class CategoriesActivity
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
            this.checkBoxMovies = new System.Windows.Forms.CheckedListBox();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkBoxMovies
            // 
            this.checkBoxMovies.BackColor = System.Drawing.Color.Black;
            this.checkBoxMovies.ForeColor = System.Drawing.Color.White;
            this.checkBoxMovies.FormattingEnabled = true;
            this.checkBoxMovies.Items.AddRange(new object[] {
            "Aksiyon",
            "Belgesel",
            "Bilim Kurgu",
            "Fantastik Yapımlar",
            "Bilim ve Doğa",
            "Çocuk ve Aile",
            "Dramalar",
            "Gerilim",
            "Komedi",
            "Korku",
            "Romantizm"});
            this.checkBoxMovies.Location = new System.Drawing.Point(362, 215);
            this.checkBoxMovies.Name = "checkBoxMovies";
            this.checkBoxMovies.Size = new System.Drawing.Size(133, 184);
            this.checkBoxMovies.TabIndex = 0;
            // 
            // btnSignUp
            // 
            this.btnSignUp.BackColor = System.Drawing.Color.Gray;
            this.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignUp.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUp.ForeColor = System.Drawing.Color.White;
            this.btnSignUp.Location = new System.Drawing.Point(362, 405);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(133, 32);
            this.btnSignUp.TabIndex = 3;
            this.btnSignUp.Text = "Sign Up";
            this.btnSignUp.UseVisualStyleBackColor = false;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // CategoriesActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(834, 661);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.checkBoxMovies);
            this.Name = "CategoriesActivity";
            this.Text = "CategoriesActivity";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkBoxMovies;
        private System.Windows.Forms.Button btnSignUp;
    }
}