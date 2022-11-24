using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieTownFinalProject
{
    public partial class MovieManagerForm : Form
    {
        public MovieManagerForm()
        {
            InitializeComponent();
        }

        private void MovieManagerForm_Load(object sender, EventArgs e)
        {
            backButton.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            ManagerSelectMenuForm SelectMenu = new ManagerSelectMenuForm();
            this.Hide();
            SelectMenu.ShowDialog();
            this.Close();
        }
    }
}
