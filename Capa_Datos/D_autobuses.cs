using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Capa_Datos
{
   public class D_autobuses
    {
        private int _IdBus;
        private string _Marca;
        private string _Modelo;
        private string _Placa;
        private string _Color;
        private DateTime _Ano;

        public int IdBus { get => _IdBus; set => _IdBus = value; }
        public string Marca { get => _Marca; set => _Marca = value; }
        public string Modelo { get => _Modelo; set => _Modelo = value; }
        public string Placa { get => _Placa; set => _Placa = value; }
        public string Color { get => _Color; set => _Color = value; }
        public DateTime Ano { get => _Ano; set => _Ano = value; }

        //Constructor vacio

        public D_autobuses()
        {
            //Sin codigo
        }
        //Constructor con parametros
        public D_autobuses( int idbus, string marca, string modelo, string placa, string color, DateTime ano)
        {
            this.IdBus = idbus;
            this.Marca = marca;
            this.Modelo = modelo;
            this.Placa = placa;
            this.Color = color;
            this.Ano = ano;
        }

        //Metodos 

        //Metodo Insertar

        public string Insertar(D_autobuses autobus)
        {
            string respuesta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Codigo

                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();

                SqlCommand SqlCmd = new  SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "sp_insertar_bus";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdBus = new SqlParameter();
                ParIdBus.ParameterName = "@idautobus";
                ParIdBus.SqlDbType = SqlDbType.Int;
                ParIdBus.Direction = ParameterDirection.Output;

                ParIdBus.Value = autobus.Marca;
                SqlCmd.Parameters.Add(ParIdBus);

                SqlParameter ParMarca = new SqlParameter();
                ParMarca.ParameterName = "@marca";
                ParMarca.SqlDbType = SqlDbType.VarChar;
                ParMarca.Size = 50;
                ParMarca.Value = autobus.Marca;
                SqlCmd.Parameters.Add(ParMarca);

                SqlParameter ParModelo = new SqlParameter();
                ParModelo.ParameterName = "@modelo";
                ParModelo.SqlDbType = SqlDbType.VarChar;
                ParModelo.Size = 50;
                ParModelo.Value = autobus.Modelo;
                SqlCmd.Parameters.Add(ParModelo);

                SqlParameter ParPlaca = new SqlParameter();
                ParPlaca.ParameterName = "@placa";
                ParPlaca.SqlDbType = SqlDbType.VarChar;
                ParPlaca.Size = 9;
                ParPlaca.Value = autobus.Placa;
                SqlCmd.Parameters.Add(ParPlaca);

                SqlParameter ParColor= new SqlParameter();
                ParColor.ParameterName = "@color";
                ParColor.SqlDbType = SqlDbType.VarChar;
                ParColor.Size = 10;
                ParColor.Value = autobus.Color;
                SqlCmd.Parameters.Add(ParColor);

                SqlParameter ParAno = new SqlParameter();
                ParAno.ParameterName = "@ano";
                ParAno.SqlDbType = SqlDbType.DateTime;
                
                ParAno.Value = autobus.Ano;
                SqlCmd.Parameters.Add(ParAno);

                respuesta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO SE INSERTO EL REGISTRO";
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
        //Metodo Editar
        public string Editar(D_autobuses autobus)
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
                SqlCmd.CommandText = "sp_editar_bus";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdBus = new SqlParameter();
                ParIdBus.ParameterName = "@idautobus";
                ParIdBus.SqlDbType = SqlDbType.Int;

                ParIdBus.Value = autobus.IdBus;
                SqlCmd.Parameters.Add(ParIdBus);

                SqlParameter ParMarca = new SqlParameter();
                ParMarca.ParameterName = "@marca";
                ParMarca.SqlDbType = SqlDbType.VarChar;
                ParMarca.Size = 50;
                ParMarca.Value = autobus.Marca;
                SqlCmd.Parameters.Add(ParMarca);

                SqlParameter ParModelo = new SqlParameter();
                ParModelo.ParameterName = "@modelo";
                ParModelo.SqlDbType = SqlDbType.VarChar;
                ParModelo.Size = 50;
                ParModelo.Value = autobus.Modelo;
                SqlCmd.Parameters.Add(ParModelo);

                SqlParameter ParPlaca = new SqlParameter();
                ParPlaca.ParameterName = "@placa";
                ParPlaca.SqlDbType = SqlDbType.VarChar;
                ParPlaca.Size = 9;
                ParPlaca.Value = autobus.Placa;
                SqlCmd.Parameters.Add(ParPlaca);

                SqlParameter ParColor = new SqlParameter();
                ParColor.ParameterName = "@color";
                ParColor.SqlDbType = SqlDbType.VarChar;
                ParColor.Size = 10;
                ParColor.Value = autobus.Color;
                SqlCmd.Parameters.Add(ParColor);

                SqlParameter ParAno = new SqlParameter();
                ParAno.ParameterName = "@ano";
                ParAno.SqlDbType = SqlDbType.DateTime;

                ParAno.Value = autobus.Ano;
                SqlCmd.Parameters.Add(ParAno);

                respuesta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "El número de placa ya está registrado";
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
        //Metodo Eliminar
        public string Eliminar(D_autobuses autobus)
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
                SqlCmd.CommandText = "sp_eliminar_bus";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdBus = new SqlParameter();
                ParIdBus.ParameterName = "@idautobus";
                ParIdBus.SqlDbType = SqlDbType.Int;

                ParIdBus.Value = autobus.IdBus;
                SqlCmd.Parameters.Add(ParIdBus);

                

                respuesta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO SE ElIMINO EL REGISTRO";
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
        //Mostrar autobus

        public DataTable MostrarBus()
        {
            DataTable dt = new DataTable("AUTOBUS");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "sp_mostrar_autobus";
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
    }
}
