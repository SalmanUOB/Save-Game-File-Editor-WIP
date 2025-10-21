using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace lmitp
{
    public partial class Aether : Form
    {
        private string selectedFileName;
        private string savePath;
        public Aether()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "All Files (*.*)|*.*";
            openFileDialog.FileName = "zm_loadouts_offline";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectedFileName = openFileDialog.FileName;


                if (selectedFileName.EndsWith("zm_loadouts_offline"))
                {
                    try
                    {
                        label2.Visible = false;
                        label4.Visible = true;
                        byte[] fileBytes;
                        fileBytes = File.ReadAllBytes(selectedFileName);
                        string filePath = "zm_loadouts_offline";
                        savePath = filePath.ToString();
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
        private void button3_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
            groupBox6.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = true;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
            groupBox6.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = true;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
            groupBox6.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = true;
            groupBox5.Visible = false;
            groupBox6.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = true;
            groupBox6.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
            groupBox6.Visible = true;
        }

        private void Aether_Load(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string hexString = richTextBox1.Text;
                byte[] fileBytes = Enumerable.Range(0, hexString.Length)
                    .Where(x => x % 2 == 0)
                    .Select(x => Convert.ToByte(hexString.Substring(x, 2), 16))
                    .ToArray();
                ///byte newByteValue = Convert.ToByte(textBox1.Text);
               // fileBytes[381] = newByteValue;
                //fileBytes[382] = Convert.ToByte(textBox2.Text);
                //c1
                string sw1 = comboBox1.SelectedItem.ToString();
                switch (sw1)
                {
                    //Star Weapon
                    case "None":
                        fileBytes[33186] = 0;
                        fileBytes[33187] = 0;
                        break;
                    case "RAY GUN":
                        fileBytes[33186] = 60;
                        fileBytes[33187] = 1;
                        break;
                    case "RAY GUN MARK 2":
                        fileBytes[33186] = 140;
                        fileBytes[33187] = 1;
                        break;
                    case "BLUNDERGAT":
                        fileBytes[33186] = 43;
                        fileBytes[33187] = 1;
                        break;
                    case "SWITCHBLADE X9":
                        fileBytes[33186] = 150;
                        fileBytes[33187] = 0;
                        break;
                    case "RAMPAGE":
                        fileBytes[33186] = 134;
                        fileBytes[33187] = 1;
                        break;
                    case "KAP40":
                        fileBytes[33186] = 153;
                        fileBytes[33187] = 0;
                        break;
                    case "MOG12":
                        fileBytes[33186] = 110;
                        fileBytes[33187] = 1;
                        break;
                    case "ICR":
                        fileBytes[33186] = 104;
                        fileBytes[33187] = 1;
                        break;
                    case "HITCHCOCK M9":
                        fileBytes[33186] = 99;
                        fileBytes[33187] = 1;
                        break;
                    case "M1897 TREBUCHET":
                        fileBytes[33186] = 122;
                        fileBytes[33187] = 1;
                        break;
                    case "REAVER":
                        fileBytes[33186] = 97;
                        fileBytes[33187] = 1;
                        break;
                    case "KN-57":
                        fileBytes[33186] = 135;
                        fileBytes[33187] = 1;
                        break;
                    case "MADDOX RFB":
                        fileBytes[33186] = 116;
                        fileBytes[33187] = 1;
                        break;
                    case "VKM 750":
                        fileBytes[33186] = 121;
                        fileBytes[33187] = 1;
                        break;
                    case "SPITFIRE":
                        fileBytes[33186] = 128;
                        fileBytes[33187] = 1;
                        break;
                    case "HADES":
                        fileBytes[33186] = 120;
                        fileBytes[33187] = 1;
                        break;
                }
                //Equipments
                string eq1 = comboBox1.SelectedItem.ToString();
                switch (eq1)
                {
                    //Pack A Punch
                    case "None":
                        fileBytes[33121] = 0;
                        fileBytes[33122] = 0;
                        break;
                    case "RAY GUN":
                        fileBytes[33121] = 60;
                        fileBytes[33122] = 1;
                        break;
                    case "RAY GUN MARK 2":
                        fileBytes[33121] = 140;
                        fileBytes[33122] = 1;
                        break;
                    case "BLUNDERGAT":
                        fileBytes[33121] = 43;
                        fileBytes[33122] = 1;
                        break;
                    case "SWITCHBLADE X9":
                        fileBytes[33121] = 150;
                        fileBytes[33122] = 0;
                        break;
                    case "RAMPAGE":
                        fileBytes[33121] = 134;
                        fileBytes[33122] = 1;
                        break;
                    case "KAP40":
                        fileBytes[33121] = 153;
                        fileBytes[33122] = 0;
                        break;
                    case "MOG12":
                        fileBytes[33121] = 110;
                        fileBytes[33122] = 1;
                        break;
                    case "ICR":
                        fileBytes[33121] = 104;
                        fileBytes[33122] = 1;
                        break;
                    case "HITCHCOCK M9":
                        fileBytes[33121] = 99;
                        fileBytes[33122] = 1;
                        break;
                    case "M1897 TREBUCHET":
                        fileBytes[33121] = 122;
                        fileBytes[33122] = 1;
                        break;
                    case "REAVER":
                        fileBytes[33121] = 97;
                        fileBytes[33122] = 1;
                        break;
                    case "Kn-57":
                        fileBytes[33121] = 135;
                        fileBytes[33122] = 1;
                        break;
                    case "MADDOX RFB":
                        fileBytes[33121] = 116;
                        fileBytes[33122] = 1;
                        break;
                    case "VKM 750":
                        fileBytes[33121] = 121;
                        fileBytes[33122] = 1;
                        break;
                    case "SPITFIRE":
                        fileBytes[33121] = 128;
                        fileBytes[33122] = 1;
                        break;
                    case "HADES":
                        fileBytes[33121] = 120;
                        fileBytes[33122] = 1;
                        break;

                    //Non-Pack A Punch
                    //Assult Rifle
                    case "Maddox RFB":
                        fileBytes[33121] = 226;
                        fileBytes[33122] = 0;
                        break;
                    case "ICR-7":
                        fileBytes[33121] = 225;
                        fileBytes[33122] = 0;
                        break;
                    case "Rempart 17":
                        fileBytes[33121] = 227;
                        fileBytes[33122] = 0;
                        break;
                    case "KN-57":
                        fileBytes[33121] = 229;
                        fileBytes[33122] = 0;
                        break;
                    case "VAPR-XKG":
                        fileBytes[33121] = 228;
                        fileBytes[33122] = 0;
                        break;
                    case "SWAT RFT (DLC)":
                        fileBytes[33121] = 219;
                        fileBytes[33122] = 0;
                        break;
                    case "Peacekeeper (DLC)":
                        fileBytes[33121] = 124;
                        fileBytes[33122] = 0;
                        break;
                    case "Grav (DLC)":
                        fileBytes[33121] = 220;
                        fileBytes[33122] = 0;
                        break;
                    case "AN-94 (DLC)":
                        fileBytes[33121] = 138;
                        fileBytes[33122] = 1;
                        break;
                    case "Doublecoss (DLC)":
                        fileBytes[33121] = 223;
                        fileBytes[33122] = 0;
                        break;
                    //Submachine Guns
                    case "MX9":
                        fileBytes[33121] = 240;
                        fileBytes[33122] = 0;
                        break;
                    case "GKS":
                        fileBytes[33121] = 244;
                        fileBytes[33122] = 0;
                        break;
                    case "Spitfire":
                        fileBytes[33121] = 242;
                        fileBytes[33122] = 0;
                        break;
                    case "Cordite":
                        fileBytes[33121] = 243;
                        fileBytes[33122] = 0;
                        break;
                    case "SAUG 9mm":
                        fileBytes[33121] = 241;
                        fileBytes[33122] = 0;
                        break;
                    case "Daemon 3xb (DLC)":
                        fileBytes[33121] = 216;
                        fileBytes[33122] = 0;
                        break;
                    case "VMP (DLC)":
                        fileBytes[33121] = 140;
                        fileBytes[33122] = 1;
                        break;
                    case "Switchblade X9 (DLC)":
                        fileBytes[33121] = 211;
                        fileBytes[33122] = 0;
                        break;
                    case "Micromg 9mm (DLC)":
                        fileBytes[33121] = 143;
                        fileBytes[33122] = 1;
                        break;
                    case "MP-40":
                        fileBytes[33121] = 1;
                        fileBytes[33122] = 1;
                        break;
                    case "M1927":
                        fileBytes[33121] = 3;
                        fileBytes[33122] = 1;
                        break;
                    case "Escargot":
                        fileBytes[33121] = 102;
                        fileBytes[33122] = 1;
                        break;
                    //Tactical Rifels
                    case "Auger DMR":
                        fileBytes[33121] = 230;
                        fileBytes[33122] = 0;
                        break;
                    case "ABR 223":
                        fileBytes[33121] = 232;
                        fileBytes[33122] = 0;
                        break;
                    case "Swordfish":
                        fileBytes[33121] = 231;
                        fileBytes[33122] = 0;
                        break;
                    case "S6 Stingray (DLC)":
                        fileBytes[33121] = 217;
                        fileBytes[33122] = 0;
                        break;
                    case "M16 (DLC)":
                        fileBytes[33121] = 96;
                        fileBytes[33122] = 0;
                        break;
                    case "ESSEX MODEL07":
                        fileBytes[33121] = 103;
                        fileBytes[33122] = 1;
                        break;
                    //Light Machine Guns
                    case "Titan":
                        fileBytes[33121] = 237;
                        fileBytes[33122] = 0;
                        break;
                    case "Hades":
                        fileBytes[33121] = 239;
                        fileBytes[33122] = 0;
                        break;
                    case "Vkm 750":
                        fileBytes[33121] = 238;
                        fileBytes[33122] = 0;
                        break;
                    case "TigerShark (DLC)":
                        fileBytes[33121] = 218;
                        fileBytes[33122] = 0;
                        break;
                    case "Zweihander":
                        fileBytes[33121] = 100;
                        fileBytes[33122] = 1;
                        break;
                    //Sniper Rifels
                    case "Paladin HB50":
                        fileBytes[33121] = 233;
                        fileBytes[33122] = 0;
                        break;
                    case "Outlaw":
                        fileBytes[33121] = 235;
                        fileBytes[33122] = 0;
                        break;
                    case "SDM":
                        fileBytes[33121] = 236;
                        fileBytes[33122] = 0;
                        break;
                    case "Koshka":
                        fileBytes[33121] = 234;
                        fileBytes[33122] = 0;
                        break;
                    case "Vendetta (DLC)":
                        fileBytes[33121] = 212;
                        fileBytes[33122] = 0;
                        break;
                    case "Locus (DLC)":
                        fileBytes[33121] = 49;
                        fileBytes[33122] = 1;
                        break;
                    case "Havelina AA50 (DLC)":
                        fileBytes[33121] = 97;
                        fileBytes[33122] = 0;
                        break;
                    // Pstols
                    case "Strife":
                        fileBytes[33121] = 249;
                        fileBytes[33122] = 0;
                        break;
                    case "RK 7 Garrasion":
                        fileBytes[33121] = 247;
                        fileBytes[33122] = 0;
                        break;
                    case "Mozu":
                        fileBytes[33121] = 248;
                        fileBytes[33122] = 0;
                        break;
                    case "KAP 45":
                        fileBytes[33121] = 215;
                        fileBytes[33122] = 0;
                        break;
                    case "Welling":
                        fileBytes[33121] = 101;
                        fileBytes[33122] = 1;
                        break;
                    // ShotGuns
                    case "MOG 12":
                        fileBytes[33121] = 245;
                        fileBytes[33122] = 0;
                        break;
                    case "SG12":
                        fileBytes[33121] = 246;
                        fileBytes[33122] = 0;
                        break;
                    case "Rampage":
                        fileBytes[33121] = 210;
                        fileBytes[33122] = 0;
                        break;
                    case "Argus":
                        fileBytes[33121] = 98;
                        fileBytes[33122] = 0;
                        break;
                    //Lancher
                    case "Hellion Salvo":
                        fileBytes[33121] = 250;
                        fileBytes[33122] = 0;
                        break;
                    //Melle
                    case "Combat Knife":
                        fileBytes[33121] = 3;
                        fileBytes[33122] = 0;
                        break;
                }
                //Perk 1
                String c1p1 = comboBox3.SelectedItem.ToString();
                switch (c1p1)
                {
                    case "Paladin HB50":
                        fileBytes[33121] = 233;
                        fileBytes[33122] = 0;
                        break;
                    case "Outlaw":
                        fileBytes[33121] = 235;
                        fileBytes[33122] = 0;
                        break;
                    case "SDM":
                        fileBytes[33121] = 236;
                        fileBytes[33122] = 0;
                        break;
                    case "Koshka":
                        fileBytes[33121] = 234;
                        fileBytes[33122] = 0;
                        break;
                    case "Vendetta (DLC)":
                        fileBytes[33121] = 212;
                        fileBytes[33122] = 0;
                        break;
                    case "Locus (DLC)":
                        fileBytes[33121] = 49;
                        fileBytes[33122] = 1;
                        break;
                    case "Havelina AA50 (DLC)":
                        fileBytes[33121] = 97;
                        fileBytes[33122] = 0;
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
}
    }
}