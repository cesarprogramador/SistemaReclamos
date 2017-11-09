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
        DataSet _emp;
        ClassPersonas _login;
        public string idpersona = "0";
        public string apellido = "";
        public string nombre = "";
        public string tipopersona = "";
       
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
            if ((this.txtUsu.Text.Length > 0) && (this.txtPass.Text.Length > 0))
            {
                this._login = new ClassPersonas();

                this._emp = new DataSet();

                this._login.usuario=this.txtUsu.Text;
                this._login.pass=this.txtPass.Text;

                this._emp = this._login.LoginPersona(this._login , "Login");

                if (this._emp.Tables["Login"].Rows.Count > 0)
                {
                    this.idpersona = this._emp.Tables["Login"].Rows[0][0].ToString();
                    this.apellido = this._emp.Tables["Login"].Rows[0][1].ToString();
                    this.nombre = this._emp.Tables["Login"].Rows[0][2].ToString();
                    this.tipopersona = this._emp.Tables["Login"].Rows[0][3].ToString();
               
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Los datos no se corresponde con ningún usuario!!!");
                }
            }
      }

        private void FormLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.idpersona == "0") Application.Exit();
        }
    }
}
