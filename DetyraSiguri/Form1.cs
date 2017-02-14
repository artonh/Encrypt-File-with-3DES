using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;        //per UTF8Encoding
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;

using System.Reflection;        //per assambly
using System.Resources;         //per ResourseMenager
using System.Globalization;     //per CultureInfo

namespace DetyraSiguri
{
    public partial class Form1 : Form
    {
        string statusiE="", statusiD="", titulliNeRuajtjeTeCelsit="", gabimi="";
        public Form1()
        {
            InitializeComponent();
            this.Size = new Size(358, this.Height);
            grInfo.Location = new Point(12, 30);

            CultureInfo ci = new CultureInfo("al-AL");
            NdrroGjuhen(ci, "DetyraSiguri.Lang.langres.al");     
            
            lblEmail.Text = "arti._3@hotmail.com"; 
            txtEmri.Text = "Arton Hoti"; 
            pbFotoja.BackgroundImage = DetyraSiguri.Properties.Resources.artoni;
        }
        private void Form1_Load(object sender, EventArgs e)//Ne load-im zgjedhet menyra enkriptuese me 3DES
        {
            comboBox1.SelectedIndex = 1;
        }

        UTF8Encoding utf8 = new UTF8Encoding();
        TripleDESCryptoServiceProvider tDES = new TripleDESCryptoServiceProvider();

        public string Enkripto(string originalString, byte[] key)//metoda per Enkriptim nese perdoret DESi
        {
            DESCryptoServiceProvider DES = new DESCryptoServiceProvider();
            DES.Padding = PaddingMode.Zeros;

            FileStream fs = new FileStream(txtFajlli.Text, FileMode.Create, FileAccess.Write);
            CryptoStream CS = new CryptoStream(fs, DES.CreateEncryptor(key, key), CryptoStreamMode.Write); //Defines a stream that links data streams to cryptographic transformations.
            StreamWriter sw = new StreamWriter(CS);
            sw.Write(originalString);
            CS.FlushFinalBlock();  // v
            sw.Flush();  //Clears all buffers for the current stream and causes any buffered data to be written to the underlying device.
            sw.Close();
            StreamReader sr = new StreamReader(txtFajlli.Text);
            string cipher = sr.ReadToEnd();
            sr.Close();
            return cipher;

        }

        public string Dekripto(string cryptedString, byte[] key)//metoda per Dekriptim nese perdoret DESi
        {
            DESCryptoServiceProvider DES = new DESCryptoServiceProvider();
            DES.Padding = PaddingMode.Zeros;

            FileStream fs = new FileStream(txtFajlli.Text, FileMode.Open, FileAccess.Read);
            CryptoStream CS = new CryptoStream(fs, DES.CreateDecryptor(key,key), CryptoStreamMode.Read);
            StreamReader sr = new StreamReader(CS);
            cryptedString = sr.ReadToEnd();
            //CS.FlushFinalBlock();
            sr.Close();
            fs.Dispose(); fs.Close();
            StreamWriter sw = new StreamWriter(txtFajlli.Text);
            sw.Write(cryptedString); sw.Flush(); sw.Close();

            return cryptedString;
        }

        private void btnZgjedh_Click(object sender, EventArgs e)//per zgjedhjen e path-it te FILE-it
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Title = "Zgjedh Fajllin";
            fd.Filter = "Text File|*.txt|Word Document|*.docx";            
            if (fd.ShowDialog() == DialogResult.OK)
            {
                txtFajlli.Text = fd.FileName;
                btnZgjerimi.Enabled = true;  //me leju dritaren per lexim fajlli
            }
            
        }    

