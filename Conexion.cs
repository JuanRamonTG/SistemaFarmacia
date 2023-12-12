using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data; 
using System.Data.SqlClient; 

namespace SistemaFarmacia
{
    class Conexion
    {
        SqlConnection aConexion = new SqlConnection(); //Conecta la base
        SqlCommand eComando = new SqlCommand(); //ejecutar consultas SQL en la base de datos.
        SqlDataAdapter iAdaptador = new SqlDataAdapter(); //Sirve como un intermediario entre la BD y la aplicacion.
        DataSet miDs = new DataSet(); //Es un contenedor en memoria.

        public Conexion()
        {
            String caConexion = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\db_clinica.mdf;Integrated Security=True";
            aConexion.ConnectionString = caConexion;
            aConexion.Open();
        }
        public DataSet obtenerDatos()
        {
            miDs.Clear();
            eComando.Connection = aConexion;

            eComando.CommandText = "select * from materias";
            iAdaptador.SelectCommand = eComando;
            iAdaptador.Fill(miDs, "materias");

            return miDs;
        }
        public String mantenimientoMaterias(String[] materias)
        {
            String sql = "";
            if (materias[0] == "nuevo")
            {
                sql = "INSERT INTO materias (codigo, materia, uv) VALUES('" + materias[1] + "', '" + materias[2] + "', '" +
                    materias[3] + "')";
            }
            else if (materias[0] == "modificar")
            {
                sql = "UPDATE materias SET codigo='" + materias[1] + "', materia='" + materias[2] + "', uv='" + materias[3] +
                    "' WHERE idMateria='" + materias[4] + "'";
            }
            else if (materias[0] == "eliminar")
            {
                sql = "DELETE FROM materias WHERE idMateria='" + materias[4] + "'";
            }
            return ejecutarSql(sql);
        }
        
        private string ejecutarSql(String sql)
        {
            try
            {
                eComando.CommandText = sql;
                eComando.Connection = aConexion;
                return eComando.ExecuteNonQuery().ToString();
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
    }


}
