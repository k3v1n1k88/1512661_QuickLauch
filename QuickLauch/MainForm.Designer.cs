namespace QuickLauch
{
    partial class QuickLaunch
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        /// 
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuickLaunch));
            this.trayQuickLaunch = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuTrayQuickLaunch = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.stasticToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scanAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chooseFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.resetAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetUsingHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewStaticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.progressPanel1 = new DevExpress.XtraWaitForm.ProgressPanel();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.contextMenuTrayQuickLaunch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // trayQuickLaunch
            // 
            this.trayQuickLaunch.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            this.trayQuickLaunch.BalloonTipText = "Press Alt + F to quick launch ";
            this.trayQuickLaunch.BalloonTipTitle = "Quick Launch";
            this.trayQuickLaunch.ContextMenuStrip = this.contextMenuTrayQuickLaunch;
            this.trayQuickLaunch.Icon = ((System.Drawing.Icon)(resources.GetObject("trayQuickLaunch.Icon")));
            this.trayQuickLaunch.Text = "Alt + F to start Quick Laucn";
            this.trayQuickLaunch.Visible = true;
            this.trayQuickLaunch.MouseClick += new System.Windows.Forms.MouseEventHandler(this.trayQuickLaunch_MouseClick);
            this.trayQuickLaunch.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.trayQuickLaunch_MouseDoubleClick);
            // 
            // contextMenuTrayQuickLaunch
            // 
            this.contextMenuTrayQuickLaunch.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.stasticToolStripMenuItem,
            this.toolStripMenuItem3,
            this.resetAllToolStripMenuItem,
            this.resetUsingHistoryToolStripMenuItem,
            this.viewStaticsToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.toolStripMenuItem4,
            this.exitToolStripMenuItem});
            this.contextMenuTrayQuickLaunch.Name = "contextMenuTrayQuickLaunch";
            this.contextMenuTrayQuickLaunch.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.contextMenuTrayQuickLaunch.Size = new System.Drawing.Size(206, 192);
            this.contextMenuTrayQuickLaunch.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(205, 22);
            this.toolStripMenuItem2.Text = "Begin open quick launch";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // stasticToolStripMenuItem
            // 
            this.stasticToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scanAllToolStripMenuItem,
            this.chooseFolderToolStripMenuItem});
            this.stasticToolStripMenuItem.Name = "stasticToolStripMenuItem";
            this.stasticToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.stasticToolStripMenuItem.Text = "Scan to build database";
            // 
            // scanAllToolStripMenuItem
            // 
            this.scanAllToolStripMenuItem.Name = "scanAllToolStripMenuItem";
            this.scanAllToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.scanAllToolStripMenuItem.Text = "Scan All";
            this.scanAllToolStripMenuItem.Click += new System.EventHandler(this.scanAllToolStripMenuItem_Click);
            // 
            // chooseFolderToolStripMenuItem
            // 
            this.chooseFolderToolStripMenuItem.Name = "chooseFolderToolStripMenuItem";
            this.chooseFolderToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.chooseFolderToolStripMenuItem.Text = "Choose folder...";
            this.chooseFolderToolStripMenuItem.Click += new System.EventHandler(this.chooseFolderToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(202, 6);
            // 
            // resetAllToolStripMenuItem
            // 
            this.resetAllToolStripMenuItem.Name = "resetAllToolStripMenuItem";
            this.resetAllToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.resetAllToolStripMenuItem.Text = "Clear database";
            this.resetAllToolStripMenuItem.Click += new System.EventHandler(this.resetAllToolStripMenuItem_Click);
            // 
            // resetUsingHistoryToolStripMenuItem
            // 
            this.resetUsingHistoryToolStripMenuItem.Name = "resetUsingHistoryToolStripMenuItem";
            this.resetUsingHistoryToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.resetUsingHistoryToolStripMenuItem.Text = "Reset running history";
            this.resetUsingHistoryToolStripMenuItem.Click += new System.EventHandler(this.resetUsingHistoryToolStripMenuItem_Click);
            // 
            // viewStaticsToolStripMenuItem
            // 
            this.viewStaticsToolStripMenuItem.Name = "viewStaticsToolStripMenuItem";
            this.viewStaticsToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.viewStaticsToolStripMenuItem.Text = "View statics";
            this.viewStaticsToolStripMenuItem.Click += new System.EventHandler(this.viewStaticsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.aboutToolStripMenuItem.Text = "About me...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.labelControl1.LineVisible = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 58);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(34, 14);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Open:";
            // 
            // textBox1
            // 
            this.textBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(64, 54);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(282, 23);
            this.textBox1.TabIndex = 2;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(367, 53);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(55, 26);
            this.simpleButton1.TabIndex = 3;
            this.simpleButton1.Text = "Go";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Type the name of program and we will open for you quickly.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuickLauch.Properties.Resources.unnamed;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 30);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // progressPanel1
            // 
            this.progressPanel1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.progressPanel1.Appearance.Options.UseBackColor = true;
            this.progressPanel1.AppearanceCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.progressPanel1.AppearanceCaption.Options.UseFont = true;
            this.progressPanel1.AppearanceDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.progressPanel1.AppearanceDescription.Options.UseFont = true;
            this.progressPanel1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.progressPanel1.Description = "Loading database...";
            this.progressPanel1.Location = new System.Drawing.Point(134, 4);
            this.progressPanel1.Name = "progressPanel1";
            this.progressPanel1.Size = new System.Drawing.Size(184, 75);
            this.progressPanel1.TabIndex = 6;
            this.progressPanel1.Text = "progressPanel1";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(202, 6);
            // 
            // QuickLaunch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(443, 89);
            this.Controls.Add(this.progressPanel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelControl1);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "QuickLaunch";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Quick Launch";
            this.MinimumSizeChanged += new System.EventHandler(this.QuickLaunch_MinimumSizeChanged);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QuickLaunch_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuTrayQuickLaunch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon trayQuickLaunch;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.ContextMenuStrip contextMenuTrayQuickLaunch;
        private System.Windows.Forms.ToolStripMenuItem stasticToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewStaticsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.TextBox textBox1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem scanAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chooseFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem resetAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetUsingHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private DevExpress.XtraWaitForm.ProgressPanel progressPanel1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;

    }
}

