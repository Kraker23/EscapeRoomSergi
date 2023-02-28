namespace SantaRitaJoc
{
    partial class cEncuesta
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
            this.scBase = new System.Windows.Forms.SplitContainer();
            this.lblPregunta = new System.Windows.Forms.Label();
            this.tbpOpciones = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.scBase)).BeginInit();
            this.scBase.Panel1.SuspendLayout();
            this.scBase.Panel2.SuspendLayout();
            this.scBase.SuspendLayout();
            this.SuspendLayout();
            // 
            // scBase
            // 
            this.scBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scBase.Location = new System.Drawing.Point(0, 0);
            this.scBase.Name = "scBase";
            this.scBase.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scBase.Panel1
            // 
            this.scBase.Panel1.Controls.Add(this.lblPregunta);
            this.scBase.Panel1MinSize = 100;
            // 
            // scBase.Panel2
            // 
            this.scBase.Panel2.Controls.Add(this.tbpOpciones);
            this.scBase.Size = new System.Drawing.Size(700, 700);
            this.scBase.SplitterDistance = 118;
            this.scBase.TabIndex = 1;
            // 
            // lblPregunta
            // 
            this.lblPregunta.AutoSize = true;
            this.lblPregunta.Location = new System.Drawing.Point(20, 14);
            this.lblPregunta.Name = "lblPregunta";
            this.lblPregunta.Size = new System.Drawing.Size(38, 15);
            this.lblPregunta.TabIndex = 0;
            this.lblPregunta.Text = "label1";
            // 
            // tbpOpciones
            // 
            this.tbpOpciones.ColumnCount = 2;
            this.tbpOpciones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbpOpciones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbpOpciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbpOpciones.Location = new System.Drawing.Point(0, 0);
            this.tbpOpciones.Name = "tbpOpciones";
            this.tbpOpciones.RowCount = 2;
            this.tbpOpciones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbpOpciones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbpOpciones.Size = new System.Drawing.Size(700, 578);
            this.tbpOpciones.TabIndex = 0;
            // 
            // cEncuesta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.scBase);
            this.Name = "cEncuesta";
            this.Size = new System.Drawing.Size(700, 700);
            this.scBase.Panel1.ResumeLayout(false);
            this.scBase.Panel1.PerformLayout();
            this.scBase.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scBase)).EndInit();
            this.scBase.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer scBase;
        private Label lblPregunta;
        private TableLayoutPanel tbpOpciones;
    }
}
