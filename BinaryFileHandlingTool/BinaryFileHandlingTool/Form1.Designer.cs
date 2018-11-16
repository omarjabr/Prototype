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
            this.txtTextFile = new System.Windows.Forms.TextBox();
            this.lblText = new System.Windows.Forms.Label();
            this.pbUpload = new System.Windows.Forms.PictureBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bFHT_DBDataSet = new BinaryFileHandlingTool.BFHT_DBDataSet();
            this.binaryfilesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.binaryfilesTableAdapter = new BinaryFileHandlingTool.BFHT_DBDataSetTableAdapters.binaryfilesTableAdapter();
            this.bFHTDataSet = new BinaryFileHandlingTool.BFHTDataSet();
            this.binaryfileBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.binaryfileTableAdapter = new BinaryFileHandlingTool.BFHTDataSetTableAdapters.binaryfileTableAdapter();
            this.bfnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pbUpload)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bFHT_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.binaryfilesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bFHTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.binaryfileBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(453, 186);
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
            // txtTextFile
            // 
            this.txtTextFile.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTextFile.Location = new System.Drawing.Point(311, 43);
            this.txtTextFile.Multiline = true;
            this.txtTextFile.Name = "txtTextFile";
            this.txtTextFile.Size = new System.Drawing.Size(245, 135);
            this.txtTextFile.TabIndex = 26;
            this.txtTextFile.TextChanged += new System.EventHandler(this.txtTextFile_TextChanged);
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
            this.pbUpload.LoadCompleted += new System.ComponentModel.AsyncCompletedEventHandler(this.pbUpload_LoadCompleted);
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
            this.bfnameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.binaryfileBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(245, 109);
            this.dataGridView1.TabIndex = 31;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // bFHT_DBDataSet
            // 
            this.bFHT_DBDataSet.DataSetName = "BFHT_DBDataSet";
            this.bFHT_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // binaryfilesBindingSource
            // 
            this.binaryfilesBindingSource.DataMember = "binaryfiles";
            this.binaryfilesBindingSource.DataSource = this.bFHT_DBDataSet;
            // 
            // binaryfilesTableAdapter
            // 
            this.binaryfilesTableAdapter.ClearBeforeFill = true;
            // 
            // bFHTDataSet
            // 
            this.bFHTDataSet.DataSetName = "BFHTDataSet";
            this.bFHTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // binaryfileBindingSource
            // 
            this.binaryfileBindingSource.DataMember = "binaryfile";
            this.binaryfileBindingSource.DataSource = this.bFHTDataSet;
            // 
            // binaryfileTableAdapter
            // 
            this.binaryfileTableAdapter.ClearBeforeFill = true;
            // 
            // bfnameDataGridViewTextBoxColumn
            // 
            this.bfnameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bfnameDataGridViewTextBoxColumn.DataPropertyName = "bf_name";
            this.bfnameDataGridViewTextBoxColumn.HeaderText = "File name";
            this.bfnameDataGridViewTextBoxColumn.Name = "bfnameDataGridViewTextBoxColumn";
            this.bfnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 486);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbUpload);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.txtTextFile);
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
            ((System.ComponentModel.ISupportInitialize)(this.bFHT_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.binaryfilesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bFHTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.binaryfileBindingSource)).EndInit();
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
        private System.Windows.Forms.TextBox txtTextFile;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.PictureBox pbUpload;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private BFHT_DBDataSet bFHT_DBDataSet;
        private System.Windows.Forms.BindingSource binaryfilesBindingSource;
        private BFHT_DBDataSetTableAdapters.binaryfilesTableAdapter binaryfilesTableAdapter;
        private BFHTDataSet bFHTDataSet;
        private System.Windows.Forms.BindingSource binaryfileBindingSource;
        private BFHTDataSetTableAdapters.binaryfileTableAdapter binaryfileTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bfnameDataGridViewTextBoxColumn;
    }
}

