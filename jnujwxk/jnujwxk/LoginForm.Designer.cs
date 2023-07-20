namespace jnujwxk
{
    partial class LoginForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.ExitBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.PWDTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ExitBtn
            // 
            this.ExitBtn.FlatAppearance.BorderSize = 0;
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.Location = new System.Drawing.Point(732, 0);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(105, 54);
            this.ExitBtn.TabIndex = 0;
            this.ExitBtn.Text = "退出";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::jnujwxk.Properties.Resources._7_210211210643296;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(419, 215);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(76, 299);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 50);
            this.label1.TabIndex = 2;
            this.label1.Text = "教务选课系统";
            // 
            // IDTextBox
            // 
            this.IDTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.IDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.IDTextBox.Location = new System.Drawing.Point(507, 259);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(197, 28);
            this.IDTextBox.TabIndex = 3;
            this.IDTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IDTextBox_KeyPress);
            // 
            // PWDTextBox
            // 
            this.PWDTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.PWDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PWDTextBox.Location = new System.Drawing.Point(507, 366);
            this.PWDTextBox.Name = "PWDTextBox";
            this.PWDTextBox.PasswordChar = '*';
            this.PWDTextBox.Size = new System.Drawing.Size(197, 28);
            this.PWDTextBox.TabIndex = 4;
            this.PWDTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PWDTextBox_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(507, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "账号";
            // 
            // LoginBtn
            // 
            this.LoginBtn.FlatAppearance.BorderSize = 0;
            this.LoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginBtn.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LoginBtn.Location = new System.Drawing.Point(608, 438);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(96, 81);
            this.LoginBtn.TabIndex = 6;
            this.LoginBtn.Text = "login";
            this.LoginBtn.UseVisualStyleBackColor = true;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(507, 300);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(195, 5);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(507, 407);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(195, 5);
            this.panel2.TabIndex = 8;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(836, 547);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PWDTextBox);
            this.Controls.Add(this.IDTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ExitBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.login_activate);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.TextBox PWDTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

