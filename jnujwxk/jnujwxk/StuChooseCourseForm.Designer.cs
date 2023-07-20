namespace jnujwxk
{
    partial class StuChooseCourseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StuChooseCourseForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.CourseNameBox = new System.Windows.Forms.TextBox();
            this.TeacherNameBox = new System.Windows.Forms.TextBox();
            this.dgvStuChooseCourse = new System.Windows.Forms.DataGridView();
            this.ChooseCourseMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.选课ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStuChooseCourse)).BeginInit();
            this.ChooseCourseMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(95, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "学生选课";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "课程：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(412, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "教师：";
            // 
            // SearchBtn
            // 
            this.SearchBtn.FlatAppearance.BorderSize = 0;
            this.SearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchBtn.Location = new System.Drawing.Point(781, 161);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(111, 48);
            this.SearchBtn.TabIndex = 3;
            this.SearchBtn.Text = "查询";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // CourseNameBox
            // 
            this.CourseNameBox.Location = new System.Drawing.Point(227, 153);
            this.CourseNameBox.Name = "CourseNameBox";
            this.CourseNameBox.Size = new System.Drawing.Size(160, 39);
            this.CourseNameBox.TabIndex = 4;
            // 
            // TeacherNameBox
            // 
            this.TeacherNameBox.Location = new System.Drawing.Point(514, 153);
            this.TeacherNameBox.Name = "TeacherNameBox";
            this.TeacherNameBox.Size = new System.Drawing.Size(160, 39);
            this.TeacherNameBox.TabIndex = 5;
            // 
            // dgvStuChooseCourse
            // 
            this.dgvStuChooseCourse.AllowUserToAddRows = false;
            this.dgvStuChooseCourse.AllowUserToDeleteRows = false;
            this.dgvStuChooseCourse.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvStuChooseCourse.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvStuChooseCourse.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvStuChooseCourse.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvStuChooseCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStuChooseCourse.ContextMenuStrip = this.ChooseCourseMenu;
            this.dgvStuChooseCourse.Location = new System.Drawing.Point(65, 292);
            this.dgvStuChooseCourse.Name = "dgvStuChooseCourse";
            this.dgvStuChooseCourse.ReadOnly = true;
            this.dgvStuChooseCourse.RowHeadersVisible = false;
            this.dgvStuChooseCourse.RowHeadersWidth = 82;
            this.dgvStuChooseCourse.RowTemplate.Height = 37;
            this.dgvStuChooseCourse.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStuChooseCourse.Size = new System.Drawing.Size(1059, 480);
            this.dgvStuChooseCourse.TabIndex = 6;
            // 
            // ChooseCourseMenu
            // 
            this.ChooseCourseMenu.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ChooseCourseMenu.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.ChooseCourseMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.选课ToolStripMenuItem});
            this.ChooseCourseMenu.Name = "ChooseCourseMenu";
            this.ChooseCourseMenu.Size = new System.Drawing.Size(137, 42);
            // 
            // 选课ToolStripMenuItem
            // 
            this.选课ToolStripMenuItem.Name = "选课ToolStripMenuItem";
            this.选课ToolStripMenuItem.Size = new System.Drawing.Size(136, 38);
            this.选课ToolStripMenuItem.Text = "选课";
            this.选课ToolStripMenuItem.Click += new System.EventHandler(this.选课ToolStripMenuItem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label4.Location = new System.Drawing.Point(951, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(206, 31);
            this.label4.TabIndex = 7;
            this.label4.Text = "选中课程右键选课";
            // 
            // StuChooseCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1169, 769);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvStuChooseCourse);
            this.Controls.Add(this.TeacherNameBox);
            this.Controls.Add(this.CourseNameBox);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StuChooseCourseForm";
            this.Text = "StuChooseCourseForm";
            this.Load += new System.EventHandler(this.StuChooseCourseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStuChooseCourse)).EndInit();
            this.ChooseCourseMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.TextBox CourseNameBox;
        private System.Windows.Forms.TextBox TeacherNameBox;
        private System.Windows.Forms.DataGridView dgvStuChooseCourse;
        private System.Windows.Forms.ContextMenuStrip ChooseCourseMenu;
        private System.Windows.Forms.ToolStripMenuItem 选课ToolStripMenuItem;
        private System.Windows.Forms.Label label4;
    }
}