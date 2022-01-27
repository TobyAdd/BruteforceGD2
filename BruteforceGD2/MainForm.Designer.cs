namespace BruteforceGD2
{
    partial class MainForm
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
            this.Caption = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.gbProxyImport = new System.Windows.Forms.GroupBox();
            this.tbProxyListPath = new System.Windows.Forms.TextBox();
            this.btnImportProxyList = new System.Windows.Forms.Button();
            this.btnHelpProxyList = new System.Windows.Forms.Button();
            this.btnBrowseProxyList = new System.Windows.Forms.Button();
            this.lblDescProxyPath = new System.Windows.Forms.Label();
            this.gbProxyManagement = new System.Windows.Forms.GroupBox();
            this.btnProxyShuffle = new System.Windows.Forms.Button();
            this.btnAddProxyManually = new System.Windows.Forms.Button();
            this.tbProxyUrl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClearProxyList = new System.Windows.Forms.Button();
            this.lbProxyView = new System.Windows.Forms.ListBox();
            this.gbActions = new System.Windows.Forms.GroupBox();
            this.btnGeneratorAttack = new System.Windows.Forms.Button();
            this.btnAttackDictionary = new System.Windows.Forms.Button();
            this.gbTarget = new System.Windows.Forms.GroupBox();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.lblDescUsername = new System.Windows.Forms.Label();
            this.gbWordlist = new System.Windows.Forms.GroupBox();
            this.tbWordlist = new System.Windows.Forms.TextBox();
            this.btnHelpWordlist = new System.Windows.Forms.Button();
            this.btnBrowseWordlist = new System.Windows.Forms.Button();
            this.lblDescWordlist = new System.Windows.Forms.Label();
            this.gbGenerator = new System.Windows.Forms.GroupBox();
            this.nudLimit = new System.Windows.Forms.NumericUpDown();
            this.tbCharset = new System.Windows.Forms.TextBox();
            this.btnHelpGenerator = new System.Windows.Forms.Button();
            this.lblDescCharset = new System.Windows.Forms.Label();
            this.lblDescLimitLength = new System.Windows.Forms.Label();
            this.nudStart = new System.Windows.Forms.NumericUpDown();
            this.lblDescStartLength = new System.Windows.Forms.Label();
            this.gbProxyImport.SuspendLayout();
            this.gbProxyManagement.SuspendLayout();
            this.gbActions.SuspendLayout();
            this.gbTarget.SuspendLayout();
            this.gbWordlist.SuspendLayout();
            this.gbGenerator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStart)).BeginInit();
            this.SuspendLayout();
            // 
            // Caption
            // 
            this.Caption.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Caption.BackColor = System.Drawing.Color.DimGray;
            this.Caption.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Caption.ForeColor = System.Drawing.Color.White;
            this.Caption.Location = new System.Drawing.Point(0, 0);
            this.Caption.Name = "Caption";
            this.Caption.Size = new System.Drawing.Size(779, 23);
            this.Caption.TabIndex = 0;
            this.Caption.Text = "BruteforceGD2";
            this.Caption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Caption.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Caption_MouseDown);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.DimGray;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(752, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.BackColor = System.Drawing.Color.DimGray;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.ForeColor = System.Drawing.Color.White;
            this.btnMin.Location = new System.Drawing.Point(726, 0);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(25, 23);
            this.btnMin.TabIndex = 2;
            this.btnMin.Text = "-";
            this.btnMin.UseVisualStyleBackColor = false;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // gbProxyImport
            // 
            this.gbProxyImport.Controls.Add(this.tbProxyListPath);
            this.gbProxyImport.Controls.Add(this.btnImportProxyList);
            this.gbProxyImport.Controls.Add(this.btnHelpProxyList);
            this.gbProxyImport.Controls.Add(this.btnBrowseProxyList);
            this.gbProxyImport.Controls.Add(this.lblDescProxyPath);
            this.gbProxyImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbProxyImport.ForeColor = System.Drawing.Color.White;
            this.gbProxyImport.Location = new System.Drawing.Point(286, 283);
            this.gbProxyImport.Name = "gbProxyImport";
            this.gbProxyImport.Size = new System.Drawing.Size(482, 59);
            this.gbProxyImport.TabIndex = 24;
            this.gbProxyImport.TabStop = false;
            this.gbProxyImport.Text = "Proxy import";
            // 
            // tbProxyListPath
            // 
            this.tbProxyListPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbProxyListPath.Enabled = false;
            this.tbProxyListPath.ForeColor = System.Drawing.Color.White;
            this.tbProxyListPath.Location = new System.Drawing.Point(6, 32);
            this.tbProxyListPath.Name = "tbProxyListPath";
            this.tbProxyListPath.Size = new System.Drawing.Size(238, 20);
            this.tbProxyListPath.TabIndex = 17;
            // 
            // btnImportProxyList
            // 
            this.btnImportProxyList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImportProxyList.Location = new System.Drawing.Point(351, 30);
            this.btnImportProxyList.Name = "btnImportProxyList";
            this.btnImportProxyList.Size = new System.Drawing.Size(125, 23);
            this.btnImportProxyList.TabIndex = 20;
            this.btnImportProxyList.Text = "Load";
            this.btnImportProxyList.UseVisualStyleBackColor = true;
            this.btnImportProxyList.Click += new System.EventHandler(this.btnImportProxyList_Click);
            // 
            // btnHelpProxyList
            // 
            this.btnHelpProxyList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelpProxyList.Location = new System.Drawing.Point(322, 30);
            this.btnHelpProxyList.Name = "btnHelpProxyList";
            this.btnHelpProxyList.Size = new System.Drawing.Size(23, 23);
            this.btnHelpProxyList.TabIndex = 19;
            this.btnHelpProxyList.Text = "?";
            this.btnHelpProxyList.UseVisualStyleBackColor = true;
            this.btnHelpProxyList.Click += new System.EventHandler(this.btnHelpProxyList_Click);
            // 
            // btnBrowseProxyList
            // 
            this.btnBrowseProxyList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowseProxyList.Location = new System.Drawing.Point(250, 30);
            this.btnBrowseProxyList.Name = "btnBrowseProxyList";
            this.btnBrowseProxyList.Size = new System.Drawing.Size(66, 23);
            this.btnBrowseProxyList.TabIndex = 17;
            this.btnBrowseProxyList.Text = "Browse";
            this.btnBrowseProxyList.UseVisualStyleBackColor = true;
            this.btnBrowseProxyList.Click += new System.EventHandler(this.btnBrowseProxyList_Click);
            // 
            // lblDescProxyPath
            // 
            this.lblDescProxyPath.AutoSize = true;
            this.lblDescProxyPath.Location = new System.Drawing.Point(6, 16);
            this.lblDescProxyPath.Name = "lblDescProxyPath";
            this.lblDescProxyPath.Size = new System.Drawing.Size(75, 13);
            this.lblDescProxyPath.TabIndex = 18;
            this.lblDescProxyPath.Text = "Proxy list path:";
            // 
            // gbProxyManagement
            // 
            this.gbProxyManagement.Controls.Add(this.btnProxyShuffle);
            this.gbProxyManagement.Controls.Add(this.btnAddProxyManually);
            this.gbProxyManagement.Controls.Add(this.tbProxyUrl);
            this.gbProxyManagement.Controls.Add(this.label1);
            this.gbProxyManagement.Controls.Add(this.btnClearProxyList);
            this.gbProxyManagement.Controls.Add(this.lbProxyView);
            this.gbProxyManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbProxyManagement.ForeColor = System.Drawing.Color.White;
            this.gbProxyManagement.Location = new System.Drawing.Point(286, 26);
            this.gbProxyManagement.Name = "gbProxyManagement";
            this.gbProxyManagement.Size = new System.Drawing.Size(482, 251);
            this.gbProxyManagement.TabIndex = 23;
            this.gbProxyManagement.TabStop = false;
            this.gbProxyManagement.Text = "Proxy management";
            // 
            // btnProxyShuffle
            // 
            this.btnProxyShuffle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProxyShuffle.Location = new System.Drawing.Point(308, 222);
            this.btnProxyShuffle.Name = "btnProxyShuffle";
            this.btnProxyShuffle.Size = new System.Drawing.Size(81, 23);
            this.btnProxyShuffle.TabIndex = 25;
            this.btnProxyShuffle.Text = "Shuffle";
            this.btnProxyShuffle.UseVisualStyleBackColor = true;
            this.btnProxyShuffle.Click += new System.EventHandler(this.btnProxyShuffle_Click);
            // 
            // btnAddProxyManually
            // 
            this.btnAddProxyManually.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProxyManually.Location = new System.Drawing.Point(332, 15);
            this.btnAddProxyManually.Name = "btnAddProxyManually";
            this.btnAddProxyManually.Size = new System.Drawing.Size(51, 23);
            this.btnAddProxyManually.TabIndex = 24;
            this.btnAddProxyManually.Text = "Add";
            this.btnAddProxyManually.UseVisualStyleBackColor = true;
            this.btnAddProxyManually.Click += new System.EventHandler(this.btnAddProxyManually_Click);
            // 
            // tbProxyUrl
            // 
            this.tbProxyUrl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbProxyUrl.ForeColor = System.Drawing.Color.White;
            this.tbProxyUrl.Location = new System.Drawing.Point(73, 17);
            this.tbProxyUrl.Name = "tbProxyUrl";
            this.tbProxyUrl.Size = new System.Drawing.Size(253, 20);
            this.tbProxyUrl.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Proxy URL:";
            // 
            // btnClearProxyList
            // 
            this.btnClearProxyList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearProxyList.Location = new System.Drawing.Point(395, 222);
            this.btnClearProxyList.Name = "btnClearProxyList";
            this.btnClearProxyList.Size = new System.Drawing.Size(81, 23);
            this.btnClearProxyList.TabIndex = 21;
            this.btnClearProxyList.Text = "Clear";
            this.btnClearProxyList.UseVisualStyleBackColor = true;
            this.btnClearProxyList.Click += new System.EventHandler(this.btnClearProxyList_Click);
            // 
            // lbProxyView
            // 
            this.lbProxyView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbProxyView.ForeColor = System.Drawing.Color.White;
            this.lbProxyView.FormattingEnabled = true;
            this.lbProxyView.Location = new System.Drawing.Point(6, 43);
            this.lbProxyView.Name = "lbProxyView";
            this.lbProxyView.Size = new System.Drawing.Size(470, 173);
            this.lbProxyView.TabIndex = 0;
            // 
            // gbActions
            // 
            this.gbActions.Controls.Add(this.btnGeneratorAttack);
            this.gbActions.Controls.Add(this.btnAttackDictionary);
            this.gbActions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbActions.ForeColor = System.Drawing.Color.White;
            this.gbActions.Location = new System.Drawing.Point(12, 293);
            this.gbActions.Name = "gbActions";
            this.gbActions.Size = new System.Drawing.Size(265, 49);
            this.gbActions.TabIndex = 22;
            this.gbActions.TabStop = false;
            this.gbActions.Text = "Actions";
            // 
            // btnGeneratorAttack
            // 
            this.btnGeneratorAttack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeneratorAttack.Location = new System.Drawing.Point(134, 19);
            this.btnGeneratorAttack.Name = "btnGeneratorAttack";
            this.btnGeneratorAttack.Size = new System.Drawing.Size(125, 24);
            this.btnGeneratorAttack.TabIndex = 1;
            this.btnGeneratorAttack.Text = "Generator Attack";
            this.btnGeneratorAttack.UseVisualStyleBackColor = true;
            this.btnGeneratorAttack.Click += new System.EventHandler(this.btnGeneratorAttack_Click);
            // 
            // btnAttackDictionary
            // 
            this.btnAttackDictionary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAttackDictionary.Location = new System.Drawing.Point(6, 19);
            this.btnAttackDictionary.Name = "btnAttackDictionary";
            this.btnAttackDictionary.Size = new System.Drawing.Size(125, 23);
            this.btnAttackDictionary.TabIndex = 0;
            this.btnAttackDictionary.Text = "Dictionary Attack";
            this.btnAttackDictionary.UseVisualStyleBackColor = true;
            this.btnAttackDictionary.Click += new System.EventHandler(this.btnAttackDictionary_Click);
            // 
            // gbTarget
            // 
            this.gbTarget.Controls.Add(this.tbUsername);
            this.gbTarget.Controls.Add(this.lblDescUsername);
            this.gbTarget.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbTarget.ForeColor = System.Drawing.Color.White;
            this.gbTarget.Location = new System.Drawing.Point(12, 228);
            this.gbTarget.Name = "gbTarget";
            this.gbTarget.Size = new System.Drawing.Size(265, 59);
            this.gbTarget.TabIndex = 21;
            this.gbTarget.TabStop = false;
            this.gbTarget.Text = "Target";
            // 
            // tbUsername
            // 
            this.tbUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbUsername.ForeColor = System.Drawing.Color.White;
            this.tbUsername.Location = new System.Drawing.Point(6, 32);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(253, 20);
            this.tbUsername.TabIndex = 5;
            // 
            // lblDescUsername
            // 
            this.lblDescUsername.AutoSize = true;
            this.lblDescUsername.Location = new System.Drawing.Point(6, 16);
            this.lblDescUsername.Name = "lblDescUsername";
            this.lblDescUsername.Size = new System.Drawing.Size(90, 13);
            this.lblDescUsername.TabIndex = 6;
            this.lblDescUsername.Text = "Target username:";
            // 
            // gbWordlist
            // 
            this.gbWordlist.Controls.Add(this.tbWordlist);
            this.gbWordlist.Controls.Add(this.btnHelpWordlist);
            this.gbWordlist.Controls.Add(this.btnBrowseWordlist);
            this.gbWordlist.Controls.Add(this.lblDescWordlist);
            this.gbWordlist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbWordlist.ForeColor = System.Drawing.Color.White;
            this.gbWordlist.Location = new System.Drawing.Point(12, 132);
            this.gbWordlist.Name = "gbWordlist";
            this.gbWordlist.Size = new System.Drawing.Size(265, 90);
            this.gbWordlist.TabIndex = 20;
            this.gbWordlist.TabStop = false;
            this.gbWordlist.Text = "Wordlist";
            // 
            // tbWordlist
            // 
            this.tbWordlist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbWordlist.Enabled = false;
            this.tbWordlist.ForeColor = System.Drawing.Color.White;
            this.tbWordlist.Location = new System.Drawing.Point(6, 34);
            this.tbWordlist.Name = "tbWordlist";
            this.tbWordlist.Size = new System.Drawing.Size(253, 20);
            this.tbWordlist.TabIndex = 9;
            // 
            // btnHelpWordlist
            // 
            this.btnHelpWordlist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelpWordlist.Location = new System.Drawing.Point(236, 61);
            this.btnHelpWordlist.Name = "btnHelpWordlist";
            this.btnHelpWordlist.Size = new System.Drawing.Size(23, 23);
            this.btnHelpWordlist.TabIndex = 16;
            this.btnHelpWordlist.Text = "?";
            this.btnHelpWordlist.UseVisualStyleBackColor = true;
            this.btnHelpWordlist.Click += new System.EventHandler(this.btnHelpWordlist_Click);
            // 
            // btnBrowseWordlist
            // 
            this.btnBrowseWordlist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowseWordlist.Location = new System.Drawing.Point(155, 61);
            this.btnBrowseWordlist.Name = "btnBrowseWordlist";
            this.btnBrowseWordlist.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseWordlist.TabIndex = 15;
            this.btnBrowseWordlist.Text = "Browse";
            this.btnBrowseWordlist.UseVisualStyleBackColor = true;
            this.btnBrowseWordlist.Click += new System.EventHandler(this.btnBrowseWordlist_Click);
            // 
            // lblDescWordlist
            // 
            this.lblDescWordlist.AutoSize = true;
            this.lblDescWordlist.Location = new System.Drawing.Point(6, 18);
            this.lblDescWordlist.Name = "lblDescWordlist";
            this.lblDescWordlist.Size = new System.Drawing.Size(72, 13);
            this.lblDescWordlist.TabIndex = 10;
            this.lblDescWordlist.Text = "Wordlist path:";
            // 
            // gbGenerator
            // 
            this.gbGenerator.Controls.Add(this.nudLimit);
            this.gbGenerator.Controls.Add(this.tbCharset);
            this.gbGenerator.Controls.Add(this.btnHelpGenerator);
            this.gbGenerator.Controls.Add(this.lblDescCharset);
            this.gbGenerator.Controls.Add(this.lblDescLimitLength);
            this.gbGenerator.Controls.Add(this.nudStart);
            this.gbGenerator.Controls.Add(this.lblDescStartLength);
            this.gbGenerator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbGenerator.ForeColor = System.Drawing.Color.White;
            this.gbGenerator.Location = new System.Drawing.Point(12, 26);
            this.gbGenerator.Name = "gbGenerator";
            this.gbGenerator.Size = new System.Drawing.Size(265, 100);
            this.gbGenerator.TabIndex = 19;
            this.gbGenerator.TabStop = false;
            this.gbGenerator.Text = "Generator";
            // 
            // nudLimit
            // 
            this.nudLimit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nudLimit.ForeColor = System.Drawing.Color.White;
            this.nudLimit.Location = new System.Drawing.Point(109, 71);
            this.nudLimit.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.nudLimit.Name = "nudLimit";
            this.nudLimit.Size = new System.Drawing.Size(97, 20);
            this.nudLimit.TabIndex = 11;
            this.nudLimit.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // tbCharset
            // 
            this.tbCharset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbCharset.ForeColor = System.Drawing.Color.White;
            this.tbCharset.Location = new System.Drawing.Point(6, 32);
            this.tbCharset.Name = "tbCharset";
            this.tbCharset.Size = new System.Drawing.Size(253, 20);
            this.tbCharset.TabIndex = 7;
            // 
            // btnHelpGenerator
            // 
            this.btnHelpGenerator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelpGenerator.Location = new System.Drawing.Point(236, 68);
            this.btnHelpGenerator.Name = "btnHelpGenerator";
            this.btnHelpGenerator.Size = new System.Drawing.Size(23, 23);
            this.btnHelpGenerator.TabIndex = 16;
            this.btnHelpGenerator.Text = "?";
            this.btnHelpGenerator.UseVisualStyleBackColor = true;
            this.btnHelpGenerator.Click += new System.EventHandler(this.btnHelpGenerator_Click);
            // 
            // lblDescCharset
            // 
            this.lblDescCharset.AutoSize = true;
            this.lblDescCharset.Location = new System.Drawing.Point(6, 16);
            this.lblDescCharset.Name = "lblDescCharset";
            this.lblDescCharset.Size = new System.Drawing.Size(73, 13);
            this.lblDescCharset.TabIndex = 8;
            this.lblDescCharset.Text = "Character set:";
            // 
            // lblDescLimitLength
            // 
            this.lblDescLimitLength.AutoSize = true;
            this.lblDescLimitLength.Location = new System.Drawing.Point(106, 55);
            this.lblDescLimitLength.Name = "lblDescLimitLength";
            this.lblDescLimitLength.Size = new System.Drawing.Size(63, 13);
            this.lblDescLimitLength.TabIndex = 12;
            this.lblDescLimitLength.Text = "Limit length:";
            // 
            // nudStart
            // 
            this.nudStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nudStart.ForeColor = System.Drawing.Color.White;
            this.nudStart.Location = new System.Drawing.Point(6, 71);
            this.nudStart.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.nudStart.Name = "nudStart";
            this.nudStart.Size = new System.Drawing.Size(97, 20);
            this.nudStart.TabIndex = 9;
            this.nudStart.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // lblDescStartLength
            // 
            this.lblDescStartLength.AutoSize = true;
            this.lblDescStartLength.Location = new System.Drawing.Point(3, 55);
            this.lblDescStartLength.Name = "lblDescStartLength";
            this.lblDescStartLength.Size = new System.Drawing.Size(64, 13);
            this.lblDescStartLength.TabIndex = 10;
            this.lblDescStartLength.Text = "Start length:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(777, 354);
            this.Controls.Add(this.gbProxyImport);
            this.Controls.Add(this.gbProxyManagement);
            this.Controls.Add(this.gbActions);
            this.Controls.Add(this.gbTarget);
            this.Controls.Add(this.gbWordlist);
            this.Controls.Add(this.gbGenerator);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.Caption);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BruteforceGD2";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.gbProxyImport.ResumeLayout(false);
            this.gbProxyImport.PerformLayout();
            this.gbProxyManagement.ResumeLayout(false);
            this.gbProxyManagement.PerformLayout();
            this.gbActions.ResumeLayout(false);
            this.gbTarget.ResumeLayout(false);
            this.gbTarget.PerformLayout();
            this.gbWordlist.ResumeLayout(false);
            this.gbWordlist.PerformLayout();
            this.gbGenerator.ResumeLayout(false);
            this.gbGenerator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Caption;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.GroupBox gbProxyImport;
        private System.Windows.Forms.TextBox tbProxyListPath;
        private System.Windows.Forms.Button btnImportProxyList;
        private System.Windows.Forms.Button btnHelpProxyList;
        private System.Windows.Forms.Button btnBrowseProxyList;
        private System.Windows.Forms.Label lblDescProxyPath;
        private System.Windows.Forms.GroupBox gbProxyManagement;
        private System.Windows.Forms.Button btnProxyShuffle;
        private System.Windows.Forms.Button btnAddProxyManually;
        private System.Windows.Forms.TextBox tbProxyUrl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClearProxyList;
        private System.Windows.Forms.ListBox lbProxyView;
        private System.Windows.Forms.GroupBox gbActions;
        private System.Windows.Forms.Button btnGeneratorAttack;
        private System.Windows.Forms.Button btnAttackDictionary;
        private System.Windows.Forms.GroupBox gbTarget;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Label lblDescUsername;
        private System.Windows.Forms.GroupBox gbWordlist;
        private System.Windows.Forms.TextBox tbWordlist;
        private System.Windows.Forms.Button btnHelpWordlist;
        private System.Windows.Forms.Button btnBrowseWordlist;
        private System.Windows.Forms.Label lblDescWordlist;
        private System.Windows.Forms.GroupBox gbGenerator;
        private System.Windows.Forms.NumericUpDown nudLimit;
        private System.Windows.Forms.TextBox tbCharset;
        private System.Windows.Forms.Button btnHelpGenerator;
        private System.Windows.Forms.Label lblDescCharset;
        private System.Windows.Forms.Label lblDescLimitLength;
        private System.Windows.Forms.NumericUpDown nudStart;
        private System.Windows.Forms.Label lblDescStartLength;
    }
}

