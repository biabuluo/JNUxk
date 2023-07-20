namespace jnujwxk
{
    partial class AddTeachForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddTeachForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SureBtn = new System.Windows.Forms.Button();
            this.CidtextBox = new System.Windows.Forms.TextBox();
            this.TidtextBox = new System.Windows.Forms.TextBox();
            this.LocationtextBox = new System.Windows.Forms.TextBox();
            this.DatetextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "课程编号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 126);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "教师编号";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 203);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "授课地点";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 295);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 31);
            this.label4.TabIndex = 3;
            this.label4.Text = "授课时间";
            // 
            // SureBtn
            // 
            this.SureBtn.FlatAppearance.BorderSize = 0;
            this.SureBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SureBtn.Location = new System.Drawing.Point(326, 366);
            this.SureBtn.Name = "SureBtn";
            this.SureBtn.Size = new System.Drawing.Size(121, 77);
            this.SureBtn.TabIndex = 4;
            this.SureBtn.Text = "确定";
            this.SureBtn.UseVisualStyleBackColor = true;
            this.SureBtn.Click += new System.EventHandler(this.SureBtn_Click);
            // 
            // CidtextBox
            // 
            this.CidtextBox.Location = new System.Drawing.Point(199, 33);
            this.CidtextBox.Name = "CidtextBox";
            this.CidtextBox.Size = new System.Drawing.Size(168, 39);
            this.CidtextBox.TabIndex = 5;
            // 
            // TidtextBox
            // 
            this.TidtextBox.Location = new System.Drawing.Point(199, 118);
            this.TidtextBox.Name = "TidtextBox";
            this.TidtextBox.Size = new System.Drawing.Size(168, 39);
            this.TidtextBox.TabIndex = 6;
            // 
            // LocationtextBox
            // 
            this.LocationtextBox.Location = new System.Drawing.Point(199, 195);
            this.LocationtextBox.Name = "LocationtextBox";
            this.LocationtextBox.Size = new System.Drawing.Size(168, 39);
            this.LocationtextBox.TabIndex = 7;
            // 
            // DatetextBox
            // 
            this.DatetextBox.Location = new System.Drawing.Point(199, 287);
            this.DatetextBox.Name = "DatetextBox";
            this.DatetextBox.Size = new System.Drawing.Size(168, 39);
            this.DatetextBox.TabIndex = 8;
            // 
            // AddTeachForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(503, 464);
            this.Controls.Add(this.DatetextBox);
            this.Controls.Add(this.LocationtextBox);
            this.Controls.Add(this.TidtextBox);
            this.Controls.Add(this.CidtextBox);
            this.Controls.Add(this.SureBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(529, 535);
            this.MinimumSize = new System.Drawing.Size(529, 535);
            this.Name = "AddTeachForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加授课";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button SureBtn;
        private System.Windows.Forms.TextBox CidtextBox;
        private System.Windows.Forms.TextBox TidtextBox;
        private System.Windows.Forms.TextBox LocationtextBox;
        private System.Windows.Forms.TextBox DatetextBox;
    }
}