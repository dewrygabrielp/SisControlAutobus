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
    public partial class frmChoferes : Form, IMetodos
    {
        private bool IsNuevo = false;
        private bool IsEditar = false;
       
        public frmChoferes()
        {
            InitializeComponent();
            this.dgvChoferes.Columns[0].Visible = false;
        }

        private void frmChoferes_Load(object sender, EventArgs e)
        {
            this.MostrarChoferes();
            this.btnGuardarChofer.Enabled = false;
            this.habilitar(false);
            
        }
        public void cancelar()
        {
            this.IsNuevo = false;
            this.IsEditar = false;
            this.botones();
            this.limpiar();
            this.habilitar(false);
        }
        private void MostrarChoferes()
        {
             N_choferes Obj = new N_choferes();


            dgvChoferes.DataSource = Obj.Mostrar();
        }
        public void mensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "MANTENIMIENTO CHOFERES", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Mensaje de error
        public void mensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "MANTENIMIENTO CHOFERES", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public void habilitar(bool valor)
        {
            txtNombreChofer.ReadOnly = !valor;
            txtApellidoChofer.ReadOnly = !valor;
            txtCedulaChofer.ReadOnly = !valor;
            
        }
        public void limpiar()
        {
            txtNombreChofer.Text = string.Empty;
            txtApellidoChofer .Text = string.Empty;
            txtID.Text = string.Empty;
            txtCedulaChofer.Text = string.Empty;
          


        }
        public void nuevo()
        {
            this.IsNuevo = true;
            this.IsEditar = false;
            this.botones();
            this.limpiar();
            this.habilitar(true);
        }
        public void guardar()
        {
            string respuesta = "";
            try
            {
                if(txtNombreChofer.Text == string.Empty)
                {
                    mensajeError("Falta ingresar algunos datos");
                    ErrorP.SetError(txtNombreChofer, "Ingrese el nombre");
                }
                else
                {
                    if (this.IsNuevo)
                    {
                        respuesta = N_choferes.Insertar(this.txtNombreChofer.Text.ToUpper(), this.txtApellidoChofer.Text.ToUpper(), dtpFecha_Nac.Value,
                            this.txtCedulaChofer.Text.Trim());
                    }
                    else
                    {
                        respuesta = N_choferes.Editar(Convert.ToInt32(this.txtID.Text), this.txtNombreChofer.Text.ToUpper(), this.txtApellidoChofer.Text.ToUpper(), dtpFecha_Nac.Value,
                            this.txtCedulaChofer.Text.Trim());
                    }
                }
                if (respuesta.Equals("OK"))
                {


                    if (this.IsNuevo)
                    {
                        this.mensajeOk("Se inserto de forma correcta el registro");
                    }
                    else
                    {
                        this.mensajeOk("Se Actualizo de forma correcta el registro");
                    }
                }
                else
                {
                    this.mensajeError(respuesta);
                }
                    this.IsNuevo = false;
                    this.IsEditar = false;
                    this.botones();
                    this.limpiar();
                    this.MostrarChoferes();
                

            }
            catch(Exception ex)
            {
                respuesta = ex.Message + ex.StackTrace;
            }
           
        }
        public void botones()
        {
           
            if (this.IsNuevo || this.IsEditar)
            {
                habilitar(true);
                btnRegistrarChofer.Enabled = false;
                btnGuardarChofer.Enabled = true;
                btnEditarChofer.Enabled = false;
               
            }
            else
            {
                
                habilitar(false);
                btnRegistrarChofer.Enabled = true;
                btnGuardarChofer.Enabled = false;
                btnEditarChofer.Enabled = true;

            }
        }
        public void editar()
        {
            if (!this.txtID.Text.Equals(""))
            {
                this.IsEditar = true;
                this.botones();
                this.habilitar(true);
            }
            else
            {
               this.mensajeError("Debe seleccionar primero el registro a Modificar");
            }
        }

        private void btnRegistrarChofer_Click(object sender, EventArgs e)
        {
            this.nuevo();
        }

        private void btnGuardarChofer_Click(object sender, EventArgs e)
        {
            this.guardar();
        }

        private void btnEditarChofer_Click(object sender, EventArgs e)
        {
            this.editar();
        }

        private void dgvChoferes_DoubleClick(object sender, EventArgs e)
        {
            this.txtID.Text = Convert.ToString(dgvChoferes.CurrentRow.Cells["IdChofer"].Value);
            this.txtNombreChofer.Text = Convert.ToString(dgvChoferes.CurrentRow.Cells["NOMBRE"].Value);
            this.txtApellidoChofer.Text = Convert.ToString(dgvChoferes.CurrentRow.Cells["APELLIDO"].Value);
            //dtpFecha_Nac.Value = Convert.ToDateTime(dgvChoferes.CurrentRow.Cells["FECHA_NACIMIENTO"].Value);
            this.txtCedulaChofer.Text = Convert.ToString(dgvChoferes.CurrentRow.Cells[5].Value);
            
        }

        public void  eliminar()
        {

            try
            {
                DialogResult opcion;
                opcion = MessageBox.Show("Realmente desea eliminar los Registros", "CONTROL DE AUTOBUSES", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (opcion == DialogResult.OK)
                {
                    string codigo;
                    string respuesta = "";

                    foreach (DataGridViewRow row in dgvChoferes.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            codigo = Convert.ToString(row.Cells[1].Value);
                            respuesta = N_choferes.Eliminar(Convert.ToInt32(codigo));

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
                    this.MostrarChoferes();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);

            }
        }

        private void chkEliminar_CheckedChanged(object sender, EventArgs e)
        {
            
            if (chkEliminar.Checked)
            {
                this.dgvChoferes.Columns[0].Visible = true;
            }
            else
            {
                this.dgvChoferes.Columns[0].Visible = false;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            this.eliminar();
        }

        private void dgvChoferes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvChoferes.Columns["EliminarC"].Index)
            {
                DataGridViewCheckBoxCell ChkEliminar = (DataGridViewCheckBoxCell)dgvChoferes.Rows[e.RowIndex].Cells["EliminarC"];
                ChkEliminar.Value = !Convert.ToBoolean(ChkEliminar.Value);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.cancelar();
        }

        private void btnEditarChofer_Click_1(object sender, EventArgs e)
        {
            this.editar();
        }

        private void btnRegistrarChofer_Click_1(object sender, EventArgs e)
        {
            this.nuevo();
            this.btnGuardarChofer.Enabled = true;
            this.habilitar(true);
        }

        private void btnGuardarChofer_Click_1(object sender, EventArgs e)
        {
            this.guardar();
        }

        private void txtNombreChofer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo Letras", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        

        private void txtCedulaChofer_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtApellidoChofer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo Letras", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
          
        }
    }
}
