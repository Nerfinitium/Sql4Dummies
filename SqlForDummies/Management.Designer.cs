namespace SqlForDummies
{
    partial class Management
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
            this.INSERT = new System.Windows.Forms.Button();
            this.dBORMANDataSet = new SqlForDummies.DBORMANDataSet();
            this.veriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.veriTableAdapter = new SqlForDummies.DBORMANDataSetTableAdapters.VeriTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.IDINSERT = new System.Windows.Forms.RichTextBox();
            this.LOKINSERT = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PINSERT = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.KID = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.UPDATE = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.PUPDATE = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.LOKUP = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.DELETE = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.DID = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dBORMANDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // INSERT
            // 
            this.INSERT.Location = new System.Drawing.Point(18, 124);
            this.INSERT.Name = "INSERT";
            this.INSERT.Size = new System.Drawing.Size(279, 23);
            this.INSERT.TabIndex = 0;
            this.INSERT.Text = "INSERT";
            this.INSERT.UseVisualStyleBackColor = true;
            this.INSERT.Click += new System.EventHandler(this.INSERT_Click);
            // 
            // dBORMANDataSet
            // 
            this.dBORMANDataSet.DataSetName = "DBORMANDataSet";
            this.dBORMANDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // veriBindingSource
            // 
            this.veriBindingSource.DataMember = "Veri";
            this.veriBindingSource.DataSource = this.dBORMANDataSet;
            // 
            // veriTableAdapter
            // 
            this.veriTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID";
            // 
            // IDINSERT
            // 
            this.IDINSERT.Location = new System.Drawing.Point(74, 11);
            this.IDINSERT.Name = "IDINSERT";
            this.IDINSERT.Size = new System.Drawing.Size(139, 23);
            this.IDINSERT.TabIndex = 3;
            this.IDINSERT.Text = "";
            // 
            // LOKINSERT
            // 
            this.LOKINSERT.Location = new System.Drawing.Point(74, 40);
            this.LOKINSERT.Name = "LOKINSERT";
            this.LOKINSERT.Size = new System.Drawing.Size(139, 23);
            this.LOKINSERT.TabIndex = 5;
            this.LOKINSERT.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Lokasyon";
            // 
            // PINSERT
            // 
            this.PINSERT.Location = new System.Drawing.Point(74, 69);
            this.PINSERT.Name = "PINSERT";
            this.PINSERT.Size = new System.Drawing.Size(139, 23);
            this.PINSERT.TabIndex = 7;
            this.PINSERT.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Puan";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(744, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(334, 410);
            this.dataGridView1.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.INSERT);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.PINSERT);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.IDINSERT);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.LOKINSERT);
            this.groupBox1.Location = new System.Drawing.Point(410, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 193);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "INSERT";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(103, 101);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(56, 17);
            this.checkBox2.TabIndex = 10;
            this.checkBox2.Text = "AUTO";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(163, 101);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(54, 17);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "NULL";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "HWID";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.KID);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.checkBox3);
            this.groupBox2.Controls.Add(this.checkBox4);
            this.groupBox2.Controls.Add(this.UPDATE);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.PUPDATE);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.LOKUP);
            this.groupBox2.Location = new System.Drawing.Point(37, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(306, 193);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "UPDATE";
            // 
            // KID
            // 
            this.KID.Location = new System.Drawing.Point(155, 11);
            this.KID.Name = "KID";
            this.KID.Size = new System.Drawing.Size(118, 23);
            this.KID.TabIndex = 12;
            this.KID.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(105, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "KId arat";
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(184, 101);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(56, 17);
            this.checkBox3.TabIndex = 10;
            this.checkBox3.Text = "AUTO";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(244, 101);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(54, 17);
            this.checkBox4.TabIndex = 9;
            this.checkBox4.Text = "NULL";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // UPDATE
            // 
            this.UPDATE.Location = new System.Drawing.Point(18, 124);
            this.UPDATE.Name = "UPDATE";
            this.UPDATE.Size = new System.Drawing.Size(279, 23);
            this.UPDATE.TabIndex = 0;
            this.UPDATE.Text = "UPDATE";
            this.UPDATE.UseVisualStyleBackColor = true;
            this.UPDATE.Click += new System.EventHandler(this.UPDATE_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(112, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "HWID";
            // 
            // PUPDATE
            // 
            this.PUPDATE.Location = new System.Drawing.Point(151, 69);
            this.PUPDATE.Name = "PUPDATE";
            this.PUPDATE.Size = new System.Drawing.Size(139, 23);
            this.PUPDATE.TabIndex = 7;
            this.PUPDATE.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(113, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Puan";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(92, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Lokasyon";
            // 
            // LOKUP
            // 
            this.LOKUP.Location = new System.Drawing.Point(151, 40);
            this.LOKUP.Name = "LOKUP";
            this.LOKUP.Size = new System.Drawing.Size(139, 23);
            this.LOKUP.TabIndex = 5;
            this.LOKUP.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.DELETE);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.DID);
            this.groupBox3.Location = new System.Drawing.Point(410, 229);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(306, 193);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "DELETE";
            // 
            // DELETE
            // 
            this.DELETE.Location = new System.Drawing.Point(18, 124);
            this.DELETE.Name = "DELETE";
            this.DELETE.Size = new System.Drawing.Size(279, 23);
            this.DELETE.TabIndex = 0;
            this.DELETE.Text = "DELETE";
            this.DELETE.UseVisualStyleBackColor = true;
            this.DELETE.Click += new System.EventHandler(this.DELETE_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(50, 67);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(18, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "ID";
            // 
            // DID
            // 
            this.DID.Location = new System.Drawing.Point(74, 62);
            this.DID.Name = "DID";
            this.DID.Size = new System.Drawing.Size(196, 23);
            this.DID.TabIndex = 3;
            this.DID.Text = "";
            // 
            // Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Management";
            this.Text = "Management";
            this.Load += new System.EventHandler(this.Management_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dBORMANDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button INSERT;
        private DBORMANDataSet dBORMANDataSet;
        private System.Windows.Forms.BindingSource veriBindingSource;
        private DBORMANDataSetTableAdapters.VeriTableAdapter veriTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox IDINSERT;
        private System.Windows.Forms.RichTextBox LOKINSERT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox PINSERT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.Button UPDATE;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox PUPDATE;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox LOKUP;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox KID;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button DELETE;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox DID;
    }
}