namespace PaintDemo
{
    partial class PaintDemo
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
            this.menuPaintDemo = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.pnTail = new System.Windows.Forms.Panel();
            this.labelCo = new System.Windows.Forms.Label();
            this.pnTitle = new System.Windows.Forms.Panel();
            this.pnLeft = new System.Windows.Forms.Panel();
            this.pnRight = new System.Windows.Forms.Panel();
            this.chooseColorBtn = new System.Windows.Forms.Button();
            this.menuPaintDemo.SuspendLayout();
            this.pnTail.SuspendLayout();
            this.pnTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPaintDemo
            // 
            this.menuPaintDemo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.editToolStripMenuItem});
            this.menuPaintDemo.Location = new System.Drawing.Point(0, 0);
            this.menuPaintDemo.Name = "menuPaintDemo";
            this.menuPaintDemo.Size = new System.Drawing.Size(752, 24);
            this.menuPaintDemo.TabIndex = 0;
            this.menuPaintDemo.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItem1.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.newToolStripMenuItem.Text = "&New";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "&Open";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.toolStripMenuItem3});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.undoToolStripMenuItem.Text = "&Undo";
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.redoToolStripMenuItem.Text = "&Redo";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(106, 22);
            this.toolStripMenuItem3.Text = "R&esize";
            // 
            // pnTail
            // 
            this.pnTail.BackColor = System.Drawing.Color.Green;
            this.pnTail.Controls.Add(this.labelCo);
            this.pnTail.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnTail.Location = new System.Drawing.Point(0, 383);
            this.pnTail.Name = "pnTail";
            this.pnTail.Size = new System.Drawing.Size(752, 21);
            this.pnTail.TabIndex = 1;
            // 
            // labelCo
            // 
            this.labelCo.AutoSize = true;
            this.labelCo.Location = new System.Drawing.Point(8, 5);
            this.labelCo.Name = "labelCo";
            this.labelCo.Size = new System.Drawing.Size(0, 13);
            this.labelCo.TabIndex = 0;
            // 
            // pnTitle
            // 
            this.pnTitle.BackColor = System.Drawing.Color.OrangeRed;
            this.pnTitle.Controls.Add(this.chooseColorBtn);
            this.pnTitle.Controls.Add(this.pnRight);
            this.pnTitle.Controls.Add(this.pnLeft);
            this.pnTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTitle.Location = new System.Drawing.Point(0, 24);
            this.pnTitle.Name = "pnTitle";
            this.pnTitle.Size = new System.Drawing.Size(752, 72);
            this.pnTitle.TabIndex = 2;
            // 
            // pnLeft
            // 
            this.pnLeft.BackColor = System.Drawing.Color.Black;
            this.pnLeft.Location = new System.Drawing.Point(570, 11);
            this.pnLeft.Name = "pnLeft";
            this.pnLeft.Size = new System.Drawing.Size(52, 50);
            this.pnLeft.TabIndex = 0;
            this.pnLeft.Click += new System.EventHandler(this.pnLeft_Click);
            // 
            // pnRight
            // 
            this.pnRight.BackColor = System.Drawing.Color.White;
            this.pnRight.Location = new System.Drawing.Point(628, 29);
            this.pnRight.Name = "pnRight";
            this.pnRight.Size = new System.Drawing.Size(34, 32);
            this.pnRight.TabIndex = 0;
            this.pnRight.Click += new System.EventHandler(this.pnRight_Click);
            // 
            // chooseColorBtn
            // 
            this.chooseColorBtn.Location = new System.Drawing.Point(668, 3);
            this.chooseColorBtn.Name = "chooseColorBtn";
            this.chooseColorBtn.Size = new System.Drawing.Size(81, 66);
            this.chooseColorBtn.TabIndex = 1;
            this.chooseColorBtn.Text = "    Choose      color";
            this.chooseColorBtn.UseVisualStyleBackColor = true;
            this.chooseColorBtn.Click += new System.EventHandler(this.chooseColorBtn_Click);
            // 
            // PaintDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 404);
            this.Controls.Add(this.pnTitle);
            this.Controls.Add(this.pnTail);
            this.Controls.Add(this.menuPaintDemo);
            this.MainMenuStrip = this.menuPaintDemo;
            this.Name = "PaintDemo";
            this.Text = "Paint";
            this.menuPaintDemo.ResumeLayout(false);
            this.menuPaintDemo.PerformLayout();
            this.pnTail.ResumeLayout(false);
            this.pnTail.PerformLayout();
            this.pnTitle.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuPaintDemo;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.Panel pnTail;
        private System.Windows.Forms.Label labelCo;
        private System.Windows.Forms.Panel pnTitle;
        private System.Windows.Forms.Button chooseColorBtn;
        private System.Windows.Forms.Panel pnRight;
        private System.Windows.Forms.Panel pnLeft;
    }
}

