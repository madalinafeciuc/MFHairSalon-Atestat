
namespace Gestiune_Coafor
{
    partial class MainMenu
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.db_btn = new System.Windows.Forms.Button();
            this.credits_btn = new System.Windows.Forms.Button();
            this.exit_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = (System.Drawing.Image)global::Gestiune_Coafor.Properties.Resources.logo_mada_no_ellipse2;
            this.pictureBox1.Location = new System.Drawing.Point(207, 76);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(441, 324);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(223, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(405, 55);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bine ati venit la";
            // 
            // db_btn
            // 
            this.db_btn.BackColor = System.Drawing.Color.Transparent;
            this.db_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.db_btn.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.db_btn.Location = new System.Drawing.Point(291, 430);
            this.db_btn.Name = "db_btn";
            this.db_btn.Size = new System.Drawing.Size(279, 46);
            this.db_btn.TabIndex = 2;
            this.db_btn.Text = "Acces baza de date";
            this.db_btn.UseVisualStyleBackColor = false;
            this.db_btn.Click += new System.EventHandler(this.db_btn_Click);
            // 
            // credits_btn
            // 
            this.credits_btn.BackColor = System.Drawing.Color.Transparent;
            this.credits_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.credits_btn.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.credits_btn.Location = new System.Drawing.Point(291, 497);
            this.credits_btn.Name = "credits_btn";
            this.credits_btn.Size = new System.Drawing.Size(279, 46);
            this.credits_btn.TabIndex = 2;
            this.credits_btn.Text = "Credite";
            this.credits_btn.UseVisualStyleBackColor = false;
            this.credits_btn.Click += new System.EventHandler(this.credits_btn_Click);
            // 
            // exit_btn
            // 
            this.exit_btn.BackColor = System.Drawing.Color.Transparent;
            this.exit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_btn.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.exit_btn.Location = new System.Drawing.Point(291, 560);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(279, 46);
            this.exit_btn.TabIndex = 2;
            this.exit_btn.Text = "Iesire";
            this.exit_btn.UseVisualStyleBackColor = false;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Plum;
            this.BackgroundImage = (System.Drawing.Image)global::Gestiune_Coafor.Properties.Resources.background_mada;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(835, 618);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.credits_btn);
            this.Controls.Add(this.db_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestiune MF";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button db_btn;
        private System.Windows.Forms.Button credits_btn;
        private System.Windows.Forms.Button exit_btn;
    }
}

