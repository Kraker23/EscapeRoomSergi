using Newtonsoft.Json;
using SantaRitaJoc.Control;
using SantaRitaJoc.DM;
using System.Windows.Forms;
using static System.Windows.Forms.Design.AxImporter;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
        private int paginaActual = 0;
        private TabControlHelper myHelper { get; set; }
        private Encuesta encuesta { get; set; }

        private System.Windows.Forms.TextBox txtFinal { get; set; }
        public Dictionary<string, cEncuesta> controles { get; set; }
        public frmMain()
        {
            InitializeComponent();

            controles = new Dictionary<string, cEncuesta>();
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
                    opcion.codOpcion = $"{preguntaAux.codPregunta}_Opcion{o.ToString()}";
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
            int contador = 1;
            foreach (Pregunta pregunta in encuesta.preguntas)
            {
                TabPage tab = new TabPage(pregunta.codPregunta);
                tab.Name = pregunta.codPregunta;
                cEncuesta cEncuestaAux = CrearEncuesta(pregunta);
                cEncuestaAux.Dock = DockStyle.Fill;
                cEncuestaAux.ActualizarPregunta += cEncuesta_ActualizarPregunta;
                tab.Controls.Add(cEncuestaAux);

                controles.Add(pregunta.codPregunta, cEncuestaAux);
                tabControl.TabPages.Add(tab);
                contador++;
            }

            CrearTextBoxResultado();

            TabPage tabFinal = new TabPage("Final");
            tabFinal.Name = tabsBase.tabFinal.ToString();
            tabFinal.Controls.Add(txtFinal);
            tabControl.TabPages.Add(tabFinal);

            myHelper = new TabControlHelper(tabControl);
            myHelper.HideAllPages();
            myHelper.ShowPage(tabsBase.tabInici.ToString());

            this.Controls.Add(tabControl);

            encuesta.MensajePrincipal.ForEach(x =>
            {
                txtInicio.Text += $"{x}  {Environment.NewLine}{Environment.NewLine}";
            });

            btEmpezar.Visible = true;
            btSiguiente.Visible = false;
            btReiniciar.Visible = false;

        }

        private void CrearTextBoxResultado()
        {
            txtFinal = new System.Windows.Forms.TextBox();

            txtFinal.Location = new System.Drawing.Point(146, 112);
            txtFinal.Multiline = true;
            txtFinal.Name = "txtInicio";
            txtFinal.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            txtFinal.Size = new System.Drawing.Size(627, 320);
            txtFinal.TabIndex = 7;
            txtFinal.Enabled = false;
            txtFinal.TextAlign = HorizontalAlignment.Center;
        }

        private cEncuesta CrearEncuesta(Pregunta pregunta)
        {
            cEncuesta cEncuestaAux = new cEncuesta(pregunta);
            return cEncuestaAux;
        }

        private void btEmpezar_Click(object sender, EventArgs e)
        {
            Pregunta preguntaAux = encuesta.preguntas.First();
            myHelper.ShowPage(preguntaAux.codPregunta);

            myHelper.HidePage(tabsBase.tabInici.ToString());

            paginaActual = encuesta.preguntas.IndexOf(preguntaAux);

            btEmpezar.Visible = false;
            btSiguiente.Visible = true;
            ActualizarInfo();
        }

        private void btSiguiente_Click(object sender, EventArgs e)
        {
            paginaActual++;
            if (encuesta.preguntas.Count() > paginaActual)
            {
                Pregunta preguntaAux = encuesta.preguntas[paginaActual];
                myHelper.ShowPage(preguntaAux.codPregunta);

                myHelper.HidePage(encuesta.preguntas[paginaActual - 1].codPregunta);

                btSiguiente.Visible = true;
                btReiniciar.Visible = false;
            }
            else
            {
                txtFinal.Text = encuesta.ResultadoEncuesta;
                myHelper.ShowPage(tabsBase.tabFinal.ToString());

                myHelper.HidePage(encuesta.preguntas[paginaActual - 1].codPregunta); ;

                btSiguiente.Visible = false;
                btReiniciar.Visible = true;
            }
        }

        private void btReiniciar_Click(object sender, EventArgs e)
        {
            paginaActual = 0;
            myHelper.ShowPage(tabsBase.tabInici.ToString());
            myHelper.HidePage(tabsBase.tabFinal.ToString());
            tabControl.SelectedTab = myHelper.GetTabPage(tabsBase.tabInici.ToString()).Key;

            encuesta.preguntas.ForEach(p =>
            {
                if (p.opciones.Any(o => o.seleccionada == false))
                {
                    controles.First(x => x.Key == p.codPregunta).Value.DesmarcarSeleccion();
                }
                //p.opciones.ForEach(o => o.seleccionada = false))
            });

            ActualizarInfo();
            btEmpezar.Visible = true;
            btSiguiente.Visible = false;
            btReiniciar.Visible = false;

        }

        #endregion


        private void cEncuesta_ActualizarPregunta(Pregunta pregunta)
        {
            foreach (Pregunta preg in encuesta.preguntas)
            {
                if (preg.codPregunta == pregunta.codPregunta)
                {
                    preg.opciones = pregunta.opciones;
                }
            }
            ActualizarInfo();
        }

        private void ActualizarInfo()
        {
            string info = string.Empty;
            foreach (Pregunta preg in encuesta.preguntas)
            {
                info += $"Pregunta ->{preg.codPregunta}, Seleccionada Opcion {preg.opciones.FirstOrDefault(x => x.seleccionada)?.codOpcion ?? "--"}  Correcta :{(preg.esCorrecta ? "Si" : "No")}. {Environment.NewLine} ";
            }
            txtInfo.Text = info;
        }
    }
}