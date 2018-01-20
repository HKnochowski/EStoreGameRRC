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
using EStoreGameRC.Models;

namespace EStoreGameRC.Controllers
{
        public class CopiesController : ApiController
        {
            private EStoreGameRCContext db = new EStoreGameRCContext();

            // GET: api/Copies
            public IQueryable<Copie> GetCopie()
            {
                return db.Copies;
            }

            // GET: api/Copies/5
            [ResponseType(typeof(Copie))]
            public IHttpActionResult GetCopie(int id)
            {
                Copie copie = db.Copies.Find(id);
                if (copie == null)
                {
                    return NotFound();
                }

                return Ok(copie);
            }

            // PUT: api/Copies/5
            [ResponseType(typeof(void))]
            public IHttpActionResult PutCopie(int id, Copie copie)
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                if (id != copie.CopieID)
                {
                    return BadRequest();
                }

                db.Entry(copie).State = EntityState.Modified;

                try
                {
                    db.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CopieExists(id))
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

            // POST: api/Copies
            [ResponseType(typeof(Copie))]
            public IHttpActionResult PostCopie(Copie copie)
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                db.Copies.Add(copie);

                try
                {
                    db.SaveChanges();
                }
                catch (DbUpdateException)
                {
                    if (CopieExists(copie.CopieID))
                    {
                        return Conflict();
                    }
                    else
                    {
                        throw;
                    }
                }

                return CreatedAtRoute("DefaultApi", new { id = copie.CopieID}, copie);
            }

            // DELETE: api/Copies/5
            [ResponseType(typeof(Copie))]
            public IHttpActionResult DeleteCopie(int id)
            {
                Copie copie = db.Copies.Find(id);
                if (copie == null)
                {
                    return NotFound();
                }

                db.Copies.Remove(copie);
                db.SaveChanges();

                return Ok(copie);
            }

            protected override void Dispose(bool disposing)
            {
                if (disposing)
                {
                    db.Dispose();
                }
                base.Dispose(disposing);
            }

            private bool CopieExists(int id)
            {
                return db.Copies.Count(e => e.CopieID == id) > 0;
            }
        }
    }