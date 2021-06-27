using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketDatabase
{
    class CustomerDal
    {
        static Connect snn = new Connect();
        public static SqlConnection _connection = new SqlConnection(snn.Adress);


        public DataSet MusterileriCek()
        {
            ConnectionControl();
            string sorgu = "SELECT* FROM musteriBilgi";
            SqlDataAdapter da = new SqlDataAdapter(sorgu, _connection);
            DataSet ds = new DataSet();
            da.Fill(ds);
            _connection.Close();
            return ds;
        }

        void ConnectionControl()
        {
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }
        }

        public void Update(Customer customer)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Update siparisDetay set siparisDurum=@siparisDurum where siparisID = @siparisID", _connection);
            command.Parameters.AddWithValue("@siparisDurum", customer.durum);
            command.Parameters.AddWithValue("@siparisID", customer.siparisID);




            command.ExecuteNonQuery();

            _connection.Close();

        }


    }
}
