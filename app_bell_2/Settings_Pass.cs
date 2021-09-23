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

namespace app_bell_2
{
    public partial class Settings_Pass : Form
    {

        private Main main;

        public Settings_Pass(Main main)
        {
            InitializeComponent();
            this.main = main;
        }

        Connection c = new Connection();
        SQLiteConnection k; SQLiteCommand cmd; SQLiteDataReader baca; string query;
        bool isSettings; string lang;

        private void Settings_Pass_Load(object sender, EventArgs e)
        {
            CenterToParent();
            k = c.connect();
            k.Open();
            isRemember();
            txtPass.isPassword = true;
            txtPass.Leave += TxtPass_Leave;
            TxtPass_Leave(sender, e);
            isSettings = false;
            lang = Main.lang;
            start();
        }

        void start()
        {
            ToolTip toolTip1 = new ToolTip();

            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 1000;
            toolTip1.ReshowDelay = 500;
            toolTip1.ShowAlways = true;

            if (lang == "1")
            {
                Text = "Enter Password";
                label1.Text = "Enter Password";
                checkBox1.Text = "Remember Me";
                linkPass.Text = "Forgot Password?";
                btnLanjut.Text = "Next";

                toolTip1.SetToolTip(btnShowPass, "Show Password");
                toolTip1.SetToolTip(checkBox1, "Remember Me");
                toolTip1.SetToolTip(linkPass, "Reset Password");
                toolTip1.SetToolTip(btnLanjut, "Continue to Settings Page");
            }
            else
            {
                Text = "Masukkan Password";
                label1.Text = "Masukkan Password";
                checkBox1.Text = "Ingat Saya";
                linkPass.Text = "Lupa Password?";
                btnLanjut.Text = "Lanjut";

                toolTip1.SetToolTip(btnShowPass, "Tampilkan Password");
                toolTip1.SetToolTip(checkBox1, "Ingat Saya");
                toolTip1.SetToolTip(linkPass, "Reset Password");
                toolTip1.SetToolTip(btnLanjut, "Lanjut ke Halaman Pengaturan");
            }
        }

        void isRemember()
        {
            try
            {
                string val;
                query = "SELECT * FROM Config WHERE Var = 'Pass';";
                Console.WriteLine(query);
                cmd = new SQLiteCommand(query, k);
                baca = cmd.ExecuteReader();
                baca.Read();
                val = baca[1].ToString();
                lblRem.Text = baca[2].ToString();
                if (val == "True")
                {
                    checkBox1.Checked = true;
                    txtPass.Text = lblRem.Text;
                }
                else
                {
                    checkBox1.Checked = false;
                    txtPass.Text = "";
                }
                baca.Close();
                cmd.Dispose();
            }
            catch (Exception)
            {

            }           
        }

        private void TxtPass_Leave(object sender, EventArgs e)
        {
            txtPass.ForeColor = Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(169)))), ((int)(((byte)(204)))));
            txtPass.HintForeColor = Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(169)))), ((int)(((byte)(204)))));
            txtPass_OnValueChanged(sender, e);
        }

        private void txtPass_OnValueChanged(object sender, EventArgs e)
        {
            if (txtPass.Text.Length > 0)
            {
                btnShowPass.Visible = true;
            }
            else
            {
                btnShowPass.Visible = false;
            }
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            txtPass.ForeColor = Color.Gray;
        }

        private void btnShowPass_Click(object sender, EventArgs e)
        {
            if (txtPass.isPassword == true)
            {
                txtPass.isPassword = false;
            }
            else
            {
                txtPass.isPassword = true;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (checkBox1.Checked == true)
                {
                    query = "UPDATE Config SET Val = 1 WHERE Var = 'Pass';";
                }
                else
                {
                    query = "UPDATE Config SET Val = 0 WHERE Var = 'Pass';";
                }
                Console.WriteLine(query);
                cmd = new SQLiteCommand(query, k);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (Exception)
            {

            }
        }

        private void Settings_Pass_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isSettings == true)
            {
                //Settings s = new Settings(main);
                //s.Show();
                //main.Visible = false;
                //Hide();
            }
            else
            {
                Hide();
                Main m = new Main();
                m.Show();
            }
        }

        private void btnLanjut_Click(object sender, EventArgs e)
        {
            if (txtPass.Text != lblRem.Text)
            {
                if (lang == "1")
                {
                    MessageBox.Show("Password incorrect. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Password salah. Silakan coba lagi.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                isSettings = true;
                Settings s = new Settings(main);
                s.Show();
                main.Visible = false;
                Hide();
            }
        }

        private void linkPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            Settings_ChangePass sc = new Settings_ChangePass(main, false);
            sc.ShowDialog(main);
        }
    }
}
