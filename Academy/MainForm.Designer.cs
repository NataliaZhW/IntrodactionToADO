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
            this.dataGridViewGroups = new System.Windows.Forms.TabControl();
            this.tabPageStudents = new System.Windows.Forms.TabPage();
            this.tabPageGroups = new System.Windows.Forms.TabPage();
            this.statusStripGroups = new System.Windows.Forms.StatusStrip();
            this.statusStripStudenrs = new System.Windows.Forms.StatusStrip();
            this.tslStudentsCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslGroupsCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.dataGridViewStudents = new System.Windows.Forms.DataGridView();
            this.dataGridViewGroups1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewGroups.SuspendLayout();
            this.tabPageStudents.SuspendLayout();
            this.tabPageGroups.SuspendLayout();
            this.statusStripGroups.SuspendLayout();
            this.statusStripStudenrs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGroups1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewGroups
            // 
            this.dataGridViewGroups.Controls.Add(this.tabPageStudents);
            this.dataGridViewGroups.Controls.Add(this.tabPageGroups);
            this.dataGridViewGroups.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewGroups.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewGroups.Name = "dataGridViewGroups";
            this.dataGridViewGroups.SelectedIndex = 0;
            this.dataGridViewGroups.Size = new System.Drawing.Size(748, 353);
            this.dataGridViewGroups.TabIndex = 0;
            // 
            // tabPageStudents
            // 
            this.tabPageStudents.Controls.Add(this.dataGridViewStudents);
            this.tabPageStudents.Controls.Add(this.statusStripStudenrs);
            this.tabPageStudents.Location = new System.Drawing.Point(4, 22);
            this.tabPageStudents.Name = "tabPageStudents";
            this.tabPageStudents.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStudents.Size = new System.Drawing.Size(740, 327);
            this.tabPageStudents.TabIndex = 0;
            this.tabPageStudents.Text = "Students";
            this.tabPageStudents.UseVisualStyleBackColor = true;
            // 
            // tabPageGroups
            // 
            this.tabPageGroups.Controls.Add(this.dataGridViewGroups1);
            this.tabPageGroups.Controls.Add(this.statusStripGroups);
            this.tabPageGroups.Location = new System.Drawing.Point(4, 22);
            this.tabPageGroups.Name = "tabPageGroups";
            this.tabPageGroups.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGroups.Size = new System.Drawing.Size(740, 327);
            this.tabPageGroups.TabIndex = 1;
            this.tabPageGroups.Text = "Groups";
            this.tabPageGroups.UseVisualStyleBackColor = true;
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
            // tslGroupsCount
            // 
            this.tslGroupsCount.Name = "tslGroupsCount";
            this.tslGroupsCount.Size = new System.Drawing.Size(107, 17);
            this.tslGroupsCount.Text = "Количество групп";
            // 
            // dataGridViewStudents
            // 
            this.dataGridViewStudents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudents.Location = new System.Drawing.Point(3, 26);
            this.dataGridViewStudents.Name = "dataGridViewStudents";
            this.dataGridViewStudents.Size = new System.Drawing.Size(734, 273);
            this.dataGridViewStudents.TabIndex = 1;
            // 
            // dataGridViewGroups1
            // 
            this.dataGridViewGroups1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewGroups1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGroups1.Location = new System.Drawing.Point(8, 26);
            this.dataGridViewGroups1.Name = "dataGridViewGroups1";
            this.dataGridViewGroups1.Size = new System.Drawing.Size(726, 273);
            this.dataGridViewGroups1.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 353);
            this.Controls.Add(this.dataGridViewGroups);
            this.Name = "MainForm";
            this.Text = "Academy";
            this.dataGridViewGroups.ResumeLayout(false);
            this.tabPageStudents.ResumeLayout(false);
            this.tabPageStudents.PerformLayout();
            this.tabPageGroups.ResumeLayout(false);
            this.tabPageGroups.PerformLayout();
            this.statusStripGroups.ResumeLayout(false);
            this.statusStripGroups.PerformLayout();
            this.statusStripStudenrs.ResumeLayout(false);
            this.statusStripStudenrs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGroups1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl dataGridViewGroups;
        private System.Windows.Forms.TabPage tabPageStudents;
        private System.Windows.Forms.TabPage tabPageGroups;
        private System.Windows.Forms.StatusStrip statusStripStudenrs;
        private System.Windows.Forms.ToolStripStatusLabel tslStudentsCount;
        private System.Windows.Forms.StatusStrip statusStripGroups;
        private System.Windows.Forms.ToolStripStatusLabel tslGroupsCount;
        private System.Windows.Forms.DataGridView dataGridViewStudents;
        private System.Windows.Forms.DataGridView dataGridViewGroups1;
    }
}

