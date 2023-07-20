namespace jnujwxk
{
    partial class ChartForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.BarChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.PieChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.BarChart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.TimeChangeBox = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.editdatebtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BarChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PieChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarChart2)).BeginInit();
            this.TimeChangeBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(28, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 42);
            this.label1.TabIndex = 18;
            this.label1.Text = "应用数据";
            // 
            // BarChart
            // 
            chartArea4.Name = "ChartArea1";
            this.BarChart.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.BarChart.Legends.Add(legend4);
            this.BarChart.Location = new System.Drawing.Point(455, 379);
            this.BarChart.Name = "BarChart";
            series4.ChartArea = "ChartArea1";
            series4.IsVisibleInLegend = false;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.BarChart.Series.Add(series4);
            this.BarChart.Size = new System.Drawing.Size(682, 378);
            this.BarChart.TabIndex = 19;
            this.BarChart.Text = "chart1";
            // 
            // PieChart
            // 
            chartArea5.Name = "ChartArea1";
            this.PieChart.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.PieChart.Legends.Add(legend5);
            this.PieChart.Location = new System.Drawing.Point(12, 75);
            this.PieChart.Name = "PieChart";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series5.CustomProperties = "PieLabelStyle=Outside";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.PieChart.Series.Add(series5);
            this.PieChart.Size = new System.Drawing.Size(640, 425);
            this.PieChart.TabIndex = 20;
            this.PieChart.Text = "chart2";
            // 
            // BarChart2
            // 
            chartArea6.Name = "ChartArea1";
            this.BarChart2.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.BarChart2.Legends.Add(legend6);
            this.BarChart2.Location = new System.Drawing.Point(35, 467);
            this.BarChart2.Name = "BarChart2";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series6.IsVisibleInLegend = false;
            series6.Legend = "Legend1";
            series6.MarkerColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            series6.Name = "Series1";
            this.BarChart2.Series.Add(series6);
            this.BarChart2.Size = new System.Drawing.Size(431, 275);
            this.BarChart2.TabIndex = 21;
            this.BarChart2.Text = "chart1";
            // 
            // TimeChangeBox
            // 
            this.TimeChangeBox.Controls.Add(this.label7);
            this.TimeChangeBox.Controls.Add(this.label6);
            this.TimeChangeBox.Controls.Add(this.label5);
            this.TimeChangeBox.Controls.Add(this.label4);
            this.TimeChangeBox.Controls.Add(this.label3);
            this.TimeChangeBox.Controls.Add(this.label2);
            this.TimeChangeBox.Location = new System.Drawing.Point(743, 75);
            this.TimeChangeBox.Name = "TimeChangeBox";
            this.TimeChangeBox.Size = new System.Drawing.Size(365, 273);
            this.TimeChangeBox.TabIndex = 22;
            this.TimeChangeBox.TabStop = false;
            this.TimeChangeBox.Text = "选课限制";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(146, 220);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 31);
            this.label7.TabIndex = 5;
            this.label7.Text = "label7";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(146, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 31);
            this.label6.TabIndex = 4;
            this.label6.Text = "label6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(146, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 31);
            this.label5.TabIndex = 3;
            this.label5.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(146, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 31);
            this.label4.TabIndex = 2;
            this.label4.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 31);
            this.label3.TabIndex = 1;
            this.label3.Text = "退改补：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "选课：";
            // 
            // editdatebtn
            // 
            this.editdatebtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.editdatebtn.FlatAppearance.BorderSize = 0;
            this.editdatebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editdatebtn.ForeColor = System.Drawing.Color.Transparent;
            this.editdatebtn.Location = new System.Drawing.Point(965, 26);
            this.editdatebtn.Name = "editdatebtn";
            this.editdatebtn.Size = new System.Drawing.Size(143, 43);
            this.editdatebtn.TabIndex = 24;
            this.editdatebtn.Text = "button1";
            this.editdatebtn.UseVisualStyleBackColor = false;
            this.editdatebtn.Click += new System.EventHandler(this.editdatebtn_Click);
            // 
            // ChartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1169, 769);
            this.Controls.Add(this.editdatebtn);
            this.Controls.Add(this.TimeChangeBox);
            this.Controls.Add(this.BarChart2);
            this.Controls.Add(this.BarChart);
            this.Controls.Add(this.PieChart);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ChartForm";
            this.Text = "ChatForm";
            this.Load += new System.EventHandler(this.ChartForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BarChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PieChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarChart2)).EndInit();
            this.TimeChangeBox.ResumeLayout(false);
            this.TimeChangeBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart BarChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart PieChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart BarChart2;
        private System.Windows.Forms.GroupBox TimeChangeBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button editdatebtn;
    }
}