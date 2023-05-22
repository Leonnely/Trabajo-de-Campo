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
            this.btnAsignarCredenciales = new MaterialSkin.Controls.MaterialButton();
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAsignarCredenciales
            // 
            this.btnAsignarCredenciales.AutoSize = false;
            this.btnAsignarCredenciales.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAsignarCredenciales.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAsignarCredenciales.Depth = 0;
            this.btnAsignarCredenciales.HighEmphasis = true;
            this.btnAsignarCredenciales.Icon = null;
            this.btnAsignarCredenciales.Location = new System.Drawing.Point(782, 384);
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
            this.btnAsignarCredenciales.Click += new System.EventHandler(this.btnAsignarCredenciales_Click);
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Location = new System.Drawing.Point(20, 27);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.Size = new System.Drawing.Size(947, 336);
            this.dgvEmpleados.TabIndex = 3;
            this.dgvEmpleados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmpleados_CellContentClick);
            this.dgvEmpleados.SelectionChanged += new System.EventHandler(this.dgvEmpleados_SelectionChanged);
            // 
            // frmGestionUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(997, 480);
            this.ControlBox = false;
            this.Controls.Add(this.btnAsignarCredenciales);
            this.Controls.Add(this.dgvEmpleados);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGestionUsuario";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Sizable = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmGestionUsuario";
            this.Load += new System.EventHandler(this.frmGestionUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialButton btnAsignarCredenciales;
        private System.Windows.Forms.DataGridView dgvEmpleados;
    }
}