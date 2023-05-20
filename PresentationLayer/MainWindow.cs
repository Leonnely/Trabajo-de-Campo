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
            //childForm.Location = new Point(0, 0);
            containerPanel.Controls.Clear();
            containerPanel.Controls.Add(childForm);
            childForm.Show();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            lblDia.Text = DateTime.Today.ToString("dddd") + " " + DateTime.Today.ToString("M");
            string formattedDateTime = DateTime.Now.ToString("HH:mm:ss");

            
            Timer timer = new Timer();
            timer.Interval = 1000; // 1000 ms = 1 segundo
            timer.Tick += Timer_Tick;
            timer.Start();

            
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Formatear la fecha y hora actual en el formato deseado
            string formattedDateTime = DateTime.Now.ToString("HH:mm:ss");

            // Actualizar el texto del reloj con el formato personalizado
            lblReloj.Text = formattedDateTime;
            CenterControl(lblDia);
            CenterControl(lblReloj);
        }

        private void CenterControl(Control control)
        {
            int x = (this.ClientSize.Width - control.Width) / 2;
            control.Location = new Point(x,control.Location.Y);
        }

        private void MainWindow_FormClosed(object sender, FormClosedEventArgs e)
        {

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

        
    }
}
