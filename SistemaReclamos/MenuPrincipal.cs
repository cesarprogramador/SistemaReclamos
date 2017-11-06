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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void aBMEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABMEmpleados _empleado = new ABMEmpleados();
            _empleado.Show();
        }

        private void aBMClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABMClientes _cliente = new ABMClientes();
            _cliente.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void aBMReclamosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABMReclamos _reclamo = new ABMReclamos();
            _reclamo.Show();
        }
    }
}
