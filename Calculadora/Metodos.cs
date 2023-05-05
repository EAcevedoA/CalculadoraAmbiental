using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class Metodos : Conexion
    {
        private SqlDataReader registro;
        private SqlConnection con;
        public Metodos()
        {
            this.con = getConexion();
        }

        public SqlDataReader LeerDatos()
        {
            conectar();
            String sql = "select * from mensual;";
            SqlCommand comando = new SqlCommand(sql, this.con);
            this.registro = comando.ExecuteReader();
            return this.registro;
        }
    }
}
