namespace jnujwxk
{
    partial class SubChangePWDForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NewPWDtextBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NewPWDtextBox2 = new System.Windows.Forms.TextBox();
            this.YesBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(95, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "修改密码";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(195, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(281, 50);
            this.label2.TabIndex = 1;
            this.label2.Text = "请输入新密码：";
            // 
            // NewPWDtextBox1
            // 
            this.NewPWDtextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NewPWDtextBox1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NewPWDtextBox1.Location = new System.Drawing.Point(363, 301);
            this.NewPWDtextBox1.Name = "NewPWDtextBox1";
            this.NewPWDtextBox1.PasswordChar = '*';
            this.NewPWDtextBox1.Size = new System.Drawing.Size(326, 32);
            this.NewPWDtextBox1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(195, 379);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(281, 50);
            this.label3.TabIndex = 3;
            this.label3.Text = "再次输入密码：";
            // 
            // NewPWDtextBox2
            // 
            this.NewPWDtextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NewPWDtextBox2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NewPWDtextBox2.Location = new System.Drawing.Point(363, 472);
            this.NewPWDtextBox2.Name = "NewPWDtextBox2";
            this.NewPWDtextBox2.PasswordChar = '*';
            this.NewPWDtextBox2.Size = new System.Drawing.Size(326, 32);
            this.NewPWDtextBox2.TabIndex = 4;
            // 
            // YesBtn
            // 
            this.YesBtn.FlatAppearance.BorderSize = 0;
            this.YesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.YesBtn.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.YesBtn.Location = new System.Drawing.Point(826, 575);
            this.YesBtn.Name = "YesBtn";
            this.YesBtn.Size = new System.Drawing.Size(139, 65);
            this.YesBtn.TabIndex = 5;
            this.YesBtn.Text = "确认更改";
            this.YesBtn.UseVisualStyleBackColor = true;
            this.YesBtn.Click += new System.EventHandler(this.YesBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(363, 339);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(326, 5);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(363, 517);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(326, 5);
            this.panel2.TabIndex = 7;
            // 
            // SubChangePWDForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1169, 769);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.YesBtn);
            this.Controls.Add(this.NewPWDtextBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NewPWDtextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SubChangePWDForm";
            this.Text = "SubMainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NewPWDtextBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NewPWDtextBox2;
        private System.Windows.Forms.Button YesBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}