using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AIProjectTrial
{
    public partial class AIPro : Form
    {
        public AIPro()
        {
            InitializeComponent();
            
            clickBtn1.Click += new EventHandler(clickBtn_clicked);
            clickBtn2.Click += new EventHandler(clickBtn_clicked);
            clickBtn3.Click += new EventHandler(clickBtn_clicked);
            
            //demoCheckBox.Checked = true;
            demoCheckBox.CheckedChanged += new EventHandler(demoCheckBox_checkedChanged);
        }

        private void demoCheckBox_checkedChanged(object sender, EventArgs e)
        {
            if (demoCheckBox.Checked)
                MessageBox.Show("Git Box");
        }

        private void clickBtn_clicked(object sender, EventArgs e)
        {
            MessageBox.Show("OK!");
        }
    }
}
