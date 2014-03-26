namespace delta
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.buttonReadInt = new System.Windows.Forms.Button();
            this.buttonWriteInt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.WAddressEdit = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.WValueEdit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonReadFl = new System.Windows.Forms.Button();
            this.RAddressEdit = new System.Windows.Forms.TextBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timerGraphUpdate = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comPortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.configureComPortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.TTaskEdit = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.KpFEdit = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.KiFEdit = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonReadInt
            // 
            this.buttonReadInt.Location = new System.Drawing.Point(19, 131);
            this.buttonReadInt.Name = "buttonReadInt";
            this.buttonReadInt.Size = new System.Drawing.Size(96, 23);
            this.buttonReadInt.TabIndex = 0;
            this.buttonReadInt.Text = "Read int";
            this.buttonReadInt.UseVisualStyleBackColor = true;
            this.buttonReadInt.Click += new System.EventHandler(this.ButtonReadIntAddresClick);
            // 
            // buttonWriteInt
            // 
            this.buttonWriteInt.Location = new System.Drawing.Point(23, 131);
            this.buttonWriteInt.Name = "buttonWriteInt";
            this.buttonWriteInt.Size = new System.Drawing.Size(96, 23);
            this.buttonWriteInt.TabIndex = 2;
            this.buttonWriteInt.Text = "Write int";
            this.buttonWriteInt.UseVisualStyleBackColor = true;
            this.buttonWriteInt.Click += new System.EventHandler(this.ButtonWriteIntClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(19, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "t";
            // 
            // WAddressEdit
            // 
            this.WAddressEdit.Location = new System.Drawing.Point(23, 89);
            this.WAddressEdit.Name = "WAddressEdit";
            this.WAddressEdit.Size = new System.Drawing.Size(96, 22);
            this.WAddressEdit.TabIndex = 4;
            this.WAddressEdit.Text = "100d";
            this.WAddressEdit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.WAddressEdit_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Address";
            // 
            // WValueEdit
            // 
            this.WValueEdit.Location = new System.Drawing.Point(26, 44);
            this.WValueEdit.Name = "WValueEdit";
            this.WValueEdit.Size = new System.Drawing.Size(93, 22);
            this.WValueEdit.TabIndex = 4;
            this.WValueEdit.Text = "12";
            this.WValueEdit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.WValueEdit_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Value";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.buttonWriteInt);
            this.groupBox1.Controls.Add(this.WAddressEdit);
            this.groupBox1.Controls.Add(this.WValueEdit);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(167, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(153, 197);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Write";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(23, 168);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Write float";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.ButtonWriteFloatClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.buttonReadFl);
            this.groupBox2.Controls.Add(this.RAddressEdit);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.buttonReadInt);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(12, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(139, 196);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Read";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(19, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "P";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Address";
            // 
            // buttonReadFl
            // 
            this.buttonReadFl.Location = new System.Drawing.Point(19, 167);
            this.buttonReadFl.Name = "buttonReadFl";
            this.buttonReadFl.Size = new System.Drawing.Size(96, 23);
            this.buttonReadFl.TabIndex = 9;
            this.buttonReadFl.Text = "Read float";
            this.buttonReadFl.UseVisualStyleBackColor = true;
            this.buttonReadFl.Click += new System.EventHandler(this.ButtonReadFloatClick);
            // 
            // RAddressEdit
            // 
            this.RAddressEdit.Location = new System.Drawing.Point(19, 89);
            this.RAddressEdit.Name = "RAddressEdit";
            this.RAddressEdit.Size = new System.Drawing.Size(96, 22);
            this.RAddressEdit.TabIndex = 5;
            this.RAddressEdit.Text = "100b";
            this.RAddressEdit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RAddressEditKeyPress);
            // 
            // chart1
            // 
            chartArea5.CursorX.IsUserEnabled = true;
            chartArea5.CursorX.IsUserSelectionEnabled = true;
            chartArea5.CursorY.IsUserEnabled = true;
            chartArea5.CursorY.IsUserSelectionEnabled = true;
            chartArea5.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea5);
            legend3.Enabled = false;
            legend3.Name = "Legend12";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(12, 254);
            this.chart1.Name = "chart1";
            series5.BorderColor = System.Drawing.Color.Red;
            series5.BorderWidth = 2;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine;
            series5.Color = System.Drawing.Color.Red;
            series5.Legend = "Legend12";
            series5.LegendText = "t";
            series5.Name = "Series1";
            this.chart1.Series.Add(series5);
            this.chart1.Size = new System.Drawing.Size(765, 176);
            this.chart1.TabIndex = 10;
            this.chart1.Text = "chart1";
            // 
            // timerGraphUpdate
            // 
            this.timerGraphUpdate.Interval = 1000;
            this.timerGraphUpdate.Tick += new System.EventHandler(this.timerGraphUpdateTick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(326, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 24);
            this.button1.TabIndex = 11;
            this.button1.Text = "Start Graph ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ButtonStartTimerClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(798, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comPortToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.settingsToolStripMenuItem.Text = "File";
            // 
            // comPortToolStripMenuItem
            // 
            this.comPortToolStripMenuItem.Name = "comPortToolStripMenuItem";
            this.comPortToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.comPortToolStripMenuItem.Text = "Com port";
            this.comPortToolStripMenuItem.Click += new System.EventHandler(this.comPortToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configureComPortToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(61, 20);
            this.toolStripMenuItem1.Text = "Settings";
            // 
            // configureComPortToolStripMenuItem
            // 
            this.configureComPortToolStripMenuItem.Name = "configureComPortToolStripMenuItem";
            this.configureComPortToolStripMenuItem.Size = new System.Drawing.Size(67, 22);
            // 
            // chart2
            // 
            chartArea6.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea6);
            this.chart2.Location = new System.Drawing.Point(12, 451);
            this.chart2.Name = "chart2";
            series6.BorderWidth = 3;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series6.Name = "Series1";
            this.chart2.Series.Add(series6);
            this.chart2.Size = new System.Drawing.Size(765, 141);
            this.chart2.TabIndex = 13;
            this.chart2.Text = "chart2";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(326, 41);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(460, 69);
            this.listBox1.TabIndex = 14;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(486, 117);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Stop Graph";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TTaskEdit
            // 
            this.TTaskEdit.Location = new System.Drawing.Point(370, 156);
            this.TTaskEdit.Name = "TTaskEdit";
            this.TTaskEdit.Size = new System.Drawing.Size(95, 20);
            this.TTaskEdit.TabIndex = 16;
            this.TTaskEdit.Text = "6000";
            this.TTaskEdit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TTaskEdit_KeyDown);
            this.TTaskEdit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TTaskEdit_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(326, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "TTask";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(480, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "KpF";
            // 
            // KpFEdit
            // 
            this.KpFEdit.Location = new System.Drawing.Point(512, 156);
            this.KpFEdit.Name = "KpFEdit";
            this.KpFEdit.Size = new System.Drawing.Size(100, 20);
            this.KpFEdit.TabIndex = 18;
            this.KpFEdit.Text = "0,001";
            this.KpFEdit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KpFEdit_KeyDown);
            this.KpFEdit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KpFEdit_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(634, 159);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "KiF";
            // 
            // KiFEdit
            // 
            this.KiFEdit.Location = new System.Drawing.Point(662, 156);
            this.KiFEdit.Name = "KiFEdit";
            this.KiFEdit.Size = new System.Drawing.Size(100, 20);
            this.KiFEdit.TabIndex = 20;
            this.KiFEdit.Text = "0,0001";
            this.KiFEdit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KiFEdit_KeyDown);
            this.KiFEdit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KiFEdit_KeyPress);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 614);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.KiFEdit);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.KpFEdit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TTaskEdit);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Delta DVP control";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonReadInt;
        private System.Windows.Forms.Button buttonWriteInt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox WAddressEdit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox WValueEdit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonReadFl;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Timer timerGraphUpdate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox RAddressEdit;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem configureComPortToolStripMenuItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comPortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox TTaskEdit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox KpFEdit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox KiFEdit;
    }
}

