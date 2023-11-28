using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data; //Libreria para conectarme a base de datos...
using System.Data.SqlClient; //Libreria para manipular datos en SQLServer.

namespace SistemaFarmacia
{
    class Conexion
    {
        SqlConnection miConexion = new SqlConnection();
        SqlCommand miComando = new SqlCommand();
        SqlDataAdapter miAdaptador = new SqlDataAdapter();
        DataSet miDs = new DataSet();

        public Conexion()
        {
            String cadenaConexion = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\db_academico.mdf;Integrated Security=True";
            miConexion.ConnectionString = cadenaConexion;
            miConexion.Open();
        }

        public DataSet obtenerDatos()
        {
            miDs.Clear();
            miComando.Connection = miConexion;

            miComando.CommandText = "select * from pacientes"; // Cambiado a 'pacientes'
            miAdaptador.SelectCommand = miComando;
            miAdaptador.Fill(miDs, "pacientes"); // Cambiado a 'pacientes'

            return miDs;
        }

        public String mantenimientoPacientes(String[] pacientes) // Cambiado a 'mantenimientoPacientes'
        {
            String sql = "";
            if (pacientes[0] == "nuevo")
            {
                sql = "INSERT INTO pacientes (codigo, nombre, direccion, telefono) VALUES('" + pacientes[1] + "', '" + pacientes[2] + "', '" +
                    pacientes[3] + "', '" + pacientes[4] + "')";
            }
            else if (pacientes[0] == "modificar")
            {
                sql = "UPDATE pacientes SET codigo='" + pacientes[1] + "', nombre='" + pacientes[2] + "', direccion='" + pacientes[3] +
                    "', telefono='" + pacientes[4] + "' WHERE idPaciente='" + pacientes[5] + "'"; // Cambiado a 'idPaciente'
            }
            else if (pacientes[0] == "eliminar")
            {
                sql = "DELETE FROM pacientes WHERE idPaciente='" + pacientes[5] + "'"; // Cambiado a 'idPaciente'
            }
            return ejecutarSql(sql);
        }

        private string ejecutarSql(String sql)
        {
            try
            {
                miComando.CommandText = sql;
                miComando.Connection = miConexion;
                return miComando.ExecuteNonQuery().ToString();
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
    }


}
