namespace app_bell_2
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOff = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnOn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblInstance = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.flpDays = new System.Windows.Forms.FlowLayoutPanel();
            this.lblDayTitle = new System.Windows.Forms.Label();
            this.lblDay = new System.Windows.Forms.Label();
            this.lblChosenDay = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.flpSch = new System.Windows.Forms.FlowLayoutPanel();
            this.lblSchTitle = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnStopAudio = new System.Windows.Forms.Button();
            this.flpAudio = new System.Windows.Forms.FlowLayoutPanel();
            this.lblAudioTitle = new System.Windows.Forms.Label();
            this.lblAbout = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.lblLang = new System.Windows.Forms.Label();
            this.lblPow = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ep = new System.Windows.Forms.ErrorProvider(this.components);
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.btnActivate = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnSettings = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnActivate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSettings)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(167)))), ((int)(((byte)(222)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Calibri", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1178, 72);
            this.label1.TabIndex = 0;
            this.label1.Text = "AUTOMATIC SCHOOL BELL";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(222)))), ((int)(((byte)(68)))));
            this.panel1.Controls.Add(this.btnOff);
            this.panel1.Controls.Add(this.btnOn);
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Controls.Add(this.lblTime);
            this.panel1.Controls.Add(this.lblAddress);
            this.panel1.Controls.Add(this.lblInstance);
            this.panel1.Controls.Add(this.pbLogo);
            this.panel1.Location = new System.Drawing.Point(0, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1178, 131);
            this.panel1.TabIndex = 3;
            // 
            // btnOff
            // 
            this.btnOff.Activecolor = System.Drawing.Color.White;
            this.btnOff.BackColor = System.Drawing.Color.White;
            this.btnOff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOff.BorderRadius = 0;
            this.btnOff.ButtonText = "OFF";
            this.btnOff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOff.DisabledColor = System.Drawing.Color.Gray;
            this.btnOff.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOff.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnOff.Iconcolor = System.Drawing.Color.Transparent;
            this.btnOff.Iconimage = null;
            this.btnOff.Iconimage_right = null;
            this.btnOff.Iconimage_right_Selected = null;
            this.btnOff.Iconimage_Selected = null;
            this.btnOff.IconMarginLeft = 0;
            this.btnOff.IconMarginRight = 0;
            this.btnOff.IconRightVisible = true;
            this.btnOff.IconRightZoom = 0D;
            this.btnOff.IconVisible = true;
            this.btnOff.IconZoom = 90D;
            this.btnOff.IsTab = false;
            this.btnOff.Location = new System.Drawing.Point(1097, 66);
            this.btnOff.Margin = new System.Windows.Forms.Padding(6);
            this.btnOff.Name = "btnOff";
            this.btnOff.Normalcolor = System.Drawing.Color.White;
            this.btnOff.OnHovercolor = System.Drawing.Color.WhiteSmoke;
            this.btnOff.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnOff.selected = false;
            this.btnOff.Size = new System.Drawing.Size(59, 52);
            this.btnOff.TabIndex = 5;
            this.btnOff.Text = "OFF";
            this.btnOff.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnOff.Textcolor = System.Drawing.Color.Black;
            this.btnOff.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOff.Click += new System.EventHandler(this.btnOff_Click);
            // 
            // btnOn
            // 
            this.btnOn.Activecolor = System.Drawing.Color.White;
            this.btnOn.BackColor = System.Drawing.Color.White;
            this.btnOn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOn.BorderRadius = 0;
            this.btnOn.ButtonText = "ON";
            this.btnOn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOn.DisabledColor = System.Drawing.Color.Gray;
            this.btnOn.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnOn.Iconcolor = System.Drawing.Color.Transparent;
            this.btnOn.Iconimage = null;
            this.btnOn.Iconimage_right = null;
            this.btnOn.Iconimage_right_Selected = null;
            this.btnOn.Iconimage_Selected = null;
            this.btnOn.IconMarginLeft = 0;
            this.btnOn.IconMarginRight = 0;
            this.btnOn.IconRightVisible = true;
            this.btnOn.IconRightZoom = 0D;
            this.btnOn.IconVisible = true;
            this.btnOn.IconZoom = 90D;
            this.btnOn.IsTab = false;
            this.btnOn.Location = new System.Drawing.Point(1097, 16);
            this.btnOn.Margin = new System.Windows.Forms.Padding(6);
            this.btnOn.Name = "btnOn";
            this.btnOn.Normalcolor = System.Drawing.Color.White;
            this.btnOn.OnHovercolor = System.Drawing.Color.WhiteSmoke;
            this.btnOn.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnOn.selected = false;
            this.btnOn.Size = new System.Drawing.Size(59, 52);
            this.btnOn.TabIndex = 4;
            this.btnOn.Text = "ON";
            this.btnOn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnOn.Textcolor = System.Drawing.Color.Black;
            this.btnOn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOn.Click += new System.EventHandler(this.btnOn_Click);
            // 
            // lblDate
            // 
            this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.Transparent;
            this.lblDate.Location = new System.Drawing.Point(832, 87);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(253, 31);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "Senin, 1 Januari 2000";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTime
            // 
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTime.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.Transparent;
            this.lblTime.Location = new System.Drawing.Point(818, 13);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(282, 75);
            this.lblTime.TabIndex = 2;
            this.lblTime.Text = "00:01:02";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAddress
            // 
            this.lblAddress.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.ForeColor = System.Drawing.Color.Transparent;
            this.lblAddress.Location = new System.Drawing.Point(148, 48);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(336, 71);
            this.lblAddress.TabIndex = 1;
            this.lblAddress.Text = "Jln. Janggan - Jatiroto\r\nKec. Jatiroto Kab. Wonogiri\r\nJawa Tengah, 57692";
            this.lblAddress.UseCompatibleTextRendering = true;
            // 
            // lblInstance
            // 
            this.lblInstance.Font = new System.Drawing.Font("Arial Unicode MS", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstance.ForeColor = System.Drawing.Color.Transparent;
            this.lblInstance.Location = new System.Drawing.Point(147, 16);
            this.lblInstance.Name = "lblInstance";
            this.lblInstance.Size = new System.Drawing.Size(336, 32);
            this.lblInstance.TabIndex = 0;
            this.lblInstance.Text = "SMK Negeri 1 Jatiroto";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(255)))), ((int)(((byte)(215)))));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.lblDay);
            this.panel2.Controls.Add(this.lblChosenDay);
            this.panel2.Location = new System.Drawing.Point(24, 226);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(504, 424);
            this.panel2.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(255)))), ((int)(((byte)(215)))));
            this.panel3.Controls.Add(this.flpDays);
            this.panel3.Controls.Add(this.lblDayTitle);
            this.panel3.Location = new System.Drawing.Point(25, 78);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(449, 323);
            this.panel3.TabIndex = 8;
            // 
            // flpDays
            // 
            this.flpDays.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.flpDays.Location = new System.Drawing.Point(0, 44);
            this.flpDays.Name = "flpDays";
            this.flpDays.Size = new System.Drawing.Size(449, 279);
            this.flpDays.TabIndex = 1;
            // 
            // lblDayTitle
            // 
            this.lblDayTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(150)))), ((int)(((byte)(199)))));
            this.lblDayTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDayTitle.Font = new System.Drawing.Font("Candara", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDayTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(255)))), ((int)(((byte)(215)))));
            this.lblDayTitle.Location = new System.Drawing.Point(0, 0);
            this.lblDayTitle.Name = "lblDayTitle";
            this.lblDayTitle.Size = new System.Drawing.Size(449, 46);
            this.lblDayTitle.TabIndex = 0;
            this.lblDayTitle.Text = "Hari Jadwal";
            this.lblDayTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDay
            // 
            this.lblDay.AutoEllipsis = true;
            this.lblDay.Font = new System.Drawing.Font("Candara", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(150)))), ((int)(((byte)(199)))));
            this.lblDay.Location = new System.Drawing.Point(218, 25);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(182, 33);
            this.lblDay.TabIndex = 1;
            this.lblDay.Text = ": -";
            // 
            // lblChosenDay
            // 
            this.lblChosenDay.Font = new System.Drawing.Font("Candara", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChosenDay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(150)))), ((int)(((byte)(199)))));
            this.lblChosenDay.Location = new System.Drawing.Point(20, 25);
            this.lblChosenDay.Name = "lblChosenDay";
            this.lblChosenDay.Size = new System.Drawing.Size(182, 33);
            this.lblChosenDay.TabIndex = 0;
            this.lblChosenDay.Text = "Hari Dipilih";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(255)))), ((int)(((byte)(215)))));
            this.panel4.Controls.Add(this.flpSch);
            this.panel4.Controls.Add(this.lblSchTitle);
            this.panel4.Location = new System.Drawing.Point(550, 226);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(252, 424);
            this.panel4.TabIndex = 9;
            // 
            // flpSch
            // 
            this.flpSch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(255)))), ((int)(((byte)(215)))));
            this.flpSch.Location = new System.Drawing.Point(5, 65);
            this.flpSch.Name = "flpSch";
            this.flpSch.Size = new System.Drawing.Size(244, 336);
            this.flpSch.TabIndex = 1;
            // 
            // lblSchTitle
            // 
            this.lblSchTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(150)))), ((int)(((byte)(199)))));
            this.lblSchTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSchTitle.Font = new System.Drawing.Font("Candara", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSchTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(255)))), ((int)(((byte)(215)))));
            this.lblSchTitle.Location = new System.Drawing.Point(0, 0);
            this.lblSchTitle.Name = "lblSchTitle";
            this.lblSchTitle.Size = new System.Drawing.Size(252, 46);
            this.lblSchTitle.TabIndex = 0;
            this.lblSchTitle.Text = "Jadwal Bel";
            this.lblSchTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(150)))), ((int)(((byte)(199)))));
            this.panel5.Controls.Add(this.btnStopAudio);
            this.panel5.Controls.Add(this.flpAudio);
            this.panel5.Controls.Add(this.lblAudioTitle);
            this.panel5.Location = new System.Drawing.Point(829, 226);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(322, 424);
            this.panel5.TabIndex = 11;
            // 
            // btnStopAudio
            // 
            this.btnStopAudio.BackColor = System.Drawing.Color.Salmon;
            this.btnStopAudio.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStopAudio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(255)))), ((int)(((byte)(215)))));
            this.btnStopAudio.Location = new System.Drawing.Point(226, 7);
            this.btnStopAudio.Name = "btnStopAudio";
            this.btnStopAudio.Size = new System.Drawing.Size(75, 35);
            this.btnStopAudio.TabIndex = 6;
            this.btnStopAudio.Text = "Stop";
            this.btnStopAudio.UseVisualStyleBackColor = false;
            this.btnStopAudio.Click += new System.EventHandler(this.btnStopAudio_Click);
            // 
            // flpAudio
            // 
            this.flpAudio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(150)))), ((int)(((byte)(199)))));
            this.flpAudio.Location = new System.Drawing.Point(20, 65);
            this.flpAudio.Name = "flpAudio";
            this.flpAudio.Size = new System.Drawing.Size(281, 336);
            this.flpAudio.TabIndex = 1;
            // 
            // lblAudioTitle
            // 
            this.lblAudioTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(255)))), ((int)(((byte)(215)))));
            this.lblAudioTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblAudioTitle.Font = new System.Drawing.Font("Candara", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAudioTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(150)))), ((int)(((byte)(199)))));
            this.lblAudioTitle.Location = new System.Drawing.Point(0, 0);
            this.lblAudioTitle.Name = "lblAudioTitle";
            this.lblAudioTitle.Size = new System.Drawing.Size(322, 46);
            this.lblAudioTitle.TabIndex = 0;
            this.lblAudioTitle.Text = "Audio Manual";
            this.lblAudioTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAbout
            // 
            this.lblAbout.Font = new System.Drawing.Font("Candara", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(201)))), ((int)(((byte)(58)))));
            this.lblAbout.Location = new System.Drawing.Point(19, 656);
            this.lblAbout.Name = "lblAbout";
            this.lblAbout.Size = new System.Drawing.Size(182, 33);
            this.lblAbout.TabIndex = 5;
            this.lblAbout.Text = "Tentang Kami";
            this.lblAbout.Click += new System.EventHandler(this.lblAbout_Click);
            this.lblAbout.MouseLeave += new System.EventHandler(this.lblAbout_MouseLeave);
            this.lblAbout.MouseHover += new System.EventHandler(this.lblAbout_MouseHover);
            // 
            // lblContact
            // 
            this.lblContact.Font = new System.Drawing.Font("Candara", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContact.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(201)))), ((int)(((byte)(58)))));
            this.lblContact.Location = new System.Drawing.Point(178, 656);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(182, 33);
            this.lblContact.TabIndex = 6;
            this.lblContact.Text = "Kontak Kami";
            this.lblContact.Click += new System.EventHandler(this.lblContact_Click);
            this.lblContact.MouseLeave += new System.EventHandler(this.lblContact_MouseLeave);
            this.lblContact.MouseHover += new System.EventHandler(this.lblContact_MouseHover);
            // 
            // lblCopyright
            // 
            this.lblCopyright.Font = new System.Drawing.Font("Candara", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopyright.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(150)))), ((int)(((byte)(199)))));
            this.lblCopyright.Location = new System.Drawing.Point(957, 656);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(194, 33);
            this.lblCopyright.TabIndex = 7;
            this.lblCopyright.Text = "Copyright © 2021";
            this.lblCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLang
            // 
            this.lblLang.AutoSize = true;
            this.lblLang.Location = new System.Drawing.Point(12, 9);
            this.lblLang.Name = "lblLang";
            this.lblLang.Size = new System.Drawing.Size(18, 20);
            this.lblLang.TabIndex = 8;
            this.lblLang.Text = "0";
            this.lblLang.Visible = false;
            // 
            // lblPow
            // 
            this.lblPow.AutoSize = true;
            this.lblPow.Location = new System.Drawing.Point(12, 37);
            this.lblPow.Name = "lblPow";
            this.lblPow.Size = new System.Drawing.Size(18, 20);
            this.lblPow.TabIndex = 9;
            this.lblPow.Text = "0";
            this.lblPow.Visible = false;
            // 
            // ep
            // 
            this.ep.ContainerControl = this;
            // 
            // pbLogo
            // 
            this.pbLogo.Location = new System.Drawing.Point(24, 13);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(105, 105);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // btnActivate
            // 
            this.btnActivate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.btnActivate.Image = global::app_bell_2.Properties.Resources.key;
            this.btnActivate.ImageActive = null;
            this.btnActivate.Location = new System.Drawing.Point(1040, 12);
            this.btnActivate.Name = "btnActivate";
            this.btnActivate.Size = new System.Drawing.Size(50, 50);
            this.btnActivate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnActivate.TabIndex = 3;
            this.btnActivate.TabStop = false;
            this.btnActivate.Zoom = 10;
            this.btnActivate.Click += new System.EventHandler(this.btnActivate_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(167)))), ((int)(((byte)(222)))));
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.ImageActive = null;
            this.btnSettings.Location = new System.Drawing.Point(1106, 12);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(50, 50);
            this.btnSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSettings.TabIndex = 2;
            this.btnSettings.TabStop = false;
            this.btnSettings.Zoom = 10;
            this.btnSettings.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1178, 694);
            this.Controls.Add(this.lblPow);
            this.Controls.Add(this.lblLang);
            this.Controls.Add(this.lblCopyright);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.lblAbout);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnActivate);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnActivate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSettings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuImageButton btnSettings;
        private Bunifu.Framework.UI.BunifuImageButton btnActivate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblInstance;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDate;
        private Bunifu.Framework.UI.BunifuFlatButton btnOff;
        private Bunifu.Framework.UI.BunifuFlatButton btnOn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblChosenDay;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblDayTitle;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.FlowLayoutPanel flpDays;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblSchTitle;
        private System.Windows.Forms.FlowLayoutPanel flpSch;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.FlowLayoutPanel flpAudio;
        private System.Windows.Forms.Label lblAudioTitle;
        private System.Windows.Forms.Label lblAbout;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Label lblCopyright;
        private System.Windows.Forms.Label lblLang;
        private System.Windows.Forms.Label lblPow;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ErrorProvider ep;
        private System.Windows.Forms.Button btnStopAudio;
    }
}