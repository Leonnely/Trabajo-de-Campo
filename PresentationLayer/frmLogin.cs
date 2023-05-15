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

namespace PresentationLayer
{
    public partial class frmLogin : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;

        public frmLogin()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo500, MaterialSkin.Primary.Indigo700, MaterialSkin.Primary.Indigo100, MaterialSkin.Accent.Pink200, MaterialSkin.TextShade.WHITE);
        
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

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            LoginController loginController = new LoginController();
            string identificador = txtIdentificador.Text;
            string password = txtPassword.Text;

            if (loginController.Login(identificador,password))
            {
                //Ya realizo la logica de sesion

                loginController = null;
                MainWindow mainWindow = new MainWindow();
                this.Hide();
                mainWindow.ShowDialog();

                txtIdentificador.Clear();
                txtPassword.Clear();
                this.Show();
            }
            else
            {
                loginController.restarIntento();
                if (loginController.Intentos == 0)
                {
                    loginController.BlockUsuario(identificador);
                }
                MessageBox.Show("Correo/Usuario o Contraseña incorrectos");
            }
            
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtIdentificador.Text = "CaRo55";
            txtPassword.Text = "5555555555";
        }
    }
}
