using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Security.Permissions;

namespace Capa_Datos
{
    public class D_Inscripcion
    {
        private string _Textobuscar;
        private int _IdInspcricion;
        private int _IdChofer;
        private int _IdRuta;
        private int _IdBus;
        private string _CodigoInsp;
        private string _Textobuscarruta;

        public string Textobuscar { get => _Textobuscar; set => _Textobuscar = value; }
        public int IdInspcricion { get => _IdInspcricion; set => _IdInspcricion = value; }
        public int IdChofer { get => _IdChofer; set => _IdChofer = value; }
        public int IdRuta { get => _IdRuta; set => _IdRuta = value; }
        public int IdBus { get => _IdBus; set => _IdBus = value; }
        public string CodigoInsp { get => _CodigoInsp; set => _CodigoInsp = value; }
        public string Textobuscarruta { get => _Textobuscarruta; set => _Textobuscarruta = value; }



        /// <summary>
        /// /Constructor vacio
        /// </summary>
        public D_Inscripcion()
        {
            //Vacio
        }
        //Constructor con parametros
        public D_Inscripcion(string textobuscar, int idinscripcion, string codigoinsp, int idruta, int idbus, int idchofer, string textobuscarruta)
        {
            this.Textobuscar = textobuscar;
            this.IdInspcricion = idinscripcion;
            this.CodigoInsp = codigoinsp;
            this.IdRuta = idruta;
            this.IdBus = idbus;
            this.IdChofer = idchofer;
            this.Textobuscarruta = textobuscarruta;
        }

        //Metodos
        public DataTable Mostrar()
        {
            DataTable dt = new DataTable("Inscripcion");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "sp_mostrar_inscripcion";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter SqlData = new SqlDataAdapter(SqlCmd);
                SqlData.Fill(dt);
            }
            catch (Exception ex)
            {
                dt = null;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return dt;
        }
        public string Insertar(D_Inscripcion inscripcion)
        {
            string respuesta = "";
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "sp_insertar_inscripcion";
                SqlCmd.CommandType = CommandType.StoredProcedure;



                SqlParameter ParIdChofer = new SqlParameter();
                ParIdChofer.ParameterName = "@idchofer";
                ParIdChofer.DbType = DbType.Int32;
                ParIdChofer.Direction = ParameterDirection.Input;
                ParIdChofer.Value = inscripcion.IdChofer;
                SqlCmd.Parameters.Add(ParIdChofer);

                SqlParameter ParIdBus = new SqlParameter();
                ParIdBus.ParameterName = "@idbus";
                ParIdBus.DbType = DbType.Int32;

                ParIdBus.Value = inscripcion.IdBus;
                SqlCmd.Parameters.Add(ParIdBus);

                SqlParameter ParIdRuta = new SqlParameter();
                ParIdRuta.ParameterName = "@idruta";
                ParIdRuta.DbType = DbType.Int32;

                ParIdRuta.Value = inscripcion.IdRuta;
                SqlCmd.Parameters.Add(ParIdRuta);

                respuesta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "Revise que el conductor  esté inactivo o autobus esté en desuso";
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
        public string Editar(D_Inscripcion inscripcion)
        {
            string respuesta = "";
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "sp_editar_inscripcion";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@idinscripcion";
                ParId.DbType = DbType.Int32;

                ParId.Value = inscripcion.IdInspcricion;
                SqlCmd.Parameters.Add(ParId);

                SqlParameter ParCodigo = new SqlParameter();
                ParCodigo.ParameterName = "@codigo";
                ParCodigo.SqlDbType = SqlDbType.VarChar;
                ParCodigo.Size = 50;

                ParCodigo.Value = inscripcion.CodigoInsp;
                SqlCmd.Parameters.Add(ParCodigo);

                SqlParameter ParIdChofer = new SqlParameter();
                ParIdChofer.ParameterName = "@idchofer";
                ParIdChofer.DbType = DbType.Int32;

                ParIdChofer.Value = inscripcion.IdChofer;
                SqlCmd.Parameters.Add(IdChofer);

                SqlParameter ParIdBus = new SqlParameter();
                ParIdBus.ParameterName = "@idbus";
                ParIdBus.DbType = DbType.Int32;

                ParIdChofer.Value = inscripcion.IdBus;
                SqlCmd.Parameters.Add(ParIdBus);

                SqlParameter ParIdRuta = new SqlParameter();
                ParIdRuta.ParameterName = "@idruta";
                ParIdRuta.DbType = DbType.Int32;

                ParIdRuta.Value = inscripcion.IdRuta;
                SqlCmd.Parameters.Add(ParIdRuta);

                respuesta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO SE EDITO INSCRITO";
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
        public string Eliminar(D_Inscripcion inscripcion)
        {
            string respuesta = "";
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "sp_eliminar_inscripcion";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@idinscripcion";
                ParId.DbType = DbType.Int32;

                ParId.Value = inscripcion.IdInspcricion;
                SqlCmd.Parameters.Add(ParId);


                respuesta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO SE ELIMINO";
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
        public DataTable BuscarInscrpcion(D_Inscripcion inscripcion)
        {
            DataTable dt = new DataTable("Inscripcion");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "sp_buscar_inscripcion";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextobuscar = new SqlParameter();
                ParTextobuscar.ParameterName = "@textobuscar";
                ParTextobuscar.SqlDbType = SqlDbType.VarChar;
                ParTextobuscar.Size = 50;
                ParTextobuscar.Value = inscripcion.Textobuscar;
                SqlCmd.Parameters.Add(ParTextobuscar);

                SqlDataAdapter SqlData = new SqlDataAdapter(SqlCmd);
                SqlData.Fill(dt);
            }
            catch (Exception ex)
            {
                dt = null;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return dt;
        }
        public string ReiniciarBD()
        {
            string respuesta = "";
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "sp_reiniciar_bd";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                if (Convert.ToBoolean(SqlCmd.ExecuteNonQuery()))
                { 
                    respuesta = "OK";
                }
                else
                {
                    respuesta = "REVISE NUEVAMENTE LOS DATOS";
                }
                
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
        ///Metodos estudiantes
        ///
        public string EliminarEstudiantes()
        {
            string respuesta = "";
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "sp_eliminar_estudiantes";
                SqlCmd.CommandType = CommandType.StoredProcedure;




                respuesta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "OK";
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
        public string InsertarEstudiantes()
        {
            string respuesta = "";
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "sp_insertar_estudiantes";
                SqlCmd.CommandType = CommandType.StoredProcedure;




                respuesta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "OK";
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
        public DataTable MostrarEstudiantes()
        {
            DataTable dt = new DataTable("ESTUDIANTES");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "sp_mostrar_estudiantes";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter SqlData = new SqlDataAdapter(SqlCmd);
                SqlData.Fill(dt);
            }
            catch (Exception ex)
            {
                dt = null;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return dt;
        }
        public DataTable BuscarRuta(D_Inscripcion inscripcion)
        {
            DataTable dt = new DataTable("ESTUDIANTES");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "sp_buscar_rutas";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextobuscar = new SqlParameter();
                ParTextobuscar.ParameterName = "@textobuscar";
                ParTextobuscar.SqlDbType = SqlDbType.VarChar;
                ParTextobuscar.Size = 50;
                ParTextobuscar.Value = inscripcion.Textobuscarruta;
                SqlCmd.Parameters.Add(ParTextobuscar);

                SqlDataAdapter SqlData = new SqlDataAdapter(SqlCmd);
                SqlData.Fill(dt);
            }
            catch (Exception ex)
            {
                dt = null;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return dt;
        }
    }
}
