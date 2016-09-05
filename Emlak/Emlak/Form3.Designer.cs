namespace Emlak
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.emlakDataSet = new Emlak.EmlakDataSet();
            this.evlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.evlerTableAdapter = new Emlak.EmlakDataSetTableAdapters.EvlerTableAdapter();
            this.emlakDataSet1 = new Emlak.EmlakDataSet1();
            this.alicilarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alicilarTableAdapter = new Emlak.EmlakDataSet1TableAdapters.AlicilarTableAdapter();
            this.aliciTCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aliciAdSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aliciTelefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ilgilendigiEvIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emlakDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.evlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emlakDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alicilarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(955, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "İlanlara Dön";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(484, 140);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(522, 150);
            this.dataGridView1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(584, 93);
            this.panel1.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.evlerBindingSource;
            this.comboBox1.DisplayMember = "Ev_ID";
            this.comboBox1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(441, 50);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(127, 26);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.ValueMember = "Ev_ID";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox3.Location = new System.Drawing.Point(441, 14);
            this.textBox3.MaxLength = 10;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(127, 26);
            this.textBox3.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox2.Location = new System.Drawing.Point(149, 46);
            this.textBox2.MaxLength = 50;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(127, 26);
            this.textBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(149, 14);
            this.textBox1.MaxLength = 11;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(127, 26);
            this.textBox1.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(333, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 36);
            this.label4.TabIndex = 3;
            this.label4.Text = "İlgilendiği İlan\r\n(Ev ID\'si)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(333, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Alıcı Telefon";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(18, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Alıcı Ad Soyad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(18, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alıcı TC";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(849, 33);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 34);
            this.button2.TabIndex = 4;
            this.button2.Text = "Alıcı Sil";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(637, 33);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 34);
            this.button3.TabIndex = 5;
            this.button3.Text = "Alıcı Ekle";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aliciTCDataGridViewTextBoxColumn,
            this.aliciAdSoyadDataGridViewTextBoxColumn,
            this.aliciTelefonDataGridViewTextBoxColumn,
            this.ilgilendigiEvIDDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.alicilarBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(13, 140);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(444, 150);
            this.dataGridView2.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(481, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Güncel Alıcılar\r\n";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(12, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 18);
            this.label6.TabIndex = 9;
            this.label6.Text = "Mevcut Alıcılar\r\n";
            // 
            // emlakDataSet
            // 
            this.emlakDataSet.DataSetName = "EmlakDataSet";
            this.emlakDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // evlerBindingSource
            // 
            this.evlerBindingSource.DataMember = "Evler";
            this.evlerBindingSource.DataSource = this.emlakDataSet;
            // 
            // evlerTableAdapter
            // 
            this.evlerTableAdapter.ClearBeforeFill = true;
            // 
            // emlakDataSet1
            // 
            this.emlakDataSet1.DataSetName = "EmlakDataSet1";
            this.emlakDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // alicilarBindingSource
            // 
            this.alicilarBindingSource.DataMember = "Alicilar";
            this.alicilarBindingSource.DataSource = this.emlakDataSet1;
            // 
            // alicilarTableAdapter
            // 
            this.alicilarTableAdapter.ClearBeforeFill = true;
            // 
            // aliciTCDataGridViewTextBoxColumn
            // 
            this.aliciTCDataGridViewTextBoxColumn.DataPropertyName = "Alici_TC";
            this.aliciTCDataGridViewTextBoxColumn.HeaderText = "Alici_TC";
            this.aliciTCDataGridViewTextBoxColumn.Name = "aliciTCDataGridViewTextBoxColumn";
            this.aliciTCDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aliciAdSoyadDataGridViewTextBoxColumn
            // 
            this.aliciAdSoyadDataGridViewTextBoxColumn.DataPropertyName = "Alici_AdSoyad";
            this.aliciAdSoyadDataGridViewTextBoxColumn.HeaderText = "Alici_AdSoyad";
            this.aliciAdSoyadDataGridViewTextBoxColumn.Name = "aliciAdSoyadDataGridViewTextBoxColumn";
            this.aliciAdSoyadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aliciTelefonDataGridViewTextBoxColumn
            // 
            this.aliciTelefonDataGridViewTextBoxColumn.DataPropertyName = "Alici_Telefon";
            this.aliciTelefonDataGridViewTextBoxColumn.HeaderText = "Alici_Telefon";
            this.aliciTelefonDataGridViewTextBoxColumn.Name = "aliciTelefonDataGridViewTextBoxColumn";
            this.aliciTelefonDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ilgilendigiEvIDDataGridViewTextBoxColumn
            // 
            this.ilgilendigiEvIDDataGridViewTextBoxColumn.DataPropertyName = "İlgilendigi_EvID";
            this.ilgilendigiEvIDDataGridViewTextBoxColumn.HeaderText = "İlgilendigi_EvID";
            this.ilgilendigiEvIDDataGridViewTextBoxColumn.Name = "ilgilendigiEvIDDataGridViewTextBoxColumn";
            this.ilgilendigiEvIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Info;
            this.label9.Location = new System.Drawing.Point(621, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(447, 14);
            this.label9.TabIndex = 19;
            this.label9.Text = "Alıcı Silme ve Güncelleme işlemlerinde TC bilgisini girdiğinize emin olunuz!";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.Location = new System.Drawing.Point(743, 33);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 34);
            this.button4.TabIndex = 20;
            this.button4.Text = "Alıcı Güncelle";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1080, 312);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.Text = "Alıcı Listesi";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emlakDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.evlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emlakDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alicilarBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private EmlakDataSet emlakDataSet;
        private System.Windows.Forms.BindingSource evlerBindingSource;
        private EmlakDataSetTableAdapters.EvlerTableAdapter evlerTableAdapter;
        private EmlakDataSet1 emlakDataSet1;
        private System.Windows.Forms.BindingSource alicilarBindingSource;
        private EmlakDataSet1TableAdapters.AlicilarTableAdapter alicilarTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn aliciTCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aliciAdSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aliciTelefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ilgilendigiEvIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button4;
    }
}