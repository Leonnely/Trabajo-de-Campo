namespace PresentationLayer.Formularios.GestionUsuarios
{
    partial class frmDesbloquearUsuario
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
            this.dgvUsuariosBloqueados = new System.Windows.Forms.DataGridView();
            this.btnDesbloquearUsuario = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuariosBloqueados)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUsuariosBloqueados
            // 
            this.dgvUsuariosBloqueados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuariosBloqueados.Location = new System.Drawing.Point(59, 34);
            this.dgvUsuariosBloqueados.Name = "dgvUsuariosBloqueados";
            this.dgvUsuariosBloqueados.Size = new System.Drawing.Size(873, 327);
            this.dgvUsuariosBloqueados.TabIndex = 0;
            this.dgvUsuariosBloqueados.SelectionChanged += new System.EventHandler(this.dgvUsuariosBloqueados_SelectionChanged);
            // 
            // btnDesbloquearUsuario
            // 
            this.btnDesbloquearUsuario.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDesbloquearUsuario.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDesbloquearUsuario.Depth = 0;
            this.btnDesbloquearUsuario.HighEmphasis = true;
            this.btnDesbloquearUsuario.Icon = null;
            this.btnDesbloquearUsuario.Location = new System.Drawing.Point(723, 403);
            this.btnDesbloquearUsuario.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDesbloquearUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDesbloquearUsuario.Name = "btnDesbloquearUsuario";
            this.btnDesbloquearUsuario.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDesbloquearUsuario.Size = new System.Drawing.Size(188, 36);
            this.btnDesbloquearUsuario.TabIndex = 1;
            this.btnDesbloquearUsuario.Text = "Desbloquear usuario";
            this.btnDesbloquearUsuario.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDesbloquearUsuario.UseAccentColor = false;
            this.btnDesbloquearUsuario.UseVisualStyleBackColor = true;
            this.btnDesbloquearUsuario.Click += new System.EventHandler(this.btnDesbloquearUsuario_Click);
            // 
            // frmDesbloquearUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(976, 480);
            this.ControlBox = false;
            this.Controls.Add(this.btnDesbloquearUsuario);
            this.Controls.Add(this.dgvUsuariosBloqueados);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDesbloquearUsuario";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmDesbloquearUsuario";
            this.Load += new System.EventHandler(this.frmDesbloquearUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuariosBloqueados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsuariosBloqueados;
        private MaterialSkin.Controls.MaterialButton btnDesbloquearUsuario;
    }
}