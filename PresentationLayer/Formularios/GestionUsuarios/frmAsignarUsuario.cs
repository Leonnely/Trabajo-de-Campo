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

        

        

        private int currentValue = 0;
        int incrementValue;

        private void btnConfirmarUsuario_Click(object sender, EventArgs e)
        {
            oEmpleado.NombreUsuario = txtUsuario.Text;

            UsuarioBLL GestorUsuario = new UsuarioBLL();
            Usuario usuario = new Usuario();
            usuario.NombreUsuario = txtUsuario.Text;
            usuario.EstadoCuenta = "Activo";
            usuario.FechaCreacion = DateTime.Now;
            usuario.UltimoInicio = DateTime.Now;
            usuario.codEMP = oEmpleado.codEMP;
            usuario.Password = txtContraseña.Text;

            GestorUsuario.Agregar(usuario);
            GestorEmpleado.Actualizar(oEmpleado);

            materialProgressBar1.Value = 0;
            Timer timer = new Timer();
            timer.Interval = 20;
            incrementValue = 100 / (2000 / timer.Interval);
            timer.Tick += Timer_Tick;
            timer.Start();
        }


        private void Timer_Tick(object sender, EventArgs e)
        {
            // Incrementar el valor de la barra de progreso
            currentValue += incrementValue;
            materialProgressBar1.Value = currentValue;

            // Verificar si se alcanzó el valor máximo (100)
            if (currentValue >= 100)
            {
                // Detener el temporizador
                Timer timer = (Timer)sender;
                timer.Stop();
            }
        }

        private void frmAsignarUsuario_Load(object sender, EventArgs e)
        {

           
            txtUsuario.Text = GestorEmpleado.CrearNombreUsuario(oEmpleado);
            //TODO: Buscar si existe ese usuario
            txtCorreo.Text = oEmpleado.Correo;

            //TODO: Para las contraseñas debe utilizarse el DNI
            txtContraseña.Text = oEmpleado.Telefono;
            txtConfirmacionContraseña.Text = oEmpleado.Telefono;
        }

        

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void SwitchPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (SwitchPassword.Checked)
            {
                txtContraseña.Password = false;
                txtContraseña.Text = oEmpleado.Telefono;
                txtConfirmacionContraseña.Password = false;
                SwitchPassword.Text = "Ocultar";
            }
            else
            {
                txtContraseña.Password = true;
                txtContraseña.Text = txtContraseña.Text;
                txtConfirmacionContraseña.Password = true;
                SwitchPassword.Text = "Ver";

            }
        }
    }
}





