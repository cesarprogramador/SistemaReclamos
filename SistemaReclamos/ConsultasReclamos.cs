using SistemaReclamos.reclamos;
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
    public partial class ConsultasReclamos : Form
    {
        ClassReclamos _reclamos;
        DataSet _ReclamoCliente;
        public string _idreclamo = "0";
        public string _numreferencia = "";
        public string _idtiporeclamo = "0";
        public string _tiporeclamo = "";
        public string _idproblematica = "0";
        public string _idcliente = "0";
        public string _idempleado = "0";
        public string _respuesta = "";
        
        public ConsultasReclamos()
        {
            InitializeComponent();
        }

        private void ConsultasReclamos_Load(object sender, EventArgs e)
        {
            this._reclamos = new ClassReclamos();

            this._reclamos.reclamo = this._tiporeclamo;

            DataTable _tiporeclamos = this._reclamos.BuscarTipoReclamos(this._reclamos);

            this.cbTipoReclamos.DataSource = _tiporeclamos;
            this.cbTipoReclamos.ValueMember = "idtiporeclamo";
            this.cbTipoReclamos.DisplayMember = "tiporeclamo";

            if ((this._idproblematica != "0") && (this._respuesta != ""))
            {
                this._reclamos.idtiporeclamo = this._idtiporeclamo;
                this._reclamos.idreclamo = this._idreclamo;
                this._reclamos.idproblematicareclamo = this._idproblematica;
                this._reclamos.respuesta = this._respuesta;

                _ReclamoCliente = this._reclamos.BuscarSiguienteReclamos(this._reclamos, "Consulta");

                if (this._ReclamoCliente.Tables["Consulta"].Rows.Count > 0)
                {
                    this.txtConsulta.Text = this._ReclamoCliente.Tables["Consulta"].Rows[0][1].ToString();
                }
            }

            if (this._idproblematica == "1")
            {
                this.txtObservacion.Text = "Fin circuito!!!";
                this.txtObservacion.Enabled = false;
                this.cbRespuesta.Text = "SI";
                this.cbRespuesta.Enabled = false;
            }
        }

        private void cbTipoReclamos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (this._idtiporeclamo == "0")
            {//Se carga reclamo solamente
                this._reclamos.idtiporeclamo = this.cbTipoReclamos.SelectedValue.ToString();
                this._reclamos.idproblematicareclamo = "0";

                _ReclamoCliente = this._reclamos.BuscarSiguienteReclamos(this._reclamos, "Consulta");

                if (this._ReclamoCliente.Tables["Consulta"].Rows.Count > 0)
                {
                    this.txtConsulta.Text = this._ReclamoCliente.Tables["Consulta"].Rows[0][1].ToString();
                }
            }
            else
            {
                this._reclamos.idtiporeclamo = this._idtiporeclamo;
                this._reclamos.idreclamo = this._idreclamo;
                this._reclamos.idproblematicareclamo = this._idproblematica;
                this._reclamos.respuesta = this._respuesta;
     
                _ReclamoCliente = this._reclamos.BuscarSiguienteReclamos(this._reclamos, "Consulta");

                if (this._ReclamoCliente.Tables["Consulta"].Rows.Count > 0)
                {
                    this.txtConsulta.Text = this._ReclamoCliente.Tables["Consulta"].Rows[0][1].ToString();
                }
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //Ingresar registro en tabla de reclamos
            if (this.cbRespuesta.Text == "SI")
            {
                this._reclamos.idproblematicareclamo = this._ReclamoCliente.Tables["Consulta"].Rows[0][0].ToString();
            }
            else
            {
                this._reclamos.idproblematicareclamo = this._ReclamoCliente.Tables["Consulta"].Rows[0][0].ToString();
            }

            this._reclamos.idreclamo = this._idreclamo;
            this._reclamos.numreferencia = this._numreferencia;
            this._reclamos.idcliente = this._idcliente.ToString();
            this._reclamos.idempleado = this._idempleado.ToString();
            this._reclamos.fechaini = DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss");
            this._reclamos.fechafin = DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss");
            this._reclamos.respuesta = this.cbRespuesta.Text;
            this._reclamos.observacion = this.txtObservacion.Text;

            this._reclamos.accion = "N";
            this._reclamos.fechaaccion = DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss");

            this._ReclamoCliente = this._reclamos.ABMReclamo(this._reclamos, "reclamo");

            if (this._reclamos.idproblematicareclamo.ToString() == "1")
            {
                MessageBox.Show("Acción realizada con exito", "Atención!!!");

                this.Close();
            }
            else
            {
                if (this._ReclamoCliente.Tables["reclamo"].Rows.Count > 0)
                {
                    MessageBox.Show("Acción realizada con exito", "Atención!!!");

                    this.Close();
                }
            }
        }
    }
}
