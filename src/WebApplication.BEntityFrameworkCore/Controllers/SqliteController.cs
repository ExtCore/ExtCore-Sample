using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.BEntityFrameworkCore.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net;
namespace WebApplication.BEntityFrameworkCore.Controllers
{
    [Route("api/[controller]")]
    public class SqliteController : Controller
    {
        private SqliteContext _service;
        public SqliteController(SqliteContext service)
        {
            _service = service;
        }
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_service.Items.ToList());
            }
            catch
            {
                return new StatusCodeResult((int)HttpStatusCode.NotFound) ;
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
                return Ok(_service.Items.First(t => t.Id == id));
            }
            catch
            {
                return new StatusCodeResult((int)HttpStatusCode.NotFound);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        [HttpPost]
        public IActionResult Post([FromBody]Item value)
        {
            try
            {
                _service.Add(value);
                _service.SaveChanges();
                return Ok();
            }
            catch
            {
                return new StatusCodeResult((int)HttpStatusCode.ExpectationFailed);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="value"></param>
        [HttpPut("{id}")]
        public IActionResult Put(long id, [FromBody]Item value)
        {
            try
            {
                _service.Update(value);
                _service.SaveChanges();
                return Ok();
            }
            catch
            {
                return new StatusCodeResult((int)HttpStatusCode.ExpectationFailed);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            try
            {
                var entity = _service.Items.First(t => t.Id == id);
                _service.Remove(entity);
                _service.SaveChanges();
                return Ok();
            }
            catch
            {
                return new StatusCodeResult((int)HttpStatusCode.ExpectationFailed);
            }
        }
    }
}
