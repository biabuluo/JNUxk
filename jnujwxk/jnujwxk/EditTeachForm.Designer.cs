namespace jnujwxk
{
    partial class EditTeachForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditTeachForm));
            this.TeachNamelabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SureBtn = new System.Windows.Forms.Button();
            this.locationtextBox = new System.Windows.Forms.TextBox();
            this.datetimetextBox = new System.Windows.Forms.TextBox();
            this.tidtextBox = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TeachNamelabel
            // 
            this.TeachNamelabel.AutoSize = true;
            this.TeachNamelabel.Location = new System.Drawing.Point(216, 35);
            this.TeachNamelabel.Name = "TeachNamelabel";
            this.TeachNamelabel.Size = new System.Drawing.Size(88, 24);
            this.TeachNamelabel.TabIndex = 0;
            this.TeachNamelabel.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "教师编号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "授课地址：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "授课时间：";
            // 
            // SureBtn
            // 
            this.SureBtn.FlatAppearance.BorderSize = 0;
            this.SureBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SureBtn.Location = new System.Drawing.Point(291, 409);
            this.SureBtn.Name = "SureBtn";
            this.SureBtn.Size = new System.Drawing.Size(117, 56);
            this.SureBtn.TabIndex = 4;
            this.SureBtn.Text = "确定";
            this.SureBtn.UseVisualStyleBackColor = true;
            this.SureBtn.Click += new System.EventHandler(this.SureBtn_Click);
            // 
            // locationtextBox
            // 
            this.locationtextBox.Location = new System.Drawing.Point(220, 183);
            this.locationtextBox.Name = "locationtextBox";
            this.locationtextBox.Size = new System.Drawing.Size(165, 35);
            this.locationtextBox.TabIndex = 6;
            // 
            // datetimetextBox
            // 
            this.datetimetextBox.Location = new System.Drawing.Point(220, 264);
            this.datetimetextBox.Name = "datetimetextBox";
            this.datetimetextBox.Size = new System.Drawing.Size(165, 35);
            this.datetimetextBox.TabIndex = 7;
            // 
            // tidtextBox
            // 
            this.tidtextBox.AutoSize = true;
            this.tidtextBox.Location = new System.Drawing.Point(216, 113);
            this.tidtextBox.Name = "tidtextBox";
            this.tidtextBox.Size = new System.Drawing.Size(88, 24);
            this.tidtextBox.TabIndex = 8;
            this.tidtextBox.Text = "label4";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "label1";
            // 
            // EditTeachForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(481, 499);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tidtextBox);
            this.Controls.Add(this.datetimetextBox);
            this.Controls.Add(this.locationtextBox);
            this.Controls.Add(this.SureBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TeachNamelabel);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(507, 570);
            this.MinimumSize = new System.Drawing.Size(507, 570);
            this.Name = "EditTeachForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "授课信息修改";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TeachNamelabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SureBtn;
        private System.Windows.Forms.TextBox locationtextBox;
        private System.Windows.Forms.TextBox datetimetextBox;
        private System.Windows.Forms.Label tidtextBox;
        private System.Windows.Forms.Label label4;
    }
}