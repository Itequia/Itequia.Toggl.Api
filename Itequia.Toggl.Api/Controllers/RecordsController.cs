using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Itequia.Toggl.Api.Services;
using Itequia.Toggl.Api.Services.Interfaces;
using Itequia.Toggl.Api.Data.Models;
using Microsoft.AspNetCore.JsonPatch;

namespace Itequia.Toggl.Api.Controllers
{
    [Produces("application/json")]
    [Route("/api/records")]
    public class RecordsController : Controller
    {
        private readonly IRecordsService _service;

        public RecordsController(IRecordsService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return new OkObjectResult(_service.Get());
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult Get(int id)
        {
            return new OkObjectResult(_service.Get(id));
        }

        [HttpPost]
        public IActionResult Post([FromBody]Record record)
        {            
            try
            {
                return new OkObjectResult(_service.Post(record));
            }
            catch (Exception e)
            {
                return new BadRequestObjectResult(e.Message);
            }
        }

        [HttpPut]
        public IActionResult Put(int id, [FromBody]Record record)
        {
            try
            {
                _service.Put(id, record);
                return new OkResult();
            }
            catch (Exception e)
            {
                return new BadRequestObjectResult(e.Message);
            }            
        }

        [HttpPatch]
        [Route("{id}")]
        public IActionResult Patch(int id, [FromBody]JsonPatchDocument<Record> patch)
        {
            try
            {
                Record record = _service.Get(id);
                //Record patched = new Record
                //{
                //    Id = record.Id,
                //    Start = record.Start,
                //    End = record.End,
                //    Description = record.Description,
                //    UserId = record.UserId,
                //    ProjectId = record.ProjectId    
                //};
                patch.ApplyTo(record);
                _service.Patch(id, record);
                //_service.Patch(id, record);
                return new OkResult();
            }
            catch (Exception e)
            {
                return new BadRequestObjectResult(e.Message);
            }
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                _service.Delete(id);
                return new OkResult();
            }
            catch (Exception e)
            {
                return new BadRequestObjectResult(e.Message);
            }
        }
    }
}