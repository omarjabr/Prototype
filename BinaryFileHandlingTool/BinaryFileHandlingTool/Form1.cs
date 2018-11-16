using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Data;

namespace BinaryFileHandlingTool
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=Omar-Jabr;Initial Catalog=BFHT;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bFHTDataSet.binaryfile' table. You can move, or remove it, as needed.
            this.binaryfileTableAdapter.Fill(this.bFHTDataSet.binaryfile);
            // TODO: This line of code loads data into the 'bFHT_DBDataSet.binaryfiles' table. You can move, or remove it, as needed.
            this.binaryfilesTableAdapter.Fill(this.bFHT_DBDataSet.binaryfiles);

        }
        // Convert Class Binary To String
        public static string BinaryToString(string data)
        {
            List<Byte> byteList = new List<Byte>();

            for (int i = 0; i < data.Length; i += 8)
            {
                byteList.Add(Convert.ToByte(data.Substring(i, 8), 2));
            }
            return Encoding.ASCII.GetString(byteList.ToArray());
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sd = new SaveFileDialog();
            sd.Title = "Save text Files";
            sd.DefaultExt = "txt";
            sd.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            sd.FilterIndex = 2;
            if (sd.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(sd.FileName))
                {
                    sw.Write(txtTextFile.Text);
                }
            }
        }

        private void txtFormat_TextChanged(object sender, EventArgs e)
        {
            txtFormat.ScrollBars = ScrollBars.Both;
        }

        private void txtIterations_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIterations_Enter(object sender, EventArgs e)
        {
            if (txtIterations.Text == "Number of iterations")
            {
                txtIterations.Text = "";
                txtIterations.ForeColor = Color.Black;
            }
        }

        private void txtIterations_Leave(object sender, EventArgs e)
        {
            if (txtIterations.Text == "")
            {
                txtIterations.Text = "Number of iterations";
                txtIterations.ForeColor = Color.Gray;
            }
        }

        private void txtUsedFormats_TextChanged(object sender, EventArgs e)
        {
            txtUsedFormats.ScrollBars = ScrollBars.Both;
        }

        private void txtTextFile_TextChanged(object sender, EventArgs e)
        {
            txtTextFile.ScrollBars = ScrollBars.Both;
        }

        private void pbUpload_Click(object sender, EventArgs e)
        {
            con.Open();
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {

                //string name = Path.GetFileName(ofd.FileName);
                string name = ofd.FileName;
                string content = File.ReadAllText(ofd.FileName);

                SqlCommand insert = new SqlCommand("INSERT INTO binaryfile (bf_name, bf_content) VALUES ('" +
                    name + "','" + content + "')", con);
                insert.ExecuteNonQuery();
                //    string asci = File.ReadAllText(ofd.FileName);
                //    string s = BinaryToString(asci);
                //    txtBinaryFile.Text = s;
                
            }
            con.Close();
            
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            var cell = dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            Process.Start(cell.ToString());
        }

        private void pbUpload_LoadCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            this.Refresh();
            Application.DoEvents();
        }
    }
}