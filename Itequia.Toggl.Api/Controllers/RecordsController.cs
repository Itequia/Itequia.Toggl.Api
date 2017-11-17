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

namespace Itequia.Toggl.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/Records")]
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
            List<Record> test = new List<Record>()
            {
                new Record()
                {
                    Description = "Desc1",
                    Start = new DateTime(2017,1,1),
                    End = new DateTime(),
                    ProjectId = 1,
                    UserId = 1
                },
                new Record()
                {
                    Description = "Desc2",
                    Start = new DateTime(2017,1,2),
                    End = new DateTime(),
                    ProjectId = 2,
                    UserId = 2
                },
                new Record()
                {
                    Description = "Desc3",
                    Start = new DateTime(2017,1,3),
                    ProjectId = 3,
                    UserId = 3
                }

            };

            List<RecordDTO> result = Mapper.Map<List<Record>, List<RecordDTO>>(_service.Get());
            return new OkObjectResult(result);
        }

        [HttpPost]
        public IActionResult Post(Record record)
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
        public IActionResult Put(int id, Record record)
        {
            try
            {
                return new OkObjectResult(_service.Put(id, record));
            }
            catch (Exception e)
            {
                return new BadRequestObjectResult(e.Message);
            }            
        }

        [HttpPatch]
        public IActionResult Patch(int id, Record record)
        {
            return new OkObjectResult(_service.Patch(id, record));
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            try
            {
                return new OkObjectResult(_service.Delete(id));
            }
            catch (Exception e)
            {
                return new BadRequestObjectResult(e.Message);
            }
        }
    }
}