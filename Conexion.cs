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

            eComando.CommandText = "select * from GestionPacientes";
            iAdaptador.SelectCommand = eComando;
            iAdaptador.Fill(miDs, "GestionPacientes");

            return miDs;
        }
        public String mantenimientoMaterias(String[] GestionPacientes)
        {
            String sql = "";
            if (GestionPacientes[0] == "nuevo")
            {
                sql = "INSERT INTO GestionPacientes (codigo, nombre, direccion, telefono) VALUES('" + GestionPacientes[1] + "', '" + GestionPacientes[2] + "', '" + GestionPacientes[3] + "', '" +
                    GestionPacientes[4] + "')";
            }
            else if (GestionPacientes[0] == "modificar")
            {
                sql = "UPDATE GestionPacientes SET codigo='" + GestionPacientes[1] + "', nombre='" + GestionPacientes[2] + "', direccion='" + GestionPacientes[3] + "', telefono='" + GestionPacientes[4] +
                    "' WHERE idPacientes='" + GestionPacientes[5] + "'";
            }
            else if (GestionPacientes[0] == "eliminar")
            {
                sql = "DELETE FROM GestionPacientes WHERE idPacientes='" + GestionPacientes[4] + "'";
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
