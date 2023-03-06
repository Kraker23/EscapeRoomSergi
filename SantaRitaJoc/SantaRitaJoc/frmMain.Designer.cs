namespace SantaRitaJoc
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabInici = new System.Windows.Forms.TabPage();
            this.tabFinal = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btReiniciar = new System.Windows.Forms.Button();
            this.btEmpezar = new System.Windows.Forms.Button();
            this.btSiguiente = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabInici);
            this.tabControl.Controls.Add(this.tabFinal);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1263, 620);
            this.tabControl.TabIndex = 0;
            // 
            // tabInici
            // 
            this.tabInici.Location = new System.Drawing.Point(4, 24);
            this.tabInici.Name = "tabInici";
            this.tabInici.Padding = new System.Windows.Forms.Padding(3);
            this.tabInici.Size = new System.Drawing.Size(1255, 592);
            this.tabInici.TabIndex = 1;
            this.tabInici.Text = "Inici";
            this.tabInici.UseVisualStyleBackColor = true;
            // 
            // tabFinal
            // 
            this.tabFinal.Location = new System.Drawing.Point(4, 24);
            this.tabFinal.Name = "tabFinal";
            this.tabFinal.Size = new System.Drawing.Size(1255, 592);
            this.tabFinal.TabIndex = 2;
            this.tabFinal.Text = "Final";
            this.tabFinal.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btReiniciar);
            this.panel1.Controls.Add(this.btEmpezar);
            this.panel1.Controls.Add(this.btSiguiente);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 620);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1263, 100);
            this.panel1.TabIndex = 3;
            // 
            // btReiniciar
            // 
            this.btReiniciar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btReiniciar.Location = new System.Drawing.Point(1042, 39);
            this.btReiniciar.Name = "btReiniciar";
            this.btReiniciar.Size = new System.Drawing.Size(75, 23);
            this.btReiniciar.TabIndex = 5;
            this.btReiniciar.Text = "Reiniciar";
            this.btReiniciar.UseVisualStyleBackColor = true;
            this.btReiniciar.Click += new System.EventHandler(this.btReiniciar_Click);
            // 
            // btEmpezar
            // 
            this.btEmpezar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btEmpezar.Location = new System.Drawing.Point(961, 39);
            this.btEmpezar.Name = "btEmpezar";
            this.btEmpezar.Size = new System.Drawing.Size(75, 23);
            this.btEmpezar.TabIndex = 4;
            this.btEmpezar.Text = "Empezar";
            this.btEmpezar.UseVisualStyleBackColor = true;
            this.btEmpezar.Click += new System.EventHandler(this.btEmpezar_Click);
            // 
            // btSiguiente
            // 
            this.btSiguiente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btSiguiente.Location = new System.Drawing.Point(1123, 39);
            this.btSiguiente.Name = "btSiguiente";
            this.btSiguiente.Size = new System.Drawing.Size(75, 23);
            this.btSiguiente.TabIndex = 3;
            this.btSiguiente.Text = "Siguiente";
            this.btSiguiente.UseVisualStyleBackColor = true;
            this.btSiguiente.Click += new System.EventHandler(this.btSiguiente_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 720);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.panel1);
            this.Name = "frmMain";
            this.Text = "Santa Rita Joc";
            this.tabControl.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl;
        private TabPage tabInici;
        private Panel panel1;
        private Button btReiniciar;
        private Button btEmpezar;
        private Button btSiguiente;
        private TabPage tabFinal;
    }
}