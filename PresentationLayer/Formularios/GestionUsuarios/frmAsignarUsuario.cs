using BusinessEntity;
using BusinessLogicLayer;
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
using System.Windows.Media.Media3D;

namespace PresentationLayer.Formularios.GestionUsuarios
{
    public partial class frmAsignarUsuario : MaterialForm
    {
        readonly MaterialSkinManager materialSkinManager;

        Empleado oEmpleado;
        EmpleadoBLL GestorEmpleado = new EmpleadoBLL();

        public frmAsignarUsuario(Empleado pEmpleado)
        {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Indigo500, Primary.Indigo700, Primary.Indigo100, Accent.Pink200, TextShade.WHITE);

            oEmpleado = pEmpleado;
        }

        private void btnConfirmarUsuario_Click(object sender, EventArgs e)
        {
            UsuarioBLL GestorUsuario = new UsuarioBLL();
            Usuario usuario = new Usuario();

            usuario.codEMP = oEmpleado.codEMP;
            usuario.NombreUsuario = txtUsuario.Text;
            usuario.Password = txtContraseña.Text;
            usuario.EstadoCuenta = "Activo";
            usuario.FechaCreacion = DateTime.Now;
            usuario.UltimoInicio = DateTime.Now;
            usuario.StateBlock = false;

            GestorUsuario.Agregar(usuario);
            oEmpleado.EsUsuario = 1;
            GestorEmpleado.Actualizar(oEmpleado);
        }

        private void frmAsignarUsuario_Load(object sender, EventArgs e)
        {
            txtUsuario.Text = GestorEmpleado.CrearNombreUsuario(oEmpleado);
            txtContraseña.Clear();
            txtConfirmacionContraseña.Clear();

            txtContraseña.Text = oEmpleado.DNI;
            txtConfirmacionContraseña.Text = oEmpleado.DNI;
        }



        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            checkPassword();
        }

        private void SwitchPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (SwitchPassword.Checked)
            {
                txtContraseña.Password = false;
                txtContraseña.Text = txtContraseña.Text;
                txtConfirmacionContraseña.Password = false;
                txtConfirmacionContraseña.Text = txtConfirmacionContraseña.Text;

                iconChar.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            }
            else
            {
                txtContraseña.Password = true;
                txtContraseña.Text = txtContraseña.Text;
                txtConfirmacionContraseña.Password = true;
                txtConfirmacionContraseña.Text = txtConfirmacionContraseña.Text;

                iconChar.IconChar = FontAwesome.Sharp.IconChar.Eye;

            }
        }

        private void btnConfirmarUsuario_MouseHover(object sender, EventArgs e)
        {
            checkPassword();
        }


        private void txtConfirmacionContraseña_TextChanged(object sender, EventArgs e)
        {
            checkPassword();
        }

        public void checkPassword()
        {
            if (!Equals(txtContraseña.Text, txtConfirmacionContraseña.Text))
            {
                btnConfirmarUsuario.Enabled = false;
                lblAvisoPassword.Text = "AVISO: LAS CONTRASEÑAS NO COINCIDEN";
                lblAvisoPassword.ForeColor = Color.Red;
            }
            else
            {
                btnConfirmarUsuario.Enabled = true;
                lblAvisoPassword.Text = "";
            }
        }
    }
}





