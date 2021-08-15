using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Capa_Datos;


namespace Capa_Negocio
{
   public class N_rutas
    {
        //Metodo Insertar que enlaza con la capa datos

        public static string Insertar(string ruta)
        {
            D_rutas ObjNegocioruta = new D_rutas();
            
            ObjNegocioruta.Ruta = ruta;

            return ObjNegocioruta.Insertar(ObjNegocioruta);
        }
        //Metodo Editar que enlaza con la capa datos

        public static  string Editar(int idruta, string ruta)
        {
            D_rutas ObjNegocioruta = new D_rutas();
            ObjNegocioruta.IdRuta = idruta;
            ObjNegocioruta.Ruta = ruta;

            return ObjNegocioruta.Editar(ObjNegocioruta);
        }
        //Metodo Eliminar que enlaza con la capa datos

        public  static string Eliminar(int idruta)
        {
            D_rutas ObjNegocioruta = new D_rutas();
            ObjNegocioruta.IdRuta = idruta;
            

            return ObjNegocioruta.Eliminar(ObjNegocioruta);
        }
        public static  DataTable MostrarRutas()
        {
            return new D_rutas().MostrarRuta();
        }
    }
}
