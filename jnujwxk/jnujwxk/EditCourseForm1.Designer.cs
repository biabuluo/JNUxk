namespace jnujwxk
{
    partial class EditCourseForm1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditCourseForm1));
            this.PointsBox = new System.Windows.Forms.TextBox();
            this.CourseNameBox = new System.Windows.Forms.TextBox();
            this.SureBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PointsBox
            // 
            this.PointsBox.Location = new System.Drawing.Point(204, 206);
            this.PointsBox.Name = "PointsBox";
            this.PointsBox.Size = new System.Drawing.Size(141, 35);
            this.PointsBox.TabIndex = 9;
            // 
            // CourseNameBox
            // 
            this.CourseNameBox.Location = new System.Drawing.Point(204, 84);
            this.CourseNameBox.Name = "CourseNameBox";
            this.CourseNameBox.Size = new System.Drawing.Size(141, 35);
            this.CourseNameBox.TabIndex = 8;
            // 
            // SureBtn
            // 
            this.SureBtn.FlatAppearance.BorderSize = 0;
            this.SureBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SureBtn.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SureBtn.Location = new System.Drawing.Point(299, 354);
            this.SureBtn.Name = "SureBtn";
            this.SureBtn.Size = new System.Drawing.Size(109, 65);
            this.SureBtn.TabIndex = 7;
            this.SureBtn.Text = "确定";
            this.SureBtn.UseVisualStyleBackColor = true;
            this.SureBtn.Click += new System.EventHandler(this.SureBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(50, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 31);
            this.label2.TabIndex = 6;
            this.label2.Text = "学分明细：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(50, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "课程名称：";
            // 
            // EditCourseForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 502);
            this.Controls.Add(this.PointsBox);
            this.Controls.Add(this.CourseNameBox);
            this.Controls.Add(this.SureBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(485, 573);
            this.MinimumSize = new System.Drawing.Size(485, 573);
            this.Name = "EditCourseForm1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "修改课程";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PointsBox;
        private System.Windows.Forms.TextBox CourseNameBox;
        private System.Windows.Forms.Button SureBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}