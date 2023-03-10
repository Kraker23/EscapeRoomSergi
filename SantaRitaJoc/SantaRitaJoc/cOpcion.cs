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
using static System.Net.Mime.MediaTypeNames;

namespace SantaRitaJoc
{
    public partial class cOpcion : UserControl
    {
        public event OpcionEvent EventoOpcion;
        public delegate void OpcionEvent(Opcion opcion);

        public Opcion opcion { get; set; }
        public bool esSelecionada
        {
            get
            {
                opcion.seleccionada = false;
                if (chkOpcion.Checked)
                {
                    opcion.seleccionada = true;
                }
                return opcion.seleccionada;
            }
        }


        public bool marcando { get; set; }
        public cOpcion()
        {
            InitializeComponent();
        }

        public cOpcion(Opcion opcion) : this()
        {
            this.opcion = opcion;
        }

        private void cOpcion_Load(object sender, EventArgs e)
        {
            LoadOpcion();
        }

        public void LoadOpcion()
        {

            this.chkOpcion.Text = opcion.descripcion;
            this.pbImagen.Image = opcion.imagen;
        }

        private void chkOpcion_CheckedChanged(object sender, EventArgs e)
        {
            if (!marcando)
            {
                marcando = true;
                opcion.seleccionada = this.chkOpcion.Checked;
                EventoOpcion?.Invoke(opcion);
                marcando = false;
            }
        }

        public void DesmarcarSeleccion()
        {
            this.chkOpcion.Checked=opcion.seleccionada = false;
        }

        private void cOpcion_Click(object sender, EventArgs e)
        {
            if (!marcando)
            {
                marcando = true;
                opcion.seleccionada = this.chkOpcion.Checked=! this.chkOpcion.Checked;
                EventoOpcion?.Invoke(opcion);
                marcando = false;
            }
        }

        private void pbImagen_Click(object sender, EventArgs e)
        {
            if (!marcando)
            {
                marcando = true;
                opcion.seleccionada = this.chkOpcion.Checked = !this.chkOpcion.Checked;
                EventoOpcion?.Invoke(opcion);
                marcando = false;
            }

        }
    }
}
