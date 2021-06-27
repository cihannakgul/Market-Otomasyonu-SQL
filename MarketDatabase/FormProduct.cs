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
    public partial class FormProduct : Form
    {
        ProductDal productDt = new ProductDal();
        Product urun = new Product();
        public FormProduct()
        {
            InitializeComponent();
        }

        private void FormProduct_Load(object sender, EventArgs e)
        {
            LoadProducts();
            LoadBranchs();
           // UrunAdlariniCek();
            UrunBilgileriniDoldur();
        }

        public void LoadProducts()
        {
            DataSet ds = productDt.UrunleriCek();
            dataGridView1.DataSource = ds.Tables[0];
        }



        public void UrunBilgileriniDoldur()
        {
            DataSet ds = productDt.UrunBilgileriniCek();
            dataGridView2.DataSource = ds.Tables[0];
        }

        public void LoadBranchs()
        {
            DataSet ds = productDt.SubeleriCek();
            comboBox1.DataSource = ds.Tables[0];
            comboBox1.DisplayMember = "subeId";
            
        }

        //public void UrunAdlariniCek()
        //{
        //    DataSet ds = productDt.UrunAdlariniCek();
        //    comboBox2.DataSource = ds.Tables[0];
        //    comboBox2.DisplayMember = "urunId";
        //}





        private void button1_Click(object sender, EventArgs e)
        {
            urun.urunId = int.Parse(textBox2.Text);
            urun.stokmiktari = int.Parse(textBox1.Text);
            urun.subeID = int.Parse(comboBox1.Text);
            productDt.ProductAdd(urun);
            LoadProducts();
            LoadBranchs();
           
            UrunBilgileriniDoldur();
            MessageBox.Show("Ürün başarıyla eklendi");

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox2.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormStokAmountt formaGec = new FormStokAmountt();

            
            formaGec.Show();
               


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
