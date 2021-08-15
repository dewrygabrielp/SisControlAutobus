using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Capa_Datos
{
    public class D_rutas
    {
        private int _IdRuta;
        private string _Ruta;

        public int IdRuta { get => _IdRuta; set => _IdRuta = value; }
        public string Ruta { get => _Ruta; set => _Ruta = value; }

        //Constructor vacio
        public D_rutas()
        {
            //Vacio
        }
        //Constructor con parametros
        public D_rutas(int idruta, string ruta)
        {
            this.IdRuta = idruta;
            this.Ruta = ruta;
        }
        //metodos

        public string Insertar(D_rutas ruta)
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
                SqlCmd.CommandText = "sp_insertar_ruta";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdRuta = new SqlParameter();
                ParIdRuta.ParameterName = "@idruta";
                ParIdRuta.SqlDbType = SqlDbType.Int;
                ParIdRuta.Direction = ParameterDirection.Output;
                ParIdRuta.Value = ruta.IdRuta;

                SqlCmd.Parameters.Add(ParIdRuta);

                SqlParameter ParRuta = new SqlParameter();
                ParRuta.ParameterName = "@ruta";
                ParRuta.SqlDbType = SqlDbType.VarChar;

                ParRuta.Value = ruta.Ruta;
                SqlCmd.Parameters.Add(ParRuta);


                respuesta = SqlCmd.ExecuteNonQuery() == 1 ? "OK": "Revise que la ruta no esté registrada";

            }catch(Exception ex)
            {
                respuesta= ex.Message +  ex.StackTrace;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }

            return respuesta;
        }
        //Metodo editar
        public string Editar(D_rutas ruta)
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
                SqlCmd.CommandText = "sp_editar_ruta";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdRuta = new SqlParameter();
                ParIdRuta.ParameterName = "@idruta";
                ParIdRuta.SqlDbType = SqlDbType.Int;
                ParIdRuta.Value = ruta.IdRuta;
                SqlCmd.Parameters.Add(ParIdRuta);

                SqlParameter ParRuta = new SqlParameter();
                ParRuta.ParameterName = "@ruta";
                ParRuta.SqlDbType = SqlDbType.VarChar;
                ParRuta.Value = ruta.Ruta;
                SqlCmd.Parameters.Add(ParRuta);


                respuesta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO SE EDITO LA RUTA";

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
        //Metodo eliminar
        public string Eliminar(D_rutas ruta)
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
                SqlCmd.CommandText = "sp_eliminar_ruta";
                SqlCmd.CommandType = CommandType.StoredProcedure;
                SqlParameter ParIdRuta = new SqlParameter();
                ParIdRuta.ParameterName = "@idruta";
                ParIdRuta.SqlDbType = SqlDbType.Int;
                ParIdRuta.Value = ruta.IdRuta;
                SqlCmd.Parameters.Add(ParIdRuta);

                respuesta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO SE ELIMINO LA RUTA";

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
        public DataTable MostrarRuta()
        {
            DataTable dt = new DataTable("RUTAS");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "sp_mostrar_rutas";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter sqlData = new SqlDataAdapter(SqlCmd);
                sqlData.Fill(dt);

                return dt;
            }catch(Exception ex)
            {
                dt = null;
                Console.WriteLine("" + ex);
            }
            return dt;
        }
    }
   
}
