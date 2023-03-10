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
            this.txtInicio = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.btReiniciar = new System.Windows.Forms.Button();
            this.btEmpezar = new System.Windows.Forms.Button();
            this.btSiguiente = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabInici.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabInici);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.MaximumSize = new System.Drawing.Size(947, 725);
            this.tabControl.MinimumSize = new System.Drawing.Size(947, 725);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(947, 725);
            this.tabControl.TabIndex = 0;
            // 
            // tabInici
            // 
            this.tabInici.Controls.Add(this.txtInicio);
            this.tabInici.Location = new System.Drawing.Point(4, 24);
            this.tabInici.Name = "tabInici";
            this.tabInici.Padding = new System.Windows.Forms.Padding(3);
            this.tabInici.Size = new System.Drawing.Size(939, 697);
            this.tabInici.TabIndex = 1;
            this.tabInici.Text = "Inici";
            this.tabInici.UseVisualStyleBackColor = true;
            // 
            // txtInicio
            // 
            this.txtInicio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInicio.Enabled = false;
            this.txtInicio.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtInicio.Location = new System.Drawing.Point(146, 112);
            this.txtInicio.Multiline = true;
            this.txtInicio.Name = "txtInicio";
            this.txtInicio.Size = new System.Drawing.Size(627, 372);
            this.txtInicio.TabIndex = 7;
            this.txtInicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtInfo);
            this.panel1.Controls.Add(this.btReiniciar);
            this.panel1.Controls.Add(this.btEmpezar);
            this.panel1.Controls.Add(this.btSiguiente);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 725);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(947, 97);
            this.panel1.TabIndex = 3;
            // 
            // txtInfo
            // 
            this.txtInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInfo.Location = new System.Drawing.Point(4, 6);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(610, 77);
            this.txtInfo.TabIndex = 6;
            // 
            // btReiniciar
            // 
            this.btReiniciar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btReiniciar.Location = new System.Drawing.Point(724, 34);
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
            this.btEmpezar.Location = new System.Drawing.Point(643, 34);
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
            this.btSiguiente.Location = new System.Drawing.Point(805, 34);
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
            this.ClientSize = new System.Drawing.Size(947, 822);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl);
            this.MaximumSize = new System.Drawing.Size(963, 861);
            this.MinimumSize = new System.Drawing.Size(963, 861);
            this.Name = "frmMain";
            this.Text = "Santa Rita Joc";
            this.tabControl.ResumeLayout(false);
            this.tabInici.ResumeLayout(false);
            this.tabInici.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl;
        private TabPage tabInici;
        private Panel panel1;
        private Button btReiniciar;
        private Button btEmpezar;
        private Button btSiguiente;
        private TextBox txtInfo;
        private TextBox txtInicio;
    }
}