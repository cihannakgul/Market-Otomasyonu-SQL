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
    public partial class FormStokAmountt : Form
    {

        StockAmountDal stokDt = new StockAmountDal();
        public FormStokAmountt()
        {
            InitializeComponent();
        }

        private void FormRayon_Load(object sender, EventArgs e)
        {
             StoklariGoster();
        }

        public void StoklariGoster()
        {
            DataSet ds = stokDt.StoklariCek();
            dataGridView1.DataSource = ds.Tables[0];
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
