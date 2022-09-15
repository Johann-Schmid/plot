namespace plot
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.plot = new System.Windows.Forms.TabPage();
            this.Threads = new System.Windows.Forms.Button();
            this.startSerial = new System.Windows.Forms.Button();
            this.formsPlot1 = new ScottPlot.FormsPlot();
            this.config = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.serialComboBox = new System.Windows.Forms.ComboBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.plot.SuspendLayout();
            this.config.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // plot
            // 
            this.plot.Controls.Add(this.Threads);
            this.plot.Controls.Add(this.startSerial);
            this.plot.Controls.Add(this.formsPlot1);
            this.plot.Location = new System.Drawing.Point(4, 24);
            this.plot.Name = "plot";
            this.plot.Padding = new System.Windows.Forms.Padding(3);
            this.plot.Size = new System.Drawing.Size(991, 580);
            this.plot.TabIndex = 0;
            this.plot.Text = "Plot";
            this.plot.UseVisualStyleBackColor = true;
            // 
            // Threads
            // 
            this.Threads.Location = new System.Drawing.Point(111, 536);
            this.Threads.Name = "Threads";
            this.Threads.Size = new System.Drawing.Size(75, 23);
            this.Threads.TabIndex = 2;
            this.Threads.Text = "Thread";
            this.Threads.UseVisualStyleBackColor = true;
            this.Threads.Click += new System.EventHandler(this.button1_Click);
            // 
            // startSerial
            // 
            this.startSerial.Location = new System.Drawing.Point(30, 536);
            this.startSerial.Name = "startSerial";
            this.startSerial.Size = new System.Drawing.Size(75, 23);
            this.startSerial.TabIndex = 1;
            this.startSerial.Text = "Start";
            this.startSerial.UseVisualStyleBackColor = true;
            this.startSerial.Click += new System.EventHandler(this.startSerial_Click);
            // 
            // formsPlot1
            // 
            this.formsPlot1.Location = new System.Drawing.Point(0, 0);
            this.formsPlot1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.formsPlot1.Name = "formsPlot1";
            this.formsPlot1.Size = new System.Drawing.Size(991, 530);
            this.formsPlot1.TabIndex = 0;
            // 
            // config
            // 
            this.config.Controls.Add(this.tableLayoutPanel1);
            this.config.Location = new System.Drawing.Point(4, 24);
            this.config.Name = "config";
            this.config.Padding = new System.Windows.Forms.Padding(3);
            this.config.Size = new System.Drawing.Size(991, 580);
            this.config.TabIndex = 1;
            this.config.Text = "Config";
            this.config.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.serialComboBox, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(991, 580);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // serialComboBox
            // 
            this.serialComboBox.FormattingEnabled = true;
            this.serialComboBox.Location = new System.Drawing.Point(3, 3);
            this.serialComboBox.Name = "serialComboBox";
            this.serialComboBox.Size = new System.Drawing.Size(489, 23);
            this.serialComboBox.TabIndex = 0;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.plot);
            this.tabControl.Controls.Add(this.config);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(999, 608);
            this.tabControl.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.textBox1.Location = new System.Drawing.Point(85, 658);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(460, 23);
            this.textBox1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 707);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.plot.ResumeLayout(false);
            this.config.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TabPage plot;
        private ScottPlot.FormsPlot formsPlot1;
        private TabPage config;
        private TabControl tabControl;
        private Button startSerial;
        private TextBox textBox1;
        private Button Threads;
        private TableLayoutPanel tableLayoutPanel1;
        private ComboBox serialComboBox;
    }
}