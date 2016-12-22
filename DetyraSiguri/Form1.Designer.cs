namespace DetyraSiguri
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblLlojiEnkr = new System.Windows.Forms.Label();
            this.btnZgjedh = new System.Windows.Forms.Button();
            this.txtkey = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFajlli = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.lblZgjedhFajllin = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnOpsion = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMbyll = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGjuha = new System.Windows.Forms.ToolStripDropDownButton();
            this.tstShqip = new System.Windows.Forms.ToolStripMenuItem();
            this.tstAnglisht = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tstStatusi = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnReset = new System.Windows.Forms.Button();
            this.chAutoKey = new System.Windows.Forms.CheckBox();
            this.grInfo = new System.Windows.Forms.GroupBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmri = new System.Windows.Forms.Label();
            this.pbFotoja = new System.Windows.Forms.PictureBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnZgjerimi = new System.Windows.Forms.Button();
            this.btnDekript = new System.Windows.Forms.Button();
            this.btnEnkript = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.grInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLlojiEnkr
            // 
            this.lblLlojiEnkr.AutoSize = true;
            this.lblLlojiEnkr.Location = new System.Drawing.Point(547, 308);
            this.lblLlojiEnkr.Name = "lblLlojiEnkr";
            this.lblLlojiEnkr.Size = new System.Drawing.Size(130, 13);
            this.lblLlojiEnkr.TabIndex = 0;
            this.lblLlojiEnkr.Text = "Zgjedh Llojin e Enkriptimit:";
            this.lblLlojiEnkr.Visible = false;
            // 
            // btnZgjedh
            // 
            this.btnZgjedh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnZgjedh.Location = new System.Drawing.Point(240, 68);
            this.btnZgjedh.Name = "btnZgjedh";
            this.btnZgjedh.Size = new System.Drawing.Size(65, 21);
            this.btnZgjedh.TabIndex = 3;
            this.btnZgjedh.Text = "...";
            this.btnZgjedh.UseVisualStyleBackColor = true;
            this.btnZgjedh.Click += new System.EventHandler(this.btnZgjedh_Click);
            // 
            // txtkey
            // 
            this.txtkey.Location = new System.Drawing.Point(20, 114);
            this.txtkey.Name = "txtkey";
            this.txtkey.Size = new System.Drawing.Size(217, 20);
            this.txtkey.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteCustomSource.AddRange(new string[] {
            "3DES"});
            this.comboBox1.Enabled = false;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "2DES",
            "TripleDES"});
            this.comboBox1.Location = new System.Drawing.Point(550, 328);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(217, 23);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Key:";
            // 
            // txtFajlli
            // 
            this.txtFajlli.Location = new System.Drawing.Point(20, 68);
            this.txtFajlli.Name = "txtFajlli";
            this.txtFajlli.ReadOnly = true;
            this.txtFajlli.Size = new System.Drawing.Size(217, 20);
            this.txtFajlli.TabIndex = 2;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(358, 30);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(277, 321);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "";
            // 
            // lblZgjedhFajllin
            // 
            this.lblZgjedhFajllin.AutoSize = true;
            this.lblZgjedhFajllin.Location = new System.Drawing.Point(17, 52);
            this.lblZgjedhFajllin.Name = "lblZgjedhFajllin";
            this.lblZgjedhFajllin.Size = new System.Drawing.Size(69, 13);
            this.lblZgjedhFajllin.TabIndex = 14;
            this.lblZgjedhFajllin.Text = "Zgjedh fajllin:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnOpsion,
            this.btnGjuha,
            this.infoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(343, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Click += new System.EventHandler(this.grInfo_Leave);
            // 
            // btnOpsion
            // 
            this.btnOpsion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMbyll});
            this.btnOpsion.Image = global::DetyraSiguri.Properties.Resources.Ampeross_Qetto_2_Settings;
            this.btnOpsion.Name = "btnOpsion";
            this.btnOpsion.Size = new System.Drawing.Size(73, 23);
            this.btnOpsion.Text = "Opsion";
            // 
            // btnMbyll
            // 
            this.btnMbyll.Image = global::DetyraSiguri.Properties.Resources.perfundo;
            this.btnMbyll.Name = "btnMbyll";
            this.btnMbyll.Size = new System.Drawing.Size(152, 22);
            this.btnMbyll.Text = "Mbyll";
            this.btnMbyll.Click += new System.EventHandler(this.btnMbyll_Click);
            // 
            // btnGjuha
            // 
            this.btnGjuha.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstShqip,
            this.tstAnglisht});
            this.btnGjuha.Image = global::DetyraSiguri.Properties.Resources.language11;
            this.btnGjuha.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGjuha.Name = "btnGjuha";
            this.btnGjuha.Size = new System.Drawing.Size(67, 20);
            this.btnGjuha.Text = "Gjuha";
            // 
            // tstShqip
            // 
            this.tstShqip.Image = global::DetyraSiguri.Properties.Resources.Shqip;
            this.tstShqip.Name = "tstShqip";
            this.tstShqip.Size = new System.Drawing.Size(152, 22);
            this.tstShqip.Text = "Shqip";
            this.tstShqip.Click += new System.EventHandler(this.tstShqip_Click);
            // 
            // tstAnglisht
            // 
            this.tstAnglisht.Image = global::DetyraSiguri.Properties.Resources.English;
            this.tstAnglisht.Name = "tstAnglisht";
            this.tstAnglisht.Size = new System.Drawing.Size(152, 22);
            this.tstAnglisht.Text = "Anglisht";
            this.tstAnglisht.Click += new System.EventHandler(this.tstAnglisht_Click);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Image = global::DetyraSiguri.Properties.Resources.Aroche_Delta_Help;
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(56, 23);
            this.infoToolStripMenuItem.Text = "Info";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstStatusi});
            this.statusStrip1.Location = new System.Drawing.Point(0, 362);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(343, 22);
            this.statusStrip1.TabIndex = 16;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tstStatusi
            // 
            this.tstStatusi.Name = "tstStatusi";
            this.tstStatusi.Size = new System.Drawing.Size(0, 17);
            // 
            // btnReset
            // 
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.Location = new System.Drawing.Point(20, 138);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(84, 26);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reseto Fushat";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // chAutoKey
            // 
            this.chAutoKey.AutoSize = true;
            this.chAutoKey.Location = new System.Drawing.Point(241, 116);
            this.chAutoKey.Name = "chAutoKey";
            this.chAutoKey.Size = new System.Drawing.Size(66, 17);
            this.chAutoKey.TabIndex = 20;
            this.chAutoKey.Text = "AutoKey";
            this.chAutoKey.UseVisualStyleBackColor = true;
            this.chAutoKey.CheckedChanged += new System.EventHandler(this.AutoKey_CheckedChanged);
            // 
            // grInfo
            // 
            this.grInfo.BackColor = System.Drawing.Color.LightSteelBlue;
            this.grInfo.BackgroundImage = global::DetyraSiguri.Properties.Resources._17ks7p1sf9w5ejpg;
            this.grInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grInfo.Controls.Add(this.pictureBox4);
            this.grInfo.Controls.Add(this.pictureBox5);
            this.grInfo.Controls.Add(this.pictureBox6);
            this.grInfo.Controls.Add(this.lblEmail);
            this.grInfo.Controls.Add(this.label1);
            this.grInfo.Controls.Add(this.txtEmri);
            this.grInfo.Controls.Add(this.pbFotoja);
            this.grInfo.Controls.Add(this.lblInfo);
            this.grInfo.Controls.Add(this.pictureBox2);
            this.grInfo.Font = new System.Drawing.Font("Arial", 10F);
            this.grInfo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.grInfo.Location = new System.Drawing.Point(480, 30);
            this.grInfo.Name = "grInfo";
            this.grInfo.Size = new System.Drawing.Size(317, 199);
            this.grInfo.TabIndex = 19;
            this.grInfo.TabStop = false;
            this.grInfo.Text = "Info rreth Projektit";
            this.grInfo.Visible = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.WindowText;
            this.pictureBox4.BackgroundImage = global::DetyraSiguri.Properties.Resources.Next;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Location = new System.Drawing.Point(202, 155);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(34, 29);
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pbNext_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.SystemColors.WindowText;
            this.pictureBox5.BackgroundImage = global::DetyraSiguri.Properties.Resources.back;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox5.Location = new System.Drawing.Point(150, 155);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(34, 29);
            this.pictureBox5.TabIndex = 8;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pbBack_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox6.Location = new System.Drawing.Point(143, 152);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(98, 36);
            this.pictureBox6.TabIndex = 9;
            this.pictureBox6.TabStop = false;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.lblEmail.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblEmail.Location = new System.Drawing.Point(134, 131);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(143, 19);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "arti._3@hotmail.com";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(134, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Student: FIEK, Viti III";
            // 
            // txtEmri
            // 
            this.txtEmri.AutoSize = true;
            this.txtEmri.ForeColor = System.Drawing.Color.DarkBlue;
            this.txtEmri.Location = new System.Drawing.Point(134, 90);
            this.txtEmri.Name = "txtEmri";
            this.txtEmri.Size = new System.Drawing.Size(70, 16);
            this.txtEmri.TabIndex = 3;
            this.txtEmri.Text = "Arton Hoti";
            // 
            // pbFotoja
            // 
            this.pbFotoja.BackColor = System.Drawing.Color.Transparent;
            this.pbFotoja.BackgroundImage = global::DetyraSiguri.Properties.Resources.artoni;
            this.pbFotoja.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbFotoja.Location = new System.Drawing.Point(17, 89);
            this.pbFotoja.Name = "pbFotoja";
            this.pbFotoja.Size = new System.Drawing.Size(100, 86);
            this.pbFotoja.TabIndex = 2;
            this.pbFotoja.TabStop = false;
            // 
            // lblInfo
            // 
            this.lblInfo.BackColor = System.Drawing.Color.CadetBlue;
            this.lblInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblInfo.Font = new System.Drawing.Font("Arial", 9F);
            this.lblInfo.ForeColor = System.Drawing.Color.FloralWhite;
            this.lblInfo.Image = global::DetyraSiguri.Properties.Resources._17ks7p1sf9w5ejpg;
            this.lblInfo.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lblInfo.Location = new System.Drawing.Point(14, 25);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(290, 53);
            this.lblInfo.TabIndex = 1;
            this.lblInfo.Text = "Projekti \"Enkriptimi me 3DES\" eshte punuar ne \r\nkuader te lendes Siguria ne Inter" +
    "net, ne mbikqyrjen \r\ne prof.Ilir Murturi dhe ne te punuan studentet:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::DetyraSiguri.Properties.Resources._17ks7p1sf9w5ejpg;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(6, 20);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(305, 155);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Transparent;
            this.btnRefresh.Image = global::DetyraSiguri.Properties.Resources.refresh;
            this.btnRefresh.Location = new System.Drawing.Point(641, 19);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(36, 34);
            this.btnRefresh.TabIndex = 21;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnZgjerimi
            // 
            this.btnZgjerimi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnZgjerimi.Enabled = false;
            this.btnZgjerimi.Font = new System.Drawing.Font("Arial", 10F);
            this.btnZgjerimi.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnZgjerimi.Image = global::DetyraSiguri.Properties.Resources.Djathte;
            this.btnZgjerimi.Location = new System.Drawing.Point(317, 61);
            this.btnZgjerimi.Name = "btnZgjerimi";
            this.btnZgjerimi.Size = new System.Drawing.Size(20, 290);
            this.btnZgjerimi.TabIndex = 10;
            this.btnZgjerimi.UseVisualStyleBackColor = true;
            this.btnZgjerimi.Click += new System.EventHandler(this.btnZgjerimi_Click);
            // 
            // btnDekript
            // 
            this.btnDekript.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDekript.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDekript.Font = new System.Drawing.Font("Arial", 11.25F);
            this.btnDekript.Image = global::DetyraSiguri.Properties.Resources.Decrypt;
            this.btnDekript.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDekript.Location = new System.Drawing.Point(176, 273);
            this.btnDekript.Name = "btnDekript";
            this.btnDekript.Size = new System.Drawing.Size(98, 34);
            this.btnDekript.TabIndex = 9;
            this.btnDekript.Text = "Dekripto";
            this.btnDekript.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDekript.UseVisualStyleBackColor = true;
            this.btnDekript.Click += new System.EventHandler(this.btnDekript_Click);
            // 
            // btnEnkript
            // 
            this.btnEnkript.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnkript.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEnkript.Font = new System.Drawing.Font("Arial", 11.25F);
            this.btnEnkript.Image = global::DetyraSiguri.Properties.Resources.Encryp1t;
            this.btnEnkript.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEnkript.Location = new System.Drawing.Point(176, 219);
            this.btnEnkript.Name = "btnEnkript";
            this.btnEnkript.Size = new System.Drawing.Size(98, 34);
            this.btnEnkript.TabIndex = 8;
            this.btnEnkript.Text = "Enkripto";
            this.btnEnkript.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEnkript.UseVisualStyleBackColor = true;
            this.btnEnkript.Click += new System.EventHandler(this.btnEnkript_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::DetyraSiguri.Properties.Resources.eeeeeee;
            this.pictureBox1.Location = new System.Drawing.Point(12, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(299, 321);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.grInfo_Leave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 384);
            this.Controls.Add(this.grInfo);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.chAutoKey);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lblZgjedhFajllin);
            this.Controls.Add(this.btnZgjerimi);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.txtFajlli);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDekript);
            this.Controls.Add(this.btnEnkript);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtkey);
            this.Controls.Add(this.btnZgjedh);
            this.Controls.Add(this.lblLlojiEnkr);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "3DES |  Encrypt File";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.grInfo_Leave);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.grInfo.ResumeLayout(false);
            this.grInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLlojiEnkr;
        private System.Windows.Forms.Button btnZgjedh;
        private System.Windows.Forms.TextBox txtkey;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnEnkript;
        private System.Windows.Forms.Button btnDekript;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFajlli;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnZgjerimi;
        private System.Windows.Forms.Label lblZgjedhFajllin;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnOpsion;
        private System.Windows.Forms.ToolStripMenuItem btnMbyll;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tstStatusi;
        private System.Windows.Forms.ToolStripDropDownButton btnGjuha;
        private System.Windows.Forms.ToolStripMenuItem tstShqip;
        private System.Windows.Forms.ToolStripMenuItem tstAnglisht;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox grInfo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pbFotoja;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label txtEmri;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.CheckBox chAutoKey;
        private System.Windows.Forms.Button btnRefresh;
    }
}

