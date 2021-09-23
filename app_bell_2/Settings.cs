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
    public partial class Settings : Form
    {
        private Main main;
        private bool lang; private string vLang;

        public Settings(Main main)
        {
            InitializeComponent();
            this.main = main;
        }

        Connection c = new Connection();
        SQLiteConnection k; SQLiteCommand cmd; SQLiteDataReader baca; SQLiteDataAdapter da; DataTable dt; string query;
        private OpenFileDialog ofd; string act;

        private void Settings_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            k = c.connect();
            k.Open();
            ep.Clear();
            start();
            Icon = new Icon(Directory.GetCurrentDirectory() + @"\bin\Debug" + Main.iconPath);
            lblUnactivated.Hide();
        }

        void start()
        {

            if (Main.lang == "1")
            {
                toolTipSettingEn();

                Text = "Settings";
                lblSettings.Text = Text;
                tabHome.Text = "Main";
                tabSch.Text = "Schedule";
                tabBell.Text = "Bells";
                tabDays.Text = "Days";
                tabProfile.Text = "Profile";
                gbSetting.Text = "Settings";
                btnSound.Text = "Sound";
                btnTime.Text = "Time";
                btnChangePass.Text = "Change Password";
                gbLang.Text = "Language";

                btnAddSch.Text = "Add";
                label7.Text = "Time";
                label6.Text = "Bell";
                btnSimpanSch.Text = "Save";
                btnBatalSche.Text = "Cancel";

                labelBel.Text = "Settings of Bells";
                btnAddBell.Text = "Add";
                label3.Text = "Bell's Name";
                label2.Text = "Path";
                btnSimpanBell.Text = "Save";
                btnBatalBell.Text = "Cancel";

                label8.Text = "Settings of Days";
                btnAddDays.Text = "Add";
                label5.Text = "Day's name";
                btnSimpanDays.Text = "Save";
                btnBatalDays.Text = "Cancel";

                label4.Text = "Logo";
                btnChangeLogo.Text = "Change";
                label9.Text = "Icon";
                btnChangeIcon.Text = "Change";
                btnChangeInstance.Text = "Change";
                label10.Text = "Name of Instance";
                label11.Text = "Address";
                label12.Text = "Website";
                label13.Text = "Phone Number";
                label14.Text = "Email";
                label15.Text = "Description";
                btnSimpanProfil.Text = "Save";
                btnBatalProfil.Text = "Cancel";                
            }
            else
            {
                toolTipSetting();

                Text = "Pengaturan";
                lblSettings.Text = Text;
                tabHome.Text = "Utama";
                tabSch.Text = "Jadwal";
                tabBell.Text = "Bel";
                tabDays.Text = "Hari";
                tabProfile.Text = "Profil";
                gbSetting.Text = "Pengaturan";
                btnSound.Text = "Suara";
                btnTime.Text = "Waktu";
                btnChangePass.Text = "Ubah Password";
                gbLang.Text = "Bahasa";

                btnAddSch.Text = "Tambah";
                label7.Text = "Jam";
                label6.Text = "Bel";
                btnSimpanSch.Text = "Simpan";
                btnBatalSche.Text = "Batal";

                labelBel.Text = "Pengaturan Bel";
                btnAddBell.Text = "Tambah";
                label3.Text = "Nama Bel";
                label2.Text = "Path";
                btnSimpanBell.Text = "Simpan";
                btnBatalBell.Text = "Batal";

                label8.Text = "Pengaturan Hari";
                btnAddDays.Text = "Tambah";
                label5.Text = "Nama Hari";
                btnSimpanDays.Text = "Simpan";
                btnBatalDays.Text = "Batal";

                label4.Text = "Logo";
                btnChangeLogo.Text = "Ubah";
                label9.Text = "Ikon";
                btnChangeIcon.Text = "Ubah";
                btnChangeInstance.Text = "Ubah";
                label10.Text = "Nama Instansi";
                label11.Text = "Alamat";
                label12.Text = "Website";
                label13.Text = "Nomor Telepon";
                label14.Text = "Email";
                label15.Text = "Deskripsi";
                btnSimpanProfil.Text = "Simpan";
                btnBatalProfil.Text = "Batal";
            }
        }

        void toolTipSetting()
        {
            ToolTip toolTip1 = new ToolTip();

            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 1000;
            toolTip1.ReshowDelay = 500;
            toolTip1.ShowAlways = true;

            toolTip1.SetToolTip(gbSetting, "Pengaturan");
            toolTip1.SetToolTip(btnSound, "Ke pengaturan suara");
            toolTip1.SetToolTip(btnTime, "Ke pengaturan waktu");
            toolTip1.SetToolTip(btnChangePass, "Ubah password");
            toolTip1.SetToolTip(gbLang, "Bahasa");

            toolTip1.SetToolTip(cmbDays, "Daftar Hari");
            toolTip1.SetToolTip(btnAddSch, "Tambah jadwal baru");
            toolTip1.SetToolTip(label7, "Atur waktu bel");
            toolTip1.SetToolTip(dtpTime, "Atur waktu bel");
            toolTip1.SetToolTip(label6, "Atur bel untuk jadwal");
            toolTip1.SetToolTip(cmbBell, "Atur bel untuk jadwal");
            toolTip1.SetToolTip(btnSimpanSch, "Simpan jadwal");
            toolTip1.SetToolTip(btnBatalSche, "Batalkan perubahan");

            toolTip1.SetToolTip(labelBel, "Pengaturan Bel");
            toolTip1.SetToolTip(btnAddBell, "Tambah bel baru");
            toolTip1.SetToolTip(label3, "Atur nama bel");
            toolTip1.SetToolTip(txtBellName, "Atur nama bel");
            toolTip1.SetToolTip(label2, "Atur path audio untuk bel");
            toolTip1.SetToolTip(txtBellPath, "Atur path audio untuk bel");
            toolTip1.SetToolTip(btnBellPath, "Cari path audio untuk bel");
            toolTip1.SetToolTip(btnSimpanBell, "Simpan bel");
            toolTip1.SetToolTip(btnBatalBell, "Batalkan perubahan");

            toolTip1.SetToolTip(label8, "Pengaturan Hari");
            toolTip1.SetToolTip(btnAddDays, "Tambah hari");
            toolTip1.SetToolTip(label5, "Atur nama hari");
            toolTip1.SetToolTip(txtDayName, "Atur nama hari");
            toolTip1.SetToolTip(btnSimpanDays, "Simpan hari");
            toolTip1.SetToolTip(btnBatalDays, "Batalkan perubahan");

            toolTip1.SetToolTip(label4, "Logo");
            toolTip1.SetToolTip(btnChangeLogo, "Ubah Logo");
            toolTip1.SetToolTip(label9, "Ikon");
            toolTip1.SetToolTip(btnChangeIcon, "Ubah Ikon");
            toolTip1.SetToolTip(btnChangeInstance, "Ubah Detail");
            toolTip1.SetToolTip(label10, "Nama Instansi");
            toolTip1.SetToolTip(txtInstanceName, "Nama Instansi");
            toolTip1.SetToolTip(label11, "Alamat");
            toolTip1.SetToolTip(txtAddress1, "Alamat");
            toolTip1.SetToolTip(txtAddress2, "Alamat");
            toolTip1.SetToolTip(txtAddress3, "Alamat");
            toolTip1.SetToolTip(label12, "Website");
            toolTip1.SetToolTip(txtWebsite, "Website");
            toolTip1.SetToolTip(label13, "Nomor Telepon");
            toolTip1.SetToolTip(txtPhone, "Nomor Telepon");
            toolTip1.SetToolTip(label14, "Email");
            toolTip1.SetToolTip(txtEmail, "Email");
            toolTip1.SetToolTip(label15, "Deskripsi");
            toolTip1.SetToolTip(txtDesc, "Deskripsi");
            toolTip1.SetToolTip(btnSimpanProfil, "Simpan Detail");
            toolTip1.SetToolTip(btnBatalProfil, "Batalkan perubahan");
        }

        void toolTipSettingEn()
        {
            ToolTip toolTip1 = new ToolTip();

            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 1000;
            toolTip1.ReshowDelay = 500;
            toolTip1.ShowAlways = true;

            toolTip1.SetToolTip(gbSetting, "Settings");
            toolTip1.SetToolTip(btnSound, "To sysem sound settings");
            toolTip1.SetToolTip(btnTime, "To sysem time settings");
            toolTip1.SetToolTip(btnChangePass, "Change password");
            toolTip1.SetToolTip(gbLang, "Language");

            toolTip1.SetToolTip(cmbDays, "List of Days");
            toolTip1.SetToolTip(btnAddSch, "Add a new schedule");
            toolTip1.SetToolTip(label7, "");
            toolTip1.SetToolTip(dtpTime, "Set bell time");
            toolTip1.SetToolTip(label6, "Set bell for schedule");
            toolTip1.SetToolTip(cmbBell, "Set bell for schedule");
            toolTip1.SetToolTip(btnSimpanSch, "Save changes");
            toolTip1.SetToolTip(btnBatalSche, "Cancel");

            toolTip1.SetToolTip(labelBel, "List of Bells");
            toolTip1.SetToolTip(btnAddBell, "Add a new bell");
            toolTip1.SetToolTip(label3, "Set bell's name");
            toolTip1.SetToolTip(txtBellName, "Set bell's name");
            toolTip1.SetToolTip(label2, "Set bell's audio path");
            toolTip1.SetToolTip(txtBellPath, "Set bell's audio path");
            toolTip1.SetToolTip(btnBellPath, "Search audio path for bell");
            toolTip1.SetToolTip(btnSimpanBell, "Save changes");
            toolTip1.SetToolTip(btnBatalBell, "Cancel");

            toolTip1.SetToolTip(label8, "List of Days");
            toolTip1.SetToolTip(btnAddDays, "Add a new day");
            toolTip1.SetToolTip(label5, "Set day's name");
            toolTip1.SetToolTip(txtDayName, "Set day's name");
            toolTip1.SetToolTip(btnSimpanDays, "Save changes");
            toolTip1.SetToolTip(btnBatalDays, "Cancel");

            toolTip1.SetToolTip(label4, "Logo");
            toolTip1.SetToolTip(btnChangeLogo, "Change Logo");
            toolTip1.SetToolTip(label9, "Icon");
            toolTip1.SetToolTip(btnChangeIcon, "Change Icon");
            toolTip1.SetToolTip(btnChangeInstance, "Change Details");
            toolTip1.SetToolTip(label10, "Name of Instance");
            toolTip1.SetToolTip(txtInstanceName, "Name of Instance");
            toolTip1.SetToolTip(label11, "Address");
            toolTip1.SetToolTip(txtAddress1, "Address");
            toolTip1.SetToolTip(txtAddress2, "Address");
            toolTip1.SetToolTip(txtAddress3, "Address");
            toolTip1.SetToolTip(label12, "Website");
            toolTip1.SetToolTip(txtWebsite, "Website");
            toolTip1.SetToolTip(label13, "Phone Number");
            toolTip1.SetToolTip(txtPhone, "Phone Number");
            toolTip1.SetToolTip(label14, "Email");
            toolTip1.SetToolTip(txtEmail, "Email");
            toolTip1.SetToolTip(label15, "Description");
            toolTip1.SetToolTip(txtDesc, "Description");
            toolTip1.SetToolTip(btnSimpanProfil, "Save changes");
            toolTip1.SetToolTip(btnBatalProfil, "Cancel");
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Hide();
            Main m = new Main();
            m.Show();
        }

        private void Settings_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();
            Main m = new Main();
            m.Show();
        }

        private void tabHome_Enter(object sender, EventArgs e)
        {
            lang = true;
            checkLang();
        }

        void checkLang()
        {
            try
            {
                query = "SELECT CAST(" + "Val" + " as TEXT) AS Conf FROM Config WHERE Var = 'Lang' ;";
                Console.WriteLine(query);
                cmd = new SQLiteCommand(query, k);
                baca = cmd.ExecuteReader();
                vLang = baca[0].ToString();
                baca.Close();
                cmd.Dispose();

                if (vLang == "0")
                {
                    rbLangId.Checked = true;
                    rbLangEn.Checked = false;
                }
                else
                {
                    rbLangId.Checked = false;
                    rbLangEn.Checked = true;
                }
                lang = false;
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

        private void btnSound_Click(object sender, EventArgs e)
        {
            Process.Start("mmsys.cpl");
        }

        private void btnTime_Click(object sender, EventArgs e)
        {
            Process.Start("timedate.cpl");
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            Settings_ChangePass sc = new Settings_ChangePass(main, true, this);
            sc.ShowDialog(this);
        }

        private void rbLangId_CheckedChanged(object sender, EventArgs e)
        {
            if (rbLangId.Checked && vLang == "1")
            {
                if (lang == false)
                {
                    DialogResult msg = MessageBox.Show("Are you sure to change the language?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (msg == DialogResult.Yes)
                    {
                        try
                        {
                            query = "UPDATE Config SET Val = 0 WHERE Var = 'Lang';";
                            Console.WriteLine(query);
                            cmd = new SQLiteCommand(query, k);
                            cmd.ExecuteNonQuery();
                            cmd.Dispose();
                            MessageBox.Show("Berhasil diubah! Aplikasi akan memulai ulang.", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Hide();
                            Main m = new Main();
                            m.Show();
                        }
                        catch (Exception)
                        {

                        }
                    }
                    else
                    {
                        rbLangEn.Checked = true;
                    }
                }
            }
        }

        private void rbLangEn_CheckedChanged(object sender, EventArgs e)
        {
            if (rbLangEn.Checked)
            {
                if (lang == false && vLang == "0")
                {
                    DialogResult msg = MessageBox.Show("Anda yakin untuk mengubah bahasa?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (msg == DialogResult.Yes)
                    {
                        try
                        {
                            query = "UPDATE Config SET Val = 1 WHERE Var = 'Lang';";
                            Console.WriteLine(query);
                            cmd = new SQLiteCommand(query, k);
                            cmd.ExecuteNonQuery();
                            cmd.Dispose();
                            MessageBox.Show("Successfully changed! The app will restart.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Hide();
                            Main m = new Main();
                            m.Show();
                        }
                        catch (Exception)
                        {

                        }
                    }
                    else
                    {
                        rbLangId.Checked = true;
                    }
                }
            }
        }

        private void tabSch_Enter(object sender, EventArgs e)
        {
            btnAddSch.Hide();
            showCmbSch();
            dgvSchedule.Hide();
            panelSch.Hide();
            ep.Clear();
            ep.Tag = "";
        }

        private void showCmbSch()
        {
            string txt;
            if (Main.lang == "1")
            {
                txt = "CHOOSE A DAY";
                query = "SELECT * FROM (SELECT * FROM Hari WHERE IsDefault = 1 ORDER BY IdHari DESC LIMIT 7) " +
                            "UNION SELECT * FROM Hari WHERE IsDefault = 0 ORDER BY IdHari";
            }
            else
            {
                txt = "PILIH SALAH SATU HARI";
                query = "SELECT * FROM (SELECT * FROM Hari WHERE IsDefault = 1 ORDER BY IdHari ASC LIMIT 7) " +
                                "UNION SELECT * FROM Hari WHERE IsDefault = 0 ORDER BY IdHari";
            }

            Console.WriteLine(query);
            da = new SQLiteDataAdapter(query, k);
            dt = new DataTable();
            try
            {
                da.Fill(dt);

                DataRow data;
                data = dt.NewRow();
                data.ItemArray = new object[] { 0, txt };
                dt.Rows.InsertAt(data, 0);

                cmbDays.DataSource = dt;
                cmbDays.ValueMember = "IdHari";
                cmbDays.DisplayMember = "Hari";
            }
            catch (Exception e)
            {
                DialogResult msg = MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (msg == DialogResult.Retry)
                {
                    showCmbSch();
                }
            }
            da.Dispose();
            cmbDays.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void cmbDays_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDays.SelectedIndex != 0)
            {
                btnAddSch.Show();
                showDgvSchedule();
                dgvSchedule.Show();
                showCmbBel();
                dtpTime.Value = DateTime.Now;

                panelSch.Hide();

                ep.Clear();
            }
            else
            {
                btnAddSch.Hide();
                dgvSchedule.Hide();
                panelSch.Hide();

                ep.Clear();
            }
        }

        void showDgvSchedule()
        {
            dgvSchedule.Rows.Clear();
            dgvSchedule.Columns.Clear();

            try
            {
                query = "SELECT Jam.id, Jam.jam, Jam.IdBel, Bel.Bel FROM Jam JOIN Hari ON Jam.IdHari = Hari.IdHari JOIN Bel ON Jam.IdBel = Bel.IdBel WHERE Jam.IdHari = " + cmbDays.SelectedValue;
                Console.WriteLine(query);
                da = new SQLiteDataAdapter(query, k);
                dt = new DataTable();
                da.Fill(dt);

                if (Main.lang == "1")
                {
                    dgvSchedule.Columns.Add("", "ID");
                    dgvSchedule.Columns.Add("", "Time");
                    dgvSchedule.Columns.Add("", "Bell ID");
                    dgvSchedule.Columns.Add("", "Bell");
                    dgvSchedule.Columns.Add("", "Edit");
                    dgvSchedule.Columns.Add("", "Delete");
                }
                else
                {
                    dgvSchedule.Columns.Add("", "ID");
                    dgvSchedule.Columns.Add("", "Jam");
                    dgvSchedule.Columns.Add("", "ID Bel");
                    dgvSchedule.Columns.Add("", "Bel");
                    dgvSchedule.Columns.Add("", "Edit");
                    dgvSchedule.Columns.Add("", "Hapus");
                }

                foreach (DataRow item in dt.Rows)
                {
                    int a = dgvSchedule.Rows.Add();
                    dgvSchedule.Rows[a].Cells[0].Value = item[0].ToString();
                    DateTime time = Convert.ToDateTime(item[1]);
                    dgvSchedule.Rows[a].Cells[1].Value = time.ToString(@"HH\:mm\:ss");
                    dgvSchedule.Rows[a].Cells[2].Value = item[2].ToString();
                    dgvSchedule.Rows[a].Cells[3].Value = item[3].ToString();

                    DataGridViewButtonCell edit = new DataGridViewButtonCell();
                    edit.Value = "Edit";
                    dgvSchedule.Rows[a].Cells[4] = edit;

                    DataGridViewButtonCell hapus = new DataGridViewButtonCell();
                    hapus.Value = "Hapus";
                    if (Main.lang == "1")
                    {
                        hapus.Value = "Delete";
                    }
                    dgvSchedule.Rows[a].Cells[5] = hapus;
                }
                da.Dispose();
                dgvSchedule.Columns[0].Visible = false;
                dgvSchedule.Columns[2].Visible = false;
                dgvSchedule.Columns[4].Width = 60;
                dgvSchedule.Columns[5].Width = 60;
                dgvSchedule.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvSchedule.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
                dgvSchedule.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                for (int i = 0; i < dgvSchedule.ColumnCount - 2; i++)
                {
                    dgvSchedule.ReadOnly = true;
                }

                dgvSchedule.AllowUserToAddRows = false;
                dgvSchedule.RowHeadersVisible = false;
            }
            catch (Exception e)
            {
                DialogResult msg = MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (msg == DialogResult.Retry)
                {
                    showDgvSchedule();
                }
            }
        }

        void showCmbBel()
        {
            string txt;
            if (Main.lang == "1")
            {
                txt = "---CHOOSE---";
            }
            else
            {
                txt = "---PILIH---";
            }

            query = "SELECT IdBel, Bel FROM Bel";
            Console.WriteLine(query);
            da = new SQLiteDataAdapter(query, k);
            dt = new DataTable();
            try
            {
                da.Fill(dt);

                DataRow data;
                data = dt.NewRow();
                data.ItemArray = new object[] { 0, txt };
                dt.Rows.InsertAt(data, 0);

                cmbBell.DataSource = dt;
                cmbBell.ValueMember = "IdBel";
                cmbBell.DisplayMember = "Bel";
            }
            catch (Exception e)
            {
                DialogResult msg = MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (msg == DialogResult.Retry)
                {
                    showCmbBel();
                }
            }
            da.Dispose();
            cmbBell.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void dgvSchedule_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dgvSchedule.Rows[e.RowIndex].Cells[0].Value);

                if (e.ColumnIndex == 4)
                {
                    btnAddSch.Hide();
                    dgvSchedule.Enabled = false;
                    panelSch.Show();
                    DateTime time = Convert.ToDateTime(dgvSchedule.Rows[e.RowIndex].Cells[1].Value);
                    dtpTime.Text = time.ToString(@"HH\:mm\:ss");
                    cmbBell.SelectedValue = dgvSchedule.Rows[e.RowIndex].Cells[2].Value.ToString();
                    btnSimpanSch.Show();
                    btnBatalSche.Show();
                    ep.Clear();
                    ep.Tag = id;
                }
                if (e.ColumnIndex == 5)
                {
                    string msgText1, msgTitle1, msgText2, msgTitle2;
                    if (Main.lang == "1")
                    {
                        msgText1 = "Are you sure to delete this? \nThis action cannot be canceled.";
                        msgTitle1 = "Confirmation";
                        msgText2 = "Successfully deleted!";
                        msgTitle2 = "Information";
                    }
                    else
                    {
                        msgText1 = "Anda yakin untuk menghapus jadwal ini? \nTindakan ini tidak dapat dibatalkan.";
                        msgTitle1 = "Konfirmasi";
                        msgText2 = "Berhasil dihapus!";
                        msgTitle2 = "Informasi";
                    }

                    DialogResult msg = MessageBox.Show(msgText1, msgTitle1, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (msg == DialogResult.Yes)
                    {
                        isDefaultDelete(id, msgText2, msgTitle2);
                    }
                }
            }
            catch (Exception)
            {
                //throw;
            }
        }

        void isDefaultDelete(int id, string msgText2, string msgTitle2)
        {
            try
            {
                string isDefault;
                query = "SELECT * FROM Hari WHERE IdHari = " + cmbDays.SelectedValue;
                Console.WriteLine(query);
                cmd = new SQLiteCommand(query, k);
                baca = cmd.ExecuteReader();
                baca.Read();
                isDefault = baca[2].ToString();
                Console.WriteLine(isDefault);
                baca.Close();
                cmd.Dispose();
                if (isDefault == "True")
                {
                    int id2 = id + 1;
                    query = "DELETE FROM Jam WHERE id = " + id;
                    Console.WriteLine(query);
                    cmd = new SQLiteCommand(query, k);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    query = "DELETE FROM Jam WHERE id = " + id2;
                    Console.WriteLine(query);
                    cmd = new SQLiteCommand(query, k);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    MessageBox.Show(msgText2, msgTitle2);
                    showDgvSchedule();
                }
                else
                {
                    query = "DELETE FROM Jam WHERE id = " + id;
                    Console.WriteLine(query);
                    cmd = new SQLiteCommand(query, k);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    MessageBox.Show(msgText2, msgTitle2);
                    showDgvSchedule();
                }
            }
            catch (Exception)
            {

            }
        }

        private void btnAddSch_Click(object sender, EventArgs e)
        {
            btnAddSch.Hide();
            dgvSchedule.Enabled = false;
            panelSch.Show();
            dtpTime.Value = DateTime.Now;
            showCmbBel();
            ep.Clear();
            ep.Tag = "+";
        }

        void isDefaultDay()
        {
            try
            {
                string isDefault, day;
                query = "SELECT * FROM Hari WHERE IdHari = " + cmbDays.SelectedValue;
                Console.WriteLine(query);
                cmd = new SQLiteCommand(query, k);
                baca = cmd.ExecuteReader();
                baca.Read();
                day = baca[1].ToString();
                isDefault = baca[2].ToString();
                Console.WriteLine(isDefault);
                baca.Close();
                cmd.Dispose();
                if (isDefault == "True")
                {
                    string dday;
                    if (Main.lang == "1")
                    {
                        dday = whichDefaultDayIndonesian(day);
                    }
                    else
                    {
                        dday = whichDefaultDayInEnglish(day);
                    }

                    if (ep.Tag.ToString() == "+")
                    {
                        try
                        {
                            insertJam(cmbDays.SelectedValue.ToString());
                            insertJam(dday);
                            if (Main.lang == "1")
                            {
                                MessageBox.Show("Successfully saved!", "Confirmation");
                            }
                            else
                            {
                                MessageBox.Show("Berhasil disimpan!", "Konfirmasi");
                            }
                        }
                        catch (Exception e1)
                        {
                            DialogResult msg1 = MessageBox.Show(e1.ToString(), "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                            if (msg1 == DialogResult.Retry)
                            {
                                insertJam(cmbDays.SelectedValue.ToString());
                                insertJam(dday);
                                if (Main.lang == "1")
                                {
                                    MessageBox.Show("Successfully saved!", "Confirmation");
                                }
                                else
                                {
                                    MessageBox.Show("Berhasil disimpan!", "Konfirmasi");
                                }
                            }
                        }

                    }
                    else
                    {
                        try
                        {
                            string id2 = whichUpdate();
                            updateJam(id2);
                            updateJam(ep.Tag.ToString());
                            if (Main.lang == "1")
                            {
                                MessageBox.Show("Successfully saved!", "Information");
                            }
                            else
                            {
                                MessageBox.Show("Berhasil disimpan!", "Informasi");
                            }
                        }
                        catch (Exception e2)
                        {
                            DialogResult msg2 = MessageBox.Show(e2.ToString(), "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                            if (msg2 == DialogResult.Retry)
                            {
                                string id2 = whichUpdate();
                                updateJam(ep.Tag.ToString());
                                updateJam(id2);
                                if (Main.lang == "1")
                                {
                                    MessageBox.Show("Successfully saved!", "Information");
                                }
                                else
                                {
                                    MessageBox.Show("Berhasil disimpan!", "Informasi");
                                }
                            }
                        }
                    }
                }
                else
                {
                    if (ep.Tag.ToString() == "+")
                    {
                        try
                        {
                            insertJam(cmbDays.SelectedValue.ToString());
                            if (Main.lang == "1")
                            {
                                MessageBox.Show("Successfully saved!", "Confirmation");
                            }
                            else
                            {
                                MessageBox.Show("Berhasil disimpan!", "Konfirmasi");
                            }
                        }
                        catch (Exception e1)
                        {
                            DialogResult msg1 = MessageBox.Show(e1.ToString(), "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                            if (msg1 == DialogResult.Retry)
                            {
                                insertJam(cmbDays.SelectedValue.ToString());
                                if (Main.lang == "1")
                                {
                                    MessageBox.Show("Successfully saved!", "Confirmation");
                                }
                                else
                                {
                                    MessageBox.Show("Berhasil disimpan!", "Konfirmasi");
                                }
                            }
                        }

                    }
                    else
                    {
                        try
                        {
                            updateJam(ep.Tag.ToString());
                            if (Main.lang == "1")
                            {
                                MessageBox.Show("Successfully saved!", "Information");
                            }
                            else
                            {
                                MessageBox.Show("Berhasil disimpan!", "Informasi");
                            }
                        }
                        catch (Exception e2)
                        {
                            DialogResult msg2 = MessageBox.Show(e2.ToString(), "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                            if (msg2 == DialogResult.Retry)
                            {
                                updateJam(ep.Tag.ToString());
                                if (Main.lang == "1")
                                {
                                    MessageBox.Show("Successfully saved!", "Information");
                                }
                                else
                                {
                                    MessageBox.Show("Berhasil disimpan!", "Informasi");
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {

            }            
        }

        string whichDefaultDayInEnglish(string day)
        {
            string dayInEng, fin;
            switch (day)
            {
                case "Senin":
                    dayInEng =  "Monday";
                    break;
                case "Selasa":
                    dayInEng = "Tuesday";
                    break;
                case "Rabu":
                    dayInEng = "Wednesday";
                    break;
                case "Kamis":
                    dayInEng = "Thursday";
                    break;
                case "Jumat":
                    dayInEng = "Friday";
                    break;
                case "Sabtu":
                    dayInEng = "Saturday";
                    break;
                case "Minggu":
                    dayInEng = "Sunday";
                    break;
                default:
                    dayInEng = "Monday";
                    break;
            }
            query = "SELECT IdHari FROM Hari WHERE Hari = '" + dayInEng + "'";
            Console.WriteLine(query);
            cmd = new SQLiteCommand(query, k);
            baca = cmd.ExecuteReader();
            baca.Read();
            fin = baca[0].ToString();
            baca.Close();
            cmd.Dispose();
            return fin;
        }

        string whichDefaultDayIndonesian(string day)
        {
            string dayInId, fin;
            switch (day)
            {
                case "Monday":
                    dayInId = "Senin";
                    break;
                case "Tuesday":
                    dayInId = "Selasa";
                    break;
                case "Wednesday":
                    dayInId = "Rabu";
                    break;
                case "Thursday":
                    dayInId = "Kamis";
                    break;
                case "Friday":
                    dayInId = "Jumat";
                    break;
                case "Saturday":
                    dayInId = "Sabtu";
                    break;
                case "Sunday":
                    dayInId = "Minggu";
                    break;
                default:
                    dayInId = "Senin";
                    break;
            }
            query = "SELECT IdHari FROM Hari WHERE Hari = '" + dayInId + "'";
            Console.WriteLine(query);
            cmd = new SQLiteCommand(query, k);
            baca = cmd.ExecuteReader();
            baca.Read();
            fin = baca[0].ToString();
            baca.Close();
            cmd.Dispose();
            return fin;
        }

        void insertJam(string idHari)
        {
            try
            {
                query = "INSERT INTO Jam VALUES (null, '" + dtpTime.Value.ToString(@"HH\:mm\:ss") + "', '" + cmbBell.SelectedValue + "', '" + idHari + "')";
                Console.WriteLine(query);
                cmd = new SQLiteCommand(query, k);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (Exception)
            {

            }
        }

        string whichUpdate() {
            int a = Convert.ToInt32(ep.Tag) + 1;
            return a.ToString();
        }

        void updateJam(string id)
        {
            try
            {
                query = "UPDATE Jam SET jam = '" + dtpTime.Value.ToString(@"HH\:mm\:ss") + "', IdBel = " + cmbBell.SelectedValue + " WHERE Id = " + id;
                Console.WriteLine(query);
                cmd = new SQLiteCommand(query, k);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (Exception)
            {

            }
        }

        private void btnSimpanSch_Click(object sender, EventArgs e)
        {
            if (cekSchTime(dtpTime) && cekBel(cmbBell))
            {
                string msgText1, msgTitle1;
                if (Main.lang == "1")
                {
                    msgText1 = "Are you sure to save this? \nThis action cannot be canceled.";
                    msgTitle1 = "Confirmation";
                }
                else
                {
                    msgText1 = "Anda yakin untuk menyimpan? \nTindakan ini tidak dapat dibatalkan.";
                    msgTitle1 = "Konfirmasi";
                }

                DialogResult msg = MessageBox.Show(msgText1, msgTitle1, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (msg == DialogResult.Yes)
                {
                    isDefaultDay();
                    btnAddSch.Show();
                    dgvSchedule.Enabled = true;
                    panelSch.Hide();
                    ep.Clear();
                    showDgvSchedule();
                }
            }
        }

        private void btnBatalSche_Click(object sender, EventArgs e)
        {
            string msgText1, msgTitle1;
            if (Main.lang == "1")
            {
                msgText1 = "Are you sure to cancel?";
                msgTitle1 = "Confirmation";
            }
            else
            {
                msgText1 = "Anda yakin untuk membatalkan?";
                msgTitle1 = "Konfirmasi";
            }

            DialogResult msg = MessageBox.Show(msgText1, msgTitle1, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (msg == DialogResult.Yes)
            {
                btnAddSch.Show();
                dgvSchedule.Enabled = true;
                panelSch.Hide();
                ep.Clear();
                ep.Tag = "";
            }
        }

        private void dtpTime_ValueChanged(object sender, EventArgs e)
        {
            cekSchTime(dtpTime);
        }

        private void dtpTime_Validating(object sender, CancelEventArgs e)
        {
            cekSchTime(dtpTime);
        }

        Boolean cekSchTime(DateTimePicker dtp)
        {
            int strInt = 0;
            string time = dtp.Value.ToString(@"HH\:mm\:ss");

            for (int i = 0; i < dgvSchedule.RowCount; i++)
            {
                string times = dgvSchedule.Rows[i].Cells[1].Value.ToString();
                if (time == times)
                {
                    strInt += 1;
                }
            }

            if (strInt == 0)
            {
                ep.Clear();
                return true;
            }
            else
            {
                if (Main.lang == "1")
                {
                    ep.SetError(dtp, "Time already exists!");
                }
                else
                {
                    ep.SetError(dtp, "Jam sudah ada!");
                }
                return false;
            }
        }

        private void cmbBell_SelectedIndexChanged(object sender, EventArgs e)
        {
            cekBel(cmbBell);
        }

        private void cmbBell_Validating(object sender, CancelEventArgs e)
        {
            cekBel(cmbBell);
        }

        Boolean cekBel(ComboBox cmb)
        {
            if (cmb.SelectedIndex != 0)
            {
                ep.Clear();
                return true;
            }
            else
            {
                if (Main.lang == "1")
                {
                    ep.SetError(cmb, "A bell must be chosen!");
                }
                else
                {
                    ep.SetError(cmb, "Bel harus dipilih!");
                }
                return false;
            }
        }

        private void tabBell_Enter(object sender, EventArgs e)
        {
            btnAddBell.Show();
            showDgvBell();
            dgvBell.Enabled = true;
            panelBell.Hide();
            ep.Clear();
            ep.Tag = "";
        }

        void showDgvBell()
        {
            dgvBell.Rows.Clear();
            dgvBell.Columns.Clear();

            try
            {
                query = "SELECT * FROM Bel";
                Console.WriteLine(query);
                da = new SQLiteDataAdapter(query, k);
                dt = new DataTable();
                da.Fill(dt);

                if (Main.lang == "1")
                {
                    dgvBell.Columns.Add("", "ID");
                    dgvBell.Columns.Add("", "Bell");
                    dgvBell.Columns.Add("", "Path");
                    dgvBell.Columns.Add("", "Edit");
                    dgvBell.Columns.Add("", "Delete");
                }
                else
                {
                    dgvBell.Columns.Add("", "ID");
                    dgvBell.Columns.Add("", "Bel");
                    dgvBell.Columns.Add("", "Path");
                    dgvBell.Columns.Add("", "Edit");
                    dgvBell.Columns.Add("", "Hapus");
                }

                foreach (DataRow data in dt.Rows)
                {
                    int a = dgvBell.Rows.Add();
                    dgvBell.Rows[a].Cells[0].Value = data[0].ToString();
                    dgvBell.Rows[a].Cells[1].Value = data[1].ToString();
                    dgvBell.Rows[a].Cells[2].Value = data[2].ToString();

                    DataGridViewButtonCell edit = new DataGridViewButtonCell();
                    edit.Value = "Edit";
                    dgvBell.Rows[a].Cells[3] = edit;

                    DataGridViewButtonCell hps = new DataGridViewButtonCell();
                    hps.Value = "Hapus";
                    if (Main.lang == "1")
                    {
                        hps.Value = "Delete";
                    }
                    dgvBell.Rows[a].Cells[4] = hps;
                }
                da.Dispose();
                dgvBell.Columns[0].Visible = false;
                dgvBell.Columns[2].Width = 100;
                dgvBell.Columns[3].Width = 85;
                dgvBell.Columns[4].Width = 85;
                dgvBell.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvBell.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 11F, FontStyle.Bold);
                dgvBell.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                for (int i = 0; i < dgvBell.ColumnCount - 2; i++)
                {
                    dgvBell.ReadOnly = true;
                }

                dgvBell.AllowUserToAddRows = false;
                dgvBell.RowHeadersVisible = false;
            }
            catch (Exception e)
            {
                DialogResult msg = MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (msg == DialogResult.Retry)
                {
                    showDgvBell();
                }
            }
        }

        private void dgvBell_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dgvBell.Rows[e.RowIndex].Cells[0].Value);

                if (e.ColumnIndex == 3)
                {
                    btnAddBell.Hide();
                    dgvBell.Enabled = false;
                    panelBell.Show();
                    txtBellName.Text = dgvBell.Rows[e.RowIndex].Cells[1].Value.ToString();
                    txtBellPath.Text = dgvBell.Rows[e.RowIndex].Cells[2].Value.ToString();
                    btnSimpanBell.Show();
                    btnBatalBell.Show();
                    ep.Clear();
                    ep.Tag = id;
                }
                if (e.ColumnIndex == 4)
                {
                    string msgText1, msgTitle1, msgText2, msgTitle2;
                    if (Main.lang == "1")
                    {
                        msgText1 = "Are you sure to delete this? \nThis action cannot be canceled.";
                        msgTitle1 = "Confirmation";
                        msgText2 = "Successfully deleted!";
                        msgTitle2 = "Information";
                    }
                    else
                    {
                        msgText1 = "Anda yakin untuk menghapus bel ini? \nTindakan ini tidak dapat dibatalkan.";
                        msgTitle1 = "Konfirmasi";
                        msgText2 = "Berhasil dihapus!";
                        msgTitle2 = "Informasi";
                    }

                    DialogResult msg = MessageBox.Show(msgText1, msgTitle1, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (msg == DialogResult.Yes)
                    {
                        query = "DELETE FROM Bel WHERE IdBel = " + id;
                        Console.WriteLine(query);
                        cmd = new SQLiteCommand(query, k);
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                        MessageBox.Show(msgText2, msgTitle2);
                        showDgvBell();
                    }
                }
            }
            catch (Exception)
            {
                //throw;
            }
        }

        private void btnAddBell_Click(object sender, EventArgs e)
        {
            btnAddBell.Hide();
            dgvBell.Enabled = false;
            panelBell.Show();
            txtBellName.Clear();
            txtBellPath.Clear();
            btnSimpanBell.Show();
            btnBatalBell.Show();
            ep.Clear();
            ep.Tag = "+";
        }

        private void btnBellPath_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (Main.lang == "1")
            {
                ofd.Title = "Choose an audio";
            }
            else
            {
                ofd.Title = "Pilih audio";
            }
            ofd.Filter = "Audio Formats (*.wav; *.mp3;) | *.wav; *.mp3; "; //validasiformatmp3
            ofd.InitialDirectory = @"C:/";
            ofd.CheckPathExists = true;
            ofd.Multiselect = false;
            ofd.ValidateNames = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string path = ofd.FileName;
                txtBellPath.Text = path;
            }
        }

        void insertBel()
        {
            try
            {
                query = "INSERT INTO Bel VALUES (null, '" + txtBellName.Text + "', '" + txtBellPath.Text + "')";
                Console.WriteLine(query);
                cmd = new SQLiteCommand(query, k);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                if (Main.lang == "1")
                {
                    MessageBox.Show("Successfully saved!", "Information");
                }
                else
                {
                    MessageBox.Show("Berhasil disimpan!", "Informasi");
                }
            }
            catch (Exception)
            {

            }
        }

        void updateBel()
        {
            try
            {
                query = "UPDATE Bel SET Bel = '" + txtBellName.Text + "', Path = '" + txtBellPath.Text + "' WHERE IdBel = " + ep.Tag.ToString();
                Console.WriteLine(query);
                cmd = new SQLiteCommand(query, k);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                if (Main.lang == "1")
                {
                    MessageBox.Show("Successfully saved!", "Information");
                }
                else
                {
                    MessageBox.Show("Berhasil disimpan!", "Informasi");
                }
            }
            catch (Exception)
            {

            }
        }

        private void btnSimpanBell_Click(object sender, EventArgs e)
        {
            if (cekBel(txtBellName) && cekPathBel(txtBellPath))
            {
                string msgText1, msgTitle1;
                if (Main.lang == "1")
                {
                    msgText1 = "Are you sure to save this? \nThis action cannot be canceled.";
                    msgTitle1 = "Confirmation";
                }
                else
                {
                    msgText1 = "Anda yakin untuk menyimpan? \nTindakan ini tidak dapat dibatalkan.";
                    msgTitle1 = "Konfirmasi";
                }

                DialogResult msg = MessageBox.Show(msgText1, msgTitle1, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (msg == DialogResult.Yes)
                {
                    if (ep.Tag.ToString() == "+")
                    {
                        try
                        {
                            insertBel();
                        }
                        catch (Exception e1)
                        {
                            DialogResult msg1 = MessageBox.Show(e1.ToString(), "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                            if (msg1 == DialogResult.Retry)
                            {
                                insertBel();
                            }
                        }
                    }
                    else
                    {
                        try
                        {
                            updateBel();
                        }
                        catch (Exception e2)
                        {
                            DialogResult msg2 = MessageBox.Show(e2.ToString(), "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                            if (msg2 == DialogResult.Retry)
                            {
                                 updateBel();
                            }
                        }
                    }
                    btnAddBell.Show();
                    dgvBell.Enabled = true;
                    panelBell.Hide();
                    ep.Clear();
                    ep.Tag = "";
                    showDgvBell();
                }
            }
        }

        private void btnBatalBell_Click(object sender, EventArgs e)
        {
            string msgText1, msgTitle1;
            if (Main.lang == "1")
            {
                msgText1 = "Are you sure to cancel?";
                msgTitle1 = "Confirmation";
            }
            else
            {
                msgText1 = "Anda yakin untuk membatalkan?";
                msgTitle1 = "Konfirmasi";
            }

            DialogResult msg = MessageBox.Show(msgText1, msgTitle1, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (msg == DialogResult.Yes)
            {
                btnAddBell.Show();
                dgvBell.Enabled = true;
                panelBell.Hide();
                ep.Clear();
                ep.Tag = "";
            }
        }

        private void txtBellName_Validating(object sender, CancelEventArgs e)
        {
            cekBel(txtBellName);
        }

        Boolean cekBel(TextBox str)
        {
            if (str.Text != string.Empty)
            {
                int strInt = 0;
                string strBel = str.Text.ToLower();

                for (int i = 0; i < dgvBell.RowCount; i++)
                {
                    string bel = dgvBell.Rows[i].Cells[1].Value.ToString().ToLower();
                    if (strBel == bel)
                    {
                        if (ep.Tag.ToString() != "+" && dgvBell.Rows[i].Cells[0].Value.ToString() == ep.Tag.ToString())
                        {
                            strInt = 0;
                        }
                        else
                        {
                            strInt += 1;
                        }
                    }
                }

                if (strInt == 0)
                {
                    ep.Clear();
                    return true;
                }
                else
                {
                    if (Main.lang == "1")
                    {
                        ep.SetError(str, "Bell's name already exists!");
                    }
                    else
                    {
                        ep.SetError(str, "Nama bel sudah ada!");
                    }
                    return false;
                }
            }
            else
            {
                if (Main.lang == "1")
                {
                    ep.SetError(str, "Bell's name cannot be empty!");
                }
                else
                {
                    ep.SetError(str, "Nama bel tidak boleh kosong!");
                }
                return false;
            }
        }

        private void txtBellName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtBellName.Text.Length > 19 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtBellPath_Validating(object sender, CancelEventArgs e)
        {
            cekPathBel(txtBellPath);
        }

        Boolean cekPathBel(TextBox str)
        {
            if (str.Text != string.Empty)
            {
                if (File.Exists(str.Text))
                {
                    ep.Clear();
                    return true;
                }
                else
                {
                    if (Main.lang == "1")
                    {
                        ep.SetError(str, "Bell's file path doesn't exist!");
                    }
                    else
                    {
                        ep.SetError(str, "Path file bel tidak ada!");
                    }
                    return false;
                }
            }
            else
            {
                if (Main.lang == "1")
                {
                    ep.SetError(str, "Bell's file path cannot be empty!");
                }
                else
                {
                    ep.SetError(str, "Path file bel tidak boleh kosong!");
                }
                return false;
            }
        }

        private void tabDays_Enter(object sender, EventArgs e)
        {
            btnAddDays.Show();
            showDgvDays();
            dgvDays.Enabled = true;
            panelDays.Hide();
            ep.Clear();
            ep.Tag = "";
        }

        void showDgvDays()
        {
            dgvDays.Rows.Clear();
            dgvDays.Columns.Clear();

            try
            {
                if (Main.lang == "1")
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

                if (Main.lang == "1")
                {
                    dgvDays.Columns.Add("", "ID");
                    dgvDays.Columns.Add("", "Day");
                    dgvDays.Columns.Add("", "Edit");
                    dgvDays.Columns.Add("", "Delete");
                }
                else
                {
                    dgvDays.Columns.Add("", "ID");
                    dgvDays.Columns.Add("", "Hari");
                    dgvDays.Columns.Add("", "Edit");
                    dgvDays.Columns.Add("", "Hapus");
                }

                foreach (DataRow data in dt.Rows)
                {
                    int a = dgvDays.Rows.Add();
                    dgvDays.Rows[a].Cells[0].Value = data[0].ToString();
                    dgvDays.Rows[a].Cells[1].Value = data[1].ToString();

                    DataGridViewButtonCell edit = new DataGridViewButtonCell();
                    edit.Value = "Edit";
                    dgvDays.Rows[a].Cells[2] = edit;

                    DataGridViewButtonCell hps = new DataGridViewButtonCell();
                    hps.Value = "Hapus";
                    if (Main.lang == "1")
                    {
                        hps.Value = "Delete";
                    }
                    dgvDays.Rows[a].Cells[3] = hps;
                }
                da.Dispose();
                dgvDays.Columns[0].Visible = false;
                dgvDays.Columns[2].Width = 95;
                dgvDays.Columns[3].Width = 95;
                dgvDays.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvDays.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 11F, FontStyle.Bold);
                dgvDays.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                for (int i = 0; i < dgvDays.ColumnCount - 2; i++)
                {
                    dgvDays.ReadOnly = true;
                }

                dgvDays.AllowUserToAddRows = false;
                dgvDays.RowHeadersVisible = false;
            }
            catch (Exception e)
            {
                DialogResult msg = MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (msg == DialogResult.Retry)
                {
                    showDgvDays();
                }
            }
        }

        private void dgvDays_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dgvDays.Rows[e.RowIndex].Cells[0].Value);
                int a = Convert.ToInt32(e.RowIndex);
                if (a < 6)
                {
                    if (e.ColumnIndex == 2 || e.ColumnIndex == 3)
                    {
                        if (Main.lang == "1")
                        {
                            MessageBox.Show("Can't change the main day!");
                        }
                        else
                        {
                            MessageBox.Show("Tidak dapat mengubah hari pokok!");
                        }
                    }
                }
                else
                {
                    if (e.ColumnIndex == 2)
                    {
                        btnAddDays.Hide();
                        dgvDays.Enabled = false;
                        panelDays.Show();
                        txtDayName.Text = dgvDays.Rows[e.RowIndex].Cells[1].Value.ToString();
                        ep.Clear();
                        ep.Tag = id;
                    }
                    if (e.ColumnIndex == 3)
                    {
                        string msgText1, msgTitle1, msgText2, msgTitle2;
                        if (Main.lang == "1")
                        {
                            msgText1 = "Are you sure to delete this? \nThis action cannot be canceled.";
                            msgTitle1 = "Confirmation";
                            msgText2 = "Successfully deleted!";
                            msgTitle2 = "Information";
                        }
                        else
                        {
                            msgText1 = "Anda yakin untuk menghapus hari ini? \nTindakan ini tidak dapat dibatalkan.";
                            msgTitle1 = "Konfirmasi";
                            msgText2 = "Berhasil dihapus!";
                            msgTitle2 = "Informasi";
                        }
                        DialogResult msg = MessageBox.Show(msgText1, msgTitle1, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (msg == DialogResult.Yes)
                        {
                            query = "DELETE FROM Hari WHERE IdHari = " + id;
                            Console.WriteLine(query);
                            cmd = new SQLiteCommand(query, k);
                            cmd.ExecuteNonQuery();
                            cmd.Dispose();
                            MessageBox.Show(msgText2, msgTitle2);
                            showDgvDays();
                        }
                    }
                }
            }
            catch (Exception)
            {
                //throw;
            }
        }

        private void btnAddDays_Click(object sender, EventArgs e)
        {
            btnAddDays.Hide();
            dgvDays.Enabled = false;
            panelDays.Show();
            txtDayName.Clear();
            ep.Clear();
            ep.Tag = "+";
        }

        void insertDay()
        {
            try
            {
                query = "INSERT INTO Hari VALUES (null, '" + txtDayName.Text + "', 0)";
                Console.WriteLine(query);
                cmd = new SQLiteCommand(query, k);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                if (Main.lang == "1")
                {
                    MessageBox.Show("Successfully saved!", "Information");
                }
                else
                {
                    MessageBox.Show("Berhasil disimpan!", "Informasi");
                }
            }
            catch (Exception)
            {

            }
        }

        void updateDay()
        {
            try
            {
                query = "UPDATE Hari SET Hari = '" + txtDayName.Text + "' WHERE IdHari = " + ep.Tag.ToString();
                Console.WriteLine(query);
                cmd = new SQLiteCommand(query, k);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                if (Main.lang == "1")
                {
                    MessageBox.Show("Successfully saved!", "Information");
                }
                else
                {
                    MessageBox.Show("Berhasil disimpan!", "Informasi");
                }
            }
            catch (Exception)
            {

            }
        }

        private void btnSimpanDays_Click(object sender, EventArgs e)
        {
            if (cekDay(txtDayName) == true)
            {
                string msgText1, msgTitle1;
                if (Main.lang == "1")
                {
                    msgText1 = "Are you sure to save this? \nThis action cannot be canceled.";
                    msgTitle1 = "Confirmation";
                }
                else
                {
                    msgText1 = "Anda yakin untuk menyimpan? \nTindakan ini tidak dapat dibatalkan.";
                    msgTitle1 = "Konfirmasi";
                }

                DialogResult msg = MessageBox.Show(msgText1, msgTitle1, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (msg == DialogResult.Yes)
                {
                    MessageBox.Show(ep.Tag.ToString());
                    if (ep.Tag.ToString() == "+")
                    {
                        try
                        {
                            insertDay();
                        }
                        catch (Exception e1)
                        {
                            DialogResult msg1 = MessageBox.Show(e1.ToString(), "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                            if (msg1 == DialogResult.Retry)
                            {
                                insertDay();
                            }
                        }
                    }
                    else
                    {
                        try
                        {
                            updateDay();
                        }
                        catch (Exception e2)
                        {
                            DialogResult msg2 = MessageBox.Show(e2.ToString(), "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                            if (msg2 == DialogResult.Retry)
                            {
                                updateDay();
                            }
                        }
                    }
                    btnAddDays.Show();
                    dgvDays.Enabled = true;
                    panelDays.Hide();
                    ep.Clear();
                    ep.Tag = "";
                    showDgvDays();
                }
            }
        }

        private void btnBatalDays_Click(object sender, EventArgs e)
        {
            string msgText1, msgTitle1;
            if (Main.lang == "1")
            {
                msgText1 = "Are you sure to cancel?";
                msgTitle1 = "Confirmation";
            }
            else
            {
                msgText1 = "Anda yakin untuk membatalkan?";
                msgTitle1 = "Konfirmasi";
            }

            DialogResult msg = MessageBox.Show(msgText1, msgTitle1, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (msg == DialogResult.Yes)
            {
                btnAddDays.Show();
                dgvDays.Enabled = true;
                panelDays.Hide();
                ep.Clear();
                ep.Tag = "";
            }
        }

        private void txtDayName_Validating(object sender, CancelEventArgs e)
        {
            cekDay(txtDayName);
        }

        Boolean cekDay(TextBox str)
        {
            if (str.Text != string.Empty)
            {
                int strInt = 0;
                string strDay = str.Text.ToLower();

                for (int i = 0; i < dgvDays.RowCount; i++)
                {
                    string days = dgvDays.Rows[i].Cells[1].Value.ToString().ToLower();
                    if (strDay == days)
                    {
                        strInt += 1;
                    }
                }

                if (strInt == 0)
                {
                    ep.Clear();
                    return true;
                }
                else
                {
                    if (Main.lang == "1")
                    {
                        ep.SetError(str, "Day already exists!");
                    }
                    else
                    {
                        ep.SetError(str, "Hari sudah ada!");
                    }
                    return false;
                }
            }
            else
            {
                if (Main.lang == "1")
                {
                    ep.SetError(str, "Day cannot be empty!");
                }
                else
                {
                    ep.SetError(str, "Hari tidak boleh kosong!");
                }
                return false;
            }
        }

        private void txtDayName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtDayName.Text.Length > 24 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Settings_FormClosed(object sender, FormClosedEventArgs e)
        {
            Hide();
            main.Main_Load(sender, e);
        }

        private void tabProfile_Enter(object sender, EventArgs e)
        {
            isActivated();
        }

        void isActivated()
        {
            try
            {
                query = "SELECT Val FROM Config WHERE Var = 'IsActive'";
                Console.WriteLine(query);
                cmd = new SQLiteCommand(query, k);
                baca = cmd.ExecuteReader();
                act = baca[0].ToString();
                baca.Read();
                baca.Close();
                cmd.Dispose();
                Console.WriteLine(act);
                if (act == "True")
                {
                    panelProfile.Show();
                    lblUnactivated.Hide();
                    showProfileLogo();
                    showProfileIcon();
                    showProfileDetails();
                    btnChangeInstance.Show();
                    panelProfileDetail.Enabled = false;
                    btnSimpanProfil.Hide();
                    btnBatalProfil.Hide();
                }
                else
                {
                    panelProfile.Hide();
                    lblUnactivated.Show();
                    if (Main.lang == "1")
                    {
                        lblUnactivated.Text = "Please activate the app to be able to change the profile";
                    }
                    else
                    {
                        lblUnactivated.Text = "Silakan lakukan aktivasi untuk dapat mengubah profil";
                    }
                }

            }
            catch (Exception)
            {

            }
        }

        void showProfileLogo()
        {
            try
            {
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

            }
        }

        void showProfileIcon()
        {
            try
            {
                string root, path;
                root = Directory.GetCurrentDirectory() + @"\bin\Debug";
                query = "SELECT Val FROM Activation WHERE Var = 'IconPath';";
                Console.WriteLine(query);
                cmd = new SQLiteCommand(query, k);
                baca = cmd.ExecuteReader();
                path = baca[0].ToString();
                baca.Close();
                cmd.Dispose();
                pbIcon.BackgroundImage = Image.FromFile(root + path);
                pbIcon.BackgroundImageLayout = ImageLayout.Stretch;
            }
            catch (Exception)
            {

            }
        }

        void showProfileDetails()
        {
            try
            {
                //nama instansi
                query = "SELECT Val FROM Activation WHERE Var = 'Instance';";
                Console.WriteLine(query);
                cmd = new SQLiteCommand(query, k);
                baca = cmd.ExecuteReader();
                baca.Read();
                txtInstanceName.Text = baca[0].ToString();
                baca.Close();
                cmd.Dispose();

                //address1
                query = "SELECT Val FROM Activation WHERE Var = 'Address1';";
                Console.WriteLine(query);
                cmd = new SQLiteCommand(query, k);
                baca = cmd.ExecuteReader();
                baca.Read();
                txtAddress1.Text = baca[0].ToString();
                baca.Close();
                cmd.Dispose();

                //address2
                query = "SELECT Val FROM Activation WHERE Var = 'Address2';";
                Console.WriteLine(query);
                cmd = new SQLiteCommand(query, k);
                baca = cmd.ExecuteReader();
                baca.Read();
                txtAddress2.Text = baca[0].ToString();
                baca.Close();
                cmd.Dispose();

                //address3
                query = "SELECT Val FROM Activation WHERE Var = 'Address3';";
                Console.WriteLine(query);
                cmd = new SQLiteCommand(query, k);
                baca = cmd.ExecuteReader();
                baca.Read();
                txtAddress3.Text = baca[0].ToString();
                baca.Close();
                cmd.Dispose();

                //website
                query = "SELECT Val FROM Activation WHERE Var = 'Website';";
                Console.WriteLine(query);
                cmd = new SQLiteCommand(query, k);
                baca = cmd.ExecuteReader();
                baca.Read();
                txtWebsite.Text = baca[0].ToString();
                baca.Close();
                cmd.Dispose();

                //phone
                query = "SELECT Val FROM Activation WHERE Var = 'Phone';";
                Console.WriteLine(query);
                cmd = new SQLiteCommand(query, k);
                baca = cmd.ExecuteReader();
                baca.Read();
                txtPhone.Text = baca[0].ToString();
                baca.Close();
                cmd.Dispose();

                //email
                query = "SELECT Val FROM Activation WHERE Var = 'Email';";
                Console.WriteLine(query);
                cmd = new SQLiteCommand(query, k);
                baca = cmd.ExecuteReader();
                baca.Read();
                txtEmail.Text = baca[0].ToString();
                baca.Close();
                cmd.Dispose();

                //desc
                query = "SELECT Desc FROM Config WHERE Var = 'Desc';";
                Console.WriteLine(query);
                cmd = new SQLiteCommand(query, k);
                baca = cmd.ExecuteReader();
                baca.Read();
                txtDesc.Text = baca[0].ToString();
                baca.Close();
                cmd.Dispose();
            }
            catch (Exception)
            {

            }            
        }

        private void btnChangeLogo_Click(object sender, EventArgs e)
        {
            string title, filter, msgTitle1, msgText1, msgTitle2, msgText2, msgTitle3, msgText3, msgText4;
            if (Main.lang == "1")
            {
                title = "Choose a picture for the logo";
                filter = "Image Formats (*.jpg; *.jpeg; *.png;) | *.jpg; *.jpeg; *.png;";
                msgTitle1 = "Confirmation";
                msgText1 = "Are you sure to replace the logo with this picture?";
                msgTitle2 = "Information";
                msgText2 = "Logo changed successfully!";
                msgTitle3 = "Failed";
                msgText3 = "Failed to copy a picture";
                msgText4 = "File doesn't exist";
            }
            else
            {
                title = "Pilih gambar sebagai logo";
                filter = "Format Gambar (*.jpg; *.jpeg; *.png;) | *.jpg; *.jpeg; *.png;";
                msgTitle1 = "Konfirmasi";
                msgText1 = "Anda yakin untuk mengubah logo dengan gambar ini?";
                msgTitle2 = "Informasi";
                msgText2 = "Logo berhasil diubah!";
                msgTitle3 = "Gagal";
                msgText3 = "Gagal menyalin gambar";
                msgText4 = "File tidak ada";
            }
            ofd = new OpenFileDialog();
            ofd.Title = title;
            ofd.Filter = filter;
            ofd.InitialDirectory = @"C:/";
            ofd.CheckPathExists = true;
            ofd.Multiselect = false;
            ofd.ValidateNames = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                DialogResult msg = MessageBox.Show(msgText1, msgTitle1, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (msg == DialogResult.Yes)
                {
                    try
                    {
                        string pathlama, namalama, ekst, pathbaru, namabaru;
                        pathlama = ofd.FileName; //file asal + path
                        namalama = ofd.SafeFileName.ToString(); //nama file
                        ekst = Path.GetExtension(pathlama); //ekstensi file
                        namabaru = @"\icons\logo\" + namalama + DateTime.Now.ToString("ddMMyyyyhhmmss") + ekst;
                        pathbaru = Directory.GetCurrentDirectory() + @"\bin\Debug" + namabaru;

                        if (File.Exists(pathlama))
                        {
                            //file ganda?
                            File.Copy(pathlama, pathbaru, true);
                            if (File.Exists(pathbaru))
                            {
                                query = "UPDATE Activation SET Val = '" + namabaru + "' WHERE Var = 'LogoPath';";
                                Console.WriteLine(query);
                                cmd = new SQLiteCommand(query, k);
                                cmd.ExecuteNonQuery();
                                cmd.Dispose();
                                MessageBox.Show(msgText2, msgTitle2, MessageBoxButtons.OK, MessageBoxIcon.Information);

                                pbLogo.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + @"\bin\Debug" + namabaru);
                                pbLogo.BackgroundImageLayout = ImageLayout.Stretch;
                            }
                            else
                            {
                                MessageBox.Show(msgText3, msgTitle3, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show(msgText4, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception)
                    {

                    }                    
                }
            }
        }

        private void btnChangeIcon_Click(object sender, EventArgs e)
        {
            string title, filter, msgTitle1, msgText1, msgTitle2, msgText2, msgTitle3, msgText3, msgText4;
            if (Main.lang == "1")
            {
                title = "Choose a picture for the icon";
                filter = "Icon Formats (*.ico;) | *.ico;";
                msgTitle1 = "Confirmation";
                msgText1 = "Are you sure to replace the icon with this picture?";
                msgTitle2 = "Information";
                msgText2 = "Icon changed successfully!";
                msgTitle3 = "Failed";
                msgText3 = "Failed to copy a picture";
                msgText4 = "File doesn't exist";
            }
            else
            {
                title = "Pilih gambar sebagai ikon";
                filter = "Format Ikon (*.ico;) | *.ico;";
                msgTitle1 = "Konfirmasi";
                msgText1 = "Anda yakin untuk mengubah ikon dengan gambar ini?";
                msgTitle2 = "Informasi";
                msgText2 = "Ikon berhasil diubah!";
                msgTitle3 = "Gagal";
                msgText3 = "Gagal menyalin gambar";
                msgText4 = "File tidak ada";
            }
            ofd = new OpenFileDialog();
            ofd.Title = title;
            ofd.Filter = filter;
            ofd.InitialDirectory = @"C:/";
            ofd.CheckPathExists = true;
            ofd.Multiselect = false;
            ofd.ValidateNames = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                DialogResult msg = MessageBox.Show(msgText1, msgTitle1, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                try
                {
                    if (msg == DialogResult.Yes)
                    {
                        string pathlama, namalama, ekst, pathbaru, namabaru;
                        pathlama = ofd.FileName; //file asal + path
                        namalama = ofd.SafeFileName.ToString(); //nama file
                        ekst = Path.GetExtension(pathlama); //ekstensi file
                        namabaru = @"\icons\logo\" + namalama + DateTime.Now.ToString("ddMMyyyyhhmmss") + ekst;
                        pathbaru = Directory.GetCurrentDirectory() + @"\bin\Debug" + namabaru;

                        if (File.Exists(pathlama))
                        {
                            //file ganda?
                            File.Copy(pathlama, pathbaru, true);
                            if (File.Exists(pathbaru))
                            {
                                query = "UPDATE Activation SET Val = '" + namabaru + "' WHERE Var = 'IconPath';";
                                Console.WriteLine(query);
                                cmd = new SQLiteCommand(query, k);
                                cmd.ExecuteNonQuery();
                                cmd.Dispose();
                                MessageBox.Show(msgText2, msgTitle2, MessageBoxButtons.OK, MessageBoxIcon.Information);

                                pbIcon.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + @"\bin\Debug" + namabaru);
                                pbIcon.BackgroundImageLayout = ImageLayout.Stretch;
                            }
                            else
                            {
                                MessageBox.Show(msgText3, msgTitle3, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show(msgText4, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception)
                {

                }                
            }
        }

        private void btnChangeInstance_Click(object sender, EventArgs e)
        {
            btnChangeInstance.Hide();
            panelProfileDetail.Enabled = true;
            btnSimpanProfil.Show();
            btnBatalProfil.Show();
        }

        private void btnSimpanProfil_Click(object sender, EventArgs e)
        {
            if (cekIsiProfil(txtInstanceName, "Name of Instance", "Nama Instansi") &&
                 cekIsiProfil(txtAddress1, "Address 1", "Alamat 1") &&
                 cekIsiProfil(txtAddress2, "Address 2", "Alamat 2") &&
                 cekIsiProfil(txtAddress3, "Address 3", "Alamat 3") &&
                 cekIsiProfil(txtWebsite, "Website", "Alamat web") &&
                 cekIsiProfil(txtPhone, "Phone number", "Nomor telepon") &&
                 cekIsiProfil(txtEmail, "Email", "Email") &&
                 cekIsiProfil(txtDesc, "Description", "Deksripsi"))
            {
                ep.Clear();
                saveInstance();
                saveInstanceAddress();
                saveInstanceContact();
                saveDesc();
                string msgText, msgTitle;
                if (Main.lang == "1")
                {
                    msgText = "Profile details changed successfully!";
                    msgTitle = "Confirmation";
                }
                else
                {
                    msgText = "Detail profil berhasil diubah!";
                    msgTitle = "Konfirmasi";
                }
                MessageBox.Show(msgText, msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                tabProfile_Enter(sender, e);
            }
            else
            {
                if (Main.lang == "1")
                {
                    ep.SetError(btnSimpanProfil, "All field must be filled and cannot be empty");
                }
                else
                {
                    ep.SetError(btnSimpanProfil, "Semua field harus terisi dan tidak boleh kosong");
                }
            }
        }

        void saveInstance()
        {
            try
            {
                query = "UPDATE Activation SET Val = '" + txtInstanceName.Text + "' WHERE Var = 'Instance';";
                Console.WriteLine(query);
                cmd = new SQLiteCommand(query, k);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (Exception)
            {

            }
        }

        void saveInstanceAddress()
        {
            try
            {
                query = "UPDATE Activation SET Val = '" + txtAddress1.Text + "' WHERE Var = 'Address1';";
                Console.WriteLine(query);
                cmd = new SQLiteCommand(query, k);
                cmd.ExecuteNonQuery();
                cmd.Dispose();

                query = "UPDATE Activation SET Val = '" + txtAddress2.Text + "' WHERE Var = 'Address2';";
                Console.WriteLine(query);
                cmd = new SQLiteCommand(query, k);
                cmd.ExecuteNonQuery();
                cmd.Dispose();

                query = "UPDATE Activation SET Val = '" + txtAddress3.Text + "' WHERE Var = 'Address3';";
                Console.WriteLine(query);
                cmd = new SQLiteCommand(query, k);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (Exception)
            {

            }
        }

        void saveInstanceContact()
        {
            try
            {
                query = "UPDATE Activation SET Val = '" + txtWebsite.Text + "' WHERE Var = 'Website';";
                Console.WriteLine(query);
                cmd = new SQLiteCommand(query, k);
                cmd.ExecuteNonQuery();
                cmd.Dispose();

                query = "UPDATE Activation SET Val = '" + txtPhone.Text + "' WHERE Var = 'Phone';";
                Console.WriteLine(query);
                cmd = new SQLiteCommand(query, k);
                cmd.ExecuteNonQuery();
                cmd.Dispose();

                query = "UPDATE Activation SET Val = '" + txtEmail.Text + "' WHERE Var = 'Email';";
                Console.WriteLine(query);
                cmd = new SQLiteCommand(query, k);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (Exception)
            {

            }
        }

        void saveDesc()
        {
            try
            {
                query = "UPDATE Config SET Desc = '" + txtDesc.Text + "' WHERE Var = 'Desc';";
                Console.WriteLine(query);
                cmd = new SQLiteCommand(query, k);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (Exception)
            {

            }
        }

        private void btnBatalProfil_Click(object sender, EventArgs e)
        {
            string msgText, msgTitle;
            if (Main.lang == "1")
            {
                msgText = "Are you sure to cancel?";
                msgTitle = "Confirmation";
            }
            else
            {
                msgText = "Anda yakin untuk membatalkan?";
                msgTitle = "Konfirmasi";
            }

            DialogResult msg = MessageBox.Show(msgText, msgTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (msg == DialogResult.Yes)
            {
                tabProfile_Enter(sender, e);
            }
        }

        bool cekIsiProfil(TextBox txt, string str1, string str2)
        {
            if (txt.Text != string.Empty)
            {
                ep.Clear();
                return true;
            }
            else
            {
                if (Main.lang == "1")
                {
                    ep.SetError(txt, str1 + " cannot be empty");
                }
                else
                {
                    ep.SetError(txt, str2 + " tidak boleh kosong");
                }
                return false;
            }
        }

        private void txtInstanceName_Validating(object sender, CancelEventArgs e)
        {
            cekIsiProfil(txtInstanceName, "Name of Instance", "Nama Instansi");
        }

        private void txtInstanceName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtInstanceName.Text.Length > 24 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtAddress1_Validating(object sender, CancelEventArgs e)
        {
            cekIsiProfil(txtAddress1, "Address 1", "Alamat 1");
        }

        private void txtAddress1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtAddress1.Text.Length > 30 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtAddress2_Validating(object sender, CancelEventArgs e)
        {
            cekIsiProfil(txtAddress2, "Address 2", "Alamat 2");
        }

        private void txtAddress2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtAddress2.Text.Length > 30 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtAddress3_Validating(object sender, CancelEventArgs e)
        {
            cekIsiProfil(txtAddress3, "Address 3", "Alamat 3");
        }

        private void txtAddress3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtAddress3.Text.Length > 30 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtWebsite_Validating(object sender, CancelEventArgs e)
        {
            cekIsiProfil(txtWebsite, "Website", "Alamat web");
        }

        private void txtWebsite_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtWebsite.Text.Length > 35 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPhone_Validating(object sender, CancelEventArgs e)
        {
            cekIsiProfil(txtPhone, "Phone number", "Nomor telepon");
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtPhone.Text.Length > 15 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            cekIsiProfil(txtEmail, "Email", "Email");
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtEmail.Text.Length > 50 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDesc_Validating(object sender, CancelEventArgs e)
        {
            cekIsiProfil(txtDesc, "Description", "Deksripsi");
        }

        private void txtDesc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtAddress1.Text.Length > 180 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
