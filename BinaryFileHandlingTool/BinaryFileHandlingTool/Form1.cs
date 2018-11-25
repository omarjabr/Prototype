using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

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
            // TODO: This line of code loads data into the 'bFHTDataSet3.textfiles' table. You can move, or remove it, as needed.
            this.textfilesTableAdapter.Fill(this.bFHTDataSet3.textfiles);
            // TODO: This line of code loads data into the 'bFHTDataSet2.textfile' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'bFHTDataSet1.binaryfile' table. You can move, or remove it, as needed.
            this.binaryfileTableAdapter1.Fill(this.bFHTDataSet1.binaryfile);
            // TODO: This line of code loads data into the 'bFHTDataSet.binaryfile' table. You can move, or remove it, as needed.
            this.binaryfileTableAdapter.Fill(this.bFHTDataSet.binaryfile);
            // TODO: This line of code loads data into the 'bFHT_DBDataSet.binaryfiles' table. You can move, or remove it, as needed.

            dataGridView1.MouseClick += new MouseEventHandler(dataGridView1_MouseClick);
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip menu = new ContextMenuStrip();
                int position = dataGridView1.HitTest(e.X, e.Y).RowIndex;

                if (position >= 0)
                {
                    menu.Items.Add("Delete").Name = "Delete";
                }
                menu.Show(dataGridView1, new Point(e.X, e.Y));
                menu.ItemClicked += new ToolStripItemClickedEventHandler(menu_ItemClicked);
            }
        }

        private void menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            con.Open();
            if (e.ClickedItem.Name.ToString() == "Delete")
            {
                if (MessageBox.Show("Are you sure you want to delete this file?", "Delete File", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    int row = dataGridView1.CurrentCell.RowIndex;
                    string id = dataGridView1.Rows[row].Cells["bf_ID"].Value.ToString();
                    SqlCommand delete = new SqlCommand("DELETE FROM binaryfile WHERE bf_ID = '" + id + "'", con);
                    delete.ExecuteNonQuery();
                    // Refresh Data Grid View

                }
            }
            con.Close();
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
                con.Open();
                int row = dataGridView2.CurrentCell.RowIndex;
                string id = dataGridView2.Rows[row].Cells["tf_ID"].Value.ToString();
                SqlCommand read = new SqlCommand("SELECT tf_content FROM textfiles WHERE tf_ID = '" + id + "'", con);
                SqlDataReader reader = read.ExecuteReader();
                if (reader.Read() == true)
                {
                    string content = reader["tf_content"].ToString();
                    using (StreamWriter sw = new StreamWriter(sd.FileName))
                    {
                        sw.Write(content);
                    }
                    reader.Close();
                }
                SqlCommand delete = new SqlCommand("DELETE FROM textfiles WHERE tf_ID = '" + id + "'", con);
                SqlDataAdapter da = new SqlDataAdapter("SELECT tf_name FROM textfiles", con);
                DataSet ds = new DataSet();
                da.Fill(ds, "textfiles");
                dataGridView2.DataSource = ds;
                dataGridView2.DataMember = "textfiles";
                con.Close();
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

        private void pbUpload_Click(object sender, EventArgs e)
        {
            con.Open();
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string name = ofd.FileName;
                string content = File.ReadAllText(ofd.FileName);

                SqlCommand insert = new SqlCommand("INSERT INTO binaryfile (bf_name, bf_content) VALUES ('" +
                    name + "','" + content + "')", con);
                insert.ExecuteNonQuery();
            }
            SqlDataAdapter da = new SqlDataAdapter("SELECT bf_name FROM binaryfile", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "binaryfile");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "binaryfile";
            con.Close();
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var cell = dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            Process.Start(cell.ToString());
        }

        private void pcConvert_Click(object sender, EventArgs e)
        {
            con.Open();
            int row = dataGridView1.RowCount;

            for (int i = 0; i < row; i++)
            {
                string name = dataGridView1.Rows[i].Cells["bf_name"].Value.ToString();
                string id = dataGridView1.Rows[i].Cells["bf_ID"].Value.ToString();
                SqlCommand read = new SqlCommand("SELECT bf_content FROM binaryfile WHERE bf_ID = '" + id + "'", con);
                SqlDataReader reader = read.ExecuteReader();
                if (reader.Read() == true)
                {
                    string asci = File.ReadAllText(name);
                    string binaryText = BinaryToString(asci);
                    SqlCommand insert = new SqlCommand("INSERT INTO textfiles (tf_name, tf_content) VALUES ('" + name +
                        "','" + binaryText + "')", con);
                    reader.Close();
                    insert.ExecuteNonQuery();

                }

                SqlDataAdapter da = new SqlDataAdapter("SELECT tf_name FROM textfiles", con);
                DataSet ds = new DataSet();
                da.Fill(ds, "textfiles");
                dataGridView2.DataSource = ds;
                dataGridView2.DataMember = "textfiles";
            }

            con.Close();
        }
    }
}