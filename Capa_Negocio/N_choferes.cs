using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;

namespace Capa_Negocio
{
    public class N_choferes
    {
        //Metodo mostrar que enlanza con la capa datos

            public  DataTable Mostrar()
            {
                
                return new D_choferes().Mostrar();
            }
        //Metodo buscar que enlanza con la capa datos

        public static DataTable Buscar(string textobuscar)
        {
            D_choferes chofer = new D_choferes();
            chofer.Textobuscar = textobuscar;
            return chofer.Buscar(chofer);
        }
            //Metodo insertar que enlanza con la capa datos
            public static string Insertar(string nombre, string apellido, DateTime fecha_nacimiento, string cedula)
            {
                D_choferes autobus = new D_choferes();
                autobus.Nombre = nombre;
                autobus.Apellido = apellido;
                autobus.Fecha_Nacimiento = fecha_nacimiento;
                autobus.Cedula = cedula;

                return autobus.Insertar(autobus);
            }
        //Metodo Editar que enlanza con la capa datos
        public static string Editar(int idchofer, string nombre, string apellido, DateTime fecha_nacimiento, string cedula)
        {
            D_choferes autobus = new D_choferes();
            autobus.IdChofer = idchofer;
            autobus.Nombre = nombre;
            autobus.Apellido = apellido;
            autobus.Fecha_Nacimiento = fecha_nacimiento;
            autobus.Cedula = cedula;

            return autobus.Editar(autobus);
        }
        //Metodo Eliminar que enlanza con la capa datos
        public static string Eliminar(int idchofer)
        {
            D_choferes autobus = new D_choferes();
            autobus.IdChofer = idchofer;
          
            return autobus.Eliminar(autobus);

        }
    }
}
