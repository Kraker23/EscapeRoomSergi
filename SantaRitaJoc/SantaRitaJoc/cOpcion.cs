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

       
    }
}
