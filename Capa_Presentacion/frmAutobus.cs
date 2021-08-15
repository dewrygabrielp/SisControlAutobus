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
    public partial class frmAutobus : Form, IMetodos
    {
        private bool IsNuevo = false;
        private bool IsEditar = false;
        private string HelpPlaca = "";
        
        public frmAutobus()
        {
            InitializeComponent();
            this.dgvAutobus.Columns[0].Visible = false;
        }

        private void frmAutobus_Load(object sender, EventArgs e)
        {
            MostrarAutobus();
            this.btnGuardarBus.Enabled = false;
            this.habilitar(false);
        }
        private void MostrarAutobus()
        {
            N_autobuses Obj = new N_autobuses();

            dgvAutobus.DataSource = Obj.MostrarAutobus();
        }
        public void cancelar()
        {
            this.IsNuevo = false;
            this.IsEditar = false;
            this.botones();
            this.limpiar();
            this.habilitar(false);
        }
        public void limpiar()
        {
            txtIDBus.Text = string.Empty;
            txtPlacaBus.Text = string.Empty;
            txtModeloBus.Text = string.Empty;
            txtMarcaBus.Text = string.Empty;
            txtColorBus.Text = string.Empty;
            

        }
        public void nuevo()
        {
            this.IsNuevo = true;
            this.IsEditar = false;
            this.botones();
            this.limpiar();
            this.habilitar(true);
        }
        public void habilitar(bool valor)
        {
            txtColorBus.ReadOnly = !valor;
            txtMarcaBus.ReadOnly = !valor;
            txtPlacaBus.ReadOnly = !valor;
            txtModeloBus.ReadOnly = !valor;
        }
        public void mensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "CONTROL AUTOBUS", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Mensaje de error
        public void mensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "CONTROL AUTOBUS", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void guardar()
        {
            string respuesta = "";
            try
            {
                if(txtPlacaBus.Text == string.Empty)
                {
                   
                    ErrorP.SetError(txtPlacaBus, "Ingrese la placa");
                }
                else
                {
                    if(this.IsNuevo)
                    {
                        respuesta = N_autobuses.Insertar(this.txtMarcaBus.Text.ToUpper(), this.txtModeloBus.Text.ToUpper(),
                           this.HelpPlaca= "I- " +(this.txtPlacaBus.Text.Trim().ToUpper()), this.txtColorBus.Text.Trim().ToUpper(), dtpAno.Value);
                            
                    }
                    else
                    {
                        respuesta = N_autobuses.Editar(Convert.ToInt32(this.txtIDBus.Text),this.txtMarcaBus.Text.ToUpper(), this.txtModeloBus.Text.ToUpper(),
                            this.txtPlacaBus.Text.Trim().ToUpper(), this.txtColorBus.Text.Trim().ToUpper(), dtpAno.Value);

                    }


                }
                if(respuesta.Equals("OK"))
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
                this.MostrarAutobus();

            }
            catch (Exception ex)
            {
                respuesta = ex.Message + ex.StackTrace;
            }
            
        }
        public void botones()
        {
            
            
            if (this.IsNuevo || this.IsEditar)
            {
                habilitar(true);
                btnRegistrarBus.Enabled = false;
                btnGuardarBus.Enabled = true;
                btnEditarBus.Enabled = false;

            }
            else
            {

                habilitar(false);
                btnRegistrarBus.Enabled = true;
                btnGuardarBus.Enabled = false;
                btnEditarBus.Enabled = true;

            }
        }
        public void editar()
        {
            if (!this.txtIDBus.Text.Equals(""))
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

                    foreach (DataGridViewRow row in dgvAutobus.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            codigo = Convert.ToString(row.Cells[1].Value);
                            respuesta = N_autobuses.Eliminar(Convert.ToInt32(codigo));

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
                    this.MostrarAutobus();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);

            }
        }


        private void dgvAutobus_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvAutobus.Columns["EliminarA"].Index)
            {
                DataGridViewCheckBoxCell ChkEliminar = (DataGridViewCheckBoxCell)dgvAutobus.Rows[e.RowIndex].Cells["EliminarA"];
                ChkEliminar.Value = !Convert.ToBoolean(ChkEliminar.Value);
            }
        }

        private void dgvAutobus_DoubleClick(object sender, EventArgs e)
        {
            this.txtIDBus.Text = Convert.ToString(this.dgvAutobus.CurrentRow.Cells["IdAutobus"].Value);
            this.txtMarcaBus.Text = Convert.ToString(this.dgvAutobus.CurrentRow.Cells["MARCA"].Value);
            this.txtModeloBus.Text= Convert.ToString(this.dgvAutobus.CurrentRow.Cells["MODELO"].Value);
            this.txtPlacaBus.Text = Convert.ToString(this.dgvAutobus.CurrentRow.Cells["PLACA"].Value);
            this.txtColorBus.Text = Convert.ToString(this.dgvAutobus.CurrentRow.Cells["COLOR"].Value);
           /// this.dtpAno.Value = Convert.ToDateTime(this.dgvAutobus.CurrentRow.Cells["AÑO"].Value);
        }


        private void btnRegistrarBus_Click_2(object sender, EventArgs e)
        {
            this.nuevo();
            this.btnGuardarBus.Enabled = true;
            this.habilitar(true);
        }

        private void btnGuardarBus_Click_2(object sender, EventArgs e)
        {
            this.guardar();
        }

        private void btnEditarBus_Click_2(object sender, EventArgs e)
        {
            this.editar();
        }

        private void chkEliminar_CheckedChanged(object sender, EventArgs e)
        {
            
            if (chkEliminar.Checked)
            {
                this.dgvAutobus.Columns[0].Visible = true;
            }
            else
            {
                this.dgvAutobus.Columns[0].Visible = false;
            }
        }

      

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.cancelar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.eliminar();
        }

        private void txtPlacaBus_TextChanged(object sender, EventArgs e)
        {
           
        }
        //Validando textbox y codificando digitos
        private void txtPlacaBus_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtMarcaBus_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMarcaBus_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo Letras", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtColorBus_KeyPress(object sender, KeyPressEventArgs e)
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
