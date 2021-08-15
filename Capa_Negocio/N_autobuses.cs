using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Capa_Datos;

namespace Capa_Negocio
{
    public class N_autobuses
    {

        //Metodo insertar que enlanza con la capa datos
        public static string Insertar( string marca, string modelo, string placa, string color, DateTime ano)
        {
            D_autobuses autobus = new D_autobuses();
            autobus.Marca = marca;
            autobus.Modelo = modelo;
            autobus.Placa = placa;
            autobus.Color = color;
            autobus.Ano = ano;
            return autobus.Insertar(autobus);
        }
        //Metodo Editar que enlanza con la capa datos
        public static string Editar(int idbus, string marca, string modelo, string placa, string color, DateTime ano)
        {
            D_autobuses autobus = new D_autobuses();
            autobus.IdBus = idbus;
            autobus.Marca = marca;
            autobus.Modelo = modelo;
            autobus.Placa = placa;
            autobus.Color = color;
            autobus.Ano = ano;
            return autobus.Editar(autobus);
        }

        //Metodo Eliminar que enlanza con la capa datos

        public static string Eliminar(int idbus)
        {
            D_autobuses autobus = new D_autobuses();
            autobus.IdBus = idbus;
         
            return autobus.Eliminar(autobus);
        }
        //Metodo mostrar
        public DataTable MostrarAutobus()
        {
            return new D_autobuses().MostrarBus();
        }
    }
}
