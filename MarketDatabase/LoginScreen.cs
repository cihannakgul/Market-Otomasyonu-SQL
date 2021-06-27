using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketDatabase
{
    public partial class LoginScreen : Form
    {

        public LoginScreen()
        {
            InitializeComponent();
        }

        private void btnMusteri_Click(object sender, EventArgs e)
        {
            FormCustomer form = new FormCustomer();
            this.Visible = false;
            form.ShowDialog();
            this.Visible = true;

        }

        private void btnSube_Click(object sender, EventArgs e)
        {
            FormBranch form = new FormBranch();
            this.Visible = false;
            form.ShowDialog();
            this.Visible = true;
        }

        private void btnUrun_Click(object sender, EventArgs e)
        {
            FormProduct form = new FormProduct();
            this.Visible = false;
            form.ShowDialog();
            this.Visible = true;
        }

        private void btnStok_Click(object sender, EventArgs e)
        {
            FormStokAmountt form = new FormStokAmountt();
            this.Visible = false;
            form.ShowDialog();
            this.Visible = true;
        }

        private void btnCalisan_Click(object sender, EventArgs e)
        {
            FormWorkers form = new FormWorkers();
            this.Visible = false;
            form.ShowDialog();
            this.Visible = true;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        int Move;
        int Mouse_X;
        int Mouse_Y;
        private void UserStart_MouseUp(object sender, MouseEventArgs e)
        {
            Move = 0;
        }

        private void UserStart_MouseDown(object sender, MouseEventArgs e)
        {
            Move = 1;
            Mouse_X = e.X;
            Mouse_Y = e.Y;
        }
        private void UserStart_MouseMove(object sender, MouseEventArgs e)
        {
            if (Move == 1)
            {
                this.SetDesktopLocation(MousePosition.X - Mouse_X, MousePosition.Y - Mouse_Y);
            }

        }

      
    }
}
