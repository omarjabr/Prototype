using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

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

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string asci = File.ReadAllText(ofd.FileName);
                string s = BinaryToString(asci);
                txtString.Text = s;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string value = "";
            if (inputBox.InputBox("New file", "New file name:", ref value) == DialogResult.OK)
            {
                using (StreamWriter stw = new StreamWriter(value + ".txt"))
                {
                    stw.WriteLine(txtString.Text);
                    MessageBox.Show("File saved successfully");
                    txtString.Text = "";
                }
            }
        }
    }
}
