namespace PresentationLayer.Formularios.GestionUsuarios
{
    partial class frmGestionUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnModificarUsuario = new MaterialSkin.Controls.MaterialButton();
            this.btnAsignarCredenciales = new MaterialSkin.Controls.MaterialButton();
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // btnModificarUsuario
            // 
            this.btnModificarUsuario.AutoSize = false;
            this.btnModificarUsuario.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnModificarUsuario.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnModificarUsuario.Depth = 0;
            this.btnModificarUsuario.HighEmphasis = true;
            this.btnModificarUsuario.Icon = null;
            this.btnModificarUsuario.Location = new System.Drawing.Point(33, 374);
            this.btnModificarUsuario.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnModificarUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnModificarUsuario.Name = "btnModificarUsuario";
            this.btnModificarUsuario.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnModificarUsuario.Size = new System.Drawing.Size(55, 47);
            this.btnModificarUsuario.TabIndex = 5;
            this.btnModificarUsuario.Text = "Modificar usuario";
            this.btnModificarUsuario.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnModificarUsuario.UseAccentColor = false;
            this.btnModificarUsuario.UseVisualStyleBackColor = true;
            // 
            // btnAsignarCredenciales
            // 
            this.btnAsignarCredenciales.AutoSize = false;
            this.btnAsignarCredenciales.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAsignarCredenciales.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAsignarCredenciales.Depth = 0;
            this.btnAsignarCredenciales.HighEmphasis = true;
            this.btnAsignarCredenciales.Icon = null;
            this.btnAsignarCredenciales.Location = new System.Drawing.Point(553, 374);
            this.btnAsignarCredenciales.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAsignarCredenciales.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAsignarCredenciales.Name = "btnAsignarCredenciales";
            this.btnAsignarCredenciales.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAsignarCredenciales.Size = new System.Drawing.Size(185, 47);
            this.btnAsignarCredenciales.TabIndex = 4;
            this.btnAsignarCredenciales.Text = "Asignar Credenciales.";
            this.btnAsignarCredenciales.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAsignarCredenciales.UseAccentColor = false;
            this.btnAsignarCredenciales.UseVisualStyleBackColor = true;
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Location = new System.Drawing.Point(33, 12);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.Size = new System.Drawing.Size(692, 326);
            this.dgvEmpleados.TabIndex = 3;
            // 
            // frmGestionUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(751, 425);
            this.ControlBox = false;
            this.Controls.Add(this.btnModificarUsuario);
            this.Controls.Add(this.btnAsignarCredenciales);
            this.Controls.Add(this.dgvEmpleados);
            this.Name = "frmGestionUsuario";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmGestionUsuario";
            this.Load += new System.EventHandler(this.frmGestionUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btnModificarUsuario;
        private MaterialSkin.Controls.MaterialButton btnAsignarCredenciales;
        private System.Windows.Forms.DataGridView dgvEmpleados;
    }
}