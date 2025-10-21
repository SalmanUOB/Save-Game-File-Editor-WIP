using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lmitp
{
    public partial class callingcardeditor : Form
    {
        private string selectedFileName;
        private string savePath;
        public callingcardeditor()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "All Files (*.*)|*.*";
            openFileDialog.FileName = "user_settings";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectedFileName = openFileDialog.FileName;


                if (selectedFileName.EndsWith("user_settings"))
                {
                    try
                    {
                        label2.Visible = false;
                        label4.Visible = true;
                        byte[] fileBytes;
                        fileBytes = File.ReadAllBytes(selectedFileName);
                        string filePath = "user_settings";
                        savePath = filePath.ToString();
                        // Read the file contents
                        // Convert the byte array to a hexadecimal string and display it in the RichTextBox
                        richTextBox1.Text = BitConverter.ToString(fileBytes).Replace("-", "");
                        MessageBox.Show("Enjoy editing your save", "File opened successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error opening the file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
