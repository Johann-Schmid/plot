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
            this.debugTextbox = new System.Windows.Forms.TextBox();
            this.formsPlot1 = new ScottPlot.FormsPlot();
            this.config = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.serialComboBox = new System.Windows.Forms.ComboBox();
            this.startSerial = new System.Windows.Forms.Button();
            this.Simulate = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.button1 = new System.Windows.Forms.Button();
            this.plot.SuspendLayout();
            this.config.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // plot
            // 
            this.plot.Controls.Add(this.debugTextbox);
            this.plot.Controls.Add(this.formsPlot1);
            this.plot.Location = new System.Drawing.Point(4, 29);
            this.plot.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.plot.Name = "plot";
            this.plot.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.plot.Size = new System.Drawing.Size(1161, 910);
            this.plot.TabIndex = 0;
            this.plot.Text = "Plot";
            this.plot.UseVisualStyleBackColor = true;
            // 
            // debugTextbox
            // 
            this.debugTextbox.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.debugTextbox.Location = new System.Drawing.Point(634, 0);
            this.debugTextbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.debugTextbox.Name = "debugTextbox";
            this.debugTextbox.Size = new System.Drawing.Size(525, 27);
            this.debugTextbox.TabIndex = 2;
            // 
            // formsPlot1
            // 
            this.formsPlot1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formsPlot1.Location = new System.Drawing.Point(3, 4);
            this.formsPlot1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.formsPlot1.Name = "formsPlot1";
            this.formsPlot1.Size = new System.Drawing.Size(1155, 902);
            this.formsPlot1.TabIndex = 0;
            // 
            // config
            // 
            this.config.Controls.Add(this.tableLayoutPanel1);
            this.config.Location = new System.Drawing.Point(4, 29);
            this.config.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.config.Name = "config";
            this.config.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.config.Size = new System.Drawing.Size(1161, 910);
            this.config.TabIndex = 1;
            this.config.Text = "Config";
            this.config.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.serialComboBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.startSerial, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.Simulate, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1133, 773);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // serialComboBox
            // 
            this.serialComboBox.FormattingEnabled = true;
            this.serialComboBox.Location = new System.Drawing.Point(3, 4);
            this.serialComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.serialComboBox.Name = "serialComboBox";
            this.serialComboBox.Size = new System.Drawing.Size(85, 28);
            this.serialComboBox.TabIndex = 0;
            // 
            // startSerial
            // 
            this.startSerial.Location = new System.Drawing.Point(3, 40);
            this.startSerial.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.startSerial.Name = "startSerial";
            this.startSerial.Size = new System.Drawing.Size(86, 31);
            this.startSerial.TabIndex = 3;
            this.startSerial.Text = "Start";
            this.startSerial.UseVisualStyleBackColor = true;
            this.startSerial.Click += new System.EventHandler(this.startSerial_Click);
            // 
            // Simulate
            // 
            this.Simulate.Location = new System.Drawing.Point(95, 40);
            this.Simulate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Simulate.Name = "Simulate";
            this.Simulate.Size = new System.Drawing.Size(86, 31);
            this.Simulate.TabIndex = 4;
            this.Simulate.Text = "Simulate";
            this.Simulate.UseVisualStyleBackColor = true;
            this.Simulate.Click += new System.EventHandler(this.simulateData_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.plot);
            this.tabControl.Controls.Add(this.config);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1169, 943);
            this.tabControl.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 79);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 31);
            this.button1.TabIndex = 5;
            this.button1.Text = "Thread";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 943);
            this.Controls.Add(this.tabControl);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.plot.ResumeLayout(false);
            this.plot.PerformLayout();
            this.config.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabPage plot;
        private ScottPlot.FormsPlot formsPlot1;
        private TabPage config;
        private TabControl tabControl;
        private TextBox debugTextbox;
        private TableLayoutPanel tableLayoutPanel1;
        private ComboBox serialComboBox;
        private Button startSerial;
        private Button Simulate;
        private Button button1;
    }
}