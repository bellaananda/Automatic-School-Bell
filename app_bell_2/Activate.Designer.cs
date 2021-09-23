namespace app_bell_2
{
    partial class Activate
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblActivate = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblActivate1 = new System.Windows.Forms.Label();
            this.txtActivate1 = new System.Windows.Forms.TextBox();
            this.txtActivate2 = new System.Windows.Forms.TextBox();
            this.lblActivate2 = new System.Windows.Forms.Label();
            this.btnActivate = new System.Windows.Forms.Button();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.ep = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(167)))), ((int)(((byte)(222)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Calibri", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(689, 72);
            this.label1.TabIndex = 0;
            this.label1.Text = "AUTOMATIC SCHOOL BELL";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(222)))), ((int)(((byte)(68)))));
            this.panel1.Controls.Add(this.lblActivate);
            this.panel1.Location = new System.Drawing.Point(0, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(689, 48);
            this.panel1.TabIndex = 1;
            // 
            // lblActivate
            // 
            this.lblActivate.Font = new System.Drawing.Font("Arial Unicode MS", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActivate.ForeColor = System.Drawing.Color.Transparent;
            this.lblActivate.Location = new System.Drawing.Point(5, 8);
            this.lblActivate.Name = "lblActivate";
            this.lblActivate.Size = new System.Drawing.Size(336, 32);
            this.lblActivate.TabIndex = 0;
            this.lblActivate.Text = "AKTIVASI";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(255)))), ((int)(((byte)(215)))));
            this.panel2.Controls.Add(this.btnActivate);
            this.panel2.Controls.Add(this.txtActivate2);
            this.panel2.Controls.Add(this.lblActivate2);
            this.panel2.Controls.Add(this.txtActivate1);
            this.panel2.Controls.Add(this.lblActivate1);
            this.panel2.Location = new System.Drawing.Point(10, 130);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(667, 247);
            this.panel2.TabIndex = 2;
            // 
            // lblActivate1
            // 
            this.lblActivate1.Font = new System.Drawing.Font("Candara", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActivate1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(150)))), ((int)(((byte)(199)))));
            this.lblActivate1.Location = new System.Drawing.Point(43, 35);
            this.lblActivate1.Name = "lblActivate1";
            this.lblActivate1.Size = new System.Drawing.Size(357, 33);
            this.lblActivate1.TabIndex = 0;
            this.lblActivate1.Text = "Masukkan Kode Aktivasi";
            // 
            // txtActivate1
            // 
            this.txtActivate1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(167)))), ((int)(((byte)(222)))));
            this.txtActivate1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtActivate1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtActivate1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(255)))), ((int)(((byte)(215)))));
            this.txtActivate1.Location = new System.Drawing.Point(48, 72);
            this.txtActivate1.Name = "txtActivate1";
            this.txtActivate1.Size = new System.Drawing.Size(352, 30);
            this.txtActivate1.TabIndex = 1;
            this.txtActivate1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtActivate1_KeyPress);
            this.txtActivate1.Validating += new System.ComponentModel.CancelEventHandler(this.txtActivate1_Validating);
            // 
            // txtActivate2
            // 
            this.txtActivate2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(167)))), ((int)(((byte)(222)))));
            this.txtActivate2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtActivate2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtActivate2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(255)))), ((int)(((byte)(215)))));
            this.txtActivate2.Location = new System.Drawing.Point(48, 165);
            this.txtActivate2.Name = "txtActivate2";
            this.txtActivate2.Size = new System.Drawing.Size(352, 30);
            this.txtActivate2.TabIndex = 3;
            this.txtActivate2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtActivate2_KeyPress);
            this.txtActivate2.Validating += new System.ComponentModel.CancelEventHandler(this.txtActivate2_Validating);
            // 
            // lblActivate2
            // 
            this.lblActivate2.Font = new System.Drawing.Font("Candara", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActivate2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(150)))), ((int)(((byte)(199)))));
            this.lblActivate2.Location = new System.Drawing.Point(43, 128);
            this.lblActivate2.Name = "lblActivate2";
            this.lblActivate2.Size = new System.Drawing.Size(357, 33);
            this.lblActivate2.TabIndex = 2;
            this.lblActivate2.Text = "Konfirmasi Kode Aktivasi";
            // 
            // btnActivate
            // 
            this.btnActivate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(167)))), ((int)(((byte)(222)))));
            this.btnActivate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActivate.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActivate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(255)))), ((int)(((byte)(215)))));
            this.btnActivate.Location = new System.Drawing.Point(451, 89);
            this.btnActivate.Name = "btnActivate";
            this.btnActivate.Size = new System.Drawing.Size(181, 72);
            this.btnActivate.TabIndex = 4;
            this.btnActivate.Text = "Aktivasi Sekarang";
            this.btnActivate.UseVisualStyleBackColor = false;
            this.btnActivate.Click += new System.EventHandler(this.btnActivate_Click);
            // 
            // lblCopyright
            // 
            this.lblCopyright.Font = new System.Drawing.Font("Candara", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopyright.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(150)))), ((int)(((byte)(199)))));
            this.lblCopyright.Location = new System.Drawing.Point(483, 387);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(194, 33);
            this.lblCopyright.TabIndex = 3;
            this.lblCopyright.Text = "Copyright © 2021";
            this.lblCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ep
            // 
            this.ep.ContainerControl = this;
            // 
            // Activate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(689, 434);
            this.Controls.Add(this.lblCopyright);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Activate";
            this.Text = "Activate";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Activate_FormClosing);
            this.Load += new System.EventHandler(this.Activate_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblActivate;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtActivate1;
        private System.Windows.Forms.Label lblActivate1;
        private System.Windows.Forms.TextBox txtActivate2;
        private System.Windows.Forms.Label lblActivate2;
        private System.Windows.Forms.Button btnActivate;
        private System.Windows.Forms.Label lblCopyright;
        private System.Windows.Forms.ErrorProvider ep;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}