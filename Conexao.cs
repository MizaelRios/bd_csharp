using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Conexao
    {

        SqlConnection con = new SqlConnection();
        //Construtor
        public Conexao()
        {
            con.ConnectionString = "Data Source=DESKTOP-UCJNEE6;Initial Catalog=Agenda;Integrated Security=True";
        }

        //Metodo conectar
        public SqlConnection conectar()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }
        //Metodo desconectar
        public void desconectar()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
