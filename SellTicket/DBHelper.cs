using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SellTicket
{
    class DBHelper
    {
        //307学生-0040\SQLEXPRESS
        public string con = @"server=.;initial catalog=CinemaTickets;uid=sa;pwd=123456";
        public SqlConnection conn;

        public void Open()
        {
            if (conn == null)
                conn = new SqlConnection(con);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
        }
        public void Close()
        {
            if (conn==null)
                return;
            if (conn.State == ConnectionState.Open)
                conn.Close();       
        }
        public SqlDataReader GetData(string sql)
        {
            Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            return cmd.ExecuteReader();
        }
        public DataSet GetDataSet(string sql)
        {
            Open();
            SqlDataAdapter asd = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            asd.Fill(ds);
            Close();
            return ds;
        }
        public int Updata(string sql)
        {
            Open();
            SqlCommand cmd = new SqlCommand(sql,conn);        
            return cmd.ExecuteNonQuery();
        }
    }
}
