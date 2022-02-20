using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace CourseSheduleManagement.DataAccess
{
    public class DataAccessBase
    {
        public virtual SqlConnection Con()
        {
            return Eros();
        }
        private static SqlConnection Eros()
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString="Data Source=LAPTOP-CRA249F6;Initial Catalog=CourseSheduleManagement;Integrated Security=True";
            return connection;
        }

        public DataSet RunProcedureQuery(string procedurename, SqlParameter[] parameters)
        {
            SqlConnection cnn = Con();

            try
            {
                SqlCommand cmd = new SqlCommand(procedurename, cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 100000;

                if (cnn.State == ConnectionState.Open) cnn.Close();
                cnn.Open();

                for (int i = 0; i <= parameters.GetUpperBound(0); i++)
                {
                    cmd.Parameters.Add(parameters[i]);
                }

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                cnn.Close();
                return ds;
            }
            catch
            {
                throw;
            }
        }

        public DataSet RunProcedureQueryText(string procedurename, SqlParameter[] parameters)
        {
            try
            {
                SqlConnection cnn = Con();
                SqlCommand cmd = new SqlCommand(procedurename, cnn);
                cmd.CommandType = CommandType.Text;
                cmd.CommandTimeout = 100000;

                if (cnn.State == ConnectionState.Open) cnn.Close();
                cnn.Open();

                for (int i = 0; i <= parameters.GetUpperBound(0); i++)
                {
                    cmd.Parameters.Add(parameters[i]);
                }
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                cnn.Close();
                return ds;
            }
            catch
            {
                throw;

            }
        }

        public object RunProcedureScalar(string procedurename, SqlParameter[] parameters)
        {
            try
            {
                SqlConnection cnn = Con();

                SqlCommand cmd = new SqlCommand(procedurename, cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 100000;

                if (cnn.State == ConnectionState.Open) cnn.Close();
                cnn.Open();

                for (int i = 0; i <= parameters.GetUpperBound(0); i++)
                {
                    cmd.Parameters.Add(parameters[i]);
                }
                var result = cmd.ExecuteScalar();
                cnn.Close();
                return result;
            }
            catch
            {
                throw;

            }

        }


    }
}
