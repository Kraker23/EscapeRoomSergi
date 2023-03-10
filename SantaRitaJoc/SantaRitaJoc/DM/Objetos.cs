using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantaRitaJoc.DM
{
    public class Encuesta
    {
        public List<Pregunta> preguntas { get; set; }
        public Encuesta()
        {
            preguntas = new List<Pregunta>();
        }

        public Encuesta(List<Pregunta> preguntas)
        {
            this.preguntas = preguntas;
        }

        public bool mostrarLog { get; set; }
        public bool esCorrecta
        {
            get
            {
                if (preguntas.All(x => x.esCorrecta))
                {
                    return true;
                }
                return false;
            }
        }

        public List<string> MensajePrincipal { get; set; }

        public string CodigoResultado
        {
            get
            {
                string resultado = string.Empty;
                foreach (Pregunta preg in preguntas)
                {
                    resultado += preg.seleccion;
                }
                return resultado;
            }
        }
        public string CodigoCorrecto { get; set; }
        public string CodigoErroneo { get; set; }
        public string MensajeRegistoRespuestas { get; set; }
        public string MensajeCrearDuda { get; set; }

        public string ResultadoEncuesta
        {
            get
            {
                string resultado = string.Empty;
                if (esCorrecta)
                {
                    resultado = $"{MensajeRegistoRespuestas} {Environment.NewLine} {CodigoResultado}{Environment.NewLine} {MensajeCrearDuda}";
                }
                else
                {
                    resultado = $"{MensajeRegistoRespuestas} {Environment.NewLine} {CodigoResultado}{Environment.NewLine} {MensajeCrearDuda}";
                }
                return resultado;
            }
        }
    }
    public class Pregunta
    {
        public List<Opcion> opciones { get; set; }
        public string codPregunta { get; set; }
        public string pregunta { get; set; }
        public bool esCorrecta
        {
            get
            {
                if (opciones.Any(x => x.verdadera && x.seleccionada))
                {
                    return true;
                }
                return false;
            }
        }
        public string seleccion
        {
            get
            {
                Opcion aux=opciones.FirstOrDefault(x => x.seleccionada);
                return aux!=null?aux.codOpcion:"-";
            }
        }
        public Pregunta()
        {
            opciones = new List<Opcion>();
        }

        public Pregunta(List<Opcion> opciones)
        {
            this.opciones = opciones;
        }
    }


    public class Opcion
    {
        public string descripcion { get; set; }
        public string codOpcion { get; set; }
        public Image imagen
        {
            get
            {
                Image aux = null;

                if (!string.IsNullOrEmpty(Path.Combine(Environment.CurrentDirectory, rutaImagen)))
                {
                    if (File.Exists(Path.Combine(Environment.CurrentDirectory, rutaImagen)))
                    {
                        aux = Image.FromFile(Path.Combine(Environment.CurrentDirectory, rutaImagen));
                    }
                }
                return aux;

            }
        }
        public string rutaImagen { get; set; }
        public bool verdadera { get; set; }
        public bool seleccionada { get; set; }
    }
}
