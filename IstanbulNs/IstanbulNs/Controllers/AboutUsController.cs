using IstanbulNs.Data;
using IstanbulNs.Models;
using IstanbulNs.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IstanbulNs.Controllers
{
    [Route("api/aboutus")]
    [ApiController]
    public class AboutUsController : ControllerBase
    {
        private readonly IndexContext _db;
        public AboutUsController(IndexContext db)
        {
            _db = db;
        }
        [HttpGet("{langId}")]
        public IActionResult GetControllerData(int langId)
        {
            var data = _db.AboutUs.Include("Photos").Include("Videos").Where(i => i.LangId == langId).FirstOrDefault();
            //var data = from aboutus in _db.AboutUs
            //           join photo in _db.Photos on aboutus.Id equals photo.AboutUsId
            //           join video in _db.Videos on aboutus.Id equals video.AboutUsId
            //           where aboutus.LangId == langId
            //           select new
            //           {
            //               Id = aboutus.Id,
            //               Text = aboutus.Text,
            //               Source = aboutus.YoutubeSource,
            //               Photos = aboutus.Photos,
            //               Videos = aboutus.Videos
            //           };
            return Ok(new ReturnMessage(data: data));
        }
        [HttpPost("create")]
        public IActionResult CreateControllerData([FromBody] AboutUs request)
        {

            return Ok();
        }
    }
}
