namespace app_bell_2
{
    partial class Settings_Pass
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnShowPass = new Bunifu.Framework.UI.BunifuImageButton();
            this.txtPass = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.linkPass = new System.Windows.Forms.LinkLabel();
            this.btnLanjut = new Bunifu.Framework.UI.BunifuFlatButton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.ep = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lblRem = new System.Windows.Forms.Label();
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnShowPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(255)))), ((int)(((byte)(215)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnShowPass);
            this.panel2.Controls.Add(this.txtPass);
            this.panel2.Controls.Add(this.linkPass);
            this.panel2.Controls.Add(this.btnLanjut);
            this.panel2.Controls.Add(this.checkBox1);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(480, 247);
            this.panel2.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(169)))), ((int)(((byte)(204)))));
            this.label1.Location = new System.Drawing.Point(24, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 28);
            this.label1.TabIndex = 16;
            this.label1.Text = "Masukkan Password";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnShowPass
            // 
            this.btnShowPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(255)))), ((int)(((byte)(215)))));
            this.btnShowPass.Image = global::app_bell_2.Properties.Resources.eye;
            this.btnShowPass.ImageActive = null;
            this.btnShowPass.Location = new System.Drawing.Point(414, 77);
            this.btnShowPass.Name = "btnShowPass";
            this.btnShowPass.Size = new System.Drawing.Size(35, 35);
            this.btnShowPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnShowPass.TabIndex = 18;
            this.btnShowPass.TabStop = false;
            this.btnShowPass.Zoom = 10;
            this.btnShowPass.Click += new System.EventHandler(this.btnShowPass_Click);
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(255)))), ((int)(((byte)(215)))));
            this.txtPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPass.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.ForeColor = System.Drawing.Color.Gray;
            this.txtPass.HintForeColor = System.Drawing.Color.Gray;
            this.txtPass.HintText = "";
            this.txtPass.isPassword = false;
            this.txtPass.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(169)))), ((int)(((byte)(204)))));
            this.txtPass.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(169)))), ((int)(((byte)(204)))));
            this.txtPass.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(169)))), ((int)(((byte)(204)))));
            this.txtPass.LineThickness = 5;
            this.txtPass.Location = new System.Drawing.Point(27, 28);
            this.txtPass.Margin = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(422, 93);
            this.txtPass.TabIndex = 17;
            this.txtPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // linkPass
            // 
            this.linkPass.ActiveLinkColor = System.Drawing.Color.Gray;
            this.linkPass.AutoSize = true;
            this.linkPass.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkPass.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(169)))), ((int)(((byte)(204)))));
            this.linkPass.Location = new System.Drawing.Point(317, 133);
            this.linkPass.Name = "linkPass";
            this.linkPass.Size = new System.Drawing.Size(132, 19);
            this.linkPass.TabIndex = 20;
            this.linkPass.TabStop = true;
            this.linkPass.Text = "Lupa Password?";
            this.linkPass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkPass_LinkClicked);
            // 
            // btnLanjut
            // 
            this.btnLanjut.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(142)))), ((int)(((byte)(240)))));
            this.btnLanjut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(138)))), ((int)(((byte)(204)))));
            this.btnLanjut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLanjut.BorderRadius = 0;
            this.btnLanjut.ButtonText = "Lanjut";
            this.btnLanjut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLanjut.DisabledColor = System.Drawing.Color.Gray;
            this.btnLanjut.Iconcolor = System.Drawing.Color.Transparent;
            this.btnLanjut.Iconimage = null;
            this.btnLanjut.Iconimage_right = null;
            this.btnLanjut.Iconimage_right_Selected = null;
            this.btnLanjut.Iconimage_Selected = null;
            this.btnLanjut.IconMarginLeft = 0;
            this.btnLanjut.IconMarginRight = 0;
            this.btnLanjut.IconRightVisible = true;
            this.btnLanjut.IconRightZoom = 0D;
            this.btnLanjut.IconVisible = true;
            this.btnLanjut.IconZoom = 90D;
            this.btnLanjut.IsTab = false;
            this.btnLanjut.Location = new System.Drawing.Point(350, 176);
            this.btnLanjut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLanjut.Name = "btnLanjut";
            this.btnLanjut.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(138)))), ((int)(((byte)(204)))));
            this.btnLanjut.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(142)))), ((int)(((byte)(240)))));
            this.btnLanjut.OnHoverTextColor = System.Drawing.Color.White;
            this.btnLanjut.selected = false;
            this.btnLanjut.Size = new System.Drawing.Size(99, 47);
            this.btnLanjut.TabIndex = 21;
            this.btnLanjut.Text = "Lanjut";
            this.btnLanjut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLanjut.Textcolor = System.Drawing.Color.White;
            this.btnLanjut.TextFont = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLanjut.Click += new System.EventHandler(this.btnLanjut_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(142)))), ((int)(((byte)(240)))));
            this.checkBox1.Location = new System.Drawing.Point(28, 129);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(118, 23);
            this.checkBox1.TabIndex = 19;
            this.checkBox1.Text = "Ingat Saya";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // lblCopyright
            // 
            this.lblCopyright.Font = new System.Drawing.Font("Candara", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopyright.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(150)))), ((int)(((byte)(199)))));
            this.lblCopyright.Location = new System.Drawing.Point(298, 262);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(194, 33);
            this.lblCopyright.TabIndex = 14;
            this.lblCopyright.Text = "Copyright © 2021";
            this.lblCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ep
            // 
            this.ep.ContainerControl = this;
            // 
            // lblRem
            // 
            this.lblRem.AutoSize = true;
            this.lblRem.Location = new System.Drawing.Point(12, 270);
            this.lblRem.Name = "lblRem";
            this.lblRem.Size = new System.Drawing.Size(51, 20);
            this.lblRem.TabIndex = 15;
            this.lblRem.Text = "label1";
            this.lblRem.Visible = false;
            // 
            // Settings_Pass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(504, 308);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblCopyright);
            this.Controls.Add(this.lblRem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Settings_Pass";
            this.Text = "Masukkan Password";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Settings_Pass_FormClosing);
            this.Load += new System.EventHandler(this.Settings_Pass_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnShowPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblCopyright;
        private System.Windows.Forms.ErrorProvider ep;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.LinkLabel linkPass;
        private Bunifu.Framework.UI.BunifuFlatButton btnLanjut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRem;
        private Bunifu.Framework.UI.BunifuImageButton btnShowPass;
        private System.Windows.Forms.CheckBox checkBox1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPass;
        private System.Windows.Forms.ToolTip toolTip2;
    }
}