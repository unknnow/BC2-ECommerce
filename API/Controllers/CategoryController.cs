using API.Models;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Linq;
using System;

namespace API.Controllers
{
    [ApiController]
    [Route("API/[controller]")]
    public class CategoryController : ControllerBase
    {
        private readonly ILogger<CategoryController> _logger;
        private ApiDbContext db;

        public CategoryController(ILogger<CategoryController> logger, ApiDbContext dbContext)
        {
            _logger = logger;
            db = dbContext;
        }

        // GET ALL
        [HttpGet]
        public ActionResult<IEnumerable<Category>> Get()
        {
            return Ok(db.Categories);
        }

        // GET BY ID
        [HttpGet("{id}")]
        public ActionResult<Category> GetById(int id)
        {
            var category = db.Categories
                                    .Where(e => e.Id == id)
                                    .FirstOrDefault();

            if (category != null)
                return Ok(category);

            return NotFound();
        }

        // POST
        [HttpPost]
        [Route("New")]
        public IActionResult Post(Category category)
        {
            try
            {
                db.Categories.Add(category);
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
        public IActionResult Put(int id, Category categoryPut)
        {
            try
            {
                if (id != categoryPut.Id)
                    return BadRequest();

                var category = db.Categories.Find(id);

                if (category == null)
                    return NotFound();

                category.Libelle = categoryPut.Libelle;
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
            var category = db.Categories.Find(id);

            if (category == null)
                return BadRequest();

            db.Categories.Remove(category);
            db.SaveChanges();

            return Ok($"Category with id \"{id}\" has been removed !");
        }
    }
}
