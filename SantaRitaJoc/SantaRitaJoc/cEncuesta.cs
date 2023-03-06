using SantaRitaJoc.DM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SantaRitaJoc
{
    public partial class cEncuesta : UserControl
    {
        private Pregunta pregunta { get; set; }
        public cEncuesta()
        {
            InitializeComponent();
        }
        public cEncuesta(Pregunta pregunta ) :this()
        {
            this.pregunta = pregunta;
        }

        private void cEncuesta_Load(object sender, EventArgs e)
        {
            lblPregunta.Text = pregunta.pregunta;
            foreach (Opcion opcionAux in pregunta.opciones)
            {
                cOpcion cOpcionAux = new cOpcion(opcionAux);
                cOpcionAux.Dock = DockStyle.Fill;
                tbpOpciones.Controls.Add(cOpcionAux);
            }
        }
    }
}
