using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace BinaryFileHandlingTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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

        private void txtBinaryFile_TextChanged(object sender, EventArgs e)
        {
            txtBinaryFile.ScrollBars = ScrollBars.Both;
            if(txtBinaryFile.Text != "")
            {
                txtBinaryFile.Enabled = true;
                pbUpload.Visible = false;
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
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string asci = File.ReadAllText(ofd.FileName);
                string s = BinaryToString(asci);
                txtBinaryFile.Text = s;
            }
        }

    }
}