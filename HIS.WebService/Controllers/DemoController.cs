using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HIS.IController;
using HIS.Service.Abstraction;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace HIS.WebService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DemoController : HisControllerBase, IDemoController
    {
        private readonly ILogger<DemoController> _logger;

        public DemoController(ILogger<DemoController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("GetString")]
        public string GetString()
        {
            return "";
        }

        [HttpGet]
        [Route("GetString2")]
        public string GetString([FromQuery]string parm)
        {
            return parm;
        }

        [HttpPost]
        [Route("GetObj")]
        public object GetObj([FromBody]string name, int index)
        {
            return new { name, index };
        }
    }
}
