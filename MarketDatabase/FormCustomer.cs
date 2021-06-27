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
    public partial class FormCustomer : Form
    {

        CustomerDal customerDt = new CustomerDal();
        public FormCustomer()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormCustomer_Load(object sender, EventArgs e)
        {
            LoadCustomers();
        }

        public void LoadCustomers()
        {
             
                DataSet ds = customerDt.MusterileriCek();
                dataGridView1.DataSource = ds.Tables[0];
             
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
         comboBox1.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            MessageBox.Show("SIPARIS ID : "+ dataGridView1.CurrentRow.Cells[0].Value.ToString());
            Customer customerUpdt = new Customer
            {
                durum = comboBox1.Text,
                siparisID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value),

            };

            customerDt.Update(customerUpdt);
            LoadCustomers();
            MessageBox.Show("Updated");
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
