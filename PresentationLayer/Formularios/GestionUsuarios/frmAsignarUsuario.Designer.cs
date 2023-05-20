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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAsignarUsuario));
            this.btnConfirmarUsuario = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.txtConfirmacionContraseña = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.txtContraseña = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtUsuario = new MaterialSkin.Controls.MaterialTextBox();
            this.SwitchPassword = new MaterialSkin.Controls.MaterialSwitch();
            this.iconChar = new FontAwesome.Sharp.IconPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAvisoPassword = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.iconChar)).BeginInit();
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
            this.btnConfirmarUsuario.Location = new System.Drawing.Point(450, 282);
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
            this.btnConfirmarUsuario.MouseHover += new System.EventHandler(this.btnConfirmarUsuario_MouseHover);
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(34, 260);
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
            this.txtConfirmacionContraseña.Location = new System.Drawing.Point(34, 282);
            this.txtConfirmacionContraseña.MaxLength = 50;
            this.txtConfirmacionContraseña.MouseState = MaterialSkin.MouseState.OUT;
            this.txtConfirmacionContraseña.Multiline = false;
            this.txtConfirmacionContraseña.Name = "txtConfirmacionContraseña";
            this.txtConfirmacionContraseña.Password = true;
            this.txtConfirmacionContraseña.Size = new System.Drawing.Size(263, 50);
            this.txtConfirmacionContraseña.TabIndex = 19;
            this.txtConfirmacionContraseña.Text = "";
            this.txtConfirmacionContraseña.TrailingIcon = null;
            this.txtConfirmacionContraseña.TextChanged += new System.EventHandler(this.txtConfirmacionContraseña_TextChanged);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(31, 163);
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
            this.txtContraseña.Location = new System.Drawing.Point(34, 194);
            this.txtContraseña.MaxLength = 50;
            this.txtContraseña.MouseState = MaterialSkin.MouseState.OUT;
            this.txtContraseña.Multiline = false;
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Password = true;
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
            this.materialLabel2.Location = new System.Drawing.Point(34, 59);
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
            this.txtUsuario.Location = new System.Drawing.Point(34, 81);
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
            // SwitchPassword
            // 
            this.SwitchPassword.AutoSize = true;
            this.SwitchPassword.Depth = 0;
            this.SwitchPassword.Location = new System.Drawing.Point(198, 154);
            this.SwitchPassword.Margin = new System.Windows.Forms.Padding(0);
            this.SwitchPassword.MouseLocation = new System.Drawing.Point(-1, -1);
            this.SwitchPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.SwitchPassword.Name = "SwitchPassword";
            this.SwitchPassword.Ripple = true;
            this.SwitchPassword.Size = new System.Drawing.Size(58, 37);
            this.SwitchPassword.TabIndex = 23;
            this.SwitchPassword.UseVisualStyleBackColor = true;
            this.SwitchPassword.CheckedChanged += new System.EventHandler(this.SwitchPassword_CheckedChanged);
            // 
            // iconChar
            // 
            this.iconChar.BackColor = System.Drawing.SystemColors.Control;
            this.iconChar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconChar.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.iconChar.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconChar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconChar.Location = new System.Drawing.Point(259, 157);
            this.iconChar.Name = "iconChar";
            this.iconChar.Size = new System.Drawing.Size(32, 32);
            this.iconChar.TabIndex = 24;
            this.iconChar.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(359, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 104);
            this.label1.TabIndex = 25;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // lblAvisoPassword
            // 
            this.lblAvisoPassword.AutoSize = true;
            this.lblAvisoPassword.Location = new System.Drawing.Point(34, 339);
            this.lblAvisoPassword.Name = "lblAvisoPassword";
            this.lblAvisoPassword.Size = new System.Drawing.Size(0, 13);
            this.lblAvisoPassword.TabIndex = 26;
            // 
            // frmAsignarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 417);
            this.ControlBox = false;
            this.Controls.Add(this.lblAvisoPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.iconChar);
            this.Controls.Add(this.SwitchPassword);
            this.Controls.Add(this.btnConfirmarUsuario);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.txtConfirmacionContraseña);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.txtUsuario);
            this.Name = "frmAsignarUsuario";
            this.Sizable = false;
            this.Text = "frmAsignarUsuario";
            this.Load += new System.EventHandler(this.frmAsignarUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconChar)).EndInit();
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
        private MaterialSkin.Controls.MaterialSwitch SwitchPassword;
        private FontAwesome.Sharp.IconPictureBox iconChar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAvisoPassword;
    }
}