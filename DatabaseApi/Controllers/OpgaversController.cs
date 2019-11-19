using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using DatabaseApi;

namespace DatabaseApi.Controllers
{
    public class OpgaversController : ApiController
    {
        private EzDbContext db = new EzDbContext();

        // GET: api/Opgavers
        public IQueryable<Opgaver> GetOpgaver()
        {
            return db.Opgaver;
        }

        // GET: api/Opgavers/5
        [ResponseType(typeof(Opgaver))]
        public async Task<IHttpActionResult> GetOpgaver(int id)
        {
            Opgaver opgaver = await db.Opgaver.FindAsync(id);
            if (opgaver == null)
            {
                return NotFound();
            }

            return Ok(opgaver);
        }

        // PUT: api/Opgavers/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutOpgaver(int id, Opgaver opgaver)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != opgaver.ID)
            {
                return BadRequest();
            }

            db.Entry(opgaver).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OpgaverExists(id))
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

        // POST: api/Opgavers
        [ResponseType(typeof(Opgaver))]
        public async Task<IHttpActionResult> PostOpgaver(Opgaver opgaver)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Opgaver.Add(opgaver);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (OpgaverExists(opgaver.ID))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = opgaver.ID }, opgaver);
        }

        // DELETE: api/Opgavers/5
        [ResponseType(typeof(Opgaver))]
        public async Task<IHttpActionResult> DeleteOpgaver(int id)
        {
            Opgaver opgaver = await db.Opgaver.FindAsync(id);
            if (opgaver == null)
            {
                return NotFound();
            }

            db.Opgaver.Remove(opgaver);
            await db.SaveChangesAsync();

            return Ok(opgaver);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool OpgaverExists(int id)
        {
            return db.Opgaver.Count(e => e.ID == id) > 0;
        }
    }
}