using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieTownFinalProject
{
    public partial class ManagerLogInForm : Form
    {
        public ManagerLogInForm()
        {
            InitializeComponent();
        }

        private void clientLoginButton_Click(object sender, EventArgs e)
        {
            HomePage homepage = new HomePage();
            homepage.ShowDialog();
            //TODO
            //Close the managerloginForm while opening the homepageForm
            //this.Close();
            
        }
    }
}
