namespace SantaRitaJoc
{
    partial class cOpcion
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.chkOpcion = new System.Windows.Forms.CheckBox();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // chkOpcion
            // 
            this.chkOpcion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkOpcion.AutoSize = true;
            this.chkOpcion.Location = new System.Drawing.Point(19, 17);
            this.chkOpcion.Name = "chkOpcion";
            this.chkOpcion.Size = new System.Drawing.Size(65, 19);
            this.chkOpcion.TabIndex = 1;
            this.chkOpcion.Text = "Opcion";
            this.chkOpcion.UseVisualStyleBackColor = true;
            this.chkOpcion.CheckedChanged += new System.EventHandler(this.chkOpcion_CheckedChanged);
            // 
            // pbImagen
            // 
            this.pbImagen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbImagen.Location = new System.Drawing.Point(19, 45);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(250, 168);
            this.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagen.TabIndex = 2;
            this.pbImagen.TabStop = false;
            // 
            // cOpcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pbImagen);
            this.Controls.Add(this.chkOpcion);
            this.Name = "cOpcion";
            this.Size = new System.Drawing.Size(294, 234);
            this.Load += new System.EventHandler(this.cOpcion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckBox chkOpcion;
        private PictureBox pbImagen;
    }
}
