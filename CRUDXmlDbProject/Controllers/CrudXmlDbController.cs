using CRUDXmlDbProject.Common.RequestModel;
using CRUDXmlDbProject.Common.ResponseModel;
using CRUDXmlDbProject.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDXmlDbProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CrudXmlDbController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;
        private readonly ILogger<CrudXmlDbController> _logger;

        public CrudXmlDbController()
        {

        }

        [HttpPost]
        public async Task<IActionResult> AddEmployeeData(AddDataRequest request)
        {
            _logger.LogInformation($" AddEmployeeData => Call { DateTime.Now.ToString() }[{ JsonConvert.SerializeObject(request)}]");
             AddDataResponse response = null;
             try
                {
                    response = await _employeeService.AddEmployeeData(request);
                }
                catch(Exception ex)
                {
                _logger.LogError($" AddEmployeeData => Error : [{ex}]");
                }

            _logger.LogInformation($" AddEmployeeData => Response { DateTime.Now.ToString()} [{ JsonConvert.SerializeObject(response)}]");
            return Ok(response); 
        }

    }
}
