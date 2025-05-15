using day1test3.Models;
using day1test3.Models.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace day1test3.Controllers
{
    [ApiController]
    //method 01
    //public class ShirtsController : ControllerBase
    //{
    //    [HttpGet]
    //    [Route("/shirts")]
    //    public string GetShirts()
    //    {
    //        return "Reading Shirts";
    //    }
    //    [HttpGet]
    //    [Route("/shirts/{id}")]
    //    public string GetShirtById(int id)
    //    {
    //        return $"Reading Shirt: {id} ";
    //    }
    //    [HttpPost]
    //    [Route("/shirts")]
    //    public string CreateShirt()
    //    {
    //        return $"Creating a shirt";
    //    }
    //    [HttpPut]
    //    [Route("/shirts/{id}")]
    //    public string UpdateShirt(int id) {
    //        return $"updating shirt: {id}";
    //    }
    //    [HttpDelete]
    //    [Route("/shirts/{id}")]
    //    public string DeleteShirt(int id)
    //    {
    //        return $"deleting shirt: {id}";
    //    }
    //}

    //method 2
    [Route("/api/[controller]")] //ShirtsController → [controller] = "shirts"

    public class ShirtsController : ControllerBase
    {
        //  Temporary in-memory data store
        private static List<Shirts> shirts = new List<Shirts>
        {
            new Shirts { ShirtId = 1, Brand = "Nike", Color = "Black", size = 7, Gender = "Men", Price = 100 },
            new Shirts { ShirtId = 2, Brand = "Adidas", Color = "White", size = 8, Gender = "Women", Price = 120 },
            new Shirts { ShirtId = 3, Brand = "Puma", Color = "Blue", size = 6, Gender = "Men", Price = 95 },
            new Shirts { ShirtId = 4, Brand = "Levis", Color = "Red", size = 9, Gender = "Unisex", Price = 150 },
            new Shirts { ShirtId = 5, Brand = "Reebok", Color = "Green", size = 7, Gender = "Men", Price = 110 }
        };
        [HttpGet]
        public IActionResult GetShirts()
        {
            return Ok("Reading Shirts");
        }
        [HttpGet("{id}")]
        //public string GetShirtById(int id)
        //{
        //    return $"Reading Shirt: {id} ";
        //}
        //public IActionResult GetShirtById(int id)  //IActionResult => can return multiple value
        //{
        //    var shirt =  shirts.FirstOrDefault(x=> x.ShirtId == id); //For each shirt x in the list, check if x.ShirtId is equal to id.
        //    if(shirt == null)
        //    {
        //        return NotFound();
        //    }

        //    return Ok(shirt);
        //}
        public IActionResult GetShirtById(int id)  //IActionResult => can return multiple value
        {
            if(id<= 0)
            {
                return BadRequest();
            }
            var shirt = ShirtRepository.GetShirtsById(id); //For each shirt x in the list, check if x.ShirtId is equal to id.
            if (shirt == null)
            {
                return NotFound();
            }

            return Ok(shirt);
        }

        [HttpPost]
        public IActionResult CreateShirt([FromBody]Shirts shirts)
        {
            return Ok($"Creating a shirt{shirts.ShirtId}");
        }
        [HttpPut("{id}")]
        public IActionResult UpdateShirt(int id)
        {
            return Ok($"updating shirt: {id}");
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteShirt(int id)
        {
            return Ok($"deleting shirt: {id}");
        }
    }
}
