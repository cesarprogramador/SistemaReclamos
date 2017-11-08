using SistemaReclamos.personas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaReclamos
{
    public partial class ABMEmpleados : Form
    {
        ClassPersonas _empleados;
        DataSet _empleado;
        string bandera;

        public ABMEmpleados()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this._empleados.idpersona = "0";
            this._empleados.apellido = this.txtBusApellido.Text;
            this._empleados.nombre = this.txtBusNombre.Text;
            this._empleados.dni = this.txtBusDni.Text;
            this._empleados.idtipopersona = this.cbBusTipoEmpleado.SelectedValue.ToString();
            this._empleados.accion = "";
            if (this.cbxEliminado.Checked == true) this._empleados.accion = "B";

            this.dgvEmpleados.DataSource = this._empleados.BuscarPersonaEmpleados(this._empleados, "Empleados");
            this.dgvEmpleados.DataMember = "Empleados";

            if (this.dgvEmpleados.Rows.Count > 0) this.dgvEmpleados.Columns[0].Visible = false;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.cbBusTipoEmpleado.SelectedValue = 1;
            this.txtBusApellido.Text = "";
            this.txtBusNombre.Text = "";
            this.txtBusDni.Text = "";
            this.cbxEliminado.Checked = false;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.bandera = "N";
            this.txtFechaIngreso.Text = DateTime.Now.ToString("dd/MM/yyyy");
            this.txtFechaEgreso.Text = "";
            this.txtFechaEgreso.Enabled = false;

            this._empleados.idpersona = "0";
            this.gbxAcciones.Enabled = false;
            this.gbxConfirmarAccion.Enabled = true;
            this.gbxBuscador.Enabled = false;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            this.bandera = "M";

            this.txtFechaIngreso.Enabled = false;
            this.txtFechaEgreso.Enabled = false;

            this.gbxAcciones.Enabled = false;
            this.gbxConfirmarAccion.Enabled = true;
            this.gbxBuscador.Enabled = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            this.bandera = "B";
            this.txtFechaIngreso.Enabled = false;
            this.txtFechaEgreso.Text = DateTime.Now.ToString("dd/MM/yyyy");
            this.txtFechaEgreso.Enabled = false;
            this.gbxAcciones.Enabled = false;
            this.gbxConfirmarAccion.Enabled = true;
            this.gbxBuscador.Enabled = false;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.bandera = "";
            this._empleados.idpersona = "0";
            this.gbxAcciones.Enabled = true;
            this.btnNuevo.Enabled = true;
            this.btnEliminar.Enabled = false;
            this.btnModificar.Enabled = false;
            this.gbxConfirmarAccion.Enabled = false;
            this.gbxBuscador.Enabled = true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this._empleados.apellido = this.txtApellido.Text;
            this._empleados.nombre = this.txtNombre.Text;
            this._empleados.dni = this.txtDni.Text;
            this._empleados.cel = this.txtCel.Text;
            this._empleados.tel = this.txtTel.Text;
            this._empleados.correo = this.txtEmail.Text;
            this._empleados.calle = this.txtCalle.Text;
            this._empleados.numero = this.txtNumero.Text;
            this._empleados.piso = this.txtPiso.Text;
            this._empleados.dpto = this.txtDpto.Text;
            this._empleados.idtipopersona = this.cbTipoEmpleado.SelectedValue.ToString();
            this._empleados.observacion = this.txtObservacion.Text;
            this._empleados.idtiposervicio = "1";
            this._empleados.numreferencia = "";
            this._empleados.usuario = this.txtUsuario.Text;
            this._empleados.pass = this.txtPass.Text;

            if (this.bandera == "N")
            {
                this._empleados.fechaingreso = DateTime.Now.ToString("yyyy/MM/dd");
            }
            
            if (this.bandera == "B")
            {
                this._empleados.fechaegreso = DateTime.Now.ToString("yyyy/MM/dd");
            }
            

            this._empleados.accion = this.bandera;
            this._empleados.fechaaccion = DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss");

            this.dgvEmpleados.DataSource = this._empleados.ABMPersona(this._empleados, "accion");
            this.dgvEmpleados.DataMember = "accion";

            if (this.dgvEmpleados.Rows.Count > 0)
            {
                this.dgvEmpleados.Columns[0].Visible = false;
                MessageBox.Show("Acción realizada con exito", "Atención!!!");

                this.btnCancelar_Click(sender, e);
            }
            else
            {
                if (this._empleados.accion == "B")
                {
                    MessageBox.Show("Acción realizada con exito", "Atención!!!");

                    this.btnCancelar_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Error en la ejecución de la acción en curso. Controle datos!!!", "Error!!!");
                }
            }
        }

        private void ABMEmpleados_Load(object sender, EventArgs e)
        {
            this._empleados = new ClassPersonas();

            this._empleados.idtipopersona = "0";

            DataTable _tipopersonas = this._empleados.BuscarTipoPersonas(this._empleados);

            this.cbTipoEmpleado.DataSource = _tipopersonas;
            this.cbTipoEmpleado.ValueMember = "idtipopersona";
            this.cbTipoEmpleado.DisplayMember = "tipopersona";

            this.cbBusTipoEmpleado.DataSource = _tipopersonas;
            this.cbBusTipoEmpleado.ValueMember = "idtipopersona";
            this.cbBusTipoEmpleado.DisplayMember = "tipopersona";
            this.cbTipoEmpleado.Text = "";
        }

        private void dgvEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvEmpleados.Rows.Count > 0)
            {
                this._empleados.idpersona = this.dgvEmpleados[0, this.dgvEmpleados.CurrentCell.RowIndex].Value.ToString();

                this._empleado = this._empleados.BuscarPersonaEmpleados(this._empleados, "Empleado");

                if (this._empleado.Tables["Empleado"].Rows.Count > 0)
                {
                    this.txtApellido.Text = this._empleado.Tables["Empleado"].Rows[0][0].ToString();
                    this.txtNombre.Text = this._empleado.Tables["Empleado"].Rows[0][1].ToString();
                    this.txtDni.Text = this._empleado.Tables["Empleado"].Rows[0][2].ToString();
                    this.txtCel.Text = this._empleado.Tables["Empleado"].Rows[0][3].ToString();
                    this.txtTel.Text = this._empleado.Tables["Empleado"].Rows[0][4].ToString();
                    this.txtEmail.Text = this._empleado.Tables["Empleado"].Rows[0][5].ToString();
                    this.txtCalle.Text = this._empleado.Tables["Empleado"].Rows[0][6].ToString();
                    this.txtNumero.Text = this._empleado.Tables["Empleado"].Rows[0][7].ToString();
                    this.txtPiso.Text = this._empleado.Tables["Empleado"].Rows[0][8].ToString();
                    this.txtDpto.Text = this._empleado.Tables["Empleado"].Rows[0][9].ToString();

                    this.cbTipoEmpleado.Text = this._empleado.Tables["Empleado"].Rows[0][10].ToString();
                    this.txtObservacion.Text = this._empleado.Tables["Empleado"].Rows[0][11].ToString();
                    this.txtFechaIngreso.Text = this._empleado.Tables["Empleado"].Rows[0][12].ToString();
                    try
                    {
                        this.txtFechaEgreso.Text = this._empleado.Tables["Empleado"].Rows[0][13].ToString();
                    }
                    catch
                    {
                        this.txtFechaEgreso.Text = "";
                    }

                    this.txtUsuario.Text = this._empleado.Tables["Empleado"].Rows[0][14].ToString();
                    this.txtPass.Text = this._empleado.Tables["Empleado"].Rows[0][15].ToString();
                }

                this.gbxAcciones.Enabled = true;
                this.btnNuevo.Enabled = true;
                this.btnModificar.Enabled = true;
                this.btnEliminar.Enabled = true;
            }
        }
    }
}
