using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app_bell_2
{
    public partial class Contact : Form
    {

        private Main main;

        public Contact(Main main)
        {
            InitializeComponent();
            this.main = main;
        }

        Connection c = new Connection();
        SQLiteConnection k; SQLiteCommand cmd; SQLiteDataReader baca; string query;

        private void Contact_Load(object sender, EventArgs e)
        {
            CenterToParent();
            k = c.connect();
            k.Open();
            Icon = new Icon(Directory.GetCurrentDirectory() + @"\bin\Debug" + Main.iconPath);
            showInstance();
            showContacts();
        }

        void showInstance()
        {
            try
            {
                //nama smk
                query = "SELECT Val FROM Activation WHERE Var = 'Instance';";
                Console.WriteLine(query);
                cmd = new SQLiteCommand(query, k);
                baca = cmd.ExecuteReader();
                lblInstance.Text = baca[0].ToString();
                baca.Close();
                cmd.Dispose();

                //alamat
                lblAddress.Text = "";
                query = "SELECT Var, Val FROM Activation WHERE Var = 'Address1' UNION " +
                        "SELECT Var, Val FROM Activation WHERE Var = 'Address2' UNION " +
                        "SELECT Var, Val FROM Activation WHERE Var = 'Address3' ORDER BY Var ASC";
                Console.WriteLine(query);
                cmd = new SQLiteCommand(query, k);
                baca = cmd.ExecuteReader();
                while (baca.Read())
                {
                    lblAddress.Text = lblAddress.Text + " " + baca[1].ToString();
                }
                baca.Close();
                cmd.Dispose();

                //foto
                string root, path;
                root = Directory.GetCurrentDirectory() + @"\bin\Debug";
                query = "SELECT Val FROM Activation WHERE Var = 'LogoPath';";
                Console.WriteLine(query);
                cmd = new SQLiteCommand(query, k);
                baca = cmd.ExecuteReader();
                path = baca[0].ToString();
                baca.Close();
                cmd.Dispose();
                pbLogo.BackgroundImage = Image.FromFile(root + path);
                pbLogo.BackgroundImageLayout = ImageLayout.Stretch;
            }
            catch (Exception)
            {
                //throw;
            }
        }

        void showContacts()
        {
            try
            {
                //phone
                query = "SELECT Val FROM Activation WHERE Var = 'Phone';";
                Console.WriteLine(query);
                cmd = new SQLiteCommand(query, k);
                baca = cmd.ExecuteReader();
                baca.Read();
                lblPhone.Text = baca[0].ToString();
                baca.Close();
                cmd.Dispose();

                //email
                query = "SELECT Val FROM Activation WHERE Var = 'Email';";
                Console.WriteLine(query);
                cmd = new SQLiteCommand(query, k);
                baca = cmd.ExecuteReader();
                baca.Read();
                lblEmail.Text = baca[0].ToString();
                baca.Close();
                cmd.Dispose();

                //website
                query = "SELECT Val FROM Activation WHERE Var = 'Website';";
                Console.WriteLine(query);
                cmd = new SQLiteCommand(query, k);
                baca = cmd.ExecuteReader();
                baca.Read();
                lblWeb.Text = baca[0].ToString();
                baca.Close();
                cmd.Dispose();
            }
            catch (Exception)
            {
                //throw;
            }           
        }

        private void Contact_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();
        }

        private void lblEmail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string command = "mailto:" + lblEmail.Text;
            Process.Start(command);
        }

        private void lblWeb_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = lblWeb.Text, UseShellExecute = true });
        }

        private void lblPhone_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Clipboard.SetText(lblPhone.Text);
            string msgText, msgTitle;
            if (Main.lang == "1")
            {
                msgText = "Phone number copied to clipboard!";
                msgTitle = "Information";
            }
            else
            {
                msgText = "Nomor telepon disalin!";
                msgTitle = "Informasi";
            }
            MessageBox.Show(msgText, msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
