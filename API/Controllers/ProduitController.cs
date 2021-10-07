using API.Models;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Linq;
using System;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("API/[controller]")]
    public class ProduitController : ControllerBase
    {
        private readonly ILogger<ProduitController> _logger;
        private ApiDbContext db;

        public ProduitController(ILogger<ProduitController> logger, ApiDbContext dbContext)
        {
            _logger = logger;
            db = dbContext;
        }

        // GET ALL
        [HttpGet]
        public ActionResult<IEnumerable<Produit>> Get()
        {
            return Ok(
                db.Produits
                    .Include(p => p.Category)
                    .Include(p => p.Seller)
                    .Include(p => p.Purchaser)
            );
        }

        // GET BY ID
        [HttpGet("{id}")]
        public ActionResult<Produit> GetById(int id)
        {
            var produit = db.Produits
                                    .Include(p => p.Category)
                                    .Include(p => p.Seller)
                                    .Include(p => p.Purchaser)
                                    .Where(e => e.Id == id)
                                    .FirstOrDefault();

            if (produit != null)
                return Ok(produit);

            return NotFound();
        }

        // POST
        [HttpPost]
        [Route("New")]
        public IActionResult Post(Produit produit)
        {
            try
            {
                db.Produits.Add(produit);
                db.SaveChanges();

                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        // PUT
        [HttpPut]
        [Route("Edit/{id:int}")]
        public IActionResult Put(int id, Produit produitPut)
        {
            try
            {
                if (id != produitPut.Id)
                    return BadRequest();

                var produit = db.Produits.Find(id);

                if (produit == null)
                    return NotFound();

                produit.Libelle = produitPut.Libelle;
                produit.Description = produitPut.Description;
                produit.Price = produitPut.Price;
                produit.Quantity = produitPut.Quantity;
                produit.img = produitPut.img;
                produit.DatePublish = produitPut.DatePublish;
                produit.SoldAt = produitPut.SoldAt;
                produit.Sold = produitPut.Sold;
                produit.Seller = produitPut.Seller;
                produit.Purchaser = produitPut.Purchaser;
                produit.Category = produitPut.Category;

                db.SaveChanges();

                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        // DELETE
        [HttpDelete]
        [Route("Delete/{id:int}")]
        public IActionResult Delete(int id)
        {
            var produit = db.Produits.Find(id);

            if (produit == null)
                return BadRequest();

            db.Produits.Remove(produit);
            db.SaveChanges();

            return Ok($"Produit with id \"{id}\" has been removed !");
        }
    }
}
