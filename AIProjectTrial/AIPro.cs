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
        private string _user = "admin", _pass = "11235";

        public AIPro()
        {
            InitializeComponent();

            loginBtn.Click += new EventHandler(loginBtn_clicked);
            this.flowLayoutPanel.BackColor = Color.ForestGreen;
            this.BackColor = Color.Gold;

            this.MouseHover += new EventHandler(AI_FormMouseHover);
            this.MouseLeave += new EventHandler(AI_FormMouseLeave);
            this.MouseClick += AIPro_MouseClick;
        }

        private void AIPro_MouseClick(object sender, MouseEventArgs e)
        {
            this.BackColor = Color.PowderBlue;
        }

        private void AI_FormMouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.Gold;
        }

        private void AI_FormMouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.Firebrick;
        }

        private void loginBtn_clicked(object sender, EventArgs e)
        {
            string user = usernameEdt.Text,
                   pass = passwordEdt.Text;
            if (user == _user && pass == _pass)
            {
                user += " (*)";
                pass += " (*)";
                MessageBox.Show("SUCCESSFUL!", "Sign in options");
            }
            else
            {
                MessageBox.Show("FAIL!", "Sign in options");
            }
            
            userBox.Items.Add(user);
            passBox.Items.Add(pass);
        }

        private void removePanelBtn_Click(object sender, EventArgs e)
        {
            if (removePanelBtn.Text == "Remove Panel")
            {
                removePanelBtn.Text = "Undo Removing Panel";
                this.Controls.Remove(this.flowLayoutPanel);
            }
            else if (removePanelBtn.Text == "Undo Removing Panel")
            {
                // setting up FlowLayoutPanel
                FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel();
                flowLayoutPanel.BackColor = Color.OrangeRed;
                flowLayoutPanel.Location = new Point(12, 165);
                flowLayoutPanel.Size = new Size(345, 145);
                flowLayoutPanel.Controls.Add(new Button());
                flowLayoutPanel.Controls.Add(new Button());
                flowLayoutPanel.Controls.Add(new Button());

                // using Control
                this.Controls.Add(flowLayoutPanel);
                removePanelBtn.Text = "Remove Panel";
            }
        }

    }
}
