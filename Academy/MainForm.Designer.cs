namespace Academy
{
    partial class MainForm
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
            this.tabPageGroups = new System.Windows.Forms.TabPage();
            this.lblGroupDirection = new System.Windows.Forms.Label();
            this.cbGroupsDirection = new System.Windows.Forms.ComboBox();
            this.dgvGroups1 = new System.Windows.Forms.DataGridView();
            this.statusStripGroups = new System.Windows.Forms.StatusStrip();
            this.tslGroupsCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabPageStudents = new System.Windows.Forms.TabPage();
            this.lblStudentsDirection = new System.Windows.Forms.Label();
            this.lblStudentsGroup = new System.Windows.Forms.Label();
            this.cbStudentsDirection = new System.Windows.Forms.ComboBox();
            this.cbStudentsGroup = new System.Windows.Forms.ComboBox();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.statusStripStudenrs = new System.Windows.Forms.StatusStrip();
            this.tslStudentsCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.dataGridViewGroups = new System.Windows.Forms.TabControl();
            this.tabPageTeachers = new System.Windows.Forms.TabPage();
            this.dgvTeachers = new System.Windows.Forms.DataGridView();
            this.statusStripTeachers = new System.Windows.Forms.StatusStrip();
            this.tslTeachersCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabPageGroups.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroups1)).BeginInit();
            this.statusStripGroups.SuspendLayout();
            this.tabPageStudents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.statusStripStudenrs.SuspendLayout();
            this.dataGridViewGroups.SuspendLayout();
            this.tabPageTeachers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeachers)).BeginInit();
            this.statusStripTeachers.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPageGroups
            // 
            this.tabPageGroups.Controls.Add(this.lblGroupDirection);
            this.tabPageGroups.Controls.Add(this.cbGroupsDirection);
            this.tabPageGroups.Controls.Add(this.dgvGroups1);
            this.tabPageGroups.Controls.Add(this.statusStripGroups);
            this.tabPageGroups.Location = new System.Drawing.Point(4, 22);
            this.tabPageGroups.Name = "tabPageGroups";
            this.tabPageGroups.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGroups.Size = new System.Drawing.Size(740, 327);
            this.tabPageGroups.TabIndex = 1;
            this.tabPageGroups.Text = "Groups";
            this.tabPageGroups.UseVisualStyleBackColor = true;
            // 
            // lblGroupDirection
            // 
            this.lblGroupDirection.AutoSize = true;
            this.lblGroupDirection.Location = new System.Drawing.Point(66, 27);
            this.lblGroupDirection.Name = "lblGroupDirection";
            this.lblGroupDirection.Size = new System.Drawing.Size(124, 13);
            this.lblGroupDirection.TabIndex = 3;
            this.lblGroupDirection.Text = "Направление обучения";
            // 
            // cbGroupsDirection
            // 
            this.cbGroupsDirection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGroupsDirection.FormattingEnabled = true;
            this.cbGroupsDirection.Location = new System.Drawing.Point(227, 24);
            this.cbGroupsDirection.Name = "cbGroupsDirection";
            this.cbGroupsDirection.Size = new System.Drawing.Size(217, 21);
            this.cbGroupsDirection.TabIndex = 2;
            this.cbGroupsDirection.SelectedIndexChanged += new System.EventHandler(this.cbGroupsDirection_SelectedIndexChanged);
            // 
            // dgvGroups1
            // 
            this.dgvGroups1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvGroups1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGroups1.Location = new System.Drawing.Point(8, 71);
            this.dgvGroups1.Name = "dgvGroups1";
            this.dgvGroups1.Size = new System.Drawing.Size(726, 228);
            this.dgvGroups1.TabIndex = 1;
            // 
            // statusStripGroups
            // 
            this.statusStripGroups.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslGroupsCount});
            this.statusStripGroups.Location = new System.Drawing.Point(3, 302);
            this.statusStripGroups.Name = "statusStripGroups";
            this.statusStripGroups.Size = new System.Drawing.Size(734, 22);
            this.statusStripGroups.TabIndex = 0;
            this.statusStripGroups.Text = "statusStripGroups";
            // 
            // tslGroupsCount
            // 
            this.tslGroupsCount.Name = "tslGroupsCount";
            this.tslGroupsCount.Size = new System.Drawing.Size(107, 17);
            this.tslGroupsCount.Text = "Количество групп";
            // 
            // tabPageStudents
            // 
            this.tabPageStudents.Controls.Add(this.lblStudentsDirection);
            this.tabPageStudents.Controls.Add(this.lblStudentsGroup);
            this.tabPageStudents.Controls.Add(this.cbStudentsDirection);
            this.tabPageStudents.Controls.Add(this.cbStudentsGroup);
            this.tabPageStudents.Controls.Add(this.dgvStudents);
            this.tabPageStudents.Controls.Add(this.statusStripStudenrs);
            this.tabPageStudents.Location = new System.Drawing.Point(4, 22);
            this.tabPageStudents.Name = "tabPageStudents";
            this.tabPageStudents.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStudents.Size = new System.Drawing.Size(740, 327);
            this.tabPageStudents.TabIndex = 0;
            this.tabPageStudents.Text = "Students";
            this.tabPageStudents.UseVisualStyleBackColor = true;
            // 
            // lblStudentsDirection
            // 
            this.lblStudentsDirection.AutoSize = true;
            this.lblStudentsDirection.Location = new System.Drawing.Point(283, 14);
            this.lblStudentsDirection.Name = "lblStudentsDirection";
            this.lblStudentsDirection.Size = new System.Drawing.Size(130, 13);
            this.lblStudentsDirection.TabIndex = 5;
            this.lblStudentsDirection.Text = "Направление обучения: ";
            // 
            // lblStudentsGroup
            // 
            this.lblStudentsGroup.AutoSize = true;
            this.lblStudentsGroup.Location = new System.Drawing.Point(32, 14);
            this.lblStudentsGroup.Name = "lblStudentsGroup";
            this.lblStudentsGroup.Size = new System.Drawing.Size(48, 13);
            this.lblStudentsGroup.TabIndex = 4;
            this.lblStudentsGroup.Text = "Группа: ";
            // 
            // cbStudentsDirection
            // 
            this.cbStudentsDirection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStudentsDirection.FormattingEnabled = true;
            this.cbStudentsDirection.Location = new System.Drawing.Point(419, 11);
            this.cbStudentsDirection.Name = "cbStudentsDirection";
            this.cbStudentsDirection.Size = new System.Drawing.Size(313, 21);
            this.cbStudentsDirection.TabIndex = 3;
            this.cbStudentsDirection.SelectedIndexChanged += new System.EventHandler(this.cbStudentsDirection_SelectedIndexChanged);
            // 
            // cbStudentsGroup
            // 
            this.cbStudentsGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStudentsGroup.FormattingEnabled = true;
            this.cbStudentsGroup.Location = new System.Drawing.Point(99, 11);
            this.cbStudentsGroup.Name = "cbStudentsGroup";
            this.cbStudentsGroup.Size = new System.Drawing.Size(105, 21);
            this.cbStudentsGroup.TabIndex = 2;
            this.cbStudentsGroup.SelectedIndexChanged += new System.EventHandler(this.cbStudentsGroup_SelectedIndexChanged);
            // 
            // dgvStudents
            // 
            this.dgvStudents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Location = new System.Drawing.Point(3, 54);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.Size = new System.Drawing.Size(734, 245);
            this.dgvStudents.TabIndex = 1;
            // 
            // statusStripStudenrs
            // 
            this.statusStripStudenrs.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslStudentsCount});
            this.statusStripStudenrs.Location = new System.Drawing.Point(3, 302);
            this.statusStripStudenrs.Name = "statusStripStudenrs";
            this.statusStripStudenrs.Size = new System.Drawing.Size(734, 22);
            this.statusStripStudenrs.TabIndex = 0;
            this.statusStripStudenrs.Text = "statusStripStudenrs";
            // 
            // tslStudentsCount
            // 
            this.tslStudentsCount.Name = "tslStudentsCount";
            this.tslStudentsCount.Size = new System.Drawing.Size(129, 17);
            this.tslStudentsCount.Text = "Количество студентов";
            // 
            // dataGridViewGroups
            // 
            this.dataGridViewGroups.Controls.Add(this.tabPageStudents);
            this.dataGridViewGroups.Controls.Add(this.tabPageGroups);
            this.dataGridViewGroups.Controls.Add(this.tabPageTeachers);
            this.dataGridViewGroups.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewGroups.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewGroups.Name = "dataGridViewGroups";
            this.dataGridViewGroups.SelectedIndex = 0;
            this.dataGridViewGroups.Size = new System.Drawing.Size(748, 353);
            this.dataGridViewGroups.TabIndex = 0;
            // 
            // tabPageTeachers
            // 
            this.tabPageTeachers.Controls.Add(this.dgvTeachers);
            this.tabPageTeachers.Controls.Add(this.statusStripTeachers);
            this.tabPageTeachers.Location = new System.Drawing.Point(4, 22);
            this.tabPageTeachers.Name = "tabPageTeachers";
            this.tabPageTeachers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTeachers.Size = new System.Drawing.Size(740, 327);
            this.tabPageTeachers.TabIndex = 2;
            this.tabPageTeachers.Text = "Teachers";
            this.tabPageTeachers.UseVisualStyleBackColor = true;
            // 
            // dgvTeachers
            // 
            this.dgvTeachers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTeachers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeachers.Location = new System.Drawing.Point(3, 58);
            this.dgvTeachers.Name = "dgvTeachers";
            this.dgvTeachers.Size = new System.Drawing.Size(734, 241);
            this.dgvTeachers.TabIndex = 1;
            // 
            // statusStripTeachers
            // 
            this.statusStripTeachers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslTeachersCount});
            this.statusStripTeachers.Location = new System.Drawing.Point(3, 302);
            this.statusStripTeachers.Name = "statusStripTeachers";
            this.statusStripTeachers.Size = new System.Drawing.Size(734, 22);
            this.statusStripTeachers.TabIndex = 0;
            this.statusStripTeachers.Text = "statusStripTeachers";
            // 
            // tslTeachersCount
            // 
            this.tslTeachersCount.Name = "tslTeachersCount";
            this.tslTeachersCount.Size = new System.Drawing.Size(164, 17);
            this.tslTeachersCount.Text = "Количество преподавателей";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 353);
            this.Controls.Add(this.dataGridViewGroups);
            this.Name = "MainForm";
            this.Text = "Academy";
            this.tabPageGroups.ResumeLayout(false);
            this.tabPageGroups.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroups1)).EndInit();
            this.statusStripGroups.ResumeLayout(false);
            this.statusStripGroups.PerformLayout();
            this.tabPageStudents.ResumeLayout(false);
            this.tabPageStudents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.statusStripStudenrs.ResumeLayout(false);
            this.statusStripStudenrs.PerformLayout();
            this.dataGridViewGroups.ResumeLayout(false);
            this.tabPageTeachers.ResumeLayout(false);
            this.tabPageTeachers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeachers)).EndInit();
            this.statusStripTeachers.ResumeLayout(false);
            this.statusStripTeachers.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPageGroups;
        private System.Windows.Forms.Label lblGroupDirection;
        private System.Windows.Forms.ComboBox cbGroupsDirection;
        private System.Windows.Forms.DataGridView dgvGroups1;
        private System.Windows.Forms.StatusStrip statusStripGroups;
        private System.Windows.Forms.ToolStripStatusLabel tslGroupsCount;
        private System.Windows.Forms.TabPage tabPageStudents;
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.StatusStrip statusStripStudenrs;
        private System.Windows.Forms.ToolStripStatusLabel tslStudentsCount;
        private System.Windows.Forms.TabControl dataGridViewGroups;
        private System.Windows.Forms.TabPage tabPageTeachers;
        private System.Windows.Forms.StatusStrip statusStripTeachers;
        private System.Windows.Forms.ToolStripStatusLabel tslTeachersCount;
        private System.Windows.Forms.DataGridView dgvTeachers;
        private System.Windows.Forms.ComboBox cbStudentsDirection;
        private System.Windows.Forms.ComboBox cbStudentsGroup;
        private System.Windows.Forms.Label lblStudentsDirection;
        private System.Windows.Forms.Label lblStudentsGroup;
    }
}

