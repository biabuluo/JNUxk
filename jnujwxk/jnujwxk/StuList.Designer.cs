namespace jnujwxk
{
    partial class StuList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StuList));
            this.label1 = new System.Windows.Forms.Label();
            this.dgvstulist = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SureBtn = new System.Windows.Forms.Button();
            this.ExportBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvstulist)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(71, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "学生名单";
            // 
            // dgvstulist
            // 
            this.dgvstulist.AllowUserToAddRows = false;
            this.dgvstulist.AllowUserToDeleteRows = false;
            this.dgvstulist.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvstulist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvstulist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvstulist.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgvstulist.Location = new System.Drawing.Point(321, 0);
            this.dgvstulist.Name = "dgvstulist";
            this.dgvstulist.ReadOnly = true;
            this.dgvstulist.RowHeadersVisible = false;
            this.dgvstulist.RowHeadersWidth = 82;
            this.dgvstulist.RowTemplate.Height = 37;
            this.dgvstulist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvstulist.Size = new System.Drawing.Size(848, 769);
            this.dgvstulist.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(78, 215);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(213, 39);
            this.comboBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "课程：";
            // 
            // SureBtn
            // 
            this.SureBtn.FlatAppearance.BorderSize = 0;
            this.SureBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SureBtn.Location = new System.Drawing.Point(64, 282);
            this.SureBtn.Name = "SureBtn";
            this.SureBtn.Size = new System.Drawing.Size(104, 55);
            this.SureBtn.TabIndex = 4;
            this.SureBtn.Text = "查询";
            this.SureBtn.UseVisualStyleBackColor = true;
            this.SureBtn.Click += new System.EventHandler(this.SureBtn_Click);
            // 
            // ExportBtn
            // 
            this.ExportBtn.FlatAppearance.BorderSize = 0;
            this.ExportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExportBtn.Location = new System.Drawing.Point(187, 282);
            this.ExportBtn.Name = "ExportBtn";
            this.ExportBtn.Size = new System.Drawing.Size(104, 55);
            this.ExportBtn.TabIndex = 5;
            this.ExportBtn.Text = "导出";
            this.ExportBtn.UseVisualStyleBackColor = true;
            this.ExportBtn.Click += new System.EventHandler(this.ExportBtn_Click);
            // 
            // StuList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1169, 769);
            this.Controls.Add(this.ExportBtn);
            this.Controls.Add(this.SureBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dgvstulist);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StuList";
            this.Text = "stuList";
            this.Load += new System.EventHandler(this.stuList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvstulist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvstulist;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SureBtn;
        private System.Windows.Forms.Button ExportBtn;
    }
}