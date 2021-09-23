using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework.UI;

namespace app_bell_2
{
    public partial class Settings_ChangePass : Form
    {

        private Main main;
        private Settings settings;
        private bool val, isEnd;

        public Settings_ChangePass(Main main, bool val)
        {
            InitializeComponent();
            this.main = main;
            this.val = val;
        }

        public Settings_ChangePass(Main main, bool val, Settings settings)
        {
            InitializeComponent();
            this.main = main;
            this.val = val;
            this.settings = settings;
        }

        Connection c = new Connection();
        SQLiteConnection k; SQLiteCommand cmd; SQLiteDataReader baca; string query;

        private void Settings_ChangePass_Load(object sender, EventArgs e)
        {
            CenterToParent();
            k = c.connect();
            k.Open();
            start();
            TxtPass1_Leave(sender, e);
            TxtPass2_Leave(sender, e);
            TxtPass3_Leave(sender, e);
            isEnd = false;
            ep.Clear();
        }

        void start()
        {
            txtPass1.Leave += TxtPass1_Leave;
            txtPass2.Leave += TxtPass2_Leave;
            txtPass3.Leave += TxtPass3_Leave;

            ToolTip toolTip1 = new ToolTip();
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 1000;
            toolTip1.ReshowDelay = 500;
            toolTip1.ShowAlways = true;

            if (Main.lang == "1")
            {
                if (val)
                {
                    Text = "Change Password";
                    label1.Text = "Enter Old Password";
                    label2.Text = "Enter New Password";
                    label3.Show();
                    label3.Text = "Enter Password Confirmation";
                    txtPass1.Text = "";
                    txtPass2.Text = "";
                    txtPass3.Text = "";

                    toolTip1.SetToolTip(label1, label1.Text);
                    toolTip1.SetToolTip(label2, label2.Text);
                    toolTip1.SetToolTip(label3, label2.Text);
                    toolTip1.SetToolTip(btnShowPass1, "Show old password");
                    toolTip1.SetToolTip(btnShowPass2, "Show new password");
                    toolTip1.SetToolTip(btnShowPass3, "Show password confirmation");

                    getPassLama();
                }
                else
                {
                    Text = "Reset Password";
                    label1.Text = "Enter New Password";
                    label2.Text = "Enter Password Confirmation";
                    label3.Hide();
                    txtPass1.Text = "";
                    txtPass2.Text = "";
                    txtPass3.Hide();
                    btnShowPass3.Hide();

                    toolTip1.SetToolTip(label1, label1.Text);
                    toolTip1.SetToolTip(label2, label2.Text);
                    toolTip1.SetToolTip(btnShowPass1, "Show new password");
                    toolTip1.SetToolTip(btnShowPass2, "Show password confirmation");
                }
                btnSimpan.Text = "Save";
                toolTip1.SetToolTip(btnSimpan, "Save Password");
            }
            else
            {
                if (val)
                {
                    Text = "Perbarui Password";
                    label1.Text = "Masukkan Password Lama";
                    label2.Text = "Masukkan Password Baru";
                    label3.Show();
                    label3.Text = "Konfirmasi Password Baru";
                    txtPass1.Text = "";
                    txtPass2.Text = "";
                    txtPass3.Text = "";

                    toolTip1.SetToolTip(label1, label1.Text);
                    toolTip1.SetToolTip(label2, label2.Text);
                    toolTip1.SetToolTip(label3, label2.Text);
                    toolTip1.SetToolTip(btnShowPass1, "Tampilkan password lama");
                    toolTip1.SetToolTip(btnShowPass2, "Tampilkan password baru");
                    toolTip1.SetToolTip(btnShowPass3, "Tampilkan konfirmasi password");

                    getPassLama();
                }
                else
                {
                    Text = "Reset Password";
                    label1.Text = "Masukkan Password Baru";
                    label2.Text = "Konfirmasi Password";
                    label3.Hide();
                    txtPass1.Text = "";
                    txtPass2.Text = "";
                    txtPass3.Hide();
                    btnShowPass3.Hide();

                    toolTip1.SetToolTip(label1, label1.Text);
                    toolTip1.SetToolTip(label2, label2.Text);
                    toolTip1.SetToolTip(btnShowPass1, "Tampilkan password baru");
                    toolTip1.SetToolTip(btnShowPass2, "Tampilkan konfirmasi password");
                }
                btnSimpan.Text = "Simpan";
                toolTip1.SetToolTip(btnSimpan, "Simpan Password");
            }
        }

