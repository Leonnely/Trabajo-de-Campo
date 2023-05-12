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
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Indigo500, Primary.Indigo700, Primary.Indigo100, Accent.Pink200, TextShade.WHITE);

            Application.Exit();
        }

        private void toggleMode_CheckedChanged(object sender, EventArgs e)
        {
            if (toggleMode.Checked)
            {
                materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            }
            else
            {
                materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;

            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {

        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            
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

        }

        private void MainWindow_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void btnConsultarEmpleados_Click(object sender, EventArgs e)
        {
            Form frmGestionUsuario = new frmGestionUsuario();
            ShowChildFormInContainer(frmGestionUsuario, panelMainMenu);
        }
    }
}
