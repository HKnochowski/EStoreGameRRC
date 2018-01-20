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
using System.Web.Http.ModelBinding;
using EStoreGameRC.Models;
namespace EStoreGameRC.Controllers
{
    public class BasketController : ApiController
    { 
     private EStoreGameRCContext db = new EStoreGameRCContext();

    // GET: api/Basket
    public IQueryable<Basket> GetBaskets()
    {
        return db.Baskets;
    }

    // GET: api/Basket/5
    [ResponseType(typeof(Basket))]
    public IHttpActionResult GetBasket(int id)
    {
        Basket basket = db.Baskets.Find(id);
        if (basket == null)
        {
            return NotFound();
        }

        return Ok(basket);
    }

    // PUT: api/Basket/5
    [ResponseType(typeof(void))]
    public IHttpActionResult PutBasket(int id, Basket basket)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        if (id != basket.BasketID)
        {
            return BadRequest();
        }

        db.Entry(basket).State = EntityState.Modified;

        try
        {
            db.SaveChanges();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!BasketExists(id))
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

    // POST: api/Basket
    [ResponseType(typeof(Basket))]
    public IHttpActionResult PostAddress(Basket basket)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        db.Baskets.Add(basket);

        try
        {
            db.SaveChanges();
        }
        catch (DbUpdateException)
        {
            if (BasketExists(basket.BasketID))
            {
                return Conflict();
            }
            else
            {
                throw;
            }
        }

        return CreatedAtRoute("DefaultApi", new { id = basket.BasketID }, basket);
    }

    // DELETE: api/Basket/5
    [ResponseType(typeof(Basket))]
    public IHttpActionResult DeleteAddress(int id)
    {
        Basket basket = db.Baskets.Find(id);
        if (basket == null)
        {
            return NotFound();
        }

        db.Baskets.Remove(basket);
        db.SaveChanges();

        return Ok(basket);
    }

    protected override void Dispose(bool disposing)
    {
        if (disposing)
        {
            db.Dispose();
        }
        base.Dispose(disposing);
    }

    private bool BasketExists(int id)
    {
        return db.Baskets.Count(e => e.BasketID == id) > 0;
    }
}
    }