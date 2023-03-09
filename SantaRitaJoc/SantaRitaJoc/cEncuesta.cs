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
        public event ActualizarPreguntaEvent ActualizarPregunta;
        public delegate void ActualizarPreguntaEvent(Pregunta pregunta);
        private Pregunta pregunta { get; set; }
        public Dictionary<string,cOpcion> controles { get; set; }
        public cEncuesta()
        {
            InitializeComponent();
            controles = new Dictionary<string, cOpcion>();
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
                cOpcionAux.EventoOpcion += c_EventoOpcion;
                controles.Add(opcionAux.codOpcion, cOpcionAux);
                tbpOpciones.Controls.Add(cOpcionAux);
            }
        }

        private void c_EventoOpcion(Opcion opcion)
        {
            foreach (Opcion opc in pregunta.opciones)
            {
                if(opc.codOpcion==opcion.codOpcion)
                {
                    opc.seleccionada = opcion.seleccionada;                    
                }
                else if (opcion.seleccionada && opc.seleccionada)
                {
                    opc.seleccionada = false;
                    controles.First(x=>x.Key== opc.codOpcion).Value.DesmarcarSeleccion();
                }
            }


            ActualizarPregunta?.Invoke(pregunta);
        }
    }
}
