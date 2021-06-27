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
    public partial class FormBranch : Form
    {
        public FormBranch()
        {
            InitializeComponent();
        }

        private BranchDal _branchDal = new BranchDal();
     
        private void LoadBranch()
        {
            dgwBranch.DataSource = _branchDal.GetAll();
        }

       

        private void FormBranch_Load(object sender, EventArgs e)
        {
            LoadBranch();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserStart userStart = new UserStart();
            userStart.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _branchDal.Add(new Branch()
            {
                subeAd = tbxAddName.Text,
                sacikAdres = tbxAddAdress.Text,
                ilID = Convert.ToInt32(tbxAddil.Text)
            });
            LoadBranch();

            MessageBox.Show("Product Added!");

        }

        public void btnShow_Click(object sender, EventArgs e)
        {
           var a=tbxAddAdress.Text;
                
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
                Branch branch = new Branch
                {
                    subeID = Convert.ToInt32(dgwBranch.CurrentRow.Cells[0].Value),
                    subeAd = tbxUpdateName.Text,
                    ilID = Convert.ToInt32(tbxUpdateilId.Text),
                    sacikAdres = tbxUpdateAdress.Text
                };
                _branchDal.Update(branch);
                LoadBranch();
                MessageBox.Show("Updated");
            
        }

        private void dgwBranch_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxUpdateName.Text = dgwBranch.CurrentRow.Cells[1].Value.ToString();
            tbxUpdateilId.Text = dgwBranch.CurrentRow.Cells[3].Value.ToString();
            tbxUpdateAdress.Text = dgwBranch.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnBracnhDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgwBranch.CurrentRow.Cells[0].Value);
            _branchDal.Delete(id);
            LoadBranch();
            MessageBox.Show("Deleted");

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

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        
    }
}
