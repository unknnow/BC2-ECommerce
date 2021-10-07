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
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;
        private ApiDbContext db;

        public UserController(ILogger<UserController> logger, ApiDbContext dbContext)
        {
            _logger = logger;
            db = dbContext;
        }

        // GET ALL
        [HttpGet]
        public ActionResult<IEnumerable<User>> Get()
        {
            return Ok(db.Users);
        }

        // GET BY ID
        [HttpGet("{id}")]
        public ActionResult<User> GetById(int id)
        {
            var user = db.Users
                                .Where(e => e.Id == id)
                                .FirstOrDefault();

            if (user != null)
                return Ok(user);

            return NotFound();
        }

        // POST
        [HttpPost]
        [Route("New")]
        public IActionResult Post(User user)
        {
            try
            {
                db.Users.Add(user);
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
        public IActionResult Put(int id, User userPut)
        {
            try
            {
                if (id != userPut.Id)
                    return BadRequest();

                var user = db.Users.Find(id);

                if (user == null)
                    return NotFound();

                user.Username = userPut.Username;
                user.Email = userPut.Email;
                user.Password = userPut.Password;
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
            var user = db.Users.Find(id);

            if (user == null)
                return BadRequest();

            db.Users.Remove(user);
            db.SaveChanges();

            return Ok($"User with id \"{id}\" has been removed !");
        }
    }
}
