
namespace Gestiune_Coafor
{
    partial class Furnizori
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.locatie_txtBox = new System.Windows.Forms.TextBox();
            this.numeProdus_txtBox = new System.Windows.Forms.TextBox();
            this.nume_furnizor = new System.Windows.Forms.TextBox();
            this.back_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.save_btn = new System.Windows.Forms.Button();
            this.add_btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.furnizoriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mFdbDataSet1 = new Gestiune_Coafor.MFdbDataSet1();
            this.refresh_btn = new System.Windows.Forms.Button();
            this.furnizoriTableAdapter = new Gestiune_Coafor.MFdbDataSet1TableAdapters.FurnizoriTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Id_txtBox = new System.Windows.Forms.TextBox();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numefurnizorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produsefurnizorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locatieSediuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.furnizoriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mFdbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(675, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 18);
            this.label3.TabIndex = 36;
            this.label3.Text = "Locatie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(426, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 18);
            this.label2.TabIndex = 35;
            this.label2.Text = "Produse furnizor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(228, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 18);
            this.label1.TabIndex = 34;
            this.label1.Text = "Nume furnizor";
            // 
            // locatie_txtBox
            // 
            this.locatie_txtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locatie_txtBox.Location = new System.Drawing.Point(599, 42);
            this.locatie_txtBox.Name = "locatie_txtBox";
            this.locatie_txtBox.Size = new System.Drawing.Size(215, 29);
            this.locatie_txtBox.TabIndex = 30;
            // 
            // numeProdus_txtBox
            // 
            this.numeProdus_txtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeProdus_txtBox.Location = new System.Drawing.Point(371, 42);
            this.numeProdus_txtBox.Name = "numeProdus_txtBox";
            this.numeProdus_txtBox.Size = new System.Drawing.Size(222, 29);
            this.numeProdus_txtBox.TabIndex = 29;
            // 
            // nume_furnizor
            // 
            this.nume_furnizor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nume_furnizor.Location = new System.Drawing.Point(167, 42);
            this.nume_furnizor.Name = "nume_furnizor";
            this.nume_furnizor.Size = new System.Drawing.Size(198, 29);
            this.nume_furnizor.TabIndex = 28;
            // 
            // back_btn
            // 
            this.back_btn.BackColor = System.Drawing.Color.Transparent;
            this.back_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_btn.Location = new System.Drawing.Point(832, 630);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(103, 102);
            this.back_btn.TabIndex = 26;
            this.back_btn.Text = "Inapoi";
            this.back_btn.UseVisualStyleBackColor = false;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.BackColor = System.Drawing.Color.Transparent;
            this.delete_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_btn.Location = new System.Drawing.Point(832, 438);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(103, 102);
            this.delete_btn.TabIndex = 25;
            this.delete_btn.Text = "Stergere";
            this.delete_btn.UseVisualStyleBackColor = false;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // save_btn
            // 
            this.save_btn.BackColor = System.Drawing.Color.Transparent;
            this.save_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_btn.Location = new System.Drawing.Point(832, 244);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(103, 102);
            this.save_btn.TabIndex = 24;
            this.save_btn.Text = "Salvare";
            this.save_btn.UseVisualStyleBackColor = false;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // add_btn
            // 
            this.add_btn.BackColor = System.Drawing.Color.Transparent;
            this.add_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_btn.Location = new System.Drawing.Point(832, 92);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(103, 102);
            this.add_btn.TabIndex = 23;
            this.add_btn.Text = "Adauga";
            this.add_btn.UseVisualStyleBackColor = false;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.numefurnizorDataGridViewTextBoxColumn,
            this.produsefurnizorDataGridViewTextBoxColumn,
            this.locatieSediuDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.furnizoriBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(802, 659);
            this.dataGridView1.TabIndex = 27;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // furnizoriBindingSource
            // 
            this.furnizoriBindingSource.DataMember = "Furnizori";
            this.furnizoriBindingSource.DataSource = this.mFdbDataSet1;
            // 
            // mFdbDataSet1
            // 
            this.mFdbDataSet1.DataSetName = "MFdbDataSet1";
            this.mFdbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // refresh_btn
            // 
            this.refresh_btn.BackColor = System.Drawing.Color.Transparent;
            this.refresh_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refresh_btn.Location = new System.Drawing.Point(12, 15);
            this.refresh_btn.Name = "refresh_btn";
            this.refresh_btn.Size = new System.Drawing.Size(73, 56);
            this.refresh_btn.TabIndex = 22;
            this.refresh_btn.Text = "Refresh";
            this.refresh_btn.UseVisualStyleBackColor = false;
            this.refresh_btn.Click += new System.EventHandler(this.refresh_btn_Click);
            // 
            // furnizoriTableAdapter
            // 
            this.furnizoriTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::Gestiune_Coafor.Properties.Resources.logo_mada_no_ellipse2;
            this.pictureBox1.Location = new System.Drawing.Point(852, -6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(136, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // Id_txtBox
            // 
            this.Id_txtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Id_txtBox.Location = new System.Drawing.Point(84, 42);
            this.Id_txtBox.Name = "Id_txtBox";
            this.Id_txtBox.Size = new System.Drawing.Size(77, 29);
            this.Id_txtBox.TabIndex = 30;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numefurnizorDataGridViewTextBoxColumn
            // 
            this.numefurnizorDataGridViewTextBoxColumn.DataPropertyName = "Nume_furnizor";
            this.numefurnizorDataGridViewTextBoxColumn.HeaderText = "Nume_furnizor";
            this.numefurnizorDataGridViewTextBoxColumn.Name = "numefurnizorDataGridViewTextBoxColumn";
            this.numefurnizorDataGridViewTextBoxColumn.Width = 210;
            // 
            // produsefurnizorDataGridViewTextBoxColumn
            // 
            this.produsefurnizorDataGridViewTextBoxColumn.DataPropertyName = "Produse_furnizor";
            this.produsefurnizorDataGridViewTextBoxColumn.HeaderText = "Produse_furnizor";
            this.produsefurnizorDataGridViewTextBoxColumn.Name = "produsefurnizorDataGridViewTextBoxColumn";
            this.produsefurnizorDataGridViewTextBoxColumn.Width = 230;
            // 
            // locatieSediuDataGridViewTextBoxColumn
            // 
            this.locatieSediuDataGridViewTextBoxColumn.DataPropertyName = "Locatie_Sediu";
            this.locatieSediuDataGridViewTextBoxColumn.HeaderText = "Locatie_Sediu";
            this.locatieSediuDataGridViewTextBoxColumn.Name = "locatieSediuDataGridViewTextBoxColumn";
            this.locatieSediuDataGridViewTextBoxColumn.Width = 220;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(101, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 18);
            this.label4.TabIndex = 36;
            this.label4.Text = "ID";
            // 
            // Furnizori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Gestiune_Coafor.Properties.Resources.background_mada;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(967, 745);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Id_txtBox);
            this.Controls.Add(this.locatie_txtBox);
            this.Controls.Add(this.numeProdus_txtBox);
            this.Controls.Add(this.nume_furnizor);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.refresh_btn);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Furnizori";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Furnizori";
            this.Load += new System.EventHandler(this.Furnizori_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.furnizoriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mFdbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox locatie_txtBox;
        private System.Windows.Forms.TextBox numeProdus_txtBox;
        private System.Windows.Forms.TextBox nume_furnizor;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button refresh_btn;
        private MFdbDataSet1 mFdbDataSet1;
        private System.Windows.Forms.BindingSource furnizoriBindingSource;
        private MFdbDataSet1TableAdapters.FurnizoriTableAdapter furnizoriTableAdapter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox Id_txtBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numefurnizorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn produsefurnizorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locatieSediuDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label4;
    }
}