using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
namespace MODEL
{
    public class Helper
    {
        string constr;
        public Helper(string constr)
        {
            this.constr = constr;

        }
        public Helper()
        {
            constr = ConfigurationManager.ConnectionStrings["dershaneConnStr"].ConnectionString;
        }


        public int ExecuteNonQuery(string sqlstr, CommandType type, SqlParameter[] paramdizi)
        {
            SqlConnection con = new SqlConnection(constr);
            SqlCommand cmd = new SqlCommand(sqlstr, con);
            cmd.CommandType = type;
            if (paramdizi != null)
                cmd.Parameters.AddRange(paramdizi);
      
                
            try
            {
                if (con.State != ConnectionState.Open)
                    con.Open();
                return cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {

                throw ex;
            }
            finally
            {
                if (con.State != ConnectionState.Closed)
                    con.Close();
            }
        }

        public object ExecuteScalar(string sqlstr, CommandType type, SqlParameter[] paramdizi)
        {
            SqlConnection con = new SqlConnection(constr);
            SqlCommand cmd = new SqlCommand(sqlstr, con);
            cmd.CommandType = type;
            if (paramdizi != null)
                cmd.Parameters.AddRange(paramdizi);

            try
            {
                if (con.State != ConnectionState.Open)
                    con.Open();
                return cmd.ExecuteScalar();
            }
            catch (SqlException ex)
            {

                throw ex;
            }
            finally
            {
                if (con.State != ConnectionState.Closed)
                   con.Close();
            }
        }

        public SqlDataReader ExecuteReader(string sqlstr, CommandType type, SqlParameter[] paramdizi)
        {
            SqlConnection con = new SqlConnection(constr);
            SqlConnection.ClearPool(con);
            SqlConnection.ClearAllPools();
            SqlCommand cmd = new SqlCommand(sqlstr, con);
            cmd.CommandType = type;
            if (paramdizi != null)
                cmd.Parameters.AddRange(paramdizi);

            try
            {
                if (con.State != ConnectionState.Open)
                    con.Open();
                return cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }
    }
}