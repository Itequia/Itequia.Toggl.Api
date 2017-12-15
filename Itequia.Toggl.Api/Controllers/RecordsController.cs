using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Itequia.Toggl.Api.Services;
using Itequia.Toggl.Api.Services.Interfaces;
using Itequia.Toggl.Api.Data.Models;
using Itequia.Toggl.Api.Data.DTO;
using AutoMapper;
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
        public IActionResult Get(string description = null, DateTime? end = null, DateTime? start = null, string projectName = null, string sort = null) 
        {
            return new OkObjectResult(Mapper.Map<List<Record>, List<RecordDTO>>(_service.Get(description, end, start, projectName, sort)));
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult Get(int id)
        {
            return new OkObjectResult(_service.Get(id));
        }

        [HttpPost]
        public IActionResult Post([FromBody]RecordDTO record)
        {            
            try
            {
                return new OkObjectResult(Mapper.Map<Record, RecordDTO>(_service.Post(Mapper.Map<RecordDTO, Record>(record))));
            }
            catch (Exception e)
            {
                return new BadRequestObjectResult(e.Message);
            }
        }

        [Route("{id}")]
        [HttpPut]
        public IActionResult Put(int id, [FromBody]RecordDTO record)
        {
            try
            {
                _service.Put(id, Mapper.Map<RecordDTO, Record>(record));
                return new OkResult();
            }
            catch (Exception e)
            {
                return new BadRequestObjectResult(e.Message);
            }            
        }

        [HttpPatch]
        [Route("{id}")]
        public IActionResult Patch(int id, [FromBody]RecordDTO record)
        {
            try
            {
                _service.Patch(id, Mapper.Map<RecordDTO, Record>(record));
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