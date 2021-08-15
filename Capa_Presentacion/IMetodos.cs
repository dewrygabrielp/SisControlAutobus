using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Presentacion
{
    interface IMetodos
    {
        //void botones();
        void limpiar();
        void habilitar(bool valor);
        void editar();
        void botones();
        void nuevo();
        void guardar();
        void eliminar();
        void mensajeOk(string mensaje);
        void mensajeError(string mensaje);

    }
}
