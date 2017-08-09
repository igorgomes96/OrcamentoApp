using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using OrcamentoApp.Models;

namespace OrcamentoApp.Controllers
{
    public class VariaveisController : ApiController
    {
        private Contexto db = new Contexto();

        // GET: api/Variaveis
        public IQueryable<Variaveis> GetVariaveis()
        {
            return db.Variaveis;
        }

        // GET: api/Variaveis/5
        [ResponseType(typeof(Variaveis))]
        public IHttpActionResult GetVariaveis(int id)
        {
            Variaveis variaveis = db.Variaveis.Find(id);
            if (variaveis == null)
            {
                return NotFound();
            }

            return Ok(variaveis);
        }

        // PUT: api/Variaveis/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutVariaveis(int id, Variaveis variaveis)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != variaveis.CargaHoraria)
            {
                return BadRequest();
            }

            db.Entry(variaveis).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VariaveisExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Variaveis
        [ResponseType(typeof(Variaveis))]
        public IHttpActionResult PostVariaveis(Variaveis variaveis)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Variaveis.Add(variaveis);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (VariaveisExists(variaveis.CargaHoraria))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = variaveis.CargaHoraria }, variaveis);
        }

        // DELETE: api/Variaveis/5
        [ResponseType(typeof(Variaveis))]
        public IHttpActionResult DeleteVariaveis(int id)
        {
            Variaveis variaveis = db.Variaveis.Find(id);
            if (variaveis == null)
            {
                return NotFound();
            }

            db.Variaveis.Remove(variaveis);
            db.SaveChanges();

            return Ok(variaveis);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool VariaveisExists(int id)
        {
            return db.Variaveis.Count(e => e.CargaHoraria == id) > 0;
        }
    }
}