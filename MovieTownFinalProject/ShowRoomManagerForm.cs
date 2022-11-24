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
    public partial class ShowRoomManagerForm : Form
    {
        public ShowRoomManagerForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Set the Size of the Back Arrow to the Size of the Button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShowRoomManagerForm_Load(object sender, EventArgs e)
        {
            backButton.BackgroundImageLayout = ImageLayout.Stretch;
        }

        /// <summary>
        /// Opens Selection Menu Form Form and Closes the Show Room Manager Form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backButton_Click(object sender, EventArgs e)
        {
            ManagerSelectMenuForm SelectMenu = new ManagerSelectMenuForm();
            this.Hide();
            SelectMenu.ShowDialog();
            this.Close();
        }


    }
}
