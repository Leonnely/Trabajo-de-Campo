using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.Formularios.GestionUsuarios
{
    public partial class frmCrearUsuario : UserControl
    {
        public frmCrearUsuario()
        {
            InitializeComponent();
        }

        private void CheckConfirmacionContraseña_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckConfirmacionContraseña.Checked)
            {
                txtConfirmacionContraseña.Enabled = true;
            }
            else
            {
                txtConfirmacionContraseña.Enabled = false;
            }
            
        }
    }
}
