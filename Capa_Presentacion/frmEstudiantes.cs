using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Negocio;

namespace Capa_Presentacion
{
    public partial class frmEstudiantes : Form
    {
        public frmEstudiantes()
        {
            InitializeComponent();
        }

        private void frmEstudiantes_Load(object sender, EventArgs e)
        {
            this.MostrarEstudiantes();
        }
        public void mensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Control de tickets", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //Mensaje Error
        public void mensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Control de tickets", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void MostrarEstudiantes()
        {
            dgvEstudiantes.DataSource = N_Inscripcion.MostrarEstudiantes();
            lblCantEstudiantes.Text = "CANTIDAD DE REGISTROS  " + dgvEstudiantes.Rows.Count;
        }
        private void BuscarRuta()
        {
            dgvEstudiantes.DataSource = N_Inscripcion.BuscarRuta(txtBuscarRuta.Text);
        }
        private void insertar()
        {
            string respuesta = "";
            try
            {
                respuesta = N_Inscripcion.InsertarEstudiantes();

                if(respuesta.Equals("OK"))
                {
                    this.mensajeOk("Se insertó correctamente");
                }
                else
                {
                    this.mensajeError(respuesta);
                }
                this.MostrarEstudiantes();

            }
            catch(Exception ex)
            {
                respuesta = ex.Message + ex.StackTrace;
            }
        }
        private void eliminar()
        {
            string respuesta = "";
            try
            {
                if(dgvEstudiantes.Rows.Count > 0)
                {
                    this.btnEliminar.Enabled = true;
                    respuesta = N_Inscripcion.EliminarEstudiantes();

                    if (respuesta.Equals("OK"))
                    {
                        this.mensajeOk("Se elimino correctamente");
                    }
                    else
                    {
                        this.mensajeError(respuesta);
                    }
                    this.MostrarEstudiantes();
                }
                else
                {
                    btnEliminar.Enabled = false;
                }
                
            }
            catch (Exception ex)
            {
                respuesta = ex.Message + ex.StackTrace;
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            this.insertar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            this.eliminar();
        }

        private void txtBuscarRuta_TextChanged(object sender, EventArgs e)
        {
            this.BuscarRuta();
        }
    }
}
