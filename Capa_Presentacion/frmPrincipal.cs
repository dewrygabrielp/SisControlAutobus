using Capa_Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Capa_Presentacion
{


    public delegate void pasar();
    //public event pasar pasado;
    public partial class frmPrincipal : Form, IMetodos
    {

        private bool IsNuevo = false;
        private bool IsEditar = false;
        

             

        public frmPrincipal()
        {
            InitializeComponent();
            lblHora.Text = DateTime.Now.ToString("hh:mm:ss");
            lblFecha.Text = DateTime.Now.ToLongDateString();
            this.chkEliminar.Checked = false;
            this.OcultarColumnas();
            SubmenuPropiedades();

          
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            // this.MostrarSubmenu();
            this.Abrirform(new frmInicio());
            this.MostrarInscripcion();
            this.chkEliminar.Checked = false;
            this.LlenarcomboboxChofer();
            this.Llenarcomboboxruta();
            this.LlenarcomboboxBus();
            this.ComboboxBusname();
            this.ComboboxChofername();
            this.Comboboxrutaname();
            this.txtBuscar.Focus();
            this.btnRegistrarInsp.Enabled = false;
            this.ttMensaje.SetToolTip(cbxChoferes, "Seleccione el Id del Chofer");
            this.ttMensaje.SetToolTip(cbxAutobus, "Seleccione el Id de la Placa");
            this.ttMensaje.SetToolTip(cbxRutaAsig, "Seleccione el Id de la Ruta");

        }
        //Mensaje Ok
        public void mensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Control de autobuses", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //Mensaje Error
        public void mensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Control de autobuses", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        //Habilitar controles
        public void habilitar(bool valor)
        {
            txtSerial.ReadOnly = !valor;

        }
        //Botones
        public void botones()
        {
            if (this.IsNuevo || this.IsEditar)
            {
                // habilitar(true);
                btnRegistrarInsp.Enabled = false;
                btnGuardarInsp.Enabled = true;

                btnCancelar.Enabled = true;
            }
            else
            {
                //habilitar(false);
                btnRegistrarInsp.Enabled = true;
                btnGuardarInsp.Enabled = false;

                btnCancelar.Enabled = false;

            }
        }



        //Limpiar controles o cajas de textos
        public void limpiar()
        {
            txtSerial.Text = string.Empty;

        }
        public void MostrarInscripcion()
        {

            dgvDatos.DataSource = N_Inscripcion.MostrarDatos();
            this.OcultarColumnas();
            lblCantidad.Text = "CANTIDAD DE REGISTROS: " + dgvDatos.Rows.Count;
        }
        public void cancelar()
        {

            this.IsNuevo = false;
            this.botones();
            this.limpiar();
            this.habilitar(false);

        }

        private void Abrirform(object formsegundo)
        {
            if (this.PanelContenedor.Controls.Count > 0)
                this.PanelContenedor.Controls.RemoveAt(0);
            Form fs = formsegundo as Form;
            fs.TopLevel = false;
            fs.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(fs);
            this.PanelContenedor.Tag = fs;
            fs.Show();

        }
        public void guardar()
        {
            string respuesta = "";
            try
            {

                if (this.cbxAutobus.DisplayMember == string.Empty)
                {
                    this.mensajeError("Debe seleccionar los elementos");

                }
                else
                {
                    if (this.IsNuevo)
                    {
                        respuesta = N_Inscripcion.Insertar(Convert.ToInt32(this.cbxChoferes.SelectedValue), Convert.ToInt32(this.cbxAutobus.SelectedValue),
                         Convert.ToInt32(this.cbxRutaAsig.SelectedValue));

                       
                    }
                    else
                    {
                        respuesta = N_Inscripcion.Editar(Convert.ToInt32(this.txtID.Text), Convert.ToString(this.txtSerial.Text), Convert.ToInt32(this.cbxChoferes.SelectedValue), Convert.ToInt32(this.cbxAutobus.SelectedValue),
                         Convert.ToInt32(this.cbxRutaAsig.SelectedValue));
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
                this.limpiar();
                this.botones();
                

                this.LlenarcomboboxBus();
                this.LlenarcomboboxChofer();
                this.Llenarcomboboxruta();
                this.ComboboxBusname();
                this.ComboboxChofername();
                this.Comboboxrutaname();
                MostrarInscripcion();

            }
            catch (Exception ex)
            {
                this.mensajeError(ex.Message + ex.StackTrace);
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
        public void nuevo()
        {
            this.IsNuevo = true;
            this.botones();
            this.limpiar();
            this.habilitar(true);
            this.LlenarcomboboxBus();
            this.LlenarcomboboxChofer();
            this.Llenarcomboboxruta();
            this.ComboboxBusname();
            this.ComboboxChofername();
            this.Comboboxrutaname();
        }

        //Boton Abrir form autobuses




        private void OcultarColumnas()
        {
            dgvDatos.Columns[0].Visible = false;
            ///dgvDatos.Columns[1].Visible = false;


        }
        private void Llenarcomboboxruta()
        {

            cbxRutaAsig.DataSource = N_rutas.MostrarRutas();
            cbxRutaAsig.DisplayMember = "IdRuta";
            cbxRutaAsig.ValueMember = "IdRuta";
        }


        private void LlenarcomboboxBus()
        {
            N_autobuses ObjNegocio = new N_autobuses();
            cbxAutobus.DataSource = ObjNegocio.MostrarAutobus();
            cbxAutobus.DisplayMember = "IdAutobus";
            cbxAutobus.ValueMember = "IdAutobus";

        }
        private void LlenarcomboboxChofer()
        {
            N_choferes ObjNegocio = new N_choferes();
            cbxChoferes.DataSource = ObjNegocio.Mostrar();
            cbxChoferes.DisplayMember = "IdChofer";
            cbxChoferes.ValueMember = "IdChofer";

        }
        //Boton Cerrar app
        private void label1_Click(object sender, EventArgs e)
        {
            DialogResult opcion;
            opcion = MessageBox.Show("¿Realmente desea salir de la aplicación?", "Control de autobuses", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (opcion == DialogResult.Yes) Application.Exit();



        }
        public void AbrirPanel(object panel)
        {
            if (this.PanelContenedor.Controls.Count > 0)
                this.PanelContenedor.Controls.RemoveAt(0);
                Panel pl = panel as Panel;
                pl.Dock = DockStyle.Fill;
               
                this.PanelContenedor.Controls.Add(pl);
                this.PanelContenedor.Tag = pl;
                pl.Show();

        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
                this.IsNuevo = false;
                this.IsEditar = false;
                this.botones();
                this.limpiar();
                this.habilitar(false);

        }






        private void dgvDatos_DoubleClick(object sender, EventArgs e)
        {
            this.txtSerial.Text = Convert.ToString(this.dgvDatos.CurrentRow.Cells["CÓDIGO SERIAL"].Value);

            




            Controles.SelectedIndex = 1;

        }

        private void btnAutobus_Click(object sender, EventArgs e)
        {

            Abrirform(new frmAutobus());
            this.ResponsivePnl();

        }
        private void ResponsivePnl()
        {
            if (this.PanelIzquierdo.Width == 200)
            {
                this.PanelIzquierdo.BackColor = Color.White;
                this.PanelIzquierdo.Width = 60;
                this.btnPanelInicio.Text = "";
                this.btnInscripcion.Text = "";
                this.btnRutas.Text = "";
                this.btnInscripcion.Text = "";
                this.btnChofer.Text = "";
                this.btnAutobus.Text = "";
                this.btnEstudiante.Text = "";
                this.btnTicket.Text = "";
                
               
            }


            else
            {
                this.PanelIzquierdo.Width = 200;
                this.PanelIzquierdo.BackColor = Color.FromArgb(0, 122, 204);
                this.btnPanelInicio.Text = "INICIO";
                this.btnInscripcion.Text = "INSCRIPCIÓN";
                this.btnRutas.Text = "RUTAS";

                this.btnChofer.Text = "CONDUCTORES";
                this.btnAutobus.Text = "AUTOBUSES";
                this.btnEstudiante.Text = "ESTUDIANTES";
                this.btnTicket.Text = "TICKETS";
            }

        }



        //Metodos para mostrar/ocultar submenus

        private void SubmenuPropiedades()
        {
            btnGuardarInsp.Visible = false;

        }
        private void OcultarSubmenu()
        {
            if (btnRegistrarInsp.Visible == true)
                btnRegistrarInsp.Visible = false;
            else
            {
                btnRegistrarInsp.Visible = true;
            }


        }
        private void MostrarSubmenu(Panel Submenu)
        {
            if (Submenu.Visible == false)
            {
                this.OcultarSubmenu();
                Submenu.Visible = true;
            }
            else
            {
                Submenu.Visible = false;
            }

        }


        private void btnChofer_Click(object sender, EventArgs e)
        {

            Abrirform(new frmChoferes());
            this.ResponsivePnl();
        }

        private void btnRutas_Click_1(object sender, EventArgs e)
        {

            Abrirform(new frmRutas());

            this.ResponsivePnl();


        }




        private void btnInscripcion_Click(object sender, EventArgs e)
        {
            this.AbrirPanel(pnlInscripcion);
            this.Controles.Visible = true;
            
            //this.MostrarSubmenu(pnlInsp);
            //this.ResponsivePnl();
            
            this.btnRegistrarInsp.Enabled = true;
            this.MostrarInscripcion();
            this.LlenarcomboboxBus();
            this.LlenarcomboboxChofer();
            this.Llenarcomboboxruta();
            this.ComboboxBusname();
            this.ComboboxChofername();
            this.Comboboxrutaname();
        }



        private void btnEditarInsp_Click(object sender, EventArgs e)
        {
            this.editar();
            //this.OcultarSubmenu();
        }

        private void btnRegistrarInsp_Click(object sender, EventArgs e)
        {
            this.nuevo();
            //this.OcultarSubmenu();
            this.btnGuardarInsp.Visible = true;
            this.MostrarInscripcion();

        }

        private void btnGuardarInsp_Click(object sender, EventArgs e)
        {
            this.guardar();
            //this.OcultarSubmenu();
            this.MostrarInscripcion();
        }

        private void chkEliminar_CheckedChanged(object sender, EventArgs e)
        {

            if (chkEliminar.Checked)
            {
                this.dgvDatos.Columns[0].Visible = true;
            }
            else
            {
                this.dgvDatos.Columns[0].Visible = false;
            }
        }

        private void dgvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvDatos.Columns["Eliminar"].Index)
            {
                DataGridViewCheckBoxCell ChkEliminar = (DataGridViewCheckBoxCell)dgvDatos.Rows[e.RowIndex].Cells["Eliminar"];
                ChkEliminar.Value = !Convert.ToBoolean(ChkEliminar.Value);
            }
        }
        public void ReiniciarBD()
        {

            try
            {

                string respuesta = null;
                DialogResult opcion;
                opcion = MessageBox.Show("¿Realmente desea reiniciar por completo la base de datos?", "ALERTA!!",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (opcion == DialogResult.OK)
                {
                    respuesta = N_Inscripcion.ReiniciarBD();

                    if (respuesta.Equals("OK"))
                    {
                        this.mensajeOk("Se vació completamente la Base de datos. " +
                            "Las restricciones volvieron a activarse. " +
                            "Todas las tablas se crearon satisfactoriamente.");
                    }
                    else
                    {
                        this.mensajeError(respuesta);
                             
                    }
                    this.MostrarInscripcion();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);

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

                    foreach (DataGridViewRow row in dgvDatos.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            codigo = Convert.ToString(row.Cells[1].Value);
                            respuesta = N_Inscripcion.Eliminar(Convert.ToInt32(codigo));

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
                    this.MostrarInscripcion();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            this.eliminar();
        }



        private void btnPanelInicio_Click(object sender, EventArgs e)
        {
            this.Abrirform(new frmInicio());
            this.ResponsivePnl();
        }
        private void Comboboxrutaname()
        {

            cbxRutaname.DataSource = N_rutas.MostrarRutas();
            cbxRutaname.DisplayMember = "RECORRIDO";
            cbxRutaname.ValueMember = "IdRuta";
        }


        private void ComboboxBusname()
        {
            N_autobuses ObjNegocio = new N_autobuses();
            cbxAutobusname.DataSource = ObjNegocio.MostrarAutobus();
            cbxAutobusname.DisplayMember = "PLACA";
            cbxAutobusname.ValueMember = "IdAutobus";

        }
        private void ComboboxChofername()
        {
            N_choferes ObjNegocio = new N_choferes();
            cbxChoferesname.DataSource = ObjNegocio.Mostrar();
            cbxChoferesname.DisplayMember = "NOMBRE";
            cbxChoferesname.ValueMember = "IdChofer";

        }

        private void txtSerial_TextChanged(object sender, EventArgs e)
        {
            this.txtSerial.Text = Convert.ToString(this.dgvDatos.CurrentRow.Cells["CÓDIGO SERIAL"].Value);
        }


        private void BuscarNombre()
        {
            this.dgvDatos.DataSource = N_Inscripcion.BuscarInscripcion(txtBuscar.Text);
            this.lblCantidad.Text = "Registros encontrados: " + Convert.ToString(this.dgvDatos.Rows.Count);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            this.BuscarNombre();
        }



        private void txtBuscar_MouseClick_1(object sender, MouseEventArgs e)
        {
            if (this.txtBuscar.Text == "Buscar...")
            {
                this.txtBuscar.Text = string.Empty;
                this.BuscarNombre();
            }
            else
            {
                txtBuscar.Text = string.Empty;
                  
            }
        }



        private void btnRegistrarInsp_Click_1(object sender, EventArgs e)
        {
            this.nuevo();
            this.btnGuardarInsp.Visible = true;

        }

        private void btnGuardarInsp_Click_1(object sender, EventArgs e)
        {
            this.guardar();
           //his.OcultarSubmenu();
        }

        private void btnReiniciarBD_Click(object sender, EventArgs e)
        {
            DialogResult opcion;
            opcion = MessageBox.Show("¿Realmente quiere borrar todos los datos?", "Sistema control de autobuses", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(opcion == DialogResult.Yes)
            {
                this.ReiniciarBD();
            }
        }

        private void Controles_MouseClick(object sender, MouseEventArgs e)
        {
            this.LlenarcomboboxBus();
            this.LlenarcomboboxChofer();
            this.Llenarcomboboxruta();
            this.ComboboxBusname();
            this.ComboboxChofername();
            this.Comboboxrutaname();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;;
        }

        private void btnEstudiante_Click(object sender, EventArgs e)
        {
            Abrirform(new frmEstudiantes());
        }

        private void btnTicket_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tickets agotados\n" +
                "\n Pase mañana","Venta de tickets", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void timerFechaHora_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("hh:mm:ss");
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DialogResult opcion;
            opcion = MessageBox.Show("¿Realmente desea salir de la aplicación?", "Sistema de control de autobuses", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(opcion == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                MessageBox.Show("¿Y para qué presiona el botón?", "Entiendo...",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
    }
}
                    
         