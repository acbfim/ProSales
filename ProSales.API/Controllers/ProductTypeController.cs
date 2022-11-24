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
public class ProductTypeController : ControllerBase
{
    private readonly IProductTypeService service;

    public ProductTypeController(IProductTypeService service)
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
    /// Get Item by Name
    /// </summary>
    /// <param name= "Name"></param>
    [HttpGet("by-name/{name}")]
    public async Task<IActionResult> GetBrandByName(string name)
    {
        var ret = this.service.GetByName(name).Result;
        return StatusCode(ret.StatusCode, ret);
    }

    /// <summary>
    /// Get Item by Query
    /// </summary>
    [HttpGet("by-query")]
    public async Task<IActionResult> GetAllBrandByQuery([FromQuery] ProductTypeQuery query)
    {
        var ret = this.service.GetAllByQuery(query).Result;
        return StatusCode(ret.StatusCode, ret);
    }

    /// <summary>
    /// Post create item
    /// </summary>
    [HttpPost("create")]
    public async Task<IActionResult> postCreate(CreateProductTypeDto create)
    {
        var ret = this.service.Create(create).Result;
        return StatusCode(ret.StatusCode, ret);
    }

    /// <summary>
    /// Put update item
    /// </summary>
    [HttpPut("update")]
    public async Task<IActionResult> putUpdate(ProductTypeDto update)
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
