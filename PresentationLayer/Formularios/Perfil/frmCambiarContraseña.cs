using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLayer;
using SecurityLayer;

namespace PresentationLayer.Formularios.Perfil
{
    public partial class frmCambiarContraseña : Form
    {
        public frmCambiarContraseña()
        {
            InitializeComponent();
        }

        private void frmCambiarContraseña_Load(object sender, EventArgs e)
        {
            //groupBox1.Hide();
            groupBox2.Hide();
            btnCambiarContraseña.Enabled = false;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            CryptoManager cryptoManager = new CryptoManager();
            
            string passwordAct = txtContraseñaActual.Text;
            passwordAct = cryptoManager.HashPassword(passwordAct);

            if (passwordAct == SessionManager.getEmpleado().usuario.Password)
            {
                groupBox1.Hide();
                groupBox2.Show();
            }
        }

        private void btnCambiarContraseña_Click(object sender, EventArgs e)
        {
            CryptoManager cryptoManager = new CryptoManager();
            string passwordHash = cryptoManager.HashPassword(txtNuevaContraseña.Text);
            
            SessionManager.getEmpleado().usuario.Password = passwordHash;

            UsuarioBLL usuario = new UsuarioBLL();
            usuario.Actualizar(SessionManager.getEmpleado().usuario);

        }

        private void txtNuevaContraseña_TextChanged(object sender, EventArgs e)
        {
            checkPassword();
        }
        
        private void txtValidacionNuevaContraseña_TextChanged(object sender, EventArgs e)
        {
            checkPassword();
        }

        public void checkPassword()
        {
            if (!Equals(txtNuevaContraseña.Text, txtValidacionNuevaContraseña.Text))
            {
                btnCambiarContraseña.Enabled = false;
                lblAvisoPassword.Text = "AVISO: LAS CONTRASEÑAS NO COINCIDEN";
                lblAvisoPassword.ForeColor = Color.Red;
            }
            else
            {
                btnCambiarContraseña.Enabled = true;
                lblAvisoPassword.Text = "";
            }
        }

    }
}
