using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("Permitir")]

    public class AlumnosController : ControllerBase
    {
        [HttpGet]
        public ActionResult Get()
        {
            using (Models.ESTUDIANTESContext db = new Models.ESTUDIANTESContext())
            {
                var lst = (from d in db.Alumnos
                           select d).ToList();

                return Ok(lst);
            }
        }

        [HttpPost]
        public ActionResult Post([FromBody] Models.Request.AlumnosRequest model)
        {
            using (Models.ESTUDIANTESContext db = new Models.ESTUDIANTESContext())
            {
                Models.Alumnos oAlumnos = new Models.Alumnos();
                oAlumnos.Nombre = model.NOMBRE;
                oAlumnos.Apellido = model.APELLIDO;
                oAlumnos.FechaNacimiento = model.FECHA_NACIMIENTO;
                oAlumnos.MateriaEspanol = model.Materia_Espanol;
                oAlumnos.MateriaMatematicas = model.Materia_Matematicas;
                oAlumnos.MateriaSociales = model.Materia_Sociales;
                oAlumnos.MateriaNaturales = model.Materia_Naturales;
                db.Alumnos.Add(oAlumnos);
                db.SaveChanges();
            }

            return Ok();
        }

        [HttpPut]
        public ActionResult Put([FromBody] Models.Request.AlumnosEditRequest model)
        {
            using (Models.ESTUDIANTESContext db = new Models.ESTUDIANTESContext())
            {
                Models.Alumnos oAlumnos = db.Alumnos.Find(model.ID_ALUMNOS);
                oAlumnos.Nombre = model.NOMBRE;
                oAlumnos.Apellido = model.APELLIDO;
                oAlumnos.FechaNacimiento = model.FECHA_NACIMIENTO;
                oAlumnos.MateriaEspanol = model.Materia_Espanol;
                oAlumnos.MateriaMatematicas = model.Materia_Matematicas;
                oAlumnos.MateriaSociales = model.Materia_Sociales;
                oAlumnos.MateriaNaturales = model.Materia_Naturales;
                db.Entry(oAlumnos).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                db.SaveChanges();
            }

            return Ok();
        }

        [HttpDelete]
        public ActionResult Delete([FromBody] Models.Request.AlumnosEditRequest model)
        {
            using (Models.ESTUDIANTESContext db = new Models.ESTUDIANTESContext())
            {
                Models.Alumnos oAlumnos = db.Alumnos.Find(model.ID_ALUMNOS);
                db.Alumnos.Remove(oAlumnos);
                db.SaveChanges();
            }

            return Ok();
        }
    }
}

