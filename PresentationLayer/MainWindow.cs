using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PresentationLayer.Formularios.GestionUsuarios;
using BusinessLogicLayer;
using SecurityLayer;
using PresentationLayer.Formularios;
using PresentationLayer.Formularios.Perfil;

namespace PresentationLayer
{
    public partial class MainWindow : MaterialForm
    {
        readonly MaterialSkinManager materialSkinManager;

        public MainWindow()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            //materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Indigo500, Primary.Indigo700, Primary.Indigo100, Accent.Pink200, TextShade.WHITE);

            //Application.Exit();
        }

        private void ShowChildFormInContainer(Form childForm, Panel containerPanel)
        {
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Location = new Point(0, 0);
            containerPanel.Controls.Clear();
            containerPanel.Controls.Add(childForm);
            childForm.Show();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            Form frmHome = new frmHome();
            ShowChildFormInContainer(frmHome, panelMainMenu);
        }

        private void btnConsultarEmpleados_Click(object sender, EventArgs e)
        {
            Form frmGestionUsuario = new frmGestionUsuario();
            ShowChildFormInContainer(frmGestionUsuario, panelMainMenu);
        }

        private void btnDesbloquearUsuario_Click(object sender, EventArgs e)
        {
            Form frmDesbloquearUsuario = new frmDesbloquearUsuario();
            ShowChildFormInContainer(frmDesbloquearUsuario,panelMainMenu);
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Estas cerrando la sesión, ¿Deseas continuar?", "Cierre de sesión", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
           
            if (resultado == DialogResult.OK)
            {
                SessionManager.Disconnect();
                this.Close();
            }
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void panelMainMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmHome = new frmHome();
            ShowChildFormInContainer(frmHome, panelMainMenu);
        }

        private void btnCambiarContraseña_Click(object sender, EventArgs e)
        {
            Form frmCambiarContraseña = new frmCambiarContraseña();
            ShowChildFormInContainer(frmCambiarContraseña, panelMainMenu);
        }
    }
}
