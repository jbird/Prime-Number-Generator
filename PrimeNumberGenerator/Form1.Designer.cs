namespace PrimeNumberGenerator {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.smallPrimesTabPage = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.primeListTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.resetButton1 = new System.Windows.Forms.Button();
            this.numOfPrimesLabel = new System.Windows.Forms.Label();
            this.generatePrimesButton = new System.Windows.Forms.Button();
            this.numOfPrimesTextBox = new System.Windows.Forms.TextBox();
            this.pseudorandomPrimeTabPage = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.bitLengthComboBox = new System.Windows.Forms.ComboBox();
            this.resetButton2 = new System.Windows.Forms.Button();
            this.bitsLabel = new System.Windows.Forms.Label();
            this.generatePseudoPrimeButton = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.primeTextBox = new System.Windows.Forms.TextBox();
            this.primalityTestTabPage = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.cancelButton2 = new System.Windows.Forms.Button();
            this.isPrimeResultLabel = new System.Windows.Forms.Label();
            this.testPrimeButton = new System.Windows.Forms.Button();
            this.isPrimeLabel = new System.Windows.Forms.Label();
            this.resetButton3 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.isPrimeTextBox = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker3 = new System.ComponentModel.BackgroundWorker();
            this.tabControl1.SuspendLayout();
            this.smallPrimesTabPage.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pseudorandomPrimeTabPage.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.primalityTestTabPage.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.tabControl1.Controls.Add(this.smallPrimesTabPage);
            this.tabControl1.Controls.Add(this.pseudorandomPrimeTabPage);
            this.tabControl1.Controls.Add(this.primalityTestTabPage);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(474, 254);
            this.tabControl1.TabIndex = 4;
            // 
            // smallPrimesTabPage
            // 
            this.smallPrimesTabPage.Controls.Add(this.groupBox2);
            this.smallPrimesTabPage.Controls.Add(this.groupBox1);
            this.smallPrimesTabPage.Location = new System.Drawing.Point(4, 22);
            this.smallPrimesTabPage.Name = "smallPrimesTabPage";
            this.smallPrimesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.smallPrimesTabPage.Size = new System.Drawing.Size(466, 228);
            this.smallPrimesTabPage.TabIndex = 0;
            this.smallPrimesTabPage.Text = "Small Primes";
            this.smallPrimesTabPage.UseVisualStyleBackColor = true;
            this.smallPrimesTabPage.Enter += new System.EventHandler(this.smallPrimesTabPage_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.primeListTextBox);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(448, 150);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Prime Numbers";
            // 
            // primeListTextBox
            // 
            this.primeListTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.primeListTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.primeListTextBox.Enabled = false;
            this.primeListTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.primeListTextBox.Location = new System.Drawing.Point(9, 19);
            this.primeListTextBox.Multiline = true;
            this.primeListTextBox.Name = "primeListTextBox";
            this.primeListTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.primeListTextBox.Size = new System.Drawing.Size(433, 119);
            this.primeListTextBox.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.resetButton1);
            this.groupBox1.Controls.Add(this.numOfPrimesLabel);
            this.groupBox1.Controls.Add(this.generatePrimesButton);
            this.groupBox1.Controls.Add(this.numOfPrimesTextBox);
            this.groupBox1.Location = new System.Drawing.Point(6, 162);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(448, 58);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Generate Prime Number List";
            // 
            // resetButton1
            // 
            this.resetButton1.Enabled = false;
            this.resetButton1.Location = new System.Drawing.Point(357, 20);
            this.resetButton1.Name = "resetButton1";
            this.resetButton1.Size = new System.Drawing.Size(75, 23);
            this.resetButton1.TabIndex = 3;
            this.resetButton1.Text = "Reset";
            this.resetButton1.UseVisualStyleBackColor = true;
            this.resetButton1.Click += new System.EventHandler(this.resetButton1_Click);
            // 
            // numOfPrimesLabel
            // 
            this.numOfPrimesLabel.AutoSize = true;
            this.numOfPrimesLabel.Location = new System.Drawing.Point(6, 27);
            this.numOfPrimesLabel.Name = "numOfPrimesLabel";
            this.numOfPrimesLabel.Size = new System.Drawing.Size(42, 13);
            this.numOfPrimesLabel.TabIndex = 2;
            this.numOfPrimesLabel.Text = "Range:";
            // 
            // generatePrimesButton
            // 
            this.generatePrimesButton.AutoSize = true;
            this.generatePrimesButton.Location = new System.Drawing.Point(216, 20);
            this.generatePrimesButton.Name = "generatePrimesButton";
            this.generatePrimesButton.Size = new System.Drawing.Size(135, 23);
            this.generatePrimesButton.TabIndex = 1;
            this.generatePrimesButton.Text = "Generate Prime Numbers";
            this.generatePrimesButton.UseVisualStyleBackColor = true;
            this.generatePrimesButton.Click += new System.EventHandler(this.generatePrimesButton_Click);
            // 
            // numOfPrimesTextBox
            // 
            this.numOfPrimesTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.numOfPrimesTextBox.Location = new System.Drawing.Point(54, 23);
            this.numOfPrimesTextBox.MaxLength = 7;
            this.numOfPrimesTextBox.Name = "numOfPrimesTextBox";
            this.numOfPrimesTextBox.Size = new System.Drawing.Size(54, 20);
            this.numOfPrimesTextBox.TabIndex = 2;
            this.numOfPrimesTextBox.Text = "200";
            this.numOfPrimesTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numOfPrimesTextBox.TextChanged += new System.EventHandler(this.numOfPrimesTextBox_TextChanged);
            // 
            // pseudorandomPrimeTabPage
            // 
            this.pseudorandomPrimeTabPage.Controls.Add(this.groupBox5);
            this.pseudorandomPrimeTabPage.Controls.Add(this.groupBox4);
            this.pseudorandomPrimeTabPage.Location = new System.Drawing.Point(4, 22);
            this.pseudorandomPrimeTabPage.Name = "pseudorandomPrimeTabPage";
            this.pseudorandomPrimeTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.pseudorandomPrimeTabPage.Size = new System.Drawing.Size(466, 228);
            this.pseudorandomPrimeTabPage.TabIndex = 1;
            this.pseudorandomPrimeTabPage.Text = "Large Pseudorandom Prime";
            this.pseudorandomPrimeTabPage.UseVisualStyleBackColor = true;
            this.pseudorandomPrimeTabPage.Enter += new System.EventHandler(this.pseudorandomPrimeTabPage_Enter);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cancelButton);
            this.groupBox5.Controls.Add(this.bitLengthComboBox);
            this.groupBox5.Controls.Add(this.resetButton2);
            this.groupBox5.Controls.Add(this.bitsLabel);
            this.groupBox5.Controls.Add(this.generatePseudoPrimeButton);
            this.groupBox5.Location = new System.Drawing.Point(6, 162);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(454, 56);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Generate Large Pseudorandom Prime";
            // 
            // cancelButton
            // 
            this.cancelButton.Enabled = false;
            this.cancelButton.Location = new System.Drawing.Point(285, 19);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // bitLengthComboBox
            // 
            this.bitLengthComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bitLengthComboBox.FormattingEnabled = true;
            this.bitLengthComboBox.Items.AddRange(new object[] {
            "32",
            "64",
            "128",
            "256",
            "512",
            "1024",
            "2048"});
            this.bitLengthComboBox.Location = new System.Drawing.Point(9, 22);
            this.bitLengthComboBox.MaxLength = 4;
            this.bitLengthComboBox.Name = "bitLengthComboBox";
            this.bitLengthComboBox.Size = new System.Drawing.Size(56, 21);
            this.bitLengthComboBox.TabIndex = 6;
            // 
            // resetButton2
            // 
            this.resetButton2.Enabled = false;
            this.resetButton2.Location = new System.Drawing.Point(366, 19);
            this.resetButton2.Name = "resetButton2";
            this.resetButton2.Size = new System.Drawing.Size(75, 23);
            this.resetButton2.TabIndex = 8;
            this.resetButton2.Text = "Reset";
            this.resetButton2.UseVisualStyleBackColor = true;
            this.resetButton2.Click += new System.EventHandler(this.resetButton2_Click);
            // 
            // bitsLabel
            // 
            this.bitsLabel.AutoSize = true;
            this.bitsLabel.Location = new System.Drawing.Point(67, 26);
            this.bitsLabel.Name = "bitsLabel";
            this.bitsLabel.Size = new System.Drawing.Size(24, 13);
            this.bitsLabel.TabIndex = 10;
            this.bitsLabel.Text = "Bits";
            // 
            // generatePseudoPrimeButton
            // 
            this.generatePseudoPrimeButton.AutoSize = true;
            this.generatePseudoPrimeButton.Location = new System.Drawing.Point(115, 19);
            this.generatePseudoPrimeButton.Name = "generatePseudoPrimeButton";
            this.generatePseudoPrimeButton.Size = new System.Drawing.Size(164, 23);
            this.generatePseudoPrimeButton.TabIndex = 5;
            this.generatePseudoPrimeButton.Text = "Generate Pseudorandom Prime";
            this.generatePseudoPrimeButton.UseVisualStyleBackColor = true;
            this.generatePseudoPrimeButton.Click += new System.EventHandler(this.generatePseudoPrimeButton_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.primeTextBox);
            this.groupBox4.Location = new System.Drawing.Point(6, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(448, 150);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Prime Number";
            // 
            // primeTextBox
            // 
            this.primeTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.primeTextBox.Enabled = false;
            this.primeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.primeTextBox.Location = new System.Drawing.Point(9, 19);
            this.primeTextBox.Multiline = true;
            this.primeTextBox.Name = "primeTextBox";
            this.primeTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.primeTextBox.Size = new System.Drawing.Size(432, 120);
            this.primeTextBox.TabIndex = 9;
            // 
            // primalityTestTabPage
            // 
            this.primalityTestTabPage.Controls.Add(this.groupBox6);
            this.primalityTestTabPage.Controls.Add(this.groupBox3);
            this.primalityTestTabPage.Location = new System.Drawing.Point(4, 22);
            this.primalityTestTabPage.Name = "primalityTestTabPage";
            this.primalityTestTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.primalityTestTabPage.Size = new System.Drawing.Size(466, 228);
            this.primalityTestTabPage.TabIndex = 2;
            this.primalityTestTabPage.Text = "Primality Test";
            this.primalityTestTabPage.UseVisualStyleBackColor = true;
            this.primalityTestTabPage.Enter += new System.EventHandler(this.primalityTestTabPage_Enter);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.cancelButton2);
            this.groupBox6.Controls.Add(this.isPrimeResultLabel);
            this.groupBox6.Controls.Add(this.testPrimeButton);
            this.groupBox6.Controls.Add(this.isPrimeLabel);
            this.groupBox6.Controls.Add(this.resetButton3);
            this.groupBox6.Location = new System.Drawing.Point(6, 72);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(454, 53);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Test for Primality";
            // 
            // cancelButton2
            // 
            this.cancelButton2.Enabled = false;
            this.cancelButton2.Location = new System.Drawing.Point(282, 19);
            this.cancelButton2.Name = "cancelButton2";
            this.cancelButton2.Size = new System.Drawing.Size(75, 23);
            this.cancelButton2.TabIndex = 5;
            this.cancelButton2.Text = "Cancel";
            this.cancelButton2.UseVisualStyleBackColor = true;
            this.cancelButton2.Click += new System.EventHandler(this.cancelButton2_Click);
            // 
            // isPrimeResultLabel
            // 
            this.isPrimeResultLabel.AutoSize = true;
            this.isPrimeResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isPrimeResultLabel.Location = new System.Drawing.Point(74, 24);
            this.isPrimeResultLabel.Name = "isPrimeResultLabel";
            this.isPrimeResultLabel.Size = new System.Drawing.Size(19, 13);
            this.isPrimeResultLabel.TabIndex = 4;
            this.isPrimeResultLabel.Text = "    ";
            // 
            // testPrimeButton
            // 
            this.testPrimeButton.AutoSize = true;
            this.testPrimeButton.Location = new System.Drawing.Point(196, 19);
            this.testPrimeButton.Name = "testPrimeButton";
            this.testPrimeButton.Size = new System.Drawing.Size(80, 23);
            this.testPrimeButton.TabIndex = 1;
            this.testPrimeButton.Text = "Test";
            this.testPrimeButton.UseVisualStyleBackColor = true;
            this.testPrimeButton.Click += new System.EventHandler(this.testPrimeButton_Click);
            // 
            // isPrimeLabel
            // 
            this.isPrimeLabel.AutoSize = true;
            this.isPrimeLabel.Location = new System.Drawing.Point(18, 24);
            this.isPrimeLabel.Name = "isPrimeLabel";
            this.isPrimeLabel.Size = new System.Drawing.Size(50, 13);
            this.isPrimeLabel.TabIndex = 3;
            this.isPrimeLabel.Text = "Is Prime?";
            // 
            // resetButton3
            // 
            this.resetButton3.Enabled = false;
            this.resetButton3.Location = new System.Drawing.Point(363, 19);
            this.resetButton3.Name = "resetButton3";
            this.resetButton3.Size = new System.Drawing.Size(76, 23);
            this.resetButton3.TabIndex = 2;
            this.resetButton3.Text = "Reset";
            this.resetButton3.UseVisualStyleBackColor = true;
            this.resetButton3.Click += new System.EventHandler(this.resetButton3_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.isPrimeTextBox);
            this.groupBox3.Location = new System.Drawing.Point(6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(454, 60);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Input";
            // 
            // isPrimeTextBox
            // 
            this.isPrimeTextBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.isPrimeTextBox.Location = new System.Drawing.Point(6, 22);
            this.isPrimeTextBox.MaxLength = 100;
            this.isPrimeTextBox.Name = "isPrimeTextBox";
            this.isPrimeTextBox.Size = new System.Drawing.Size(433, 20);
            this.isPrimeTextBox.TabIndex = 1;
            this.isPrimeTextBox.Text = " e.g 331163628450422933897854183047337139561";
            this.isPrimeTextBox.TextChanged += new System.EventHandler(this.isPrimeTextBox_TextChanged);
            this.isPrimeTextBox.Enter += new System.EventHandler(this.isPrimeTextBox_Enter);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Transparent;
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(12, 267);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(17, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.WorkerSupportsCancellation = true;
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            this.backgroundWorker2.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker2_RunWorkerCompleted);
            // 
            // backgroundWorker3
            // 
            this.backgroundWorker3.WorkerSupportsCancellation = true;
            this.backgroundWorker3.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker3_DoWork);
            this.backgroundWorker3.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker3_RunWorkerCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(498, 291);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Prime Number Generator Utility";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.smallPrimesTabPage.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pseudorandomPrimeTabPage.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.primalityTestTabPage.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage smallPrimesTabPage;
        private System.Windows.Forms.Button resetButton1;
        private System.Windows.Forms.Button generatePrimesButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox numOfPrimesTextBox;
        private System.Windows.Forms.TabPage pseudorandomPrimeTabPage;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox primeTextBox;
        private System.Windows.Forms.Button resetButton2;
        private System.Windows.Forms.Button generatePseudoPrimeButton;
        private System.Windows.Forms.Label numOfPrimesLabel;
        private System.Windows.Forms.TabPage primalityTestTabPage;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox primeListTextBox;
        private System.Windows.Forms.Label bitsLabel;
        private System.Windows.Forms.ComboBox bitLengthComboBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox isPrimeTextBox;
        private System.Windows.Forms.Button testPrimeButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button cancelButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button resetButton3;
        private System.Windows.Forms.Label isPrimeResultLabel;
        private System.Windows.Forms.Label isPrimeLabel;
        private System.Windows.Forms.Button cancelButton2;
        private System.ComponentModel.BackgroundWorker backgroundWorker3;

    }
}

