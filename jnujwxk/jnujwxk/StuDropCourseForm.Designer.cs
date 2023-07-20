namespace jnujwxk
{
    partial class StuDropCourseForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StuDropCourseForm));
            this.label1 = new System.Windows.Forms.Label();
            this.TeacherNameBox = new System.Windows.Forms.TextBox();
            this.CourseNameBox = new System.Windows.Forms.TextBox();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvStuDropCourse = new System.Windows.Forms.DataGridView();
            this.DropCourseMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.退选ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStuDropCourse)).BeginInit();
            this.DropCourseMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(95, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "学生退选";
            // 
            // TeacherNameBox
            // 
            this.TeacherNameBox.Location = new System.Drawing.Point(513, 159);
            this.TeacherNameBox.Name = "TeacherNameBox";
            this.TeacherNameBox.Size = new System.Drawing.Size(160, 39);
            this.TeacherNameBox.TabIndex = 10;
            // 
            // CourseNameBox
            // 
            this.CourseNameBox.Location = new System.Drawing.Point(226, 159);
            this.CourseNameBox.Name = "CourseNameBox";
            this.CourseNameBox.Size = new System.Drawing.Size(160, 39);
            this.CourseNameBox.TabIndex = 9;
            // 
            // SearchBtn
            // 
            this.SearchBtn.FlatAppearance.BorderSize = 0;
            this.SearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchBtn.Location = new System.Drawing.Point(780, 167);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(111, 48);
            this.SearchBtn.TabIndex = 8;
            this.SearchBtn.Text = "查询";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(411, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 31);
            this.label3.TabIndex = 7;
            this.label3.Text = "教师：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 31);
            this.label2.TabIndex = 6;
            this.label2.Text = "课程：";
            // 
            // dgvStuDropCourse
            // 
            this.dgvStuDropCourse.AllowUserToAddRows = false;
            this.dgvStuDropCourse.AllowUserToDeleteRows = false;
            this.dgvStuDropCourse.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvStuDropCourse.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvStuDropCourse.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvStuDropCourse.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvStuDropCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStuDropCourse.ContextMenuStrip = this.DropCourseMenu;
            this.dgvStuDropCourse.Location = new System.Drawing.Point(60, 289);
            this.dgvStuDropCourse.Name = "dgvStuDropCourse";
            this.dgvStuDropCourse.ReadOnly = true;
            this.dgvStuDropCourse.RowHeadersVisible = false;
            this.dgvStuDropCourse.RowHeadersWidth = 82;
            this.dgvStuDropCourse.RowTemplate.Height = 37;
            this.dgvStuDropCourse.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStuDropCourse.Size = new System.Drawing.Size(1059, 480);
            this.dgvStuDropCourse.TabIndex = 11;
            // 
            // DropCourseMenu
            // 
            this.DropCourseMenu.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DropCourseMenu.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.DropCourseMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.退选ToolStripMenuItem});
            this.DropCourseMenu.Name = "DropCourseMenu";
            this.DropCourseMenu.Size = new System.Drawing.Size(137, 42);
            // 
            // 退选ToolStripMenuItem
            // 
            this.退选ToolStripMenuItem.Name = "退选ToolStripMenuItem";
            this.退选ToolStripMenuItem.Size = new System.Drawing.Size(136, 38);
            this.退选ToolStripMenuItem.Text = "退选";
            this.退选ToolStripMenuItem.Click += new System.EventHandler(this.退选ToolStripMenuItem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label4.Location = new System.Drawing.Point(951, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(206, 31);
            this.label4.TabIndex = 12;
            this.label4.Text = "选中课程右键退课";
            // 
            // StuDropCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1169, 769);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvStuDropCourse);
            this.Controls.Add(this.TeacherNameBox);
            this.Controls.Add(this.CourseNameBox);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StuDropCourseForm";
            this.Text = "StuDropCourseForm";
            this.Load += new System.EventHandler(this.StuDropCourseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStuDropCourse)).EndInit();
            this.DropCourseMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TeacherNameBox;
        private System.Windows.Forms.TextBox CourseNameBox;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvStuDropCourse;
        private System.Windows.Forms.ContextMenuStrip DropCourseMenu;
        private System.Windows.Forms.ToolStripMenuItem 退选ToolStripMenuItem;
        private System.Windows.Forms.Label label4;
    }
}