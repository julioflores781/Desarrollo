using Modelo.Prueba;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace PruebaWE.Controllers
{
    public class PersonaController:ApiController
    {
        [HttpGet]
        [Route("api/ObtenerPersona")]
        public IHttpActionResult ObtenerPersona()
        {

            DBEntitiesPrueba db = new DBEntitiesPrueba();


            List<Persona> TBPersona = new List<Persona>();
            TBPersona = (from datos in db.Persona
                         select datos).ToList();

            var Resultado = TBPersona.Select(d => new
            {
                d.codigo_personal,
                d.documento,
                d.nombre,
                d.apellido1,
                d.telefono,
                d.fecha_creacion
            }).ToList();



            return Ok(Resultado);
        }





        //obtenerPersona por id 
        [HttpGet]
        [Route("api/ObtenerPersona")]
        public IHttpActionResult ObtenerPersona(int id)
        {

            DBEntitiesPrueba db = new DBEntitiesPrueba();


            Persona TBPersona = new Persona();
            TBPersona = (from datos in db.Persona
                         where datos.codigo_personal==id
                         select datos).FirstOrDefault();

           

            return Ok(TBPersona);
        }
        //obtenerPersona por nombre
        [HttpGet]
        [Route("api/ObtenerPersona")]
        public IHttpActionResult ObtenerPersona(string nombre )
        {

            DBEntitiesPrueba db = new DBEntitiesPrueba();


            Persona TBPersona = new Persona();
            TBPersona = (from datos in db.Persona
                         where  datos.nombre.Equals(nombre)
                         select datos).FirstOrDefault();

            return Ok(TBPersona);
        }

        //obtenerPersona por Documento
        [HttpGet]
        [Route("api/obtenerPersonaDocumento")]
        public IHttpActionResult ObtenerPersonaDocumento(string documento)
        {

            DBEntitiesPrueba db = new DBEntitiesPrueba();


            Persona TBPersona = new Persona();
            TBPersona = (from datos in db.Persona
                         where datos.documento.Equals(documento)
                         select datos).FirstOrDefault();

            return Ok(TBPersona);
        }

        //obtenerPersona por Apellido
        [HttpGet]
        [Route("api/obtenerPersonaApellido")]
        public IHttpActionResult ObtenerPersonaApellido(string apellido1)
        {

            DBEntitiesPrueba db = new DBEntitiesPrueba();


            Persona TBPersona = new Persona();
            TBPersona = (from datos in db.Persona
                         where datos.apellido1.Equals(apellido1)
                         select datos).FirstOrDefault();
            return Ok(TBPersona);
        }

        //CreaPersona
        [HttpPost]
        [Route("api/CreaPersona")]
        public IHttpActionResult CreaPersona(Modelo.Prueba.Class1 models)
        {

            DBEntitiesPrueba db = new DBEntitiesPrueba();
            Persona TBPersona = new Persona();

            TBPersona.documento = models.documento;
            TBPersona.nombre = models.nombre;
            TBPersona.apellido1 = models.apellido1;
            TBPersona.fecha_creacion = DateTime.Now;

            db.Persona.Add(TBPersona);
            db.SaveChanges();
            return Ok("Exito");
        }

        //ModificaPersona
        [HttpPost]
        [Route("api/ModificaPersona")]
        public IHttpActionResult ModificaPersona(Persona models)
        {

            DBEntitiesPrueba db = new DBEntitiesPrueba();
          
            var prueba = from Persona in db.Persona
                         where Persona.codigo_personal==models.codigo_personal
                         select Persona;
                         
            if (prueba.Count()>0) {

                Persona encontrado = prueba.First();

                encontrado.documento = models.documento;
                encontrado.nombre = models.nombre;
                encontrado.apellido1 = models.apellido1;
                encontrado.fecha_creacion = DateTime.Now;

            
            db.SaveChanges();
            }
            else
            {
                
            }

            return Ok("Exito");
        }

        //obtenerPersona por id 
        [HttpGet]
        [Route("api/EliminaPersona")]
        public IHttpActionResult EliminaPersona(int id)
        {
            DBEntitiesPrueba db = new DBEntitiesPrueba();

            
            Persona TBPersona = new Persona();
            TBPersona = (from datos in db.Persona
                         where datos.codigo_personal == id
                         select datos).FirstOrDefault();
                       
            db.Persona.Remove(TBPersona);
            db.SaveChanges();
            
            return Ok("Exito");
        }


    }
}