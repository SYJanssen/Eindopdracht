
namespace Eindopdracht
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Metal = new System.Windows.Forms.ComboBox();
            this.Title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Profile = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.HeatConduction = new System.Windows.Forms.TrackBar();
            this.label12 = new System.Windows.Forms.Label();
            this.SizeX = new System.Windows.Forms.TextBox();
            this.SizeY = new System.Windows.Forms.TextBox();
            this.IntervalX = new System.Windows.Forms.TextBox();
            this.IntervalY = new System.Windows.Forms.TextBox();
            this.TempStart = new System.Windows.Forms.TextBox();
            this.TempEnd = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.HeatConduction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // Metal
            // 
            this.Metal.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Metal.FormattingEnabled = true;
            this.Metal.Items.AddRange(new object[] {
            "Aluminum",
            "Cadmium",
            "Chromium",
            "Copper",
            "Iron",
            "Lead",
            "Nickel",
            "Silver",
            "Steel",
            "Tin"});
            this.Metal.Location = new System.Drawing.Point(1013, 126);
            this.Metal.Name = "Metal";
            this.Metal.Size = new System.Drawing.Size(138, 24);
            this.Metal.TabIndex = 0;
            this.Metal.SelectedValueChanged += new System.EventHandler(this.Metal_SelectedValueChanged);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.8F, System.Drawing.FontStyle.Bold);
            this.Title.Location = new System.Drawing.Point(300, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(641, 39);
            this.Title.TabIndex = 1;
            this.Title.Text = "Stational Temperature in a metal plate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(1021, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Value";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(893, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Variable";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.label3.Location = new System.Drawing.Point(925, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "Metal";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.label5.Location = new System.Drawing.Point(935, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 26);
            this.label5.TabIndex = 8;
            this.label5.Text = "Size";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.label4.Location = new System.Drawing.Point(858, 362);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 26);
            this.label4.TabIndex = 9;
            this.label4.Text = "Temperature";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.label6.Location = new System.Drawing.Point(919, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 26);
            this.label6.TabIndex = 12;
            this.label6.Text = "Profile";
            // 
            // Profile
            // 
            this.Profile.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Profile.FormattingEnabled = true;
            this.Profile.Items.AddRange(new object[] {
            "Constant",
            "Linear",
            "Exponential"});
            this.Profile.Location = new System.Drawing.Point(1013, 156);
            this.Profile.MaxDropDownItems = 3;
            this.Profile.Name = "Profile";
            this.Profile.Size = new System.Drawing.Size(138, 24);
            this.Profile.TabIndex = 13;
            this.Profile.SelectedValueChanged += new System.EventHandler(this.Profile_SelectedValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(1021, 245);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 26);
            this.label7.TabIndex = 14;
            this.label7.Text = "x";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(1097, 245);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 26);
            this.label8.TabIndex = 15;
            this.label8.Text = "y";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(1008, 333);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 26);
            this.label9.TabIndex = 16;
            this.label9.Text = "Start";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(1080, 333);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 26);
            this.label10.TabIndex = 17;
            this.label10.Text = "End";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.label11.Location = new System.Drawing.Point(910, 294);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 26);
            this.label11.TabIndex = 18;
            this.label11.Text = "Interval";
            // 
            // HeatConduction
            // 
            this.HeatConduction.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.HeatConduction.Location = new System.Drawing.Point(1013, 186);
            this.HeatConduction.Maximum = 1000;
            this.HeatConduction.Minimum = 100;
            this.HeatConduction.Name = "HeatConduction";
            this.HeatConduction.Size = new System.Drawing.Size(138, 56);
            this.HeatConduction.TabIndex = 20;
            this.HeatConduction.Value = 100;
            this.HeatConduction.ValueChanged += new System.EventHandler(this.HeatConduction_ValueChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.label12.Location = new System.Drawing.Point(819, 181);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(174, 26);
            this.label12.TabIndex = 21;
            this.label12.Text = "Heat Conduction";
            // 
            // SizeX
            // 
            this.SizeX.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SizeX.Location = new System.Drawing.Point(1013, 274);
            this.SizeX.Name = "SizeX";
            this.SizeX.Size = new System.Drawing.Size(46, 22);
            this.SizeX.TabIndex = 23;
            this.SizeX.TextChanged += new System.EventHandler(this.SizeX_TextChanged);
            // 
            // SizeY
            // 
            this.SizeY.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SizeY.Location = new System.Drawing.Point(1085, 274);
            this.SizeY.Name = "SizeY";
            this.SizeY.Size = new System.Drawing.Size(46, 22);
            this.SizeY.TabIndex = 24;
            this.SizeY.TextChanged += new System.EventHandler(this.SizeY_TextChanged);
            // 
            // IntervalX
            // 
            this.IntervalX.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.IntervalX.Location = new System.Drawing.Point(1013, 298);
            this.IntervalX.Name = "IntervalX";
            this.IntervalX.Size = new System.Drawing.Size(46, 22);
            this.IntervalX.TabIndex = 25;
            this.IntervalX.TextChanged += new System.EventHandler(this.IntervalX_TextChanged);
            // 
            // IntervalY
            // 
            this.IntervalY.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.IntervalY.Location = new System.Drawing.Point(1085, 298);
            this.IntervalY.Name = "IntervalY";
            this.IntervalY.Size = new System.Drawing.Size(46, 22);
            this.IntervalY.TabIndex = 26;
            this.IntervalY.TextChanged += new System.EventHandler(this.IntervalY_TextChanged);
            // 
            // TempStart
            // 
            this.TempStart.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TempStart.Location = new System.Drawing.Point(1013, 366);
            this.TempStart.Name = "TempStart";
            this.TempStart.Size = new System.Drawing.Size(46, 22);
            this.TempStart.TabIndex = 27;
            this.TempStart.TextChanged += new System.EventHandler(this.TempStart_TextChanged);
            // 
            // TempEnd
            // 
            this.TempEnd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TempEnd.Location = new System.Drawing.Point(1085, 366);
            this.TempEnd.Name = "TempEnd";
            this.TempEnd.Size = new System.Drawing.Size(46, 22);
            this.TempEnd.TabIndex = 28;
            this.TempEnd.TextChanged += new System.EventHandler(this.TempEnd_TextChanged);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(121, 396);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(8, 8);
            this.listView1.TabIndex = 30;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // chart1
            // 
            chartArea1.Area3DStyle.Enable3D = true;
            chartArea1.Area3DStyle.IsRightAngleAxes = false;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(189, 245);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(351, 212);
            this.chart1.TabIndex = 31;
            this.chart1.Text = "chart1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(75, 117);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(177, 22);
            this.textBox1.TabIndex = 32;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(382, 117);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel1.TabIndex = 33;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 577);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.TempEnd);
            this.Controls.Add(this.TempStart);
            this.Controls.Add(this.IntervalY);
            this.Controls.Add(this.IntervalX);
            this.Controls.Add(this.SizeY);
            this.Controls.Add(this.SizeX);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.HeatConduction);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Profile);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.Metal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Eindopdracht SC";
            ((System.ComponentModel.ISupportInitialize)(this.HeatConduction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Metal;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox Profile;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TrackBar HeatConduction;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox SizeX;
        private System.Windows.Forms.TextBox SizeY;
        private System.Windows.Forms.TextBox IntervalX;
        private System.Windows.Forms.TextBox IntervalY;
        private System.Windows.Forms.TextBox TempStart;
        private System.Windows.Forms.TextBox TempEnd;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

