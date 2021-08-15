using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Capa_Datos
{
   public class D_choferes
    {
        private string _Textobuscar;
        private int _IdChofer;
        private string _Nombre;
        private string _Apellido;
        private DateTime _Fecha_Nacimiento;
        private string _Cedula;

        // propiedades

        public string Textobuscar { get => _Textobuscar; set => _Textobuscar = value; }
        public int IdChofer { get => _IdChofer; set => _IdChofer = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Apellido { get => _Apellido; set => _Apellido = value; }
        public DateTime Fecha_Nacimiento { get => _Fecha_Nacimiento; set => _Fecha_Nacimiento = value; }
        public string Cedula { get => _Cedula; set => _Cedula = value; }

        // Constructor sin parametros
        public D_choferes()
        {

        }

       
        // Constructor con parametros
        public D_choferes(string textobuscar, int idchofer, string nombre, string apellido, DateTime fecha_nacimiento, string cedula)
        {
            this.Textobuscar = textobuscar;
            this.IdChofer = idchofer;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Fecha_Nacimiento = fecha_nacimiento;
            this.Cedula = cedula;
        }

              //Metodos que se enlazan con Sql server

        public DataTable Mostrar()
        {
            DataTable dt = new DataTable("CHOFER");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                // Codigo

                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "sp_mostrar_chofer";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter sqlData = new SqlDataAdapter(SqlCmd);
                sqlData.Fill(dt);

            }
            catch(Exception ex)
            {
                dt = null;
                
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return dt;
            
        }
         //Metodo buscar por nombre del chofer

        public DataTable Buscar(D_choferes chofer)
        {
            DataTable dt = new DataTable("CHOFER");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "sp_buscar_inscripcion";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter SqlData = new SqlDataAdapter(SqlCmd);
                SqlData.Fill(dt);
            }
            catch(Exception ex)
            {
                dt = null;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return dt;
        }
        //Metodo Insertar choferes

        public string Insertar(D_choferes chofer)
        {
            string respuesta = "";
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                //Codigo
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "sp_insertar_chofer";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@idchofer";
                ParId.DbType = DbType.Int32;
                ParId.Direction = ParameterDirection.Output;
                ParId.Value = chofer.IdChofer;
                SqlCmd.Parameters.Add(ParId);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@nombre";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 50;
                ParNombre.Value = chofer.Nombre;
                SqlCmd.Parameters.Add(ParNombre);

                SqlParameter ParApellido = new SqlParameter();
                ParApellido.ParameterName = "@apellido";
                ParApellido.SqlDbType = SqlDbType.VarChar;
                ParApellido.Size = 50;
                ParApellido.Value = chofer.Apellido;
                SqlCmd.Parameters.Add(ParApellido);
                
                SqlParameter ParFecha_Nac = new SqlParameter();
                ParFecha_Nac.ParameterName = "@fecha_nac";
                ParFecha_Nac.DbType = DbType.DateTime;
                ParFecha_Nac.Value = chofer.Fecha_Nacimiento;
                SqlCmd.Parameters.Add(ParFecha_Nac);

                SqlParameter ParCedula = new SqlParameter();
                ParCedula.ParameterName = "@cedula";
                ParCedula.SqlDbType = SqlDbType.VarChar;
                ParCedula.Size = 15;
                ParCedula.Value = chofer.Cedula;
                SqlCmd.Parameters.Add(ParCedula);


             
                respuesta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "El doc. de identidad ya ha sido registrado en la base de datos.";

            }
            catch(Exception ex)
            {
                respuesta = ex.Message + ex.StackTrace;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }

            return respuesta;
        }
        //Metodo Editar choferes
        public string Editar(D_choferes chofer)
        {
            string respuesta = "";
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                //Codigo
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "sp_editar_chofer";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@idchofer";
                ParId.DbType = DbType.Int32;

                ParId.Value = chofer.IdChofer;
                SqlCmd.Parameters.Add(ParId);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@nombre";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 50;
                ParNombre.Value = chofer.Nombre;
                SqlCmd.Parameters.Add(ParNombre);

                SqlParameter ParApellido = new SqlParameter();
                ParApellido.ParameterName = "@apellido";
                ParApellido.SqlDbType = SqlDbType.VarChar;
                ParApellido.Size = 50;
                ParApellido.Value = chofer.Apellido;
                SqlCmd.Parameters.Add(ParApellido);

                SqlParameter ParFecha_Nac = new SqlParameter();
                ParFecha_Nac.ParameterName = "@fecha_nac";
                ParFecha_Nac.DbType = DbType.DateTime;
                ParFecha_Nac.Value = chofer.Fecha_Nacimiento;
                SqlCmd.Parameters.Add(ParFecha_Nac);

                SqlParameter ParCedula = new SqlParameter();
                ParCedula.ParameterName = "@cedula";
                ParCedula.SqlDbType = SqlDbType.VarChar;
                ParCedula.Size = 15;
                ParCedula.Value = chofer.Cedula;
                SqlCmd.Parameters.Add(ParCedula);

                respuesta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO SE EDITO EL REGISTRO";

            }
            catch (Exception ex)
            {
                respuesta = ex.Message + ex.StackTrace;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }

            return respuesta;
        }
        //Metodo Editar choferes
        public string Eliminar(D_choferes chofer)
        {
            string respuesta = "";
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                //Codigo
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "sp_eliminar_chofer";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@idchofer";
                ParId.DbType = DbType.Int32;

                ParId.Value = chofer.IdChofer;
                SqlCmd.Parameters.Add(ParId);



                respuesta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO SE ELIMINO EL REGISTRO";

            }
            catch (Exception ex)
            {
                respuesta = ex.Message + ex.StackTrace;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }

            return respuesta;
        }

    }

    





}
