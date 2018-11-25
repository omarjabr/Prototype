namespace BinaryFileHandlingTool
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnSave = new System.Windows.Forms.Button();
            this.lblBinary = new System.Windows.Forms.Label();
            this.lblNewFormat = new System.Windows.Forms.Label();
            this.txtFormat = new System.Windows.Forms.TextBox();
            this.txtIterations = new System.Windows.Forms.TextBox();
            this.btnSaveFormat = new System.Windows.Forms.Button();
            this.txtUsedFormats = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblText = new System.Windows.Forms.Label();
            this.pbUpload = new System.Windows.Forms.PictureBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bf_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bf_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.binaryfileBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bFHTDataSet1 = new BinaryFileHandlingTool.BFHTDataSet1();
            this.binaryfileBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bFHTDataSet = new BinaryFileHandlingTool.BFHTDataSet();
            this.binaryfileTableAdapter = new BinaryFileHandlingTool.BFHTDataSetTableAdapters.binaryfileTableAdapter();
            this.binaryfileTableAdapter1 = new BinaryFileHandlingTool.BFHTDataSet1TableAdapters.binaryfileTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tf_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tf_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bFHTDataSet2 = new BinaryFileHandlingTool.BFHTDataSet2();
            this.pcConvert = new System.Windows.Forms.PictureBox();
            this.bFHTDataSet3 = new BinaryFileHandlingTool.BFHTDataSet3();
            this.textfilesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textfilesTableAdapter = new BinaryFileHandlingTool.BFHTDataSet3TableAdapters.textfilesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pbUpload)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.binaryfileBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bFHTDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.binaryfileBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bFHTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bFHTDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcConvert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bFHTDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textfilesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(453, 162);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(103, 28);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "browse";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblBinary
            // 
            this.lblBinary.AutoSize = true;
            this.lblBinary.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBinary.Location = new System.Drawing.Point(8, 19);
            this.lblBinary.Name = "lblBinary";
            this.lblBinary.Size = new System.Drawing.Size(165, 21);
            this.lblBinary.TabIndex = 19;
            this.lblBinary.Text = "Input the binary file:";
            // 
            // lblNewFormat
            // 
            this.lblNewFormat.AutoSize = true;
            this.lblNewFormat.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewFormat.Location = new System.Drawing.Point(12, 193);
            this.lblNewFormat.Name = "lblNewFormat";
            this.lblNewFormat.Size = new System.Drawing.Size(107, 21);
            this.lblNewFormat.TabIndex = 20;
            this.lblNewFormat.Text = "New format:";
            // 
            // txtFormat
            // 
            this.txtFormat.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFormat.Location = new System.Drawing.Point(12, 217);
            this.txtFormat.Multiline = true;
            this.txtFormat.Name = "txtFormat";
            this.txtFormat.Size = new System.Drawing.Size(245, 65);
            this.txtFormat.TabIndex = 21;
            this.txtFormat.TextChanged += new System.EventHandler(this.txtFormat_TextChanged);
            // 
            // txtIterations
            // 
            this.txtIterations.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIterations.ForeColor = System.Drawing.Color.Gray;
            this.txtIterations.Location = new System.Drawing.Point(12, 288);
            this.txtIterations.Name = "txtIterations";
            this.txtIterations.Size = new System.Drawing.Size(245, 22);
            this.txtIterations.TabIndex = 22;
            this.txtIterations.Text = "Number of iterations";
            this.txtIterations.TextChanged += new System.EventHandler(this.txtIterations_TextChanged);
            this.txtIterations.Enter += new System.EventHandler(this.txtIterations_Enter);
            this.txtIterations.Leave += new System.EventHandler(this.txtIterations_Leave);
            // 
            // btnSaveFormat
            // 
            this.btnSaveFormat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveFormat.Location = new System.Drawing.Point(12, 316);
            this.btnSaveFormat.Name = "btnSaveFormat";
            this.btnSaveFormat.Size = new System.Drawing.Size(121, 50);
            this.btnSaveFormat.TabIndex = 23;
            this.btnSaveFormat.Text = "Save";
            this.btnSaveFormat.UseVisualStyleBackColor = true;
            // 
            // txtUsedFormats
            // 
            this.txtUsedFormats.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsedFormats.Location = new System.Drawing.Point(12, 406);
            this.txtUsedFormats.Multiline = true;
            this.txtUsedFormats.Name = "txtUsedFormats";
            this.txtUsedFormats.Size = new System.Drawing.Size(245, 65);
            this.txtUsedFormats.TabIndex = 24;
            this.txtUsedFormats.TextChanged += new System.EventHandler(this.txtUsedFormats_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 382);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 21);
            this.label1.TabIndex = 25;
            this.label1.Text = "List of recently used formats:";
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText.Location = new System.Drawing.Point(307, 19);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(159, 21);
            this.lblText.TabIndex = 27;
            this.lblText.Text = "Text file converted:";
            // 
            // pbUpload
            // 
            this.pbUpload.BackColor = System.Drawing.Color.Transparent;
            this.pbUpload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbUpload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbUpload.Image = ((System.Drawing.Image)(resources.GetObject("pbUpload.Image")));
            this.pbUpload.Location = new System.Drawing.Point(78, 47);
            this.pbUpload.Name = "pbUpload";
            this.pbUpload.Size = new System.Drawing.Size(41, 28);
            this.pbUpload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUpload.TabIndex = 28;
            this.pbUpload.TabStop = false;
            this.pbUpload.Click += new System.EventHandler(this.pbUpload_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 30;
            this.label2.Text = "UPLOAD";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bf_name,
            this.bf_ID});
            this.dataGridView1.DataSource = this.binaryfileBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(245, 109);
            this.dataGridView1.TabIndex = 31;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // bf_name
            // 
            this.bf_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bf_name.DataPropertyName = "bf_name";
            this.bf_name.HeaderText = "File name";
            this.bf_name.Name = "bf_name";
            this.bf_name.ReadOnly = true;
            // 
            // bf_ID
            // 
            this.bf_ID.DataPropertyName = "bf_ID";
            this.bf_ID.HeaderText = "ID";
            this.bf_ID.Name = "bf_ID";
            this.bf_ID.ReadOnly = true;
            this.bf_ID.Visible = false;
            // 
            // binaryfileBindingSource1
            // 
            this.binaryfileBindingSource1.DataMember = "binaryfile";
            this.binaryfileBindingSource1.DataSource = this.bFHTDataSet1;
            // 
            // bFHTDataSet1
            // 
            this.bFHTDataSet1.DataSetName = "BFHTDataSet1";
            this.bFHTDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // binaryfileBindingSource
            // 
            this.binaryfileBindingSource.DataMember = "binaryfile";
            this.binaryfileBindingSource.DataSource = this.bFHTDataSet;
            // 
            // bFHTDataSet
            // 
            this.bFHTDataSet.DataSetName = "BFHTDataSet";
            this.bFHTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // binaryfileTableAdapter
            // 
            this.binaryfileTableAdapter.ClearBeforeFill = true;
            // 
            // binaryfileTableAdapter1
            // 
            this.binaryfileTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tf_ID,
            this.tf_name});
            this.dataGridView2.DataSource = this.textfilesBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(316, 43);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(240, 109);
            this.dataGridView2.TabIndex = 32;
            // 
            // tf_ID
            // 
            this.tf_ID.DataPropertyName = "tf_ID";
            this.tf_ID.HeaderText = "ID";
            this.tf_ID.Name = "tf_ID";
            this.tf_ID.ReadOnly = true;
            this.tf_ID.Visible = false;
            // 
            // tf_name
            // 
            this.tf_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tf_name.DataPropertyName = "tf_name";
            this.tf_name.HeaderText = "File name";
            this.tf_name.Name = "tf_name";
            this.tf_name.ReadOnly = true;
            // 
            // bFHTDataSet2
            // 
            this.bFHTDataSet2.DataSetName = "BFHTDataSet2";
            this.bFHTDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pcConvert
            // 
            this.pcConvert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcConvert.Image = ((System.Drawing.Image)(resources.GetObject("pcConvert.Image")));
            this.pcConvert.Location = new System.Drawing.Point(263, 81);
            this.pcConvert.Name = "pcConvert";
            this.pcConvert.Size = new System.Drawing.Size(47, 42);
            this.pcConvert.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcConvert.TabIndex = 33;
            this.pcConvert.TabStop = false;
            this.pcConvert.Click += new System.EventHandler(this.pcConvert_Click);
            // 
            // bFHTDataSet3
            // 
            this.bFHTDataSet3.DataSetName = "BFHTDataSet3";
            this.bFHTDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textfilesBindingSource
            // 
            this.textfilesBindingSource.DataMember = "textfiles";
            this.textfilesBindingSource.DataSource = this.bFHTDataSet3;
            // 
            // textfilesTableAdapter
            // 
            this.textfilesTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 479);
            this.Controls.Add(this.pcConvert);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbUpload);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUsedFormats);
            this.Controls.Add(this.btnSaveFormat);
            this.Controls.Add(this.txtIterations);
            this.Controls.Add(this.txtFormat);
            this.Controls.Add(this.lblNewFormat);
            this.Controls.Add(this.lblBinary);
            this.Controls.Add(this.btnSave);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Binary File Handling Tool";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbUpload)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.binaryfileBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bFHTDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.binaryfileBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bFHTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bFHTDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcConvert)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bFHTDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textfilesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblBinary;
        private System.Windows.Forms.Label lblNewFormat;
        private System.Windows.Forms.TextBox txtFormat;
        private System.Windows.Forms.TextBox txtIterations;
        private System.Windows.Forms.Button btnSaveFormat;
        private System.Windows.Forms.TextBox txtUsedFormats;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.PictureBox pbUpload;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private BFHTDataSet bFHTDataSet;
        private System.Windows.Forms.BindingSource binaryfileBindingSource;
        private BFHTDataSetTableAdapters.binaryfileTableAdapter binaryfileTableAdapter;
        private BFHTDataSet1 bFHTDataSet1;
        private System.Windows.Forms.BindingSource binaryfileBindingSource1;
        private BFHTDataSet1TableAdapters.binaryfileTableAdapter binaryfileTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private BFHTDataSet2 bFHTDataSet2;
        private System.Windows.Forms.PictureBox pcConvert;
        private System.Windows.Forms.DataGridViewTextBoxColumn bf_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn bf_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn tf_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn tf_name;
        private BFHTDataSet3 bFHTDataSet3;
        private System.Windows.Forms.BindingSource textfilesBindingSource;
        private BFHTDataSet3TableAdapters.textfilesTableAdapter textfilesTableAdapter;
    }
}

