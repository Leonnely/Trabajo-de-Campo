namespace PresentationLayer.Formularios.Perfil
{
    partial class frmCambiarContraseña
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
            this.txtContraseñaActual = new MaterialSkin.Controls.MaterialTextBox();
            this.txtNuevaContraseña = new MaterialSkin.Controls.MaterialTextBox();
            this.txtValidacionNuevaContraseña = new MaterialSkin.Controls.MaterialTextBox();
            this.btnCambiarContraseña = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.btnConfirmar = new MaterialSkin.Controls.MaterialButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblAvisoPassword = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtContraseñaActual
            // 
            this.txtContraseñaActual.AnimateReadOnly = false;
            this.txtContraseñaActual.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContraseñaActual.Depth = 0;
            this.txtContraseñaActual.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtContraseñaActual.LeadingIcon = null;
            this.txtContraseñaActual.Location = new System.Drawing.Point(33, 44);
            this.txtContraseñaActual.MaxLength = 50;
            this.txtContraseñaActual.MouseState = MaterialSkin.MouseState.OUT;
            this.txtContraseñaActual.Multiline = false;
            this.txtContraseñaActual.Name = "txtContraseñaActual";
            this.txtContraseñaActual.Size = new System.Drawing.Size(282, 50);
            this.txtContraseñaActual.TabIndex = 0;
            this.txtContraseñaActual.Text = "";
            this.txtContraseñaActual.TrailingIcon = null;
            // 
            // txtNuevaContraseña
            // 
            this.txtNuevaContraseña.AnimateReadOnly = false;
            this.txtNuevaContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNuevaContraseña.Depth = 0;
            this.txtNuevaContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNuevaContraseña.LeadingIcon = null;
            this.txtNuevaContraseña.Location = new System.Drawing.Point(18, 44);
            this.txtNuevaContraseña.MaxLength = 50;
            this.txtNuevaContraseña.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNuevaContraseña.Multiline = false;
            this.txtNuevaContraseña.Name = "txtNuevaContraseña";
            this.txtNuevaContraseña.Size = new System.Drawing.Size(282, 50);
            this.txtNuevaContraseña.TabIndex = 1;
            this.txtNuevaContraseña.Text = "";
            this.txtNuevaContraseña.TrailingIcon = null;
            this.txtNuevaContraseña.TextChanged += new System.EventHandler(this.txtNuevaContraseña_TextChanged);
            // 
            // txtValidacionNuevaContraseña
            // 
            this.txtValidacionNuevaContraseña.AnimateReadOnly = false;
            this.txtValidacionNuevaContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtValidacionNuevaContraseña.Depth = 0;
            this.txtValidacionNuevaContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtValidacionNuevaContraseña.LeadingIcon = null;
            this.txtValidacionNuevaContraseña.Location = new System.Drawing.Point(18, 140);
            this.txtValidacionNuevaContraseña.MaxLength = 50;
            this.txtValidacionNuevaContraseña.MouseState = MaterialSkin.MouseState.OUT;
            this.txtValidacionNuevaContraseña.Multiline = false;
            this.txtValidacionNuevaContraseña.Name = "txtValidacionNuevaContraseña";
            this.txtValidacionNuevaContraseña.Size = new System.Drawing.Size(282, 50);
            this.txtValidacionNuevaContraseña.TabIndex = 2;
            this.txtValidacionNuevaContraseña.Text = "";
            this.txtValidacionNuevaContraseña.TrailingIcon = null;
            this.txtValidacionNuevaContraseña.TextChanged += new System.EventHandler(this.txtValidacionNuevaContraseña_TextChanged);
            // 
            // btnCambiarContraseña
            // 
            this.btnCambiarContraseña.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCambiarContraseña.Depth = 0;
            this.btnCambiarContraseña.HighEmphasis = true;
            this.btnCambiarContraseña.Icon = null;
            this.btnCambiarContraseña.Location = new System.Drawing.Point(439, 140);
            this.btnCambiarContraseña.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCambiarContraseña.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCambiarContraseña.Name = "btnCambiarContraseña";
            this.btnCambiarContraseña.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCambiarContraseña.Size = new System.Drawing.Size(191, 50);
            this.btnCambiarContraseña.TabIndex = 3;
            this.btnCambiarContraseña.Text = "Cambiar contraseña";
            this.btnCambiarContraseña.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCambiarContraseña.UseAccentColor = false;
            this.btnCambiarContraseña.UseVisualStyleBackColor = true;
            this.btnCambiarContraseña.Click += new System.EventHandler(this.btnCambiarContraseña_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(33, 19);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(130, 19);
            this.materialLabel1.TabIndex = 4;
            this.materialLabel1.Text = "Contraseña actual";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(18, 22);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(129, 19);
            this.materialLabel2.TabIndex = 5;
            this.materialLabel2.Text = "Nueva contraseña";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(18, 118);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(220, 19);
            this.materialLabel3.TabIndex = 6;
            this.materialLabel3.Text = "Nueva contraseña nuevamente";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnConfirmar.Depth = 0;
            this.btnConfirmar.HighEmphasis = true;
            this.btnConfirmar.Icon = null;
            this.btnConfirmar.Location = new System.Drawing.Point(439, 41);
            this.btnConfirmar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnConfirmar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnConfirmar.Size = new System.Drawing.Size(191, 50);
            this.btnConfirmar.TabIndex = 7;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnConfirmar.UseAccentColor = false;
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtContraseñaActual);
            this.groupBox1.Controls.Add(this.btnConfirmar);
            this.groupBox1.Controls.Add(this.materialLabel1);
            this.groupBox1.Location = new System.Drawing.Point(49, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(676, 100);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Contraseña actual";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblAvisoPassword);
            this.groupBox2.Controls.Add(this.txtNuevaContraseña);
            this.groupBox2.Controls.Add(this.txtValidacionNuevaContraseña);
            this.groupBox2.Controls.Add(this.btnCambiarContraseña);
            this.groupBox2.Controls.Add(this.materialLabel3);
            this.groupBox2.Controls.Add(this.materialLabel2);
            this.groupBox2.Location = new System.Drawing.Point(49, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(676, 238);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Contraseña nueva";
            // 
            // lblAvisoPassword
            // 
            this.lblAvisoPassword.AutoSize = true;
            this.lblAvisoPassword.Location = new System.Drawing.Point(18, 193);
            this.lblAvisoPassword.Name = "lblAvisoPassword";
            this.lblAvisoPassword.Size = new System.Drawing.Size(0, 13);
            this.lblAvisoPassword.TabIndex = 27;
            // 
            // frmCambiarContraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 493);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCambiarContraseña";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmCambiarContraseña";
            this.Load += new System.EventHandler(this.frmCambiarContraseña_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox txtContraseñaActual;
        private MaterialSkin.Controls.MaterialTextBox txtNuevaContraseña;
        private MaterialSkin.Controls.MaterialTextBox txtValidacionNuevaContraseña;
        private MaterialSkin.Controls.MaterialButton btnCambiarContraseña;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialButton btnConfirmar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblAvisoPassword;
    }
}