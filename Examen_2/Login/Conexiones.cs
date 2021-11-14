using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Login
{
    class Conexiones
    {
        private SqlDataAdapter da;
        private DataTable ta;
        string query = string.Empty;

        public static SqlConnection conecta()
        {
            string cadena = ("server=GOMEZ\\SQLEXPRESS ; database=Soporte ; integrated security = true");
            SqlConnection conexion = new SqlConnection(cadena);
            conexion.Open();
            return conexion;
        }
        public void registra( string sql, SqlConnection con)//ejecuta un inssert en la base de datos 
        {
            if(con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            SqlDataAdapter sqlr;
            sqlr = new SqlDataAdapter(sql, con);
            sqlr.SelectCommand.CommandTimeout = 180;
            sqlr.SelectCommand.ExecuteNonQuery();
            con.Close();

        }

        public int entero(string sql, SqlConnection con)
        {
            int retorno = 0;
            try
            {
                DataTable dta = new DataTable();
                SqlDataAdapter dad;
                dad = new SqlDataAdapter(sql, con);
                dad.Fill(dta);
                if (dta.Rows.Count > 0)
                {
                    retorno = Convert.ToInt32(dta.Rows[0][0].ToString());
                }
                else
                {
                    retorno = 0;
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
            return retorno;
        }

        public DataTable table(string sql, SqlConnection con)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da;
            da = new SqlDataAdapter(sql, con);
            da.Fill(dt);
            con.Close();
            return dt;
        }
      

    }
}