        private void btnEnkript_Click(object sender, EventArgs e)
        {
            int fillimi=0;
            if (comboBox1.SelectedIndex == 0) //kjo do te gjeneronte enkriptim per 2DES-in
            {                
                fillimi = DateTime.Now.Millisecond;     
                try
                {
                    StreamReader sr = new StreamReader(txtFajlli.Text);
                    string plain = sr.ReadToEnd();
                    sr.Close();
                    string celesi = txtkey.Text;
                    byte[] key1 = utf8.GetBytes(celesi.Substring(0, 8));
                    byte[] key2 = utf8.GetBytes(celesi.Substring(8, 8));
                    
                    MessageBox.Show("Enkriptimi perfundoi me sukses!");
                }

                catch (Exception error)
                {
                    MessageBox.Show("Ka ndodhur nje gabim!\n" + error);
                }
            }
            else if (comboBox1.SelectedIndex == 1)  //zgjedhja behet e 3DES-it 
            {
                fillimi = DateTime.Now.Millisecond;     
                try 
                {
                    tDES.Key = utf8.GetBytes(txtkey.Text);  //me utf8 merr edhe disa karaktere tveqanta
                    tDES.Mode = CipherMode.CBC;
                    tDES.IV = utf8.GetBytes("06041995");
                    tDES.Padding = PaddingMode.Zeros;
                    
                    StreamReader sr = new StreamReader(txtFajlli.Text);
                    string permbajtja = sr.ReadToEnd();
                    sr.Close();
                    FileStream fs1 = new FileStream(txtFajlli.Text, FileMode.Create, FileAccess.Write);
                    CryptoStream cs = new CryptoStream(fs1, tDES.CreateEncryptor(), CryptoStreamMode.Write);
                    StreamWriter sw = new StreamWriter(cs);
                    sw.Write(permbajtja);
                    sw.Flush();
                    sw.Close();
                    
                    int fundi = DateTime.Now.Millisecond;

                    //Ruajtja e qelsit ne fajll
                    string permbajtjaQelsit = txtkey.Text;
                    SaveFileDialog saveFD = new SaveFileDialog();
                    saveFD.InitialDirectory = Convert.ToString(Environment.SpecialFolder.Desktop);
                    saveFD.Title = titulliNeRuajtjeTeCelsit;
                    saveFD.Filter = "Text File|*.txt|Word Document|*.docx";
                    saveFD.FilterIndex = 1;
                    if (saveFD.ShowDialog() == DialogResult.OK && saveFD.FileName.Length > 0)
                    {
                        FileStream fs2 = new FileStream(saveFD.FileName, FileMode.Create, FileAccess.Write);
                        StreamWriter sw2 = new StreamWriter(fs2);
                        sw2.Write(permbajtjaQelsit);
                        sw2.Flush();
                        sw2.Close();
                    }

                    tstStatusi.Text = statusiE + (fundi - fillimi) + " ms";
                }
                catch (Exception error)
                {
                    MessageBox.Show(gabimi + error);
                }
            }
            else MessageBox.Show("Ju lutem zgjedhni nje lloj te Enkriptimit!");
        }
        
        private void btnDekript_Click(object sender, EventArgs e)
        {
            int fillimi = 0;
            if (comboBox1.SelectedIndex == 0)
            {
                fillimi = DateTime.Now.Millisecond;     //me mate kohen
                try
                {
                    StreamReader sr = new StreamReader(txtFajlli.Text);
                    string cipher = sr.ReadToEnd();
                    sr.Close();
                    string celesi = txtkey.Text;
                    byte[] key1 = utf8.GetBytes(celesi.Substring(0, 8));
                    byte[] key2 = utf8.GetBytes(celesi.Substring(8, 8));

                    int fundi = DateTime.Now.Millisecond;
                    tstStatusi.Text = statusiE + (fundi - fillimi) + " ms";
                    //MessageBox.Show("Dekriptimi perfundoi me sukses!"); 
                }

                catch (Exception error)
                {
                    MessageBox.Show("Ka ndodhur nje gabim!\n" + error);
                }
            }
            else if (comboBox1.SelectedIndex == 1)   //zgjedhja per enkriptim me 3DES 
            {
                fillimi = DateTime.Now.Millisecond;   
                tDES.Key = utf8.GetBytes(txtkey.Text);
                tDES.Mode = CipherMode.CBC;   //modi enkriptues Cipher Block Chaining each block of plaintext is XORed with the previous ciphertext block before being encrypted. To make each message unique, an initialization vector must be used in the first block.
                tDES.IV = utf8.GetBytes("06041995");
                tDES.Padding = PaddingMode.Zeros;

                FileStream fs = new FileStream(txtFajlli.Text, FileMode.Open, FileAccess.Read);
                CryptoStream csDec = new CryptoStream(fs, tDES.CreateDecryptor(), CryptoStreamMode.Read);
                StreamReader sr = new StreamReader(csDec);
                string permbajtja = sr.ReadToEnd();
                sr.Close();
                fs.Dispose(); fs.Close();

                int fundi = DateTime.Now.Millisecond;
                tstStatusi.Text = statusiD + (fundi - fillimi) + " ms";

                StreamWriter sw = new StreamWriter(txtFajlli.Text);
                sw.Write(permbajtja);
                sw.Flush();
                sw.Close();
            }
            else MessageBox.Show("Ju lutem zgjidhni nje lloj te Enkriptimit!");
        }

