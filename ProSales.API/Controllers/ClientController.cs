using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProSales.Application;
using ProSales.Application.Contracts;
using ProSales.Domain.Dtos;

namespace ProSales.API.Controllers;

//[AllowAnonymous]
[Route("api/[controller]")]
[ApiController]
public class ClientController : ControllerBase
{
    private readonly IClientService service;

    public ClientController(IClientService service)
    {
        this.service = service;
    }


    /// <summary>
    /// Get Item by ExternalID
    /// </summary>
    /// <param name= "externalId"></param>
    [HttpGet("by-external-id/{externalId}")]
    public async Task<IActionResult> getByExternalId(Guid externalId)
    {
        var ret = this.service.GetByExternalId(externalId).Result;
        return StatusCode(ret.StatusCode, ret);
    }

    /// <summary>
    /// Get Item by Name
    /// </summary>
    /// <param name= "name"></param>
    [HttpGet("by-name/{name}")]
    public async Task<IActionResult> GetByFullName(string name)
    {
        var ret = this.service.GetByFullName(name).Result;
        return StatusCode(ret.StatusCode, ret);
    }

    /// <summary>
    /// Get Item by Query
    /// </summary>
    [HttpGet("by-query")]
    public async Task<IActionResult> GetAllByQuery([FromQuery] ClientQuery query)
    {
        var ret = this.service.GetAllByQuery(query).Result;
        return StatusCode(ret.StatusCode, ret);
    }

    /// <summary>
    /// Get Item by Document
    /// </summary>
    [HttpGet("by-document")]
    public async Task<IActionResult> GetAllByDocument([FromQuery] DocumentQuery query)
    {
        var ret = this.service.GetAllByDocument(query).Result;
        return StatusCode(ret.StatusCode, ret);
    }

    /// <summary>
    /// Get Item by Contact
    /// </summary>
    [HttpGet("by-contact")]
    public async Task<IActionResult> GetAllByContact([FromQuery] ContactQuery query)
    {
        var ret = this.service.GetAllByContact(query).Result;
        return StatusCode(ret.StatusCode, ret);
    }

    /// <summary>
    /// Post create item
    /// </summary>
    [HttpPost("create")]
    public async Task<IActionResult> postCreate(CreateClientDto create)
    {
        var ret = this.service.Create(create).Result;
        return StatusCode(ret.StatusCode, ret);
    }

    /// <summary>
    /// Put update item
    /// </summary>
    [HttpPut("update")]
    public async Task<IActionResult> putUpdate(ClientDto update)
    {
        var ret = this.service.Update(update).Result;
        return StatusCode(ret.StatusCode, ret);
    }

    /// <summary>
    /// Put toogle alter status active
    /// </summary>
    /// <param name= "externalId"></param>
    [HttpPut("toggleStatus/by-external-id/{externalId}")]
    public async Task<IActionResult> ToogleAlterStatus(Guid externalId)
    {
        var ret = this.service.ToogleAlterStatus(externalId).Result;
        return StatusCode(ret.StatusCode, ret);
    }
}
