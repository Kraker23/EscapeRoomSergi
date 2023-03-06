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
                    resultado = $"{MensajeRegistoRespuestas} {Environment.NewLine} {CodigoCorrecto}{Environment.NewLine} {MensajeCrearDuda}";
                }
                else
                {
                    resultado = $"{MensajeRegistoRespuestas} {Environment.NewLine} {CodigoErroneo}{Environment.NewLine} {MensajeCrearDuda}";
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
        public Image imagen
        {
            get
            {
                Image aux = null;
                if (!string.IsNullOrEmpty(rutaImagen))
                {
                    if (File.Exists(rutaImagen))
                    {
                        aux = Image.FromFile(rutaImagen);
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