        private void btnReset_Click(object sender, EventArgs e)//Freskimi i te gjitha fushave
        {
            richTextBox1.Clear();
            txtkey.Clear();
            txtFajlli.Clear();
            comboBox1.SelectedIndex = -1;
        }

        private void AutoKey_CheckedChanged(object sender, EventArgs e)//Gjenerimi Auto i Celsit 3DES
        {
            if (chAutoKey.Checked)
            {
                RandomNumberGenerator rng = RandomNumberGenerator.Create();
                byte[] key = new byte[24];
                rng.GetBytes(key);
                txtkey.Text = Encoding.ASCII.GetString(key);
            }
            else txtkey.Clear();
        }

        private void btnRefresh_Click(object sender, EventArgs e)//Freskimi i leximit te fajllit
        {
            StreamReader sr = new StreamReader(txtFajlli.Text);
            richTextBox1.Text = sr.ReadToEnd();
            sr.Dispose();
        } 

        /// <>
        /// -------------------------   Pjesa e kodit shtese, interaksioni    --------------------------------\\\
        /// </>
        bool Zgjerimi = false; //zgjerimi i FORM-es 
        private void btnZgjerimi_Click(object sender, EventArgs e)
        {
            if (Zgjerimi)
            {
                this.Size = new Size(358, this.Size.Height);
                Zgjerimi = false;
                btnZgjerimi.Image = DetyraSiguri.Properties.Resources.Djathte;
                btnZgjerimi.Location = new Point(317, btnZgjerimi.Location.Y);
            }
            else
            {
                this.Size = new Size(338 + 360, this.Size.Height);
                Zgjerimi = true;
                btnZgjerimi.Image = DetyraSiguri.Properties.Resources.Majte;
                btnZgjerimi.Location = new Point(338 + 360-50, btnZgjerimi.Location.Y);
                try
                {
                    StreamReader sr = new StreamReader(txtFajlli.Text);
                    richTextBox1.Text = sr.ReadToEnd();
                    sr.Dispose();
                }
                catch (Exception)
                {
                    MessageBox.Show("Ju lutem zgjedhni fajllin paraprakisht!");
                }
            }
        }

        private void NdrroGjuhen(CultureInfo ci, string q)
        {
            Assembly a = Assembly.Load("DetyraSiguri");
            ResourceManager rm = new ResourceManager(q, a);

            btnOpsion.Text = rm.GetString("btnOpsion", ci);
            btnReset.Text = rm.GetString("btnReset", ci);
            lblLlojiEnkr.Text = rm.GetString("lblLlojiEnkr", ci);
            lblZgjedhFajllin.Text = rm.GetString("lblZgjedhFajllin", ci);            
            btnMbyll.Text = rm.GetString("btnMbyll", ci);
            tstShqip.Text = rm.GetString("tstShqip", ci);
            tstAnglisht.Text = rm.GetString("tstAnglisht", ci);
            btnDekript.Text = rm.GetString("btnDekript", ci);
            btnEnkript.Text = rm.GetString("btnEnkript", ci);
            grInfo.Text = rm.GetString("grInfo", ci);
            lblInfo.Text = rm.GetString("lblInfo", ci);

            statusiE = rm.GetString("tstStatusiE", ci);
            statusiD = rm.GetString("tstStatusiD", ci);
            gabimi = rm.GetString("gabimi", ci);
            titulliNeRuajtjeTeCelsit = rm.GetString("titulliNeRuajtjeTeCelsit", ci);
        } 

        private void tstShqip_Click(object sender, EventArgs e)
        {
                CultureInfo ci = new CultureInfo("al-AL");
                NdrroGjuhen(ci, "DetyraSiguri.Lang.langres.al");            
        }

        private void tstAnglisht_Click(object sender, EventArgs e)
        {
                CultureInfo ci = new CultureInfo("en-US");
                NdrroGjuhen(ci, "DetyraSiguri.Lang.langres");            
        }

        private void btnMbyll_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        int radha = 2;
        private void pbNext_Click(object sender, EventArgs e)
        {  }  
        private void pbBack_Click(object sender, EventArgs e)
        {}

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grInfo.Visible = true;
        }
        private void grInfo_Leave(object sender, EventArgs e)
        {
            grInfo.Visible = false;
        }        
    }
}
