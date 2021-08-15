using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;
using System.Data;

namespace Capa_Negocio
{
   public class N_Inscripcion
    {
        public static DataTable MostrarDatos()
        {
            return new D_Inscripcion().Mostrar();
        }
        public static string Insertar( int idchofer, int idbus, int idruta)
        {
            D_Inscripcion ObjDato = new D_Inscripcion();
            
            ObjDato.IdChofer = idchofer;
            ObjDato.IdBus = idbus;
            ObjDato.IdRuta = idruta;

            return ObjDato.Insertar(ObjDato);
        }
        public static string Editar(int idinscripcion,string codigoinsp, int idchofer, int idbus, int idruta)
        {
            D_Inscripcion ObjDato = new D_Inscripcion();
            ObjDato.IdInspcricion = idinscripcion;
            ObjDato.CodigoInsp = codigoinsp;
            ObjDato.IdChofer = idchofer;
            ObjDato.IdBus = idbus;
            ObjDato.IdRuta = idruta;

            return ObjDato.Editar(ObjDato);
        }
        public static string Eliminar(int idinscripcion)
        {
            D_Inscripcion ObjDato = new D_Inscripcion();
            ObjDato.IdInspcricion = idinscripcion;

            return ObjDato.Eliminar(ObjDato);
        }
        public static DataTable BuscarInscripcion(string textobuscar)
        {
            D_Inscripcion ObjDato = new D_Inscripcion();
            ObjDato.Textobuscar = textobuscar;

            return ObjDato.BuscarInscrpcion(ObjDato);
        }
        public static string ReiniciarBD()
        {
            return new D_Inscripcion().ReiniciarBD();
        }
        public static string InsertarEstudiantes()
        {
            return new D_Inscripcion().InsertarEstudiantes();
        }
        public static string EliminarEstudiantes()
        {
            return new D_Inscripcion().EliminarEstudiantes();
        }
        public static DataTable MostrarEstudiantes()
        {
            return new D_Inscripcion().MostrarEstudiantes();
        }
        public static DataTable BuscarRuta(string textobuscarruta)
        {
            D_Inscripcion ObjDato = new D_Inscripcion();
            ObjDato.Textobuscarruta = textobuscarruta;

            return ObjDato.BuscarRuta(ObjDato);
        }

    }
}
