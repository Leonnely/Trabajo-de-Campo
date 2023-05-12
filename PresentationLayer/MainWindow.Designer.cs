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
            this.panel1 = new System.Windows.Forms.Panel();
            this.toggleMode = new MaterialSkin.Controls.MaterialSwitch();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.empleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnConsultarEmpleados = new FontAwesome.Sharp.IconMenuItem();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMainMenu
            // 
            this.panelMainMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainMenu.Location = new System.Drawing.Point(3, 130);
            this.panelMainMenu.Name = "panelMainMenu";
            this.panelMainMenu.Size = new System.Drawing.Size(996, 573);
            this.panelMainMenu.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.toggleMode);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(996, 42);
            this.panel1.TabIndex = 0;
            // 
            // toggleMode
            // 
            this.toggleMode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.toggleMode.AutoSize = true;
            this.toggleMode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.toggleMode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toggleMode.Depth = 0;
            this.toggleMode.ForeColor = System.Drawing.Color.Transparent;
            this.toggleMode.Location = new System.Drawing.Point(929, 5);
            this.toggleMode.Margin = new System.Windows.Forms.Padding(0);
            this.toggleMode.MouseLocation = new System.Drawing.Point(-1, -1);
            this.toggleMode.MouseState = MaterialSkin.MouseState.HOVER;
            this.toggleMode.Name = "toggleMode";
            this.toggleMode.Ripple = true;
            this.toggleMode.Size = new System.Drawing.Size(58, 37);
            this.toggleMode.TabIndex = 7;
            this.toggleMode.UseVisualStyleBackColor = false;
            this.toggleMode.CheckedChanged += new System.EventHandler(this.toggleMode_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.empleadosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 64);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(996, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // empleadosToolStripMenuItem
            // 
            this.empleadosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnConsultarEmpleados});
            this.empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            this.empleadosToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.empleadosToolStripMenuItem.Text = "Empleados";
            // 
            // btnConsultarEmpleados
            // 
            this.btnConsultarEmpleados.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.btnConsultarEmpleados.IconColor = System.Drawing.Color.Black;
            this.btnConsultarEmpleados.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnConsultarEmpleados.Name = "btnConsultarEmpleados";
            this.btnConsultarEmpleados.Size = new System.Drawing.Size(186, 22);
            this.btnConsultarEmpleados.Text = "Consultar Empleados";
            this.btnConsultarEmpleados.Click += new System.EventHandler(this.btnConsultarEmpleados_Click);
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
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainWindow_FormClosed);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMainMenu;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialSwitch toggleMode;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem;
        private FontAwesome.Sharp.IconMenuItem btnConsultarEmpleados;
    }
}

