namespace jnujwxk
{
    partial class AddCourseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCourseForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SureBtn = new System.Windows.Forms.Button();
            this.CidtextBox = new System.Windows.Forms.TextBox();
            this.CnametextBox = new System.Windows.Forms.TextBox();
            this.CpointstextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(39, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "课程编号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(39, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "课程名称：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(39, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "课程学分：";
            // 
            // SureBtn
            // 
            this.SureBtn.FlatAppearance.BorderSize = 0;
            this.SureBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SureBtn.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SureBtn.Location = new System.Drawing.Point(300, 376);
            this.SureBtn.Name = "SureBtn";
            this.SureBtn.Size = new System.Drawing.Size(95, 50);
            this.SureBtn.TabIndex = 3;
            this.SureBtn.Text = "确定";
            this.SureBtn.UseVisualStyleBackColor = true;
            this.SureBtn.Click += new System.EventHandler(this.SureBtn_Click);
            // 
            // CidtextBox
            // 
            this.CidtextBox.Location = new System.Drawing.Point(181, 70);
            this.CidtextBox.Name = "CidtextBox";
            this.CidtextBox.Size = new System.Drawing.Size(149, 35);
            this.CidtextBox.TabIndex = 4;
            // 
            // CnametextBox
            // 
            this.CnametextBox.Location = new System.Drawing.Point(181, 148);
            this.CnametextBox.Name = "CnametextBox";
            this.CnametextBox.Size = new System.Drawing.Size(149, 35);
            this.CnametextBox.TabIndex = 5;
            // 
            // CpointstextBox
            // 
            this.CpointstextBox.Location = new System.Drawing.Point(181, 234);
            this.CpointstextBox.Name = "CpointstextBox";
            this.CpointstextBox.Size = new System.Drawing.Size(149, 35);
            this.CpointstextBox.TabIndex = 6;
            // 
            // AddCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 472);
            this.Controls.Add(this.CpointstextBox);
            this.Controls.Add(this.CnametextBox);
            this.Controls.Add(this.CidtextBox);
            this.Controls.Add(this.SureBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(483, 543);
            this.MinimumSize = new System.Drawing.Size(483, 543);
            this.Name = "AddCourseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加课程";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SureBtn;
        private System.Windows.Forms.TextBox CidtextBox;
        private System.Windows.Forms.TextBox CnametextBox;
        private System.Windows.Forms.TextBox CpointstextBox;
    }
}