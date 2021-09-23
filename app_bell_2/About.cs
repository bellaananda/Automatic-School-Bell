using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace app_bell_2
{
    public partial class About : Form
    {

        private Main main;

        public About(Main main)
        {
            InitializeComponent();
            this.main = main;
            lblAppName.Text = AssemblyProduct.ToUpper();
            lblVersi.Text = String.Format("Version {0}", AssemblyVersion);
            lblCr.Text = AssemblyCopyright;
            label2.Text = AssemblyCompany;
        }

        #region Assembly Attribute Accessors

        public string AssemblyTitle
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (attributes.Length > 0)
                {
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    if (titleAttribute.Title != "")
                    {
                        return titleAttribute.Title;
                    }
                }
                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        public string AssemblyDescription
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyDescriptionAttribute)attributes[0]).Description;
            }
        }

        public string AssemblyProduct
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }

        public string AssemblyCopyright
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }

        public string AssemblyCompany
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCompanyAttribute)attributes[0]).Company;
            }
        }
        #endregion

        Connection c = new Connection();
        SQLiteConnection k; SQLiteCommand cmd; SQLiteDataReader baca; string query;

        private void About_Load(object sender, EventArgs e)
        {
            CenterToParent();
            k = c.connect();
            k.Open();
            Icon = new Icon(Directory.GetCurrentDirectory() + @"\bin\Debug" + Main.iconPath);
            showAppDesc();
        }

        void showAppDesc()
        {
            try
            {
                string root, path;
                root = Directory.GetCurrentDirectory() + @"\bin\Debug"; //for publishing
                query = "SELECT Val FROM Activation WHERE Var = 'IconPath';";
                Console.WriteLine(query);
                cmd = new SQLiteCommand(query, k);
                baca = cmd.ExecuteReader();
                path = baca[0].ToString();
                baca.Close();
                cmd.Dispose();
                pbIcon.BackgroundImage = Image.FromFile(root + path);
                pbIcon.BackgroundImageLayout = ImageLayout.Stretch;

                query = "SELECT Desc FROM Config WHERE Var = 'Desc';";
                Console.WriteLine(query);
                cmd = new SQLiteCommand(query, k);
                baca = cmd.ExecuteReader();
                lblDesc.Text = baca[0].ToString();
                baca.Close();
                cmd.Dispose();
            }
            catch (Exception)
            {
                //throw;
            }
        }

        private void About_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();
        }
    }
}
