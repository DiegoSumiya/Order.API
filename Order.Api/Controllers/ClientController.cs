using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Order.Application.DataContract.Request;
using Order.Application.DataContract.Request.Client;
using Order.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Order.Api.Controllers
{
    [Route("api/client")]
    [ApiController]
    [Authorize]
    public class ClientController : Controller
    {
        private readonly IClientApplication _clientApplication;

        public ClientController(IClientApplication clientApplication)
        {
            _clientApplication = clientApplication;
        }

        public async Task<IActionResult>Get([FromQuery] string clientId, [FromQuery] string name)
        {
            var response = await _clientApplication.ListByFilterAsync(clientId, name);

            if (response.Report.Any())
                return UnprocessableEntity(response.Report);

            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> Get(string id)
        {
            var response = await _clientApplication.GetByIdAsync(id);

            if (response.Report.Any())
                return UnprocessableEntity(response.Report);

            return Ok(response);
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] CreateClientRequest request)
        {
            var response = await _clientApplication.CreateAsync(request);

            if (response.Report.Any())
                return UnprocessableEntity(response.Report);

            return Ok(response);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] UpdateClientRequest request)
        {
            var response = await  _clientApplication.UpdateAsync(request);

            if (response.Report.Any())
                return UnprocessableEntity(response.Report);

            return Ok(response);
        }

        [HttpDelete]
        public async Task<ActionResult> Delete(string id)
        {
            var response = await _clientApplication.DeleteAsync(id);

            if (response.Report.Any())
                return UnprocessableEntity(response.Report);

            return Ok(response);
        }
    }
}
