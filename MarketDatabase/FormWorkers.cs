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
    public partial class FormWorkers : Form
    {
        public FormWorkers()
        {
            InitializeComponent();
        }

        private void FormWorkers_Load(object sender, EventArgs e)
        {
            LoadWorkersMyWay();
        }

        WorkersDal workersDatabase = new WorkersDal();
        Worker worker = new Worker();


        void LoadWorkersMyWay()
        {
            DataSet ds = workersDatabase.VeritabaniSelectIslemi();
            dtWorkers.DataSource = ds.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            worker.calisanAd = txtAd.Text;
            worker.calisanSoyad = txtSoyad.Text;
            worker.subeID = int.Parse(txtSubeID.Text);
            worker.maas = float.Parse(txtMaas.Text);
            worker.acikAdres = txtAdress.Text;
            worker.ilID = int.Parse(txtIl.Text);
            worker.mevki = cmbMevki.Text;
            workersDatabase.WorkerAdd(worker);
            LoadWorkersMyWay();


        }

        private void dtWorkers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUpdtName.Text = dtWorkers.CurrentRow.Cells[1].Value.ToString();
            txtUpdtMaas.Text = dtWorkers.CurrentRow.Cells[4].Value.ToString();
            cmbUpdtMevki.Text = dtWorkers.CurrentRow.Cells[7].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test" + cmbUpdtMevki.Text);
            Worker workerUpdate = new Worker
            {
                calisanId = Convert.ToInt32(dtWorkers.CurrentRow.Cells[0].Value),

                mevki = cmbUpdtMevki.Text,
                maas = float.Parse(txtUpdtMaas.Text)

            };

            workersDatabase.Update(workerUpdate);
            LoadWorkersMyWay();
            MessageBox.Show("Updated");

        }

        private void dtWorkers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dtWorkers.CurrentRow.Cells[0].Value);
            workersDatabase.Delete(id);
            LoadWorkersMyWay();
            MessageBox.Show("Deleted");
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            // Application.Exit();
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
