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
            this.clickBtn2 = new System.Windows.Forms.Button();
            this.demoCheckBox = new System.Windows.Forms.CheckBox();
            this.clickBtn3 = new System.Windows.Forms.Button();
            this.clickBtn1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clickBtn2
            // 
            this.clickBtn2.Location = new System.Drawing.Point(54, 59);
            this.clickBtn2.Name = "clickBtn2";
            this.clickBtn2.Size = new System.Drawing.Size(94, 30);
            this.clickBtn2.TabIndex = 0;
            this.clickBtn2.Text = "Click2";
            this.clickBtn2.UseVisualStyleBackColor = true;
            // 
            // demoCheckBox
            // 
            this.demoCheckBox.AutoSize = true;
            this.demoCheckBox.Location = new System.Drawing.Point(54, 160);
            this.demoCheckBox.Name = "demoCheckBox";
            this.demoCheckBox.Size = new System.Drawing.Size(153, 17);
            this.demoCheckBox.TabIndex = 1;
            this.demoCheckBox.Text = "Add source code to Github";
            this.demoCheckBox.UseVisualStyleBackColor = true;
            // 
            // clickBtn3
            // 
            this.clickBtn3.Location = new System.Drawing.Point(54, 95);
            this.clickBtn3.Name = "clickBtn3";
            this.clickBtn3.Size = new System.Drawing.Size(94, 30);
            this.clickBtn3.TabIndex = 0;
            this.clickBtn3.Text = "Click3";
            this.clickBtn3.UseVisualStyleBackColor = true;
            // 
            // clickBtn1
            // 
            this.clickBtn1.Location = new System.Drawing.Point(54, 23);
            this.clickBtn1.Name = "clickBtn1";
            this.clickBtn1.Size = new System.Drawing.Size(94, 30);
            this.clickBtn1.TabIndex = 0;
            this.clickBtn1.Text = "Click1";
            this.clickBtn1.UseVisualStyleBackColor = true;
            // 
            // AIPro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.demoCheckBox);
            this.Controls.Add(this.clickBtn1);
            this.Controls.Add(this.clickBtn3);
            this.Controls.Add(this.clickBtn2);
            this.Name = "AIPro";
            this.Text = "AIProjectDemo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button clickBtn2;
        private System.Windows.Forms.CheckBox demoCheckBox;
        private System.Windows.Forms.Button clickBtn3;
        private System.Windows.Forms.Button clickBtn1;
    }
}

