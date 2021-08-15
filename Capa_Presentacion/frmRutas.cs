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

   
    public partial class frmRutas : Form, IMetodos
    {
       

        //public event pasar pasado;
       
        
        public bool IsNuevo = false;
        public bool IsEditar = false;
       
        
        public frmRutas()
        {
            InitializeComponent();
            this.dgvRutas.Columns[0].Visible = false;  
        }
        public void limpiar()
        {
            lblIDRuta.Text = string.Empty;
            txtRuta.Text = string.Empty;

            

        }
        public  void mensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "MANTENIMIENTO RUTAS", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public void mensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "MANTENIMIENTO RUTAS", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
       
        public  void guardar()
        {
            
           
            try
            {
                string respuesta = "";
                if (txtRuta.Text == string.Empty)
                {
                    mensajeError("Debe completar el campo");
                    ErrorP.SetError(txtRuta, "Ingrese aqui una Ruta a cursar");
                }
                else
                {
                    
                    if(this.IsNuevo)
                    {
                        respuesta = N_rutas.Insertar(this.txtRuta.Text.ToUpper());
                    }

                    else
                    {
                        respuesta = N_rutas.Editar(Convert.ToInt32(this.txtIDRuta.Text),this.txtRuta.Text.ToUpper());
                    }

                }
                if(respuesta.Equals("OK"))
                {
                    if (IsNuevo)
                    {
                        mensajeOk("Se ingreso el registro");
                    }
                    else
                    {
                        mensajeOk("se edito el registro");
                    }
                }
                else
                {
                    mensajeError(respuesta);
                }
                IsNuevo = false;
                IsEditar = false;
                botones();
                limpiar();
                MostrarRutas();

            }
            catch(Exception ex)
            {
               MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        public void nuevo()
        {
            this.IsNuevo = true;
            this.IsEditar = false;
            this. botones();
            this.limpiar();
            this.habilitar(true);
        }
        private void MostrarRutas()
        {

            dgvRutas.DataSource = N_rutas.MostrarRutas();
        }
        public void habilitar(bool valor)
        {
            txtRuta.ReadOnly = !valor;

        }

        private void frmRutas_Load(object sender, EventArgs e)
        {
            this.MostrarRutas();
            this.chkEliminar.Checked = false;
            this.btnGuardarRuta.Enabled = false;
            this.habilitar(false);
        }
        public void botones()
        {
            
            if (this.IsNuevo || this.IsEditar)
            {
                habilitar(true);
                btnRegistrarRuta.Enabled = false;
                btnGuardarRuta.Enabled = true;
                btnEditarRuta.Enabled = false;

            }
            else
            {

                habilitar(false);
                btnRegistrarRuta.Enabled = true;
                btnGuardarRuta.Enabled = false;
                btnEditarRuta.Enabled = true;

            }
        }
        public void editar()
        {
            if (!this.txtIDRuta.Text.Equals(""))
            {
                IsEditar = true;
                botones();
                habilitar(true);
            }
            else
            {
                MessageBox.Show("Debe seleccionar primero el registro a Modificar");
            }
        }
        public void eliminar()
        {
            try
            {
                DialogResult opcion;
                opcion = MessageBox.Show("Realmente desea eliminar los Registros", "CONTROL DE AUTOBUSES", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (opcion == DialogResult.OK)
                {
                    string codigo;
                    string respuesta = "";

                    foreach (DataGridViewRow row in dgvRutas.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            codigo = Convert.ToString(row.Cells[1].Value);
                            respuesta = N_rutas.Eliminar(Convert.ToInt32(codigo));

                            if (respuesta.Equals("OK"))
                            {
                                this.mensajeOk("Se elimino correctamente el registro");
                            }
                            else
                            {
                                this.mensajeError(respuesta);
                            }
                        }
                    }
                    this.MostrarRutas();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);

            }
        }


      

        private void dgvRutas_DoubleClick(object sender, EventArgs e)
        {
            this.txtIDRuta.Text = Convert.ToString(this.dgvRutas.CurrentRow.Cells["IdRuta"].Value);
            this.txtRuta.Text = Convert.ToString(this.dgvRutas.CurrentRow.Cells["RUTA"].Value);
        }

    
        private void btnRegistrarRuta_Click_1(object sender, EventArgs e)
        {
            this.nuevo();
            this.btnGuardarRuta.Enabled = true;
            this.habilitar(true);
        }

        private void btnGuardarRuta_Click_1(object sender, EventArgs e)
        {
           this.guardar();
        }

        private void btnEditarRuta_Click_1(object sender, EventArgs e)
        {
            this.editar();
        }

        private void dgvRutas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvRutas.Columns["Eliminar"].Index)
            {
                DataGridViewCheckBoxCell ChkEliminar = (DataGridViewCheckBoxCell)dgvRutas.Rows[e.RowIndex].Cells["Eliminar"];
                ChkEliminar.Value = !Convert.ToBoolean(ChkEliminar.Value);
            }
        }
        public void cancelar()
        {
            this.IsNuevo = false;
            this.IsEditar = false;
            this.botones();
            this.limpiar();
            this.habilitar(false);
        }

        private void chkEliminar_CheckedChanged(object sender, EventArgs e)
        {
            
            if (chkEliminar.Checked)
            {
                this.dgvRutas.Columns[0].Visible = true;
            }
            else
            {
                this.dgvRutas.Columns[0].Visible = false;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            this.eliminar();
        }

      
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.cancelar();
        }
    }
}




