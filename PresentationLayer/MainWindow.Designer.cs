namespace PresentationLayer
{
    partial class MainWindow
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMainMenu = new System.Windows.Forms.Panel();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.lblDia = new MaterialSkin.Controls.MaterialLabel();
            this.lblReloj = new MaterialSkin.Controls.MaterialLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnConsultarEmpleados = new FontAwesome.Sharp.IconMenuItem();
            this.btnDesbloquearUsuario = new FontAwesome.Sharp.IconMenuItem();
            this.configuracionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPerfil = new FontAwesome.Sharp.IconMenuItem();
            this.btnProfile = new FontAwesome.Sharp.IconMenuItem();
            this.btnCambiarContraseña = new FontAwesome.Sharp.IconMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCerrarSesion = new FontAwesome.Sharp.IconMenuItem();
            this.panelMainMenu.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMainMenu
            // 
            this.panelMainMenu.Controls.Add(this.materialDivider1);
            this.panelMainMenu.Controls.Add(this.lblDia);
            this.panelMainMenu.Controls.Add(this.lblReloj);
            this.panelMainMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainMenu.Location = new System.Drawing.Point(3, 118);
            this.panelMainMenu.Name = "panelMainMenu";
            this.panelMainMenu.Size = new System.Drawing.Size(996, 585);
            this.panelMainMenu.TabIndex = 1;
            this.panelMainMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMainMenu_Paint);
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(214, 302);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(574, 10);
            this.materialDivider1.TabIndex = 2;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // lblDia
            // 
            this.lblDia.AutoSize = true;
            this.lblDia.Depth = 0;
            this.lblDia.Font = new System.Drawing.Font("Roboto Light", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblDia.FontType = MaterialSkin.MaterialSkinManager.fontType.H2;
            this.lblDia.Location = new System.Drawing.Point(244, 119);
            this.lblDia.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(482, 72);
            this.lblDia.TabIndex = 1;
            this.lblDia.Text = "Lunes 14 de Mayo";
            // 
            // lblReloj
            // 
            this.lblReloj.AutoSize = true;
            this.lblReloj.Depth = 0;
            this.lblReloj.Font = new System.Drawing.Font("Roboto Light", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblReloj.FontType = MaterialSkin.MaterialSkinManager.fontType.H2;
            this.lblReloj.Location = new System.Drawing.Point(412, 191);
            this.lblReloj.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblReloj.Name = "lblReloj";
            this.lblReloj.Size = new System.Drawing.Size(146, 72);
            this.lblReloj.TabIndex = 0;
            this.lblReloj.Text = "15:34";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 93);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(996, 25);
            this.panel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Gainsboro;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.empleadosToolStripMenuItem,
            this.configuracionToolStripMenuItem,
            this.usuarioToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 64);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(996, 29);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(64, 25);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // empleadosToolStripMenuItem
            // 
            this.empleadosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnConsultarEmpleados,
            this.btnDesbloquearUsuario});
            this.empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            this.empleadosToolStripMenuItem.Size = new System.Drawing.Size(83, 25);
            this.empleadosToolStripMenuItem.Text = "Usuarios";
            this.empleadosToolStripMenuItem.Click += new System.EventHandler(this.empleadosToolStripMenuItem_Click);
            // 
            // btnConsultarEmpleados
            // 
            this.btnConsultarEmpleados.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.btnConsultarEmpleados.IconColor = System.Drawing.Color.Black;
            this.btnConsultarEmpleados.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnConsultarEmpleados.Name = "btnConsultarEmpleados";
            this.btnConsultarEmpleados.Size = new System.Drawing.Size(269, 26);
            this.btnConsultarEmpleados.Text = "Empleados sin credenciales";
            this.btnConsultarEmpleados.Click += new System.EventHandler(this.btnConsultarEmpleados_Click);
            // 
            // btnDesbloquearUsuario
            // 
            this.btnDesbloquearUsuario.IconChar = FontAwesome.Sharp.IconChar.UserLock;
            this.btnDesbloquearUsuario.IconColor = System.Drawing.Color.Black;
            this.btnDesbloquearUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDesbloquearUsuario.Name = "btnDesbloquearUsuario";
            this.btnDesbloquearUsuario.Size = new System.Drawing.Size(269, 26);
            this.btnDesbloquearUsuario.Text = "Desbloquear Usuario";
            this.btnDesbloquearUsuario.Click += new System.EventHandler(this.btnDesbloquearUsuario_Click);
            // 
            // configuracionToolStripMenuItem
            // 
            this.configuracionToolStripMenuItem.Name = "configuracionToolStripMenuItem";
            this.configuracionToolStripMenuItem.Size = new System.Drawing.Size(120, 25);
            this.configuracionToolStripMenuItem.Text = "Configuracion";
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnPerfil,
            this.toolStripSeparator1,
            this.btnCerrarSesion});
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(68, 25);
            this.usuarioToolStripMenuItem.Text = "Sesión";
            // 
            // btnPerfil
            // 
            this.btnPerfil.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnProfile,
            this.btnCambiarContraseña});
            this.btnPerfil.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerfil.IconChar = FontAwesome.Sharp.IconChar.User;
            this.btnPerfil.IconColor = System.Drawing.Color.Black;
            this.btnPerfil.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPerfil.Name = "btnPerfil";
            this.btnPerfil.Size = new System.Drawing.Size(180, 24);
            this.btnPerfil.Text = "Perfil";
            // 
            // btnProfile
            // 
            this.btnProfile.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnProfile.IconColor = System.Drawing.Color.Black;
            this.btnProfile.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(210, 24);
            this.btnProfile.Text = "Mi Perfil";
            // 
            // btnCambiarContraseña
            // 
            this.btnCambiarContraseña.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnCambiarContraseña.IconColor = System.Drawing.Color.Black;
            this.btnCambiarContraseña.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCambiarContraseña.Name = "btnCambiarContraseña";
            this.btnCambiarContraseña.Size = new System.Drawing.Size(210, 24);
            this.btnCambiarContraseña.Text = "Cambiar contraseña";
            this.btnCambiarContraseña.Click += new System.EventHandler(this.btnCambiarContraseña_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.btnCerrarSesion.IconColor = System.Drawing.Color.Black;
            this.btnCerrarSesion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(180, 24);
            this.btnCerrarSesion.Text = "Cerrar Sesión";
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 706);
            this.Controls.Add(this.panelMainMenu);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bienvenido";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.panelMainMenu.ResumeLayout(false);
            this.panelMainMenu.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMainMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem;
        private FontAwesome.Sharp.IconMenuItem btnConsultarEmpleados;
        private System.Windows.Forms.ToolStripMenuItem configuracionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private FontAwesome.Sharp.IconMenuItem btnPerfil;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private FontAwesome.Sharp.IconMenuItem btnCerrarSesion;
        private MaterialSkin.Controls.MaterialLabel lblReloj;
        private MaterialSkin.Controls.MaterialLabel lblDia;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private FontAwesome.Sharp.IconMenuItem btnDesbloquearUsuario;
        private FontAwesome.Sharp.IconMenuItem btnProfile;
        private FontAwesome.Sharp.IconMenuItem btnCambiarContraseña;
    }
}

