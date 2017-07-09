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
    }
}
