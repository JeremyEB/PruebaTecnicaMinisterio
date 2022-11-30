using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI1.Models.Request
{
    public class AlumnosRequest
    {
        public string NOMBRE { get; set; }
        public string APELLIDO { get; set; }
        public string FECHA_NACIMIENTO { get; set; }
        public string Materia_Espanol { get; set; }
        public string Materia_Matematicas { get; set; }
        public string Materia_Sociales { get; set; }
        public string Materia_Naturales { get; set; }
    }
}
