using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication.BEntityFrameworkCore.Models;

namespace WebApplication.BEntityFrameworkCore.Controllers
{
    [Route("api/[controller]")]
    public class InMemoryController : Controller
    {
        private readonly InMemoryContext _service;
        public InMemoryController(InMemoryContext service)
        {
            _service = service;
        }
        [HttpGet("create/data")]
        public IActionResult Create()
        {
            try
            {
                using (var context = _service)
                {

                    context.InMemorys.AddRange(
                        new InMemory { Id = 1, Name = "Gobo" },
                        new InMemory { Id = 2, Name = "Monkey" },
                        new InMemory { Id = 3, Name = "Red" },
                        new InMemory { Id = 4, Name = "Wembley" },
                        new InMemory { Id = 5, Name = "Boober" },
                        new InMemory { Id = 6, Name = "Uncle Traveling Matt" }
                    );
                    context.SaveChanges();
                }
                return Ok();
            }
            catch
            {
                return BadRequest();
            }
        }
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_service.InMemorys.ToList());
            }
            catch
            {
                return NotFound();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public IActionResult Get(long id)
        {
            try
            {
                return Ok(_service.InMemorys.First(t => t.Id == id));
            }
            catch
            {
                return NotFound();
            }
        }
    }
}
