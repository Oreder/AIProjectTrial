namespace AIProjectTrial
{
    partial class AIPro
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.userBox = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.passBox = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.passwordEdt = new System.Windows.Forms.TextBox();
            this.usernameEdt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.removePanelBtn = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(248, 23);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(217, 126);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.userBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(209, 100);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Username";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // userBox
            // 
            this.userBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userBox.FormattingEnabled = true;
            this.userBox.Location = new System.Drawing.Point(3, 3);
            this.userBox.Name = "userBox";
            this.userBox.Size = new System.Drawing.Size(203, 94);
            this.userBox.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.passBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(209, 100);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Password";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // passBox
            // 
            this.passBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.passBox.FormattingEnabled = true;
            this.passBox.Location = new System.Drawing.Point(3, 3);
            this.passBox.Name = "passBox";
            this.passBox.Size = new System.Drawing.Size(203, 94);
            this.passBox.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.loginBtn);
            this.groupBox1.Controls.Add(this.passwordEdt);
            this.groupBox1.Controls.Add(this.usernameEdt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(14, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 126);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Login to Server ";
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(73, 85);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(100, 27);
            this.loginBtn.TabIndex = 2;
            this.loginBtn.Text = "Sign in";
            this.loginBtn.UseVisualStyleBackColor = true;
            // 
            // passwordEdt
            // 
            this.passwordEdt.Location = new System.Drawing.Point(73, 54);
            this.passwordEdt.Name = "passwordEdt";
            this.passwordEdt.Size = new System.Drawing.Size(100, 20);
            this.passwordEdt.TabIndex = 1;
            // 
            // usernameEdt
            // 
            this.usernameEdt.Location = new System.Drawing.Point(73, 25);
            this.usernameEdt.Name = "usernameEdt";
            this.usernameEdt.Size = new System.Drawing.Size(100, 20);
            this.usernameEdt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.Controls.Add(this.button1);
            this.flowLayoutPanel.Controls.Add(this.button2);
            this.flowLayoutPanel.Controls.Add(this.button3);
            this.flowLayoutPanel.Location = new System.Drawing.Point(12, 165);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(345, 145);
            this.flowLayoutPanel.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(84, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(165, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // removePanelBtn
            // 
            this.removePanelBtn.Location = new System.Drawing.Point(373, 166);
            this.removePanelBtn.Name = "removePanelBtn";
            this.removePanelBtn.Size = new System.Drawing.Size(75, 144);
            this.removePanelBtn.TabIndex = 3;
            this.removePanelBtn.Text = "Remove Panel";
            this.removePanelBtn.UseVisualStyleBackColor = true;
            this.removePanelBtn.Click += new System.EventHandler(this.removePanelBtn_Click);
            // 
            // AIPro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 322);
            this.Controls.Add(this.removePanelBtn);
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabControl1);
            this.Name = "AIPro";
            this.Text = "AIProjectDemo";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.flowLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListBox userBox;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox passBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.TextBox passwordEdt;
        private System.Windows.Forms.TextBox usernameEdt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button removePanelBtn;

    }
}

