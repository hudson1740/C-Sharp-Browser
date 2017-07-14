namespace C_Sharp_Browser
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
            this.faderTheme1 = new Fader_Theme.FaderTheme();
            this.faderControlBox1 = new Fader_Theme.FaderControlBox();
            this.faderVerticalTabControl1 = new Fader_Theme.FaderVerticalTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.faderButton1 = new Fader_Theme.FaderButton();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.faderTextBox1 = new Fader_Theme.FaderTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.faderTheme2 = new Fader_Theme.FaderTheme();
            this.faderTextBox2 = new Fader_Theme.FaderTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.faderButton3 = new Fader_Theme.FaderButton();
            this.faderButton2 = new Fader_Theme.FaderButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.faderPanel1 = new Fader_Theme.FaderPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.faderTheme1.SuspendLayout();
            this.faderVerticalTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.faderTheme2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.faderPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // faderTheme1
            // 
            this.faderTheme1.Controls.Add(this.faderControlBox1);
            this.faderTheme1.Controls.Add(this.faderVerticalTabControl1);
            this.faderTheme1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.faderTheme1.HeaderAlignment = Fader_Theme.AlignmentStyle.Center;
            this.faderTheme1.Icon = null;
            this.faderTheme1.Location = new System.Drawing.Point(0, 0);
            this.faderTheme1.MaximumSize = new System.Drawing.Size(1170, 761);
            this.faderTheme1.Name = "faderTheme1";
            this.faderTheme1.ShowHeader = true;
            this.faderTheme1.ShowIcon = true;
            this.faderTheme1.Size = new System.Drawing.Size(1170, 761);
            this.faderTheme1.TabIndex = 1;
            this.faderTheme1.Text = "C-Sharp Browser (Brett-Tech)";
            this.faderTheme1.Click += new System.EventHandler(this.faderTheme1_Click);
            // 
            // faderControlBox1
            // 
            this.faderControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.faderControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.faderControlBox1.Location = new System.Drawing.Point(1068, 12);
            this.faderControlBox1.MaximumDisable = false;
            this.faderControlBox1.MinimumDisable = false;
            this.faderControlBox1.Name = "faderControlBox1";
            this.faderControlBox1.Size = new System.Drawing.Size(85, 30);
            this.faderControlBox1.TabIndex = 1;
            this.faderControlBox1.Text = "faderControlBox1";
            // 
            // faderVerticalTabControl1
            // 
            this.faderVerticalTabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.faderVerticalTabControl1.Controls.Add(this.tabPage1);
            this.faderVerticalTabControl1.Controls.Add(this.tabPage2);
            this.faderVerticalTabControl1.Controls.Add(this.tabPage3);
            this.faderVerticalTabControl1.ItemSize = new System.Drawing.Size(35, 100);
            this.faderVerticalTabControl1.Location = new System.Drawing.Point(16, 62);
            this.faderVerticalTabControl1.Multiline = true;
            this.faderVerticalTabControl1.Name = "faderVerticalTabControl1";
            this.faderVerticalTabControl1.SelectedIndex = 0;
            this.faderVerticalTabControl1.Size = new System.Drawing.Size(1142, 674);
            this.faderVerticalTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.faderVerticalTabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.pictureBox3);
            this.tabPage1.Controls.Add(this.pictureBox2);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.faderButton1);
            this.tabPage1.Controls.Add(this.webBrowser1);
            this.tabPage1.Controls.Add(this.faderTextBox1);
            this.tabPage1.Location = new System.Drawing.Point(104, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1034, 666);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Browser";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Yellow;
            this.button1.Location = new System.Drawing.Point(35, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Add Bookmark";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::C_Sharp_Browser.Properties.Resources.imageedit_6_5075381405;
            this.pictureBox3.Location = new System.Drawing.Point(163, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(56, 40);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::C_Sharp_Browser.Properties.Resources.imageedit_3_9787858024;
            this.pictureBox2.Location = new System.Drawing.Point(990, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 31);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::C_Sharp_Browser.Properties.Resources.imageedit_1_9972363874;
            this.pictureBox1.Location = new System.Drawing.Point(937, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // faderButton1
            // 
            this.faderButton1.BackColor = System.Drawing.Color.Transparent;
            this.faderButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.faderButton1.ForeColor = System.Drawing.Color.Red;
            this.faderButton1.Location = new System.Drawing.Point(881, 6);
            this.faderButton1.Name = "faderButton1";
            this.faderButton1.Size = new System.Drawing.Size(50, 33);
            this.faderButton1.TabIndex = 3;
            this.faderButton1.Text = "Go";
            this.faderButton1.Click += new System.EventHandler(this.faderButton1_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(2, 42);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.Size = new System.Drawing.Size(1031, 624);
            this.webBrowser1.TabIndex = 2;
            this.webBrowser1.Url = new System.Uri("http://www.google.com", System.UriKind.Absolute);
            // 
            // faderTextBox1
            // 
            this.faderTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.faderTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.faderTextBox1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.faderTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.faderTextBox1.Location = new System.Drawing.Point(221, 8);
            this.faderTextBox1.MaxLength = 32767;
            this.faderTextBox1.MultiLine = false;
            this.faderTextBox1.Name = "faderTextBox1";
            this.faderTextBox1.ReadOnly = false;
            this.faderTextBox1.Size = new System.Drawing.Size(654, 30);
            this.faderTextBox1.TabIndex = 0;
            this.faderTextBox1.Text = "Enter URL ";
            this.faderTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.faderTextBox1.UseSystemPasswordChar = false;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.tabPage2.Controls.Add(this.faderTheme2);
            this.tabPage2.Location = new System.Drawing.Point(104, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1034, 666);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "Bookmarks";
            // 
            // faderTheme2
            // 
            this.faderTheme2.Controls.Add(this.faderTextBox2);
            this.faderTheme2.Controls.Add(this.label4);
            this.faderTheme2.Controls.Add(this.listView1);
            this.faderTheme2.Controls.Add(this.faderButton3);
            this.faderTheme2.Controls.Add(this.faderButton2);
            this.faderTheme2.Controls.Add(this.toolStrip1);
            this.faderTheme2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.faderTheme2.HeaderAlignment = Fader_Theme.AlignmentStyle.Center;
            this.faderTheme2.Icon = null;
            this.faderTheme2.Location = new System.Drawing.Point(0, 0);
            this.faderTheme2.Name = "faderTheme2";
            this.faderTheme2.ShowHeader = true;
            this.faderTheme2.ShowIcon = true;
            this.faderTheme2.Size = new System.Drawing.Size(1034, 666);
            this.faderTheme2.TabIndex = 0;
            this.faderTheme2.Text = "Bookmarks";
            this.faderTheme2.Click += new System.EventHandler(this.faderTheme2_Click);
            // 
            // faderTextBox2
            // 
            this.faderTextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.faderTextBox2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.faderTextBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.faderTextBox2.Location = new System.Drawing.Point(461, 96);
            this.faderTextBox2.MaxLength = 32767;
            this.faderTextBox2.MultiLine = false;
            this.faderTextBox2.Name = "faderTextBox2";
            this.faderTextBox2.ReadOnly = false;
            this.faderTextBox2.Size = new System.Drawing.Size(129, 30);
            this.faderTextBox2.TabIndex = 5;
            this.faderTextBox2.Text = "Load Bookmark";
            this.faderTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.faderTextBox2.UseSystemPasswordChar = false;
            this.faderTextBox2.Click += new System.EventHandler(this.faderTextBox2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Lime;
            this.label4.Location = new System.Drawing.Point(68, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(307, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Enter Link You Want To Bookmark:";
            // 
            // listView1
            // 
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(238, 132);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(592, 511);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // faderButton3
            // 
            this.faderButton3.BackColor = System.Drawing.Color.Transparent;
            this.faderButton3.Location = new System.Drawing.Point(685, 91);
            this.faderButton3.Name = "faderButton3";
            this.faderButton3.Size = new System.Drawing.Size(145, 35);
            this.faderButton3.TabIndex = 2;
            this.faderButton3.Text = "Remove Bookmark";
            this.faderButton3.Click += new System.EventHandler(this.faderButton3_Click);
            // 
            // faderButton2
            // 
            this.faderButton2.BackColor = System.Drawing.Color.Transparent;
            this.faderButton2.Location = new System.Drawing.Point(238, 91);
            this.faderButton2.Name = "faderButton2";
            this.faderButton2.Size = new System.Drawing.Size(124, 35);
            this.faderButton2.TabIndex = 1;
            this.faderButton2.Text = "Add Boomark";
            this.faderButton2.Click += new System.EventHandler(this.faderButton2_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1});
            this.toolStrip1.Location = new System.Drawing.Point(376, 63);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(304, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(290, 25);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.tabPage3.Controls.Add(this.faderPanel1);
            this.tabPage3.Location = new System.Drawing.Point(104, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1034, 666);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Info";
            // 
            // faderPanel1
            // 
            this.faderPanel1.BackColor = System.Drawing.Color.Transparent;
            this.faderPanel1.Controls.Add(this.label3);
            this.faderPanel1.Controls.Add(this.textBox1);
            this.faderPanel1.Controls.Add(this.label2);
            this.faderPanel1.Controls.Add(this.label1);
            this.faderPanel1.Location = new System.Drawing.Point(118, 179);
            this.faderPanel1.Name = "faderPanel1";
            this.faderPanel1.Size = new System.Drawing.Size(778, 298);
            this.faderPanel1.TabIndex = 0;
            this.faderPanel1.Text = "faderPanel1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.label3.Location = new System.Drawing.Point(236, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(290, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Email: Support@Brett-TechRepair.Com";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(174, 83);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(411, 125);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("AR ESSENCE", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(271, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Developed By Brett Tech Networking";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Colonna MT", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(202, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(406, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "C-Sharp Browser ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 761);
            this.Controls.Add(this.faderTheme1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1170, 761);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Brett Tech C-Sharp Browser";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.faderTheme1.ResumeLayout(false);
            this.faderVerticalTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.faderTheme2.ResumeLayout(false);
            this.faderTheme2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.faderPanel1.ResumeLayout(false);
            this.faderPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Fader_Theme.FaderTheme faderTheme1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;
        private Fader_Theme.FaderButton faderButton1;
        private Fader_Theme.FaderControlBox faderControlBox1;
        private Fader_Theme.FaderPanel faderPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public Fader_Theme.FaderVerticalTabControl faderVerticalTabControl1;
        public System.Windows.Forms.WebBrowser webBrowser1;
        public Fader_Theme.FaderTextBox faderTextBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TabPage tabPage2;
        private Fader_Theme.FaderTheme faderTheme2;
        public System.Windows.Forms.ListView listView1;
        public Fader_Theme.FaderButton faderButton3;
        public Fader_Theme.FaderButton faderButton2;
        public System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private Fader_Theme.FaderTextBox faderTextBox2;
    }
}

