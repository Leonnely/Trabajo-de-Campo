using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.Formularios
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            lblReloj.Text = DateTime.Now.ToString("HH:mm:ss");
            lblDia.Text = DateTime.Today.ToString("dddd") + " " + DateTime.Today.ToString("M");
            string formattedDateTime = DateTime.Now.ToString("HH:mm:ss");

            CenterControl(lblDia);
            CenterControl(lblReloj);
            CenterControl(materialDivider1);

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
            control.Location = new Point(x, control.Location.Y);
        }
    }
}
