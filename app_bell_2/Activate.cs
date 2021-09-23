using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app_bell_2
{
    public partial class Activate : Form
    {
        public Activate()
        {
            InitializeComponent();
        }

        Connection c = new Connection();
        SQLiteConnection k; SQLiteCommand cmd; SQLiteDataReader baca; string query;
        public static string lang; int x = 0;

        private void Activate_Load(object sender, EventArgs e)
        {
            CenterToParent();
            k = c.connect();
            k.Open();
            checkLang();
            start();
            ep.Clear();
        }

        void checkLang()
        {
            ToolTip toolTip1 = new ToolTip();

            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 1000;
            toolTip1.ReshowDelay = 500;
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(label1, "AUTOMATIC SCHOOL BELL");

            if (Main.lang == "1")
            {
                Text = "Activation";
                lblActivate.Text = "ACTIVATION";
                lblActivate1.Text = "Enter Activation Code";
                lblActivate2.Text = "Confirm Activation Code";
                btnActivate.Text = "Activate Now";

                toolTip1.SetToolTip(lblActivate1, "Enter Activation Code");
                toolTip1.SetToolTip(lblActivate2, "Confirm Activation Code");
                toolTip1.SetToolTip(txtActivate1, "Enter Activation Code");
                toolTip1.SetToolTip(txtActivate2, "Confirm Activation Code");
                toolTip1.SetToolTip(btnActivate, "Activate Now");
            }
            else
            {
                Text = "Aktivasi";
                lblActivate.Text = "AKTIVASI";
                lblActivate1.Text = "Masukkan Kode Aktivasi";
                lblActivate2.Text = "Konfirmasi Kode Aktivasi";
                btnActivate.Text = "Aktivasi Sekarang";

                toolTip1.SetToolTip(lblActivate1, "Masukkan Kode Aktivasi");
                toolTip1.SetToolTip(lblActivate2, "Konfirmasi Kode Aktivasi");
                toolTip1.SetToolTip(txtActivate1, "Masukkan Kode Aktivasi");
                toolTip1.SetToolTip(txtActivate2, "Konfirmasi Kode Aktivasi");
                toolTip1.SetToolTip(btnActivate, "Aktivasi Sekarang");
            }
        }

        void start()
        {
            txtActivate1.Clear();
            txtActivate2.Clear();
        }

        private string Encrypt(string clearText)
        {
            string EncryptionKey = "bean";
            byte[] clearBytes = Encoding.Unicode.GetBytes(clearText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }
                    clearText = Convert.ToBase64String(ms.ToArray());
                }
            }
            return clearText;
        }

        private void btnActivate_Click(object sender, EventArgs e)
        {
            try
            {
                if (validate(txtActivate1, "Activation Code", "Kode Aktivasi") && validate(txtActivate2, "Confirmation Code", "Kode Konfirmasi") && txtActivate1.Text == txtActivate2.Text)
                {
                    string answer;
                    query = "SELECT Val FROM Activation WHERE Var = 'Code';";
                    Console.WriteLine(query);
                    cmd = new SQLiteCommand(query, k);
                    baca = cmd.ExecuteReader();
                    answer = baca[0].ToString();
                    baca.Close();
                    cmd.Dispose();
                    Console.WriteLine(answer);
                    Console.WriteLine(Encrypt(txtActivate1.Text));

                    if (Encrypt(txtActivate1.Text) == answer)
                    {
                        ep.Clear();
                        query = "UPDATE Config SET Val = 1 WHERE Var = 'IsActive';";
                        Console.WriteLine(query);
                        cmd = new SQLiteCommand(query, k);
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                        if (Main.lang == "1")
                        {
                            MessageBox.Show("Successfully ACTIVATED! The app will restart.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Aktivasi BERHASIL! Aplikasi akan restart.", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        x = 1;
                        Hide();
                        Main M = new Main();
                        M.Show();
                    }
                    else
                    {
                        if (Main.lang == "1")
                        {
                            ep.SetError(btnActivate, "Code incorrect. Please try again.");
                        }
                        else
                        {
                            ep.SetError(btnActivate, "Kode salah. Silakan coba lagi.");
                        }
                    }
                }
                else
                {
                    if (Main.lang == "1")
                    {
                        ep.SetError(btnActivate, "Activation code or confirmation code incorrect. Please try again.");
                    }
                    else
                    {
                        ep.SetError(btnActivate, "Kode aktivasi atau kode konfirmasi salah. Silakan coba lagi.");
                    }
                }
            }
            catch (Exception)
            {

            }            
        }

        bool validate(TextBox txt, string prop1, string prop2)
        {
            if (txt.Text != string.Empty)
            {
                if (txt.Text.Length > 5)
                {
                    ep.Clear();
                    return true;
                }
                else
                {
                    if (Main.lang == "1")
                    {
                        ep.SetError(txt, prop1 + " cannot be under 5 digits");
                    }
                    else
                    {
                        ep.SetError(txt, prop2 + " tidak boleh kurang dari 5 digit");
                    }
                    return false;
                }
            }
            else
            {
                if (Main.lang == "1")
                {
                    ep.SetError(txt, prop1 + " cannot be empty");
                }
                else
                {
                    ep.SetError(txt, prop2 + " tidak boleh kosong");
                }
                return false;
            }
        }

        private void txtActivate1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtActivate1_Validating(object sender, CancelEventArgs e)
        {
            validate(txtActivate1, "Activation Code", "Kode Aktivasi");
        }

        private void txtActivate2_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtActivate2_Validating(object sender, CancelEventArgs e)
        {
            if (validate(txtActivate2, "Confirmation Code", "Kode Konfirmasi"))
            {
                if (txtActivate1.Text != txtActivate2.Text)
                {
                    if (Main.lang == "1")
                    {
                        ep.SetError(txtActivate1, "Confirmation Code must be same with Activation Code");
                    }
                    else
                    {
                        ep.SetError(txtActivate1, "Kode Konfirmassi harus sama dengan Kode Aktivasi");
                    }
                }
                else
                {
                    ep.Clear();
                }
            }
        }

        private void Activate_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (x == 1)
            {

            }
            else
            {
                Hide();
                Main m = new Main();
                m.Show();
            }
        }
    }
}
