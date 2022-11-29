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
public class ContactController : ControllerBase
{
    private readonly IContactService service;

    public ContactController(IContactService service)
    {
        this.service = service;
    }


    /// <summary>
    /// Get Item by ExternalID
    /// </summary>
    /// <param name= "ExternalId"></param>
    [HttpGet("by-external-id/{externalId}")]
    public async Task<IActionResult> getByExternalId(Guid externalId)
    {
        var ret = this.service.GetByExternalId(externalId).Result;
        return StatusCode(ret.StatusCode, ret);
    }

    /// <summary>
    /// Get Item by Value and ContactTypeExternalId
    /// </summary>
    /// <param name= "value"></param>
    /// <param name= "contactTypeExternalId"></param>
    [HttpGet("by-name/{value}/{contactTypeExternalId}")]
    public async Task<IActionResult> GetByValueAndContactType(string value, Guid contactTypeExternalId)
    {
        var ret = this.service.GetByValueAndTypeContact(value,contactTypeExternalId).Result;
        return StatusCode(ret.StatusCode, ret);
    }

    /// <summary>
    /// Get Item by Query
    /// </summary>
    [HttpGet("by-query")]
    public async Task<IActionResult> GetAllBrandByQuery([FromQuery] ContactQuery query)
    {
        var ret = this.service.GetAllByQuery(query).Result;
        return StatusCode(ret.StatusCode, ret);
    }

    /// <summary>
    /// Post create item
    /// </summary>
    [HttpPost("create")]
    public async Task<IActionResult> postCreate(CreateContactDto create)
    {
        var ret = this.service.Create(create).Result;
        return StatusCode(ret.StatusCode, ret);
    }

    /// <summary>
    /// Put update item
    /// </summary>
    [HttpPut("update")]
    public async Task<IActionResult> putUpdate(ContactDto update)
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
