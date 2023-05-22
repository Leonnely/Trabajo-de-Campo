namespace PresentationLayer.Formularios
{
    partial class frmHome
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
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.lblDia = new MaterialSkin.Controls.MaterialLabel();
            this.lblReloj = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(214, 316);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(574, 10);
            this.materialDivider1.TabIndex = 5;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // lblDia
            // 
            this.lblDia.AutoSize = true;
            this.lblDia.Depth = 0;
            this.lblDia.Font = new System.Drawing.Font("Roboto Light", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblDia.FontType = MaterialSkin.MaterialSkinManager.fontType.H2;
            this.lblDia.Location = new System.Drawing.Point(244, 133);
            this.lblDia.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(482, 72);
            this.lblDia.TabIndex = 4;
            this.lblDia.Text = "Lunes 14 de Mayo";
            // 
            // lblReloj
            // 
            this.lblReloj.AutoSize = true;
            this.lblReloj.Depth = 0;
            this.lblReloj.Font = new System.Drawing.Font("Roboto Light", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblReloj.FontType = MaterialSkin.MaterialSkinManager.fontType.H2;
            this.lblReloj.Location = new System.Drawing.Point(412, 205);
            this.lblReloj.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblReloj.Name = "lblReloj";
            this.lblReloj.Size = new System.Drawing.Size(146, 72);
            this.lblReloj.TabIndex = 3;
            this.lblReloj.Text = "15:34";
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 585);
            this.ControlBox = false;
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.lblDia);
            this.Controls.Add(this.lblReloj);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmHome";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmHome";
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialLabel lblDia;
        private MaterialSkin.Controls.MaterialLabel lblReloj;
    }
}