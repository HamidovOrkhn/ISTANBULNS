using IstanbulNs.Data;
using IstanbulNs.Models;
using IstanbulNs.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static IstanbulNs.Repositories.ReturnMessage;

namespace IstanbulNs.Controllers
{
    [Route("api/home")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IndexContext _db;
        public HomeController(IndexContext db)
        {
            _db = db;
        }
        [HttpGet, Route("{langId}")]
        
        public  IActionResult GetHomeParams(int langId)
        {
            var data = _db.Home.Where(h=>h.LangId == langId).FirstOrDefault();
            if (data == null)
            {
                return NotFound(new ReturnMessage(data: data));
            }
            else
            {
                return Ok(new ReturnMessage(data: data));
            }
        }

        //[HttpGet, Route("{id}")]

        //public IActionResult GetHomeParamsById(int id)
        //{
        //    var data = _db.Home.Find(id);
        //    if (data == null)
        //    {
        //        return NotFound(new ErrorMessage(data: data));
        //    }
        //    else
        //    {
        //        return Ok(new ReturnMessage(data: data));
        //    }
        //}
        //[HttpPost, Route("")]

        //public IActionResult CreateHomeParams([FromBody] Home request)
        //{
        //    var data = _db.Home.Add(request);
        //    _db.SaveChanges();
        //    return Ok(new ReturnMessage());
        //}
        //[HttpPut, Route("{id}")]

        //public IActionResult UpdateHomeParams(int id, Home request)
        //{
        //    var data = _db.Home.FirstOrDefault(h=>h.Id == id);
        //    if (data == null)
        //    {
        //        return NotFound(new ErrorMessage(data: data));
        //    }
        //    else
        //    {
        //        data.Source = request.Source;
        //        _db.SaveChanges();
        //        return Ok(new ReturnMessage(data: data));
        //    }
        //}
        //[HttpDelete, Route("{id}")]

        //public IActionResult DeleteHomeParams(int id, Home request)
        //{
        //    var data = _db.Home.Find(id);
        //    if (data == null)
        //    {
        //        return NotFound(new ErrorMessage(data: data));
        //    }
        //    else
        //    {
        //        _db.Home.Remove(data);
        //        _db.SaveChanges();
        //        return Ok(new ErrorMessage(data: data));
        //    }
        //}
    }
}
