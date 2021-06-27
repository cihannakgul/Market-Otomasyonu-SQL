using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketDatabase
{
    class BranchDal
    {
        static Connect snn = new Connect();
        public static SqlConnection _connection = new SqlConnection(snn.Adress);

        public List<Branch> GetAll()
        {

            ConnectionControl();
            
            //SqlCommand command = new SqlCommand("Select il,[şube adı] ,[açık adres],ilID From subeBilgi ,sube", _connection);
            //SqlCommand command = new SqlCommand("Select * From sube,il where sube.ilId=il.ilID",_connection);
            //SqlCommand command = new SqlCommand("Select * from sube union all select * from subeBilgi ", _connection);
             SqlCommand command = new SqlCommand("Select* from sube Inner join il On il.ilId=sube.ilId", _connection); //bu da view mantığında il de boşa gitmez view gözükür
            //SqlCommand command = new SqlCommand("Select * from sube union all subeBilgi",_connection);
            SqlDataReader reader = command.ExecuteReader();
            List<Branch> branchesList = new List<Branch>();

            while (reader.Read())
            {
                Branch branch = new Branch()
                {
                    subeID = Convert.ToInt32(reader["subeID"]),
                    Il = (reader["ilAdi"]).ToString(),
                    subeAd = reader["subeAd"].ToString(),
                    sacikAdres = reader["sacikAdres"].ToString(),
                    ilID = Convert.ToInt32(reader["ilID"])

                };
                //Branch branch = new Branch()
                //{
                //    Il = (reader["il"]).ToString(),
                //    SubeAdi = reader["Şube Adı"].ToString(),
                //    AcikAdres = reader["Açık Adres"].ToString(),
                //    //IlId = Convert.ToInt32(reader["ilID"])

                //};
                branchesList.Add(branch);
            }
            reader.Close();
            _connection.Close();
            return branchesList;

        }
        public void Add(Branch branch)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand(
                "Insert into sube values(@subeAd,@ilID,@sacikAdres)", _connection);
            
            command.Parameters.AddWithValue("@subeAd", branch.subeAd);
            command.Parameters.AddWithValue("@ilID", branch.ilID);
            command.Parameters.AddWithValue("@sacikAdres", branch.sacikAdres);
            command.ExecuteNonQuery();

            _connection.Close();
        }

        public void Update(Branch branch)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand(
                "Update sube set subeAd=@subeAd,ilID=@ilID,sacikAdres=@sacikAdres where subeID=@subeID", _connection);
            command.Parameters.AddWithValue("@subeAd", branch.subeAd);
            command.Parameters.AddWithValue("@sacikAdres", branch.sacikAdres);
            command.Parameters.AddWithValue("@ilID", branch.ilID);
            command.Parameters.AddWithValue("@subeID", branch.subeID);
            command.ExecuteNonQuery();

            _connection.Close();

        }
        public void Delete(int Id)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand(
                "Delete from sube where subeID=@subeID", _connection);
            command.Parameters.AddWithValue("@subeID", Id);
            command.ExecuteNonQuery();

            _connection.Close();

        }



        void ConnectionControl()
        {
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }
        }





    }
}