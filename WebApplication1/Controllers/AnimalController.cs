using Microsoft.AspNetCore.Mvc;
using WebApplication1.DB;
using WebApplication1.Models;

namespace WebApplication1.Controllers;

[ApiController]
[Route("api/Animals")]
public class AnimalController : ControllerBase
{
    [HttpGet("")]
    public IActionResult GetAllAnimals()
    {
        return Ok(DbAnimal.Animals);
    }
    
    [HttpGet("{id:int}")]
    public IActionResult GetAnimalById(int id)
    {
        var animal=DbAnimal.Animals.FirstOrDefault(a => a.Id == id);
        if (animal==null)
        {
            return NotFound("nie ma zwierzaka"); 
        }
    
        return Ok(animal);
    }

    [HttpPost("")]
    public IActionResult AddAnimal([FromBody] Animal newAnimal)
    {
        var Animal = new Animal()
        {
            Id = DbAnimal.Animals.Max(a => a.Id) + 1,
            Name = newAnimal.Name,
            Category = newAnimal.Category,
            Weight = newAnimal.Weight,
            Color = newAnimal.Color
        };
        DbAnimal.Animals.Add(Animal);
        return NoContent();
    }
    
    [HttpPut("{id:int}")]
    public IActionResult UpAnimal(int id, [FromBody] Animal updatedAnimal)
    {
        var upAnimal = DbAnimal.Animals.FirstOrDefault(a => a.Id == id);
        if (upAnimal==null)
        {
            return NotFound(); 
        }
        upAnimal.Name = updatedAnimal.Name;
        upAnimal.Category = updatedAnimal.Category;
        upAnimal.Weight = updatedAnimal.Weight;
        upAnimal.Color = updatedAnimal.Color;
        return Ok(upAnimal);
    }
    [HttpDelete("{id:int}")]
    public IActionResult DelAnimal(int id)
    {
        var delAnimal = DbAnimal.Animals.FirstOrDefault(a => a.Id == id);
        if (delAnimal == null)
        {
            return NotFound("nie ma zwierzaka");
        }
        DbAnimal.Animals.Remove(delAnimal);
        return NoContent();
    }
    [HttpGet("{animalId:int}/Visits")]
    public IActionResult GetVisAnimal(int animalId)
    {
        var VisAnimal = DbVisit.Visits.Where(v => v.AnimalId == animalId).ToList();
        if (VisAnimal == null)
        {
            return NotFound("nie ma wizyty");
        }

        return Ok(VisAnimal);
    }
    
    [HttpPost("{animalId:int}/Visits")]
    public IActionResult AddVisit(int animalId, [FromBody] Visit newVisit)
    {
        
        var animal=DbAnimal.Animals.FirstOrDefault(a => a.Id == animalId);
        if (animal==null)
        {
            return NotFound("nie ma zwierzaka");
        }
        newVisit.AnimalId = animalId;
        newVisit.Date = DateTime.Now.ToString(); 
        DbVisit.Visits.Add(newVisit);
        return NoContent();

    }
    
    
}
    
    
    
    
    
    
    
    
