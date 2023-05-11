using BusinessLogicLayer;
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
    public partial class frmGestionUsuario : Form
    {
        public frmGestionUsuario()
        {
            InitializeComponent();
        }

        private void frmGestionUsuario_Load(object sender, EventArgs e)
        {
            EmpleadoBLL GestorEmpleado = new EmpleadoBLL();
            
            foreach (var empleado in GestorEmpleado.ObtenerTodos())
            {
                dgvEmpleados.Rows.Add(empleado);
            }
            


        }
    }
}
