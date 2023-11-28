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
        SqlConnection miConexion = new SqlConnection(); //Conectarme a  la BD
        SqlCommand miComando = new SqlCommand(); //ejecutar consultas SQL en la base de datos.
        SqlDataAdapter miAdaptador = new SqlDataAdapter(); //Sirve como un intermediario entre la BD y la aplicacion.
        DataSet miDs = new DataSet(); //Es una representacion grafica de la BD en memoria.

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

            miComando.CommandText = "select * from materias";
            miAdaptador.SelectCommand = miComando;
            miAdaptador.Fill(miDs, "materias");

            miComando.CommandText = "select * from alumnos";
            miAdaptador.SelectCommand = miComando;
            miAdaptador.Fill(miDs, "alumnos");

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
        public String mantenimientoAlumnos(String[] GestionPacientes)
        {
            String sql = "";
            if (GestionPacientes[0] == "nuevo")
            {
                sql = "INSERT INTO alumnos (codigo, nombre, direccion, telefono) VALUES('" + GestionPacientes[1] + "', '" + GestionPacientes[2] + "', '" +
                    GestionPacientes[3] + "', '" + GestionPacientes[4] + "')";
            }
            else if (GestionPacientes[0] == "modificar")
            {
                sql = "UPDATE alumnos SET codigo='" + GestionPacientes[1] + "', nombre='" + GestionPacientes[2] + "', direccion='" + GestionPacientes[3] +
                    "', telefono='" + GestionPacientes[4] + "' WHERE idAlumno='" + GestionPacientes[5] + "'";
            }
            else if (GestionPacientes[0] == "eliminar")
            {
                sql = "DELETE FROM alumnos WHERE idAlumno='" + GestionPacientes[5] + "'";
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
