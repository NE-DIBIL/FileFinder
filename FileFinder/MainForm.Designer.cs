
    partial class MainForm {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.status = new System.Windows.Forms.StatusStrip();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.pathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pathEditor = new System.Windows.Forms.ToolStripTextBox();
            this.searchPatternEditor = new System.Windows.Forms.ToolStripTextBox();
            this.regexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.totalFilesFoundLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.status.SuspendLayout();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // status
            // 
            this.status.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.totalFilesFoundLabel});
            this.status.Location = new System.Drawing.Point(0, 427);
            this.status.Name = "status";
            this.status.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.status.Size = new System.Drawing.Size(782, 26);
            this.status.TabIndex = 0;
            this.status.Text = "statusStrip1";
            // 
            // menu
            // 
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pathToolStripMenuItem,
            this.pathEditor,
            this.searchPatternEditor,
            this.regexToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(782, 31);
            this.menu.TabIndex = 1;
            this.menu.Text = "menuStrip1";
            // 
            // pathToolStripMenuItem
            // 
            this.pathToolStripMenuItem.Name = "pathToolStripMenuItem";
            this.pathToolStripMenuItem.Size = new System.Drawing.Size(54, 27);
            this.pathToolStripMenuItem.Text = "Path:";
            // 
            // pathEditor
            // 
            this.pathEditor.Name = "pathEditor";
            this.pathEditor.Size = new System.Drawing.Size(500, 27);
            // 
            // searchPatternEditor
            // 
            this.searchPatternEditor.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.searchPatternEditor.Name = "searchPatternEditor";
            this.searchPatternEditor.Size = new System.Drawing.Size(100, 27);
            // 
            // regexToolStripMenuItem
            // 
            this.regexToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.regexToolStripMenuItem.Name = "regexToolStripMenuItem";
            this.regexToolStripMenuItem.Size = new System.Drawing.Size(67, 27);
            this.regexToolStripMenuItem.Text = "Regex:";
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(0, 31);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(782, 396);
            this.treeView1.TabIndex = 2;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(171, 20);
            this.toolStripStatusLabel1.Text = "Всего найдено файлов:";
            // 
            // totalFilesFoundLabel
            // 
            this.totalFilesFoundLabel.Name = "totalFilesFoundLabel";
            this.totalFilesFoundLabel.Size = new System.Drawing.Size(17, 20);
            this.totalFilesFoundLabel.Text = "0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.status);
            this.Controls.Add(this.menu);
            this.MainMenuStrip = this.menu;
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.status.ResumeLayout(false);
            this.status.PerformLayout();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private StatusStrip status;
        private MenuStrip menu;
        private ToolStripTextBox pathEditor;
        private ToolStripTextBox searchPatternEditor;
        private TreeView treeView1;
    private ToolStripMenuItem pathToolStripMenuItem;
    private ToolStripMenuItem regexToolStripMenuItem;
    private ToolStripStatusLabel toolStripStatusLabel1;
    private ToolStripStatusLabel totalFilesFoundLabel;
}