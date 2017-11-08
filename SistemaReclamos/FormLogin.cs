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
    public partial class FormLogin : Form
    {
        ClassPersonas _empleados;
        DataSet _empleado;
        string idempleado;

        public FormLogin()
        {
            InitializeComponent();
        }

        private void txtUsu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if ((this.txtUsu.Text.Length > 0) && (this.txtPass.Text.Length > 0))
                {
                    this.ValidadUsuario();
                }
                else
                {
                    MessageBox.Show("Faltan datos!!!", "Atención");
                }
            }
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if ((this.txtUsu.Text.Length > 0) && (this.txtPass.Text.Length > 0))
                {
                    this.ValidadUsuario();
                }
                else
                {
                    MessageBox.Show("Faltan datos!!!", "Atención");
                }
            }
        }

        private void ValidadUsuario()
        {
            this._empleados = new ClassPersonas();

            this._empleados.usuario = this.txtUsu.Text;
            this._empleados.pass = this.txtPass.Text;

            DataSet _empleado = this._empleados.LoginPersona(this._empleados, "login");


        }

        private void FormLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
