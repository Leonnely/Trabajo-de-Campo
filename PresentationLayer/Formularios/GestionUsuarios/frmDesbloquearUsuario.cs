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
    public partial class frmDesbloquearUsuario : Form
    {
        private MaterialSkinManager materialSkinManager;

        public frmDesbloquearUsuario()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            //materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Indigo500, Primary.Indigo700, Primary.Indigo100, Accent.Pink200, TextShade.WHITE);
        }

        UsuarioBLL GestorUsuario = new UsuarioBLL();
        private void frmDesbloquearUsuario_Load(object sender, EventArgs e)
        {

            dgvUsuariosBloqueados.DataSource = GestorUsuario.ObtenerUsuariosBloqueados();

            

        }


        private Usuario oUsuarioSeleccionado = null;
        private void dgvUsuariosBloqueados_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvUsuariosBloqueados.SelectedRows.Count > 0)
            {
                DataGridViewRow fila = dgvUsuariosBloqueados.SelectedRows[0];
                oUsuarioSeleccionado = (Usuario)fila.DataBoundItem;
                btnDesbloquearUsuario.Enabled = true;
            }
            else
            {
                oUsuarioSeleccionado = null;
                btnDesbloquearUsuario.Enabled = false;
            }
        }

        private void btnDesbloquearUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult resultado = MessageBox.Show($"Estas por desbloquear el usuario {oUsuarioSeleccionado.NombreUsuario}\n Desea Continuar?", "Desbloquear usuario", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (resultado == DialogResult.OK)
                {
                    oUsuarioSeleccionado.StateBlock = false;
                    GestorUsuario.Actualizar(oUsuarioSeleccionado);

                    dgvUsuariosBloqueados.DataSource = GestorUsuario.ObtenerUsuariosBloqueados();
                }
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
