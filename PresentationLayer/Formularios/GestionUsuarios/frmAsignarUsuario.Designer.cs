namespace PresentationLayer.Formularios.GestionUsuarios
{
    partial class frmAsignarUsuario
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
            this.btnConfirmarUsuario = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.txtConfirmacionContraseña = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.txtContraseña = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtUsuario = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtCorreo = new MaterialSkin.Controls.MaterialTextBox();
            this.SwitchPassword = new MaterialSkin.Controls.MaterialSwitch();
            this.SuspendLayout();
            // 
            // btnConfirmarUsuario
            // 
            this.btnConfirmarUsuario.AutoSize = false;
            this.btnConfirmarUsuario.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnConfirmarUsuario.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnConfirmarUsuario.Depth = 0;
            this.btnConfirmarUsuario.HighEmphasis = true;
            this.btnConfirmarUsuario.Icon = null;
            this.btnConfirmarUsuario.Location = new System.Drawing.Point(451, 315);
            this.btnConfirmarUsuario.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnConfirmarUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnConfirmarUsuario.Name = "btnConfirmarUsuario";
            this.btnConfirmarUsuario.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnConfirmarUsuario.Size = new System.Drawing.Size(167, 50);
            this.btnConfirmarUsuario.TabIndex = 22;
            this.btnConfirmarUsuario.Text = "Confirmar";
            this.btnConfirmarUsuario.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnConfirmarUsuario.UseAccentColor = false;
            this.btnConfirmarUsuario.UseVisualStyleBackColor = true;
            this.btnConfirmarUsuario.Click += new System.EventHandler(this.btnConfirmarUsuario_Click);
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(37, 293);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(157, 19);
            this.materialLabel4.TabIndex = 20;
            this.materialLabel4.Text = "Confirmar Contraseña";
            // 
            // txtConfirmacionContraseña
            // 
            this.txtConfirmacionContraseña.AnimateReadOnly = false;
            this.txtConfirmacionContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConfirmacionContraseña.Depth = 0;
            this.txtConfirmacionContraseña.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtConfirmacionContraseña.LeadingIcon = null;
            this.txtConfirmacionContraseña.Location = new System.Drawing.Point(37, 315);
            this.txtConfirmacionContraseña.MaxLength = 50;
            this.txtConfirmacionContraseña.MouseState = MaterialSkin.MouseState.OUT;
            this.txtConfirmacionContraseña.Multiline = false;
            this.txtConfirmacionContraseña.Name = "txtConfirmacionContraseña";
            this.txtConfirmacionContraseña.Password = true;
            this.txtConfirmacionContraseña.ReadOnly = true;
            this.txtConfirmacionContraseña.Size = new System.Drawing.Size(263, 50);
            this.txtConfirmacionContraseña.TabIndex = 19;
            this.txtConfirmacionContraseña.Text = "";
            this.txtConfirmacionContraseña.TrailingIcon = null;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(37, 205);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(82, 19);
            this.materialLabel3.TabIndex = 17;
            this.materialLabel3.Text = "Contraseña";
            // 
            // txtContraseña
            // 
            this.txtContraseña.AnimateReadOnly = false;
            this.txtContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContraseña.Depth = 0;
            this.txtContraseña.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtContraseña.LeadingIcon = null;
            this.txtContraseña.Location = new System.Drawing.Point(37, 227);
            this.txtContraseña.MaxLength = 50;
            this.txtContraseña.MouseState = MaterialSkin.MouseState.OUT;
            this.txtContraseña.Multiline = false;
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Password = true;
            this.txtContraseña.ReadOnly = true;
            this.txtContraseña.Size = new System.Drawing.Size(263, 50);
            this.txtContraseña.TabIndex = 16;
            this.txtContraseña.Text = "";
            this.txtContraseña.TrailingIcon = null;
            this.txtContraseña.TextChanged += new System.EventHandler(this.txtContraseña_TextChanged);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(37, 24);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(55, 19);
            this.materialLabel2.TabIndex = 15;
            this.materialLabel2.Text = "Usuario";
            // 
            // txtUsuario
            // 
            this.txtUsuario.AnimateReadOnly = false;
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Depth = 0;
            this.txtUsuario.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtUsuario.LeadingIcon = null;
            this.txtUsuario.Location = new System.Drawing.Point(37, 46);
            this.txtUsuario.MaxLength = 50;
            this.txtUsuario.MouseState = MaterialSkin.MouseState.OUT;
            this.txtUsuario.Multiline = false;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.ReadOnly = true;
            this.txtUsuario.Size = new System.Drawing.Size(263, 50);
            this.txtUsuario.TabIndex = 14;
            this.txtUsuario.Text = "";
            this.txtUsuario.TrailingIcon = null;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(37, 113);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(47, 19);
            this.materialLabel1.TabIndex = 13;
            this.materialLabel1.Text = "Correo";
            // 
            // txtCorreo
            // 
            this.txtCorreo.AnimateReadOnly = false;
            this.txtCorreo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCorreo.Depth = 0;
            this.txtCorreo.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCorreo.LeadingIcon = null;
            this.txtCorreo.Location = new System.Drawing.Point(37, 135);
            this.txtCorreo.MaxLength = 50;
            this.txtCorreo.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCorreo.Multiline = false;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.ReadOnly = true;
            this.txtCorreo.Size = new System.Drawing.Size(263, 50);
            this.txtCorreo.TabIndex = 12;
            this.txtCorreo.Text = "";
            this.txtCorreo.TrailingIcon = null;
            // 
            // SwitchPassword
            // 
            this.SwitchPassword.AutoSize = true;
            this.SwitchPassword.Depth = 0;
            this.SwitchPassword.Location = new System.Drawing.Point(306, 234);
            this.SwitchPassword.Margin = new System.Windows.Forms.Padding(0);
            this.SwitchPassword.MouseLocation = new System.Drawing.Point(-1, -1);
            this.SwitchPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.SwitchPassword.Name = "SwitchPassword";
            this.SwitchPassword.Ripple = true;
            this.SwitchPassword.Size = new System.Drawing.Size(81, 37);
            this.SwitchPassword.TabIndex = 23;
            this.SwitchPassword.Text = "Ver";
            this.SwitchPassword.UseVisualStyleBackColor = true;
            this.SwitchPassword.CheckedChanged += new System.EventHandler(this.SwitchPassword_CheckedChanged);
            // 
            // frmAsignarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 437);
            this.ControlBox = false;
            this.Controls.Add(this.SwitchPassword);
            this.Controls.Add(this.btnConfirmarUsuario);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.txtConfirmacionContraseña);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.txtCorreo);
            this.Name = "frmAsignarUsuario";
            this.Sizable = false;
            this.Text = "frmAsignarUsuario";
            this.Load += new System.EventHandler(this.frmAsignarUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btnConfirmarUsuario;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialTextBox txtConfirmacionContraseña;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialTextBox txtContraseña;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialTextBox txtUsuario;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox txtCorreo;
        private MaterialSkin.Controls.MaterialSwitch SwitchPassword;
    }
}