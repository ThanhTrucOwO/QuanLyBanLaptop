using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class PhieuYeuCauNhapHangDAO
    {
        private Connect conn = new Connect();

        public void addCoupon(PhieuYeuCauNhapHang p)
        {
            conn.Conn.Open();
            SqlCommand command = new SqlCommand("Proc_addCoupon", conn.Conn);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@idCoupon", p.IdCoupon);
            command.Parameters.AddWithValue("@dateAdded", p.DateAdded);
            command.Parameters.AddWithValue("@intoMoney", p.IntoMoney);
            command.Parameters.AddWithValue("@idSupplier", p.IdSupplier);


            command.ExecuteReader();
            conn.Conn.Close();  

        }
        public void updateCoupon(PhieuYeuCauNhapHang p)
        {
            conn.Conn.Open();
            SqlCommand command = new SqlCommand("Proc_updateCoupon", conn.Conn);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@idCoupon", p.IdCoupon);
            command.Parameters.AddWithValue("@dateAdded", p.DateAdded);
            command.Parameters.AddWithValue("@intoMoney", p.IntoMoney);
            command.Parameters.AddWithValue("@idSupplier", p.IdSupplier);
            command.ExecuteReader();
            conn.Conn.Close();
        }
        public void deleteCoupon(int id)
        {
            conn.Conn.Open();
            SqlCommand command = new SqlCommand("Proc_deleteCoupon", conn.Conn);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@idCoupon", id);
            command.ExecuteReader();
            conn.Conn.Close();
        }
        public List<PhieuYeuCauNhapHang> listCoupon()
        {
            List<PhieuYeuCauNhapHang> listCoupon = new List<PhieuYeuCauNhapHang>();
            SqlCommand command = new SqlCommand();
            conn.Conn.Open();
            command.Connection = conn.Conn;
            string query = "select * from Tbl_PhieuYeuCauNhapHang";
            command.CommandText = query;
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    int idCoupon = int.Parse(reader["idCoupon"].ToString());
                    DateTime dateAdded = DateTime.Parse(reader["dateAdded"].ToString());
                    float intoMoney = float.Parse(reader["intoMoney"].ToString());
                    string idSupplier = reader["idSupplier"].ToString();
                    PhieuYeuCauNhapHang phieuYeuCauNhapHang = new PhieuYeuCauNhapHang(idCoupon, dateAdded, intoMoney, idSupplier);
                    listCoupon.Add(phieuYeuCauNhapHang);

                }
            }

            conn.Conn.Close();
            reader.Close();
            return listCoupon;
        }
        public PhieuYeuCauNhapHang coupon(int idCoupon)
        {
            PhieuYeuCauNhapHang phieuYeuCauNhapHang = null;
            SqlCommand command = new SqlCommand();
            conn.Conn.Open();
            command.Connection = conn.Conn;
            string query = "select * from Tbl_PhieuYeuCauNhapHang where idCoupon =@idCoupon";
            command.CommandText = query;
            command.Parameters.AddWithValue("@idCoupon", idCoupon + "");
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                   
                    DateTime dateAdded = DateTime.Parse(reader["dateAdded"].ToString());
                    float intoMoney = float.Parse(reader["intoMoney"].ToString());
                    string idSupplier = reader["idSupplier"].ToString();
                    phieuYeuCauNhapHang = new PhieuYeuCauNhapHang(idCoupon, dateAdded, intoMoney, idSupplier);

                }
            }

            conn.Conn.Close();
            reader.Close();
            return phieuYeuCauNhapHang;
        }
    }
}
