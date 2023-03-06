using Newtonsoft.Json;
using SantaRitaJoc.Control;
using SantaRitaJoc.DM;
using System.Windows.Forms;

namespace SantaRitaJoc
{
    public partial class frmMain : Form
    {
        #region Propiedades y Constructor
        public enum tabsBase
        {
            tabInici,
            tabFinal
        }

        private TabControlHelper myHelper { get; set; }
        private Encuesta encuesta { get; set; }

        public frmMain()
        {
            InitializeComponent();

            // CrearJson();
            LeerDatosJson();

            CargarTabs();

        }
        #endregion

        #region CargaDatos
        public void CrearJson()
        {
            List<Pregunta> preguntas = new List<Pregunta>();
            int numPreguntas = 4;
            int numOpciones = 4;

            for (int p = 0; p < numPreguntas; p++)
            {
                Pregunta preguntaAux = new Pregunta();
                preguntaAux.codPregunta = $"Pregunta{p.ToString()}";
                preguntaAux.pregunta = $"Pregunta {p.ToString()}";

                for (int o = 0; o < numOpciones; o++)
                {
                    Opcion opcion = new Opcion();
                    opcion.descripcion = $"{preguntaAux.pregunta} -> Opcion {o.ToString()}";
                    opcion.rutaImagen = Path.Combine(Environment.CurrentDirectory, $"p{p}-o{o}.png");
                    if (o == 1)
                    {
                        opcion.verdadera = true;
                    }
                    preguntaAux.opciones.Add(opcion);
                }
                preguntas.Add(preguntaAux);
            }


            Encuesta encuesta = new Encuesta(preguntas);
            List<string> mensajesPrincipales = new List<string>();
            mensajesPrincipales.Add("Ja que cuidem els espais d’Olot, volem que ens diguis quins creus que són els llocs que veuràs a continuació.");
            mensajesPrincipales.Add("Selecciona el que creguis que és, però tingues en compte que el resultat pot variar en funció del que triïs.");
            encuesta.MensajePrincipal = mensajesPrincipales;

            encuesta.MensajeRegistoRespuestas = "Molt bé, s’han enregistrat les teves respostes i el codi és :";
            encuesta.MensajeCrearDuda = "Si has encertat, podràs continuar el joc. Si no, torna-ho a provar.";

            string output = JsonConvert.SerializeObject(encuesta);
        }
        private void LeerDatosJson()
        {
            string rutaArchivo = string.Format("{0}\\{1}", System.Windows.Forms.Application.StartupPath.ToString(), "datos.json");
            if (File.Exists(rutaArchivo))
            {
                string jsonDatos = File.ReadAllText(rutaArchivo);

                encuesta = new Encuesta();

                encuesta = JsonConvert.DeserializeObject<Encuesta>(jsonDatos);
            }
            else
            {
                MessageBox.Show("No se ha encontrado el archivo con los datos");
            }
        }


        #endregion

        #region Gestion Tabs
        private void CargarTabs()
        {
            //TabControl myTabControl = new TabControl();
            //myTabControl.Dock = DockStyle.Fill;
            // myHelper = new TabControlHelper(myTabControl); 
            myHelper = new TabControlHelper(tabControl);

            int contador = 1;
            foreach (Pregunta pregunta in encuesta.preguntas)
            {
                TabPage tab = new TabPage(pregunta.codPregunta);
                cEncuesta cEncuestaAux=CrearEncuesta(pregunta);
                cEncuestaAux.Dock = DockStyle.Fill;
                tab.Controls.Add(cEncuestaAux);


                myHelper.InsertTabPage(tab, contador);
                contador++;
            }


            myHelper.HidePage(tabsBase.tabFinal.ToString());

            this.Controls.Add(tabControl);

        }

        private cEncuesta CrearEncuesta(Pregunta pregunta)
        {
            cEncuesta cEncuestaAux = new cEncuesta(pregunta);
            return cEncuestaAux;
        }

        private void btEmpezar_Click(object sender, EventArgs e)
        {
           
        }

        private void btReiniciar_Click(object sender, EventArgs e)
        {
        }

        private void btSiguiente_Click(object sender, EventArgs e)
        {
        }

        #endregion
    }
}