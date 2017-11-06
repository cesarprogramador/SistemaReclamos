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
        string _idproblematica;
        DataSet _reclamocliente;

        public ConsultasReclamos()
        {
            InitializeComponent();
        }

        private void ConsultasReclamos_Load(object sender, EventArgs e)
        {
            this._reclamos = new ClassReclamos();

            this._reclamos.idtiporeclamo = "0";
            this._idproblematica = "0";

            DataTable _tiporeclamos = this._reclamos.BuscarTipoReclamos(this._reclamos);

            this.cbTipoReclamos.DataSource = _tiporeclamos;
            this.cbTipoReclamos.ValueMember = "idtiporeclamo";
            this.cbTipoReclamos.DisplayMember = "tiporeclamo";
        }

        private void cbTipoReclamos_KeyPress(object sender, KeyPressEventArgs e)
        {
            this._reclamos.idproblematicareclamo =this._idproblematica;
            this._reclamos.idtiporeclamo = this.cbTipoReclamos.SelectedValue.ToString();

            _reclamocliente = this._reclamos.BuscarSiguienteReclamos(this._reclamos, "Consulta");

            if (this._reclamocliente.Tables["Consulta"].Rows.Count > 0)
            {
                this.txtConsulta.Text = this._reclamocliente.Tables["Consulta"].Rows[0][1].ToString();
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //Ingresar registro en base de datos de historial de reclamos

        }
    }
}
