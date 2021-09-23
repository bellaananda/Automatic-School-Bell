using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app_bell_2
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        Timer time = new Timer(); //timer for time label
        Connection c = new Connection();
        SQLiteConnection k; SQLiteCommand cmd; SQLiteDataAdapter da; SQLiteDataReader baca; DataTable dt; string query;
        public static string lang, iconPath; //for language identifying & icon path
        int isPlayin = 0; //audio playing status
        WMPLib.WindowsMediaPlayer playy = new WMPLib.WindowsMediaPlayer(); //audio play

        public void Main_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            k = c.connect();
            k.Open();
            isActivated();
            checkLang();
            isOn();
            start();
            showInstance();
            showIcon();
        }

        //check if the program has already activated
        void isActivated()
        {
            try
            {
                query = "SELECT Val FROM Config WHERE Var = 'IsActive';";
                Console.WriteLine(query);
                cmd = new SQLiteCommand(query, k);
                baca = cmd.ExecuteReader();
                string isActive = baca[0].ToString();
                Console.WriteLine(isActive);
                baca.Close();
                cmd.Dispose();
                if (isActive == "True")
                {
                    btnActivate.Visible = false;
                }
                else
                {
                    btnActivate.Visible = true;
                }
            }
            catch (Exception)
            {
                //
            }
        }

        //check language used
        void checkLang()
        {
            try
            {
                query = "SELECT CAST(" + "Val" + " as TEXT) AS Conf FROM Config WHERE Var = 'Lang' ;";
                Console.WriteLine(query);
                cmd = new SQLiteCommand(query, k);
                baca = cmd.ExecuteReader();
                lblLang.Text = baca[0].ToString();
                lang = lblLang.Text;
                baca.Close();
                cmd.Dispose();

                if (lblLang.Text == "0")
                {
                    Text = "Halaman Utama";
                    lblChosenDay.Text = "Hari Dipilih";
                    lblDay.Text = ": -";
                    lblDayTitle.Text = "Hari Jadwal";
                    lblSchTitle.Text = "Jadwal Bel";
                    lblAudioTitle.Text = "Audio Manual";
                    lblAbout.Text = "Tentang Kami";
                    lblContact.Text = "Kontak Kami";
                }
                else
                {
                    Text = "Main";
                    lblChosenDay.Text = "Selected Day";
                    lblDay.Text = ": -";
                    lblDayTitle.Text = "Schedule Day";
                    lblSchTitle.Text = "Bell Schedule";
                    lblAudioTitle.Text = "Manual Audio";
                    lblAbout.Text = "About Us";
                    lblContact.Text = "Contact Us";
                }
            }
            catch (Exception e)
            {
                DialogResult msg = MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (msg == DialogResult.Retry)
                {
                    checkLang();
                }
            }
        }

        //is automatic mode on
        void isOn()
        {
            try
            {
                query = "SELECT CAST(" + "Val" + " as TEXT) AS Conf FROM Config WHERE Var = 'Start' ;";
                Console.WriteLine(query);
                cmd = new SQLiteCommand(query, k);
                baca = cmd.ExecuteReader();
                lblPow.Text = baca[0].ToString();
                baca.Close();
                cmd.Dispose();

                if (lblPow.Text == "1")
                {
                    btnOn.Enabled = false;
                    btnOff.Enabled = true;
                    Text = "Halaman Utama - Mode Otomatis";
                    if (lblLang.Text == "1")
                    {
                        Text = "Main - Automatic Mode";
                    }
                }
                else
                {
                    btnOn.Enabled = true;
                    btnOff.Enabled = false;
                    Text = "Halaman Utama";
                    if (lblLang.Text == "1")
                    {
                        Text = "Main";
                    }
                }
            }
            catch (Exception e)
            {
                DialogResult msg = MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (msg == DialogResult.Retry)
                {
                    isOn();
                }
            }
        }

        //main start program
        void start()
        {
            lblDate.Text = "";
            lblTime.Text = "";
            flpSch.Controls.Clear();
            showDate();
            showAudios();
            btnStopAudio.Visible = false;
            showDays();
            if (lblLang.Text == "0")
            {
                toolTipSetting();
            }
            else
            {
                toolTipSettingEn();
            }
            if (lblPow.Text == "1")
            {
                DateTime skrg = DateTime.Now;
                DateTime waktu = skrg.AddSeconds(-1).AddSeconds(1);

                var id = new CultureInfo("id-ID", false).DateTimeFormat; //ambil Indonesia
                if (lblLang.Text == "1")
                {
                    id = new CultureInfo("en-US", false).DateTimeFormat; //ambil English
                }
                var hari = id.GetDayName(dayofweek: waktu.DayOfWeek);
                showSchAuto(hari);
            }
            else
            {
                showSchOff();
            }
        }

        //show instance identity
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

        //show icon of the program
        void showIcon()
        {
            try
            {
                query = "SELECT Val FROM Activation WHERE Var = 'IconPath';";
                Console.WriteLine(query);
                cmd = new SQLiteCommand(query, k);
                baca = cmd.ExecuteReader();
                iconPath = baca[0].ToString();
                Console.WriteLine(iconPath);
                baca.Close();
                cmd.Dispose();
                Icon = new Icon(Directory.GetCurrentDirectory() + @"\bin\Debug" + iconPath);
            }
            catch (Exception)
            {
                //throw;
            }
        }

        //show tooltip settings in indonesian
        void toolTipSetting()
        {
            ToolTip toolTip1 = new ToolTip();

            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 1000;
            toolTip1.ReshowDelay = 500;
            toolTip1.ShowAlways = true;

            toolTip1.SetToolTip(label1, "AUTOMATIC SCHOOL BELL");
            toolTip1.SetToolTip(btnActivate, "Aktivasi Aplikasi");
            toolTip1.SetToolTip(btnSettings, "Ke Halaman Pengaturan");
            toolTip1.SetToolTip(btnOn, "Mode Otomatis");
            toolTip1.SetToolTip(btnOff, "Nonaktifkan Mode Otomatis");
            toolTip1.SetToolTip(lblTime, "Waktu");
            toolTip1.SetToolTip(lblDate, "Tanggal");
            toolTip1.SetToolTip(lblChosenDay, "Hari Dipilih");
            toolTip1.SetToolTip(lblDay, "Hari Dipilih");
            toolTip1.SetToolTip(lblDayTitle, "Hari Jadwal");
            toolTip1.SetToolTip(flpDays, "Daftar Hari");
            toolTip1.SetToolTip(lblSchTitle, "Jadwal Bel");
            toolTip1.SetToolTip(flpSch, "Jadwal Bel");
            toolTip1.SetToolTip(lblAudioTitle, "Audio Manual");
            toolTip1.SetToolTip(flpAudio, "Audio Manual");
            toolTip1.SetToolTip(lblAbout, "Tentang Kami");
            toolTip1.SetToolTip(lblContact, "Kontak Kami");
        }

        //show tooltip settings in english
        void toolTipSettingEn()
        {
            ToolTip toolTip1 = new ToolTip();

            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 1000;
            toolTip1.ReshowDelay = 500;
            toolTip1.ShowAlways = true;

            toolTip1.SetToolTip(label1, "AUTOMATIC SCHOOL BELL");
            toolTip1.SetToolTip(btnActivate, "App Activation");
            toolTip1.SetToolTip(btnSettings, "To Settings Page");
            toolTip1.SetToolTip(btnOn, "Enable Automatic Mode");
            toolTip1.SetToolTip(btnOff, "Disable Automatic Mode");
            toolTip1.SetToolTip(lblTime, "Time");
            toolTip1.SetToolTip(lblDate, "Date");
            toolTip1.SetToolTip(lblChosenDay, "Selected Day");
            toolTip1.SetToolTip(lblDay, "Selected Day");
            toolTip1.SetToolTip(lblDayTitle, "Schedule Day");
            toolTip1.SetToolTip(flpDays, "List of Days");
            toolTip1.SetToolTip(lblSchTitle, "Bell Schedule");
            toolTip1.SetToolTip(flpSch, "Bell Schedule");
            toolTip1.SetToolTip(lblAudioTitle, "Manual Audio");
            toolTip1.SetToolTip(flpAudio, "Manual Audio");
            toolTip1.SetToolTip(lblAbout, "About Us");
            toolTip1.SetToolTip(lblContact, "Contact Us");
        }

        //start timer tick
        void showDate()
        {
            time.Tick += new EventHandler(timer1_Tick);
            time.Interval = 100;
            time.Start();
        }

        //show date and time, start automatic mode if it's enabled
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime skrg = DateTime.Now;
            DateTime waktu = skrg.AddSeconds(-1).AddSeconds(1);

            var id = new CultureInfo("id-ID", false).DateTimeFormat; //ambil Indonesia
            if (lblLang.Text == "1")
            {
                id = new CultureInfo("en-US", false).DateTimeFormat; //ambil English
            }
            var hari = id.GetDayName(dayofweek: waktu.DayOfWeek);
            if (lblLang.Text == "1")
            {
                hari = id.GetDayName(dayofweek: waktu.DayOfWeek);
            }
            var bln = id.GetMonthName(month: waktu.Month);
            var tgl = skrg.ToString("dd");
            var thn = skrg.ToString("yyyy");

            lblDate.Text = hari + ", " + tgl + " " + bln + " " + thn;
            lblTime.Text = waktu.ToString(@"HH\:mm\:ss");

            if (lblPow.Text == "1")
            {
                AutoBell(hari);
            }
        }

        //run automatic mode
        void AutoBell(string hari)
        {
            foreach (Label item in flpSch.Controls)
            {
                if (item.Text == lblTime.Text)
                {
                    string path;
                    query = "SELECT Path FROM Jam JOIN Hari ON Jam.IdHari = Hari.IdHari JOIN Bel ON Jam.IdBel = Bel.IdBel WHERE Hari = '" + hari + "' AND jam = '" + item.Text + "'";
                    Console.WriteLine(query);
                    cmd = new SQLiteCommand(query, k);
                    baca = cmd.ExecuteReader();
                    baca.Read();
                    if (baca.HasRows)
                    {
                        path = baca[0].ToString();
                    }
                    else
                    {
                        path = "";
                    }
                    baca.Close();
                    cmd.Dispose();

                    try
                    {
                        if (File.Exists(path))
                        {
                            if (isPlayin == 0)
                            {
                                playy.URL = path;
                                playy.controls.play();
                                playy.PlayStateChange += Playy_PlayStateChange;
                            }
                            else
                            {
                                playy.controls.stop();
                                playy.URL = path;
                                playy.controls.play();
                                playy.PlayStateChange += Playy_PlayStateChange;
                            }
                        }
                        else
                        {
                            if (lblLang.Text == "1")
                            {
                                MessageBox.Show("File not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                MessageBox.Show("File tidak ditemukan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        if (lblLang.Text == "1")
                        {
                            MessageBox.Show(ex.ToString(), "Error - Invalid file", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show(ex.ToString(), "Error - File tidak sesuai", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void Player_PlayStateChange(int NewState)
        {
            Console.WriteLine(NewState);
            if (NewState == (int)WMPLib.WMPPlayState.wmppsPlaying)
            {
                isPlayin = 1;
                btnStopAudio.Visible = true;
            }
            else
            {
                isPlayin = 0;
                btnStopAudio.Visible = false;
            }
        }

        //to activation window
        private void btnActivate_Click(object sender, EventArgs e)
        {
            Activate act = new Activate();
            act.ShowDialog(this);
            Visible = false;
        }

        //to settings window
        private void btnSetting_Click(object sender, EventArgs e)
        {
            Settings_Pass sp = new Settings_Pass(this);
            sp.ShowDialog(this);
            Visible = false;
        }

        //enable automatic mode
        private void btnOn_Click(object sender, EventArgs e)
        {
            lblPow.Text = "1";
            changeStart(lblPow.Text);
            showDays();
            if (lblLang.Text == "1")
            {
                MessageBox.Show("Automatic mode enabled!");
                Text = "Main - Automatic Mode";
            }
            else
            {
                MessageBox.Show("Mode otomatis aktif!");
                Text = "Halaman Utama - Mode Otomatis";
            }
            DateTime skrg = DateTime.Now;
            var id = new CultureInfo("id-ID", false).DateTimeFormat; //ambil Indonesia
            if (lblLang.Text == "1")
            {
                id = new CultureInfo("en-US", false).DateTimeFormat;
            }
            var hari = id.GetDayName(dayofweek: skrg.DayOfWeek);
            showSchAuto(hari);
            flpDays.Enabled = true;
            btnOn.Enabled = false;
            btnOff.Enabled = true;
        }

        //disable automatic mode
        private void btnOff_Click(object sender, EventArgs e)
        {
            lblPow.Text = "0";
            changeStart(lblPow.Text);
            showDays();
            if (lblLang.Text == "1")
            {
                MessageBox.Show("Automatic mode disabled!");
                Text = "Main";
            }
            else
            {
                MessageBox.Show("Mode otomatis nonaktif!");
                Text = "Halaman Utama";
            }
            flpSch.Controls.Clear();
            showSchOff();
            flpDays.Enabled = true;
            btnOn.Enabled = true;
            btnOff.Enabled = false;
        }

        //change variable of program's mode
        void changeStart(string var)
        {
            query = "UPDATE Config SET Val = " + var + " WHERE Var = 'Start';";
            Console.WriteLine(query);
            cmd = new SQLiteCommand(query, k);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
        }

        //show schedule when automatic mode disabled (head)
        void showSchOff()
        {
            Label lbl = new Label();
            if (lblLang.Text == "1")
            {
                lbl.Text = "Automatic mode disabled";
            }
            else
            {
                lbl.Text = "Mode otomatis nonaktif";
            }
            lbl.Width = 140; lbl.Height = 50;
            lbl.ForeColor = Color.FromArgb(62, 150, 199); lbl.TextAlign = ContentAlignment.TopRight;
            lbl.Font = new Font("Candara", 10F, FontStyle.Bold);
            flpSch.Controls.Add(lbl);
        }

        //show days
        void showDays()
        {
            flpDays.Controls.Clear();

            ToolTip toolTip2 = new ToolTip();
            toolTip2.AutoPopDelay = 5000;
            toolTip2.InitialDelay = 1000;
            toolTip2.ReshowDelay = 500;
            toolTip2.ShowAlways = true;

            try
            {
                if (lblLang.Text == "1")
                {
                    query = "SELECT * FROM (SELECT * FROM Hari WHERE IsDefault = 1 ORDER BY IdHari DESC LIMIT 7) " +
                            "UNION SELECT * FROM Hari WHERE IsDefault = 0 ORDER BY IdHari";
                }
                else
                {
                    query = "SELECT * FROM (SELECT * FROM Hari WHERE IsDefault = 1 ORDER BY IdHari ASC LIMIT 7) " +
                            "UNION SELECT * FROM Hari WHERE IsDefault = 0 ORDER BY IdHari";
                }
                Console.WriteLine(query);
                da = new SQLiteDataAdapter(query, k);
                dt = new DataTable();
                da.Fill(dt);
                Func<IEnumerable<TextBox>>
                            txt = Controls.OfType<TextBox>;
                int a = 1;
                foreach (DataRow data in dt.Rows)
                {
                    a += 5;
                    Button x = new Button();
                    x.Text = data[1].ToString();
                    x.Tag = data[0].ToString();
                    x.Name = x.Text;
                    x.Top = a;
                    x.Width = 85; x.Height = 35;
                    x.ForeColor = Color.FromArgb(62, 150, 199);
                    if (lblPow.Text == "1")
                    {
                        x.ForeColor = Color.FromArgb(79, 201, 58);
                    }
                    x.Font = new Font("Candara", 8F, FontStyle.Bold);
                    x.FlatStyle = FlatStyle.Standard;
                    x.FlatAppearance.BorderSize = 1;
                    x.BackColor = Color.FromArgb(220, 255, 215);
                    x.MouseClick += X_MouseClick;
                    toolTip2.SetToolTip(x, "Jadwal " + x.Text);
                    if (lblLang.Text == "1")
                    {
                        toolTip2.SetToolTip(x, "Schedule of " + x.Text);
                    }
                    flpDays.Controls.Add(x);
                    flpDays.FlowDirection = FlowDirection.LeftToRight;
                    flpDays.WrapContents = true;
                    flpDays.AutoScroll = true;
                }
                da.Dispose();
            }
            catch (Exception e)
            {
                DialogResult msg = MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (msg == DialogResult.Retry)
                {
                    showDays();
                }
            }
        }

        //event for days
        private void X_MouseClick(object sender, MouseEventArgs e)
        {
            Button x = sender as Button;
            lblDay.Text = ": " + x.Text;
            if (lblPow.Text == "1")
            {
                DateTime skrg = DateTime.Now;
                var id = new CultureInfo("id-ID", false).DateTimeFormat; //ambil Indonesia
                if (lblLang.Text == "1")
                {
                    id = new CultureInfo("en-US", false).DateTimeFormat;
                }
                var hari = id.GetDayName(dayofweek: skrg.DayOfWeek);
                showSchAuto(hari);
                showSch(x.Tag.ToString(), x.Text);
            }
            else
            {
                showSchOff(x.Tag.ToString());
            }
        }

        //show audios
        void showAudios()
        {
            flpAudio.Controls.Clear();

            ToolTip toolTip3 = new ToolTip();
            toolTip3.AutoPopDelay = 5000;
            toolTip3.InitialDelay = 1000;
            toolTip3.ReshowDelay = 500;
            toolTip3.ShowAlways = true;

            try
            {
                query = "SELECT * FROM Bel";
                Console.WriteLine(query);
                da = new SQLiteDataAdapter(query, k);
                dt = new DataTable();
                da.Fill(dt);
                Func<IEnumerable<TextBox>>
                            txt = Controls.OfType<TextBox>;
                int a = 1;
                foreach (DataRow data in dt.Rows)
                {
                    a += 5;
                    Button x = new Button();
                    x.Text = data[1].ToString();
                    x.Tag = data[0].ToString();
                    x.Name = x.Text;
                    x.Top = a;
                    x.Width = 75; x.Height = 35;
                    x.ForeColor = Color.FromArgb(62, 150, 199);
                    x.Font = new Font("Candara", 9F, FontStyle.Bold);
                    x.FlatStyle = FlatStyle.Standard;
                    x.FlatAppearance.BorderSize = 1;
                    x.BackColor = Color.FromArgb(220, 255, 215);
                    x.MouseClick += X_MouseClick1;
                    x.MouseHover += X_MouseHover;
                    x.MouseLeave += X_MouseLeave;
                    x.LostFocus += X_LostFocus;
                    toolTip3.SetToolTip(x, "Bel " + x.Text);
                    if (lblLang.Text == "1")
                    {
                        toolTip3.SetToolTip(x, "Bell " + x.Text);
                    }
                    flpAudio.Controls.Add(x);
                    flpAudio.FlowDirection = FlowDirection.LeftToRight;
                    flpAudio.WrapContents = true;
                    flpAudio.AutoScroll = true;
                }
                da.Dispose();
            }
            catch (Exception e)
            {
                DialogResult msg = MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (msg == DialogResult.Retry)
                {
                    showAudios();
                }
            }
        }

        //event for audios
        private void X_MouseClick1(object sender, MouseEventArgs e)
        {
            Button x = sender as Button;
            string id = x.Tag.ToString();

            string path;
            query = "SELECT Path FROM Bel WHERE IdBel = " + id;
            Console.WriteLine(query);
            cmd = new SQLiteCommand(query, k);
            baca = cmd.ExecuteReader();
            baca.Read();
            if (baca.HasRows)
            {
                path = baca[0].ToString();
            }
            else
            {
                path = "";
            }
            baca.Close();
            cmd.Dispose();

            try
            {
                if (File.Exists(path))
                {
                    if (isPlayin == 0)
                    {
                        playy.URL = path;
                        playy.controls.play();
                        playy.PlayStateChange += Playy_PlayStateChange;
                    }
                    else
                    {
                        playy.controls.stop();
                        playy.URL = path;
                        playy.controls.play();
                        playy.PlayStateChange += Playy_PlayStateChange;
                    }                    
                }
                else
                {
                    if (lblLang.Text == "1")
                    {
                        MessageBox.Show("File not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("File tidak ditemukan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                if (lblLang.Text == "1")
                {
                    MessageBox.Show(ex.ToString(), "Error - Invalid file", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(ex.ToString(), "Error - File tidak sesuai", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Playy_PlayStateChange(int NewState)
        {
            Console.WriteLine(NewState);
            if (NewState == (int)WMPLib.WMPPlayState.wmppsPlaying)
            {
                isPlayin = 1;
                btnStopAudio.Visible = true;
            }
            else
            {
                isPlayin = 0;
                btnStopAudio.Visible = false;
            }
        }

        private void X_MouseHover(object sender, EventArgs e)
        {
            Button x = sender as Button;
            x.BackColor = Color.White;
        }

        private void X_MouseLeave(object sender, EventArgs e)
        {
            Button x = sender as Button;
            x.BackColor = Color.FromArgb(220, 255, 215);
        }

        private void X_LostFocus(object sender, EventArgs e)
        {
            Button x = sender as Button;
            x.BackColor = Color.FromArgb(220, 255, 215);
        }

        //show schedule when automatic mode enabled
        void showSchAuto(string hari)
        {
            flpSch.Controls.Clear();

            try
            {
                Label lbl = new Label();
                lbl.Text = hari + ":";
                lbl.ForeColor = Color.FromArgb(79, 201, 58); lbl.TextAlign = ContentAlignment.MiddleLeft;
                lbl.Font = new Font("Candara", 12F, FontStyle.Bold);
                flpSch.Controls.Add(lbl);

                query = "SELECT id, jam FROM Jam JOIN Hari ON Jam.IdHari = Hari.IdHari WHERE Hari = '" + hari + "'";
                //query = "SELECT * FROM Jam WHERE IdHari = " + idHari;
                Console.WriteLine(query);
                da = new SQLiteDataAdapter(query, k);
                dt = new DataTable();
                da.Fill(dt);
                Func<IEnumerable<TextBox>>
                            txt = Controls.OfType<TextBox>;
                int a = 1;
                foreach (DataRow data in dt.Rows)
                {
                    a += 5;
                    Label x = new Label();
                    DateTime time = Convert.ToDateTime(data[1]);
                    x.Text = time.ToString(@"HH\:mm\:ss");
                    x.Tag = data[0].ToString();
                    x.Name = x.Text;
                    x.Top = a;
                    x.Width = 70; x.Height = 25;
                    x.ForeColor = Color.FromArgb(79, 201, 58); x.TextAlign = ContentAlignment.MiddleLeft;
                    x.Font = new Font("Candara", 11F, FontStyle.Bold);
                    flpSch.Controls.Add(x);
                    flpSch.FlowDirection = FlowDirection.TopDown;
                    flpSch.WrapContents = false;
                    flpSch.AutoScroll = true;
                }
                da.Dispose();
            }
            catch (Exception)
            {

            }
        }

        //show schedule when automatic mode disabled (body)
        void showSchOff(string idHari)
        {
            flpSch.Controls.Clear();
            showSchOff();

            try
            {
                query = "SELECT * FROM Jam WHERE IdHari = " + idHari;
                Console.WriteLine(query);
                da = new SQLiteDataAdapter(query, k);
                dt = new DataTable();
                da.Fill(dt);
                Func<IEnumerable<TextBox>>
                            txt = Controls.OfType<TextBox>;
                int a = 1;
                foreach (DataRow data in dt.Rows)
                {
                    a += 5;
                    Label x = new Label();
                    DateTime time = Convert.ToDateTime(data[1]);
                    x.Text = time.ToString(@"HH\:mm\:ss");
                    x.Tag = data[0].ToString();
                    x.Name = x.Text;
                    x.Top = a;
                    x.Width = 70; x.Height = 25;
                    x.ForeColor = Color.FromArgb(62, 150, 199); x.TextAlign = ContentAlignment.MiddleLeft;
                    x.Font = new Font("Candara", 11F, FontStyle.Bold);
                    flpSch.Controls.Add(x);
                    flpSch.FlowDirection = FlowDirection.TopDown;
                    flpSch.WrapContents = false;
                    flpSch.AutoScroll = true;
                }
                da.Dispose();
            }
            catch (Exception)
            {

            }
        }

        //to about page
        private void lblAbout_Click(object sender, EventArgs e)
        {
            About a = new About(this);
            a.ShowDialog(this);
        }

        private void lblAbout_MouseHover(object sender, EventArgs e)
        {
            lblAbout.ForeColor = Color.FromArgb(62, 150, 199);
        }

        private void lblAbout_MouseLeave(object sender, EventArgs e)
        {
            lblAbout.ForeColor = Color.FromArgb(79, 201, 58);
        }

        //to contact page
        private void lblContact_Click(object sender, EventArgs e)
        {
            Contact c = new Contact(this);
            c.ShowDialog(this);
        }

        private void lblContact_MouseHover(object sender, EventArgs e)
        {
            lblContact.ForeColor = Color.FromArgb(62, 150, 199);
        }

        private void lblContact_MouseLeave(object sender, EventArgs e)
        {
            lblContact.ForeColor = Color.FromArgb(79, 201, 58);
        }

        private void btnStopAudio_Click(object sender, EventArgs e)
        {
            playy.controls.stop();
            isPlayin = 0;
        }

        //show schedule
        void showSch(string idHari, string hari)
        {
            try
            {
                Label lbl = new Label();
                lbl.Text = hari + ":";
                lbl.ForeColor = Color.FromArgb(62, 150, 199); lbl.TextAlign = ContentAlignment.MiddleLeft;
                lbl.Font = new Font("Candara", 12F, FontStyle.Bold);
                flpSch.Controls.Add(lbl);

                query = "SELECT * FROM Jam WHERE IdHari = " + idHari;
                Console.WriteLine(query);
                da = new SQLiteDataAdapter(query, k);
                dt = new DataTable();
                da.Fill(dt);
                Func<IEnumerable<TextBox>>
                            txt = Controls.OfType<TextBox>;
                int a = 1;
                foreach (DataRow data in dt.Rows)
                {
                    a += 5;
                    Label x = new Label();
                    DateTime time = Convert.ToDateTime(data[1]);
                    x.Text = time.ToString(@"HH\:mm\:ss");
                    x.Tag = data[0].ToString();
                    x.Name = x.Text;
                    x.Top = a;
                    x.Width = 70; x.Height = 25;
                    x.ForeColor = Color.FromArgb(62, 150, 199); x.TextAlign = ContentAlignment.MiddleLeft;
                    x.Font = new Font("Candara", 11F, FontStyle.Bold);
                    flpSch.Controls.Add(x);
                    flpSch.FlowDirection = FlowDirection.TopDown;
                    flpSch.WrapContents = false;
                    flpSch.AutoScroll = true;
                }
                da.Dispose();
            }
            catch (Exception)
            {

            }
        }
    }
}
