using BusinessEntity;
using BusinessLogicLayer;
using MaterialSkin;
using MaterialSkin.Controls;
using SecurityLayer;
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
    public partial class frmGestionUsuario : MaterialForm
    {
        readonly MaterialSkinManager materialSkinManager;

        public frmGestionUsuario()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Indigo500, Primary.Indigo700, Primary.Indigo100, Accent.Pink200, TextShade.WHITE);
        }

        private void frmGestionUsuario_Load(object sender, EventArgs e)
        {
            EmpleadoBLL GestorEmpleado = new EmpleadoBLL();
            dgvEmpleados.DataSource = GestorEmpleado.ObtenerTodosSinUsuarios();
            
            btnAsignarCredenciales.Enabled = false;
        }

        private void dgvEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        Empleado oEmpleadoSeleccionado;
        private void dgvEmpleados_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvEmpleados.SelectedRows.Count > 0)
            {
                DataGridViewRow fila = dgvEmpleados.SelectedRows[0];
                oEmpleadoSeleccionado = (Empleado)fila.DataBoundItem;
                
                btnAsignarCredenciales.Enabled = true;

            }
        }

        private void btnAsignarCredenciales_Click(object sender, EventArgs e)
        {
            frmAsignarUsuario miForm = new frmAsignarUsuario(oEmpleadoSeleccionado);
            ShowChildFormInParent(miForm, this);
        }

        private void ShowChildFormInParent(Form childForm, Form parentForm)
        {
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            parentForm.Controls.Clear();
            parentForm.Controls.Add(childForm);

            childForm.Show();
        }


    }
}

