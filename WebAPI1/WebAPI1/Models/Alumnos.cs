using System;
using System.Collections.Generic;

namespace WebAPI1.Models
{
    public partial class Alumnos
    {
        public int IdAlumnos { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string FechaNacimiento { get; set; }
        public string MateriaEspanol { get; set; }
        public string MateriaMatematicas { get; set; }
        public string MateriaSociales { get; set; }
        public string MateriaNaturales { get; set; }
    }
}