        void getPassLama()
        {
            try
            {
                query = "SELECT Desc FROM Config WHERE Var = 'Pass';";
                Console.WriteLine(query);
                cmd = new SQLiteCommand(query, k);
                baca = cmd.ExecuteReader();
                baca.Read();
                lblRem.Text = baca[0].ToString();
                baca.Close();
                cmd.Dispose();
            }
            catch (Exception e)
            {
                DialogResult msg = MessageBox.Show(e.ToString(), "Kesalahan", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (msg == DialogResult.Retry)
                {
                    getPassLama();
                }
            }
            
        }

        private void TxtPass1_Leave(object sender, EventArgs e)
        {
            txtPass1.isPassword = false;
            txtPass1.ForeColor = Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(169)))), ((int)(((byte)(204)))));
            txtPass1.HintForeColor = Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(169)))), ((int)(((byte)(204)))));
            txtPass1_OnValueChanged(sender, e);
        }

        private void TxtPass2_Leave(object sender, EventArgs e)
        {
            txtPass2.isPassword = false;
            txtPass2.ForeColor = Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(169)))), ((int)(((byte)(204)))));
            txtPass2.HintForeColor = Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(169)))), ((int)(((byte)(204)))));
            txtPass2_OnValueChanged(sender, e);
        }

        private void TxtPass3_Leave(object sender, EventArgs e)
        {
            txtPass3.isPassword = false;
            txtPass3.ForeColor = Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(169)))), ((int)(((byte)(204)))));
            txtPass3.HintForeColor = Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(169)))), ((int)(((byte)(204)))));
            txtPass3_OnValueChanged(sender, e);
        }

        private void txtPass1_OnValueChanged(object sender, EventArgs e)
        {
            txtPass1.isPassword = true;
            if (txtPass1.Text.Length > 0)
            {
                btnShowPass1.Visible = true;
            }
            else
            {
                btnShowPass1.Visible = false;
            }
        }

        private void txtPass2_OnValueChanged(object sender, EventArgs e)
        {
            txtPass2.isPassword = true;
            if (txtPass2.Text.Length > 0)
            {
                btnShowPass2.Visible = true;
            }
            else
            {
                btnShowPass2.Visible = false;
            }
        }

        private void txtPass3_OnValueChanged(object sender, EventArgs e)
        {
            txtPass3.isPassword = true;
            if (val)
            {
                if (txtPass3.Text.Length > 0)
                {
                    btnShowPass3.Visible = true;
                }
                else
                {
                    btnShowPass3.Visible = false;
                }
            }
        }

        private void txtPass1_Enter(object sender, EventArgs e)
        {
            txtPass1.isPassword = true;
            txtPass1.ForeColor = Color.Gray;
        }

        private void txtPass2_Enter(object sender, EventArgs e)
        {
            txtPass2.isPassword = true;
            txtPass2.ForeColor = Color.Gray;
        }

        private void txtPass3_Enter(object sender, EventArgs e)
        {
            txtPass3.isPassword = true;
            txtPass3.ForeColor = Color.Gray;
        }

        private void btnShowPass1_Click(object sender, EventArgs e)
        {
            if (txtPass1.isPassword == true)
            {
                txtPass1.isPassword = false;
            }
            else
            {
                txtPass1.isPassword = true;
            }
        }

        private void btnShowPass2_Click(object sender, EventArgs e)
        {
            if (txtPass2.isPassword == true)
            {
                txtPass2.isPassword = false;
            }
            else
            {
                txtPass2.isPassword = true;
            }
        }

        private void btnShowPass3_Click(object sender, EventArgs e)
        {
            if (txtPass3.isPassword == true)
            {
                txtPass3.isPassword = false;
            }
            else
            {
                txtPass3.isPassword = true;
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (val)
            {
                if (cekPassLama(txtPass1) && cekPassBaru(txtPass2) && cekConfirmPass(txtPass2, txtPass3))
                {
                    saveNewPass();
                }
            }
            else
            {
                if (cekPassBaru(txtPass1) && cekConfirmPass(txtPass1, txtPass2))
                {
                    saveNewPass();
                }
            }
        }

        void saveNewPass()
        {
            string text1, capt1, text2, capt2;
            if (Main.lang == "1")
            {
                text1 = "Are you sure to update the password?";
                text2 = "Password updated successfully!";
                capt1 = "Confirmation";
                capt2 = "Information";
            }
            else
            {
                text1 = "Anda yakin untuk memperbarui password?";
                text2 = "Password berhasil diperbarui!";
                capt1 = "Konfirmasi";
                capt2 = "Informasi";
            }


            DialogResult msg = MessageBox.Show(text1, capt1, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (msg == DialogResult.Yes)
            {
                try
                {
                    query = "UPDATE Config SET Desc = '" + txtPass2.Text + "', Val = 0 WHERE Var = 'Pass';";
                    Console.WriteLine(query);
                    cmd = new SQLiteCommand(query, k);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    MessageBox.Show(text2, capt2, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    isEnd = true;
                    if (val)
                    {
                        Hide();
                        settings.Hide();
                        Main f = new Main();
                        f.Show();
                    }
                    else
                    {
                        Hide();
                    }
                }
                catch (Exception e)
                {
                    DialogResult msg1 = MessageBox.Show(e.ToString(), "Kesalahan", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    if (msg1 == DialogResult.Retry)
                    {
                        saveNewPass();
                    }
                }
            }
        }

        bool cekPassLama(BunifuMaterialTextbox txt)
        {
            string a, b;
            if (Main.lang == "1")
            {
                a = "Old password incorrect. Please try again.";
                b = "Old password cannot be empty. Please try again.";
            }
            else
            {
                a = "Password lama salah. Silakan coba lagi.";
                b = "Password lama tidak boleh kosong. Silakan coba lagi.";
            }

            if (txt.Text != string.Empty)
            {
                if (txt.Text == lblRem.Text)
                {
                    ep.Clear();
                    return true;
                }
                else
                {
                    ep.SetError(txt, a);
                    return false;
                }
            }
            else
            {
                ep.SetError(txt, b);
                return false;
            }
        }

        bool cekPassBaru(BunifuMaterialTextbox txt)
        {
            string a;
            if (Main.lang == "1")
            {
                a = "New password cannot be empty. Please try again.";
            }
            else
            {
                a = "Password baru tidak boleh kosong. Silakan coba lagi.";
            }
            if (txt.Text != string.Empty)
            {
                ep.Clear();
                return true;
            }
            else
            {
                ep.SetError(txt, a);
                return false;
            }
        }

        bool cekConfirmPass(BunifuMaterialTextbox passBaru, BunifuMaterialTextbox txt)
        {
            string a, b;
            if (Main.lang == "1")
            {
                a = "Password confirmation must be equal to new password. Please try again.";
                b = "Password confirmation cannot be empty. Please try again.";
            }
            else
            {
                a = "Konfirmasi password harus sama dengan password baru. Silakan coba lagi.";
                b = "Konfirmasi password tidak boleh kosong. Silakan coba lagi.";
            }

            if (txt.Text != string.Empty)
            {
                if (txt.Text == passBaru.Text)
                {
                    ep.Clear();
                    return true;
                }
                else
                {
                    ep.SetError(txt, a);
                    return false;
                }
            }
            else
            {
                ep.SetError(txt, b);
                return false;
            }
        }

        private void txtPass1_Validating(object sender, CancelEventArgs e)
        {
            if (val)
            {
                cekPassLama(txtPass1);
            }
            else
            {
                cekPassBaru(txtPass1);
            }
        }

        private void txtPass2_Validating(object sender, CancelEventArgs e)
        {
            if (val)
            {
                cekPassBaru(txtPass2);
            }
            else
            {
                cekConfirmPass(txtPass1, txtPass2);
            }
        }

        private void txtPass3_Validating(object sender, CancelEventArgs e)
        {
            if (val)
            {
                cekConfirmPass(txtPass2, txtPass3);
            }
        }

        private void Settings_ChangePass_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isEnd)
            {
                Hide();
            }
        }
    }
}
