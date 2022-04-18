
namespace Gestiune_Coafor
{
    partial class Programari
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nume_specialist_txtBox = new System.Windows.Forms.TextBox();
            this.serviciu_txtBox = new System.Windows.Forms.TextBox();
            this.data_txtBox = new System.Windows.Forms.TextBox();
            this.prenume_Client_txtBox = new System.Windows.Forms.TextBox();
            this.nume_client_txtBox = new System.Windows.Forms.TextBox();
            this.back_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.save_btn = new System.Windows.Forms.Button();
            this.add_btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.progrmariBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mFdbDataSet1 = new Gestiune_Coafor.MFdbDataSet1();
            this.refresh_btn = new System.Windows.Forms.Button();
            this.progrmariTableAdapter = new Gestiune_Coafor.MFdbDataSet1TableAdapters.ProgrmariTableAdapter();
            this.ora_txtBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pret_txtBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Id_txtBox = new System.Windows.Forms.TextBox();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeclientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenumeclientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviciuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numespecialistDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pretDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progrmariBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mFdbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(585, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 16);
            this.label5.TabIndex = 54;
            this.label5.Text = "Nume Specialist";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(489, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 18);
            this.label4.TabIndex = 53;
            this.label4.Text = "Serviciu";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(429, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 18);
            this.label3.TabIndex = 52;
            this.label3.Text = "Ora";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(224, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 18);
            this.label2.TabIndex = 51;
            this.label2.Text = "Prenume client";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(128, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 18);
            this.label1.TabIndex = 50;
            this.label1.Text = "Nume client";
            // 
            // nume_specialist_txtBox
            // 
            this.nume_specialist_txtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nume_specialist_txtBox.Location = new System.Drawing.Point(581, 39);
            this.nume_specialist_txtBox.Name = "nume_specialist_txtBox";
            this.nume_specialist_txtBox.Size = new System.Drawing.Size(101, 29);
            this.nume_specialist_txtBox.TabIndex = 48;
            // 
            // serviciu_txtBox
            // 
            this.serviciu_txtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serviciu_txtBox.Location = new System.Drawing.Point(476, 41);
            this.serviciu_txtBox.Name = "serviciu_txtBox";
            this.serviciu_txtBox.Size = new System.Drawing.Size(99, 29);
            this.serviciu_txtBox.TabIndex = 49;
            // 
            // data_txtBox
            // 
            this.data_txtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data_txtBox.Location = new System.Drawing.Point(331, 41);
            this.data_txtBox.Name = "data_txtBox";
            this.data_txtBox.Size = new System.Drawing.Size(90, 29);
            this.data_txtBox.TabIndex = 47;
            // 
            // prenume_Client_txtBox
            // 
            this.prenume_Client_txtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prenume_Client_txtBox.Location = new System.Drawing.Point(227, 41);
            this.prenume_Client_txtBox.Name = "prenume_Client_txtBox";
            this.prenume_Client_txtBox.Size = new System.Drawing.Size(98, 29);
            this.prenume_Client_txtBox.TabIndex = 46;
            // 
            // nume_client_txtBox
            // 
            this.nume_client_txtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nume_client_txtBox.Location = new System.Drawing.Point(123, 40);
            this.nume_client_txtBox.Name = "nume_client_txtBox";
            this.nume_client_txtBox.Size = new System.Drawing.Size(101, 29);
            this.nume_client_txtBox.TabIndex = 45;
            // 
            // back_btn
            // 
            this.back_btn.BackColor = System.Drawing.Color.Transparent;
            this.back_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_btn.Location = new System.Drawing.Point(832, 630);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(103, 102);
            this.back_btn.TabIndex = 43;
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
            this.delete_btn.TabIndex = 42;
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
            this.save_btn.TabIndex = 41;
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
            this.add_btn.TabIndex = 40;
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
            this.numeclientDataGridViewTextBoxColumn,
            this.prenumeclientDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn,
            this.oraDataGridViewTextBoxColumn,
            this.serviciuDataGridViewTextBoxColumn,
            this.numespecialistDataGridViewTextBoxColumn,
            this.pretDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.progrmariBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(32, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(745, 659);
            this.dataGridView1.TabIndex = 44;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // progrmariBindingSource
            // 
            this.progrmariBindingSource.DataMember = "Progrmari";
            this.progrmariBindingSource.DataSource = this.mFdbDataSet1;
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
            this.refresh_btn.Location = new System.Drawing.Point(32, 12);
            this.refresh_btn.Name = "refresh_btn";
            this.refresh_btn.Size = new System.Drawing.Size(73, 26);
            this.refresh_btn.TabIndex = 39;
            this.refresh_btn.Text = "Refresh";
            this.refresh_btn.UseVisualStyleBackColor = false;
            this.refresh_btn.Click += new System.EventHandler(this.refresh_btn_Click);
            // 
            // progrmariTableAdapter
            // 
            this.progrmariTableAdapter.ClearBeforeFill = true;
            // 
            // ora_txtBox
            // 
            this.ora_txtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ora_txtBox.Location = new System.Drawing.Point(425, 41);
            this.ora_txtBox.Name = "ora_txtBox";
            this.ora_txtBox.Size = new System.Drawing.Size(47, 29);
            this.ora_txtBox.TabIndex = 47;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(359, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 18);
            this.label6.TabIndex = 52;
            this.label6.Text = "Data";
            // 
            // pret_txtBox
            // 
            this.pret_txtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pret_txtBox.Location = new System.Drawing.Point(688, 40);
            this.pret_txtBox.Name = "pret_txtBox";
            this.pret_txtBox.Size = new System.Drawing.Size(79, 29);
            this.pret_txtBox.TabIndex = 47;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(712, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 18);
            this.label7.TabIndex = 52;
            this.label7.Text = "Pret";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::Gestiune_Coafor.Properties.Resources.logo_mada_no_ellipse2;
            this.pictureBox1.Location = new System.Drawing.Point(862, -9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(116, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 55;
            this.pictureBox1.TabStop = false;
            // 
            // Id_txtBox
            // 
            this.Id_txtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Id_txtBox.Location = new System.Drawing.Point(32, 39);
            this.Id_txtBox.Name = "Id_txtBox";
            this.Id_txtBox.Size = new System.Drawing.Size(85, 29);
            this.Id_txtBox.TabIndex = 47;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 50;
            // 
            // numeclientDataGridViewTextBoxColumn
            // 
            this.numeclientDataGridViewTextBoxColumn.DataPropertyName = "Nume_client";
            this.numeclientDataGridViewTextBoxColumn.HeaderText = "Nume_client";
            this.numeclientDataGridViewTextBoxColumn.Name = "numeclientDataGridViewTextBoxColumn";
            // 
            // prenumeclientDataGridViewTextBoxColumn
            // 
            this.prenumeclientDataGridViewTextBoxColumn.DataPropertyName = "Prenume_client";
            this.prenumeclientDataGridViewTextBoxColumn.HeaderText = "Prenume_client";
            this.prenumeclientDataGridViewTextBoxColumn.Name = "prenumeclientDataGridViewTextBoxColumn";
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "Data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            // 
            // oraDataGridViewTextBoxColumn
            // 
            this.oraDataGridViewTextBoxColumn.DataPropertyName = "Ora";
            this.oraDataGridViewTextBoxColumn.HeaderText = "Ora";
            this.oraDataGridViewTextBoxColumn.Name = "oraDataGridViewTextBoxColumn";
            this.oraDataGridViewTextBoxColumn.Width = 50;
            // 
            // serviciuDataGridViewTextBoxColumn
            // 
            this.serviciuDataGridViewTextBoxColumn.DataPropertyName = "Serviciu";
            this.serviciuDataGridViewTextBoxColumn.HeaderText = "Serviciu";
            this.serviciuDataGridViewTextBoxColumn.Name = "serviciuDataGridViewTextBoxColumn";
            // 
            // numespecialistDataGridViewTextBoxColumn
            // 
            this.numespecialistDataGridViewTextBoxColumn.DataPropertyName = "Nume_specialist";
            this.numespecialistDataGridViewTextBoxColumn.HeaderText = "Nume_specialist";
            this.numespecialistDataGridViewTextBoxColumn.Name = "numespecialistDataGridViewTextBoxColumn";
            // 
            // pretDataGridViewTextBoxColumn
            // 
            this.pretDataGridViewTextBoxColumn.DataPropertyName = "Pret";
            this.pretDataGridViewTextBoxColumn.HeaderText = "Pret";
            this.pretDataGridViewTextBoxColumn.Name = "pretDataGridViewTextBoxColumn";
            // 
            // Programari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Gestiune_Coafor.Properties.Resources.background_mada;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(967, 745);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pret_txtBox);
            this.Controls.Add(this.Id_txtBox);
            this.Controls.Add(this.ora_txtBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nume_specialist_txtBox);
            this.Controls.Add(this.serviciu_txtBox);
            this.Controls.Add(this.data_txtBox);
            this.Controls.Add(this.prenume_Client_txtBox);
            this.Controls.Add(this.nume_client_txtBox);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.refresh_btn);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Programari";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Programari";
            this.Load += new System.EventHandler(this.Programari_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progrmariBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mFdbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nume_specialist_txtBox;
        private System.Windows.Forms.TextBox serviciu_txtBox;
        private System.Windows.Forms.TextBox data_txtBox;
        private System.Windows.Forms.TextBox prenume_Client_txtBox;
        private System.Windows.Forms.TextBox nume_client_txtBox;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button refresh_btn;
        private MFdbDataSet1 mFdbDataSet1;
        private System.Windows.Forms.BindingSource progrmariBindingSource;
        private MFdbDataSet1TableAdapters.ProgrmariTableAdapter progrmariTableAdapter;
        private System.Windows.Forms.TextBox ora_txtBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox pret_txtBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox Id_txtBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeclientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenumeclientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviciuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numespecialistDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pretDataGridViewTextBoxColumn;
    }
}