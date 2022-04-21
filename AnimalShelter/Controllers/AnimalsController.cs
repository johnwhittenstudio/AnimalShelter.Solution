using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AnimalShelter.Models;

namespace AnimalShelter.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class AnimalsController : ControllerBase
  {
    private readonly AnimalShelterContext _db;

    public AnimalsController(AnimalShelterContext db)
    {
      _db = db;
    }

    /// <summary>
    /// Gets all animals or animals based off search query
    /// </summary>
    /// <param name="name"></param>
    /// <param name="species"></param>
    /// <param name="minimumAge"></param>
    /// <param name="gender"></param>
    /// <returns>List of animals</returns>
    /// <remarks>
    /// Sample request:
    ///
    ///     GET/api/Animals
    ///     {
    ///       "AnimalId": "1",
    ///       "Name": "Rose",
    ///       "Species": "Cat",
    ///       "Age": "2",
    ///       "Gender": "Female",
    ///     }
    /// </remarks>
    /// <response code="200">Returns an array of entries. If no entries returns an empty array</response>
    /// <response code="400">Returns Not Found</response>

    // GET api/animals
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Animal>>> Get(string species, string gender, string name, int minimumAge)
    {
      var query = _db.Animals.AsQueryable();

      if (species != null)
      {
        query = query.Where(entry => entry.Species == species);
      }

      if (gender != null)
      {
        query = query.Where(entry => entry.Gender == gender);
      }

      if (name != null)
      {
        query = query.Where(entry => entry.Name == name);
      }

      if (minimumAge > 0)
      {
        query = query.Where(entry => entry.Age >= minimumAge);
      }

      return await query.ToListAsync();
    }

    /// <summary>
    /// Gets specific animal based off id
    /// </summary>
    /// <param name="id"></param>
    /// <returns>Animal object that matches id</returns>
    /// <remarks>
    /// Sample request:
    ///
    ///     GET/api/Animals{id}
    ///     {
    ///       "AnimalId": "1",
    ///       "Name": "Rose",
    ///       "Species": "Cat",
    ///       "Age": "2",
    ///       "Gender": "Female",
    ///     }
    /// </remarks>
    /// <response code="200">Returns Ok (Success)</response>
    /// <response code="404">Returns Not Found</response>

    // GET: api/Animals/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Animal>> GetAnimal(int id)
    {
      var animal = await _db.Animals.FindAsync(id);

      if (animal == null)
      {
        return NotFound();
      }

      return animal;
    }

    /// <summary>
    /// Edits properties of entries in database
    /// </summary>
    ///<param name="id"></param>
    /// <param name="animal"></param>
    /// <returns>Status code 204: successful </returns>
    /// <remarks>
    /// Sample request:
    ///
    ///     PUT/api/Animals{id}
    ///     {
    ///       "AnimalId": "1",
    ///       "Name": "Rose",
    ///       "Species": "Cat",
    ///       "Age": "2",
    ///       "Gender": "Female",
    ///     }
    /// </remarks>
    /// <response code="204">Successfully posted animal</response>
    /// <response code="404">Returns Not Found</response>

    // PUT: api/Animals/5
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Animal animal)
    {
      if (id != animal.AnimalId)
      {
        return BadRequest();
      }

      _db.Entry(animal).State = EntityState.Modified;

      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!AnimalExists(id))
        {
          return NotFound();
        }
        else
        {
          throw;
        }
      }

      return NoContent();
    }

    /// <summary>
    /// Posts a new animal
    /// </summary>
    /// <param name="animal"></param>
    /// <returns>Status code 204: successful </returns>
    /// <remarks>
    /// Sample request:
    ///
    ///     POST/api/Animals
    ///     {
    ///       "AnimalId": "1",
    ///       "Name": "Rose",
    ///       "Species": "Cat",
    ///       "Age": "2",
    ///       "Gender": "Female",
    ///     }
    /// </remarks>
    /// <response code="204">Successfully posted animal</response>
    /// <response code="404">Returns Not Found</response>

    // POST api/animals
    [HttpPost]
    public async Task<ActionResult<Animal>> Post(Animal animal)
    {
      _db.Animals.Add(animal);
      await _db.SaveChangesAsync();

      return CreatedAtAction(nameof(GetAnimal), new { id = animal.AnimalId }, animal);
    }

    /// <summary>
    /// Deletes animal entry
    /// </summary>
    /// <param name="id"></param>
    /// <returns>Status code 204: successful </returns>
    /// <response code="404">Returns Not Found</response>

    // DELETE: api/Animals/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAnimal(int id)
    {
      var animal = await _db.Animals.FindAsync(id);
      if (animal == null)
      {
        return NotFound();
      }

      _db.Animals.Remove(animal);
      await _db.SaveChangesAsync();

      return NoContent();
    }

    private bool AnimalExists(int id)
    {
      return _db.Animals.Any(e => e.AnimalId == id);
    }
  }
}