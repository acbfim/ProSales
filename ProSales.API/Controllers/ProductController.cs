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
public class ProductController : ControllerBase
{
    private readonly IProductService service;

    public ProductController(IProductService service)
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
        var ret = await this.service.GetByExternalId(externalId);
        return StatusCode(ret.StatusCode, ret);
    }

    /// <summary>
    /// Get Item by Name
    /// </summary>
    /// <param name= "name"></param>
    [HttpGet("by-name/{name}")]
    public async Task<IActionResult> GetBrandByName(string name)
    {
        var ret = await this.service.GetByName(name);
        return StatusCode(ret.StatusCode, ret);
    }

    /// <summary>
    /// Get Item by Query
    /// </summary>
    /// <param name= "query"></param>
    /// <param name= "includeJoins"></param>
    [HttpGet("by-query")]
    public async Task<IActionResult> GetAllBrandByQuery([FromQuery] ProductQuery query
    ,[FromQuery] bool includeJoins = false)
    {
        var ret = await this.service.GetAllByQuery(query, includeJoins);
        return StatusCode(ret.StatusCode, ret);
    }

    /// <summary>
    /// Post create item
    /// </summary>
    [HttpPost("create")]
    public async Task<IActionResult> postCreate(CreateProductDto create)
    {
        var ret = await this.service.Create(create);
        return StatusCode(ret.StatusCode, ret);
    }

    /// <summary>
    /// Put update item
    /// </summary>
    [HttpPut("update")]
    public async Task<IActionResult> putUpdate(ProductDto update)
    {
        var ret = await this.service.Update(update);
        return StatusCode(ret.StatusCode, ret);
    }

    /// <summary>
    /// Put toogle alter status active
    /// </summary>
    /// <param name= "externalId"></param>
    [HttpPut("toggleStatus/by-external-id/{externalId}")]
    public async Task<IActionResult> ToogleAlterStatus(Guid externalId)
    {
        var ret = await this.service.ToogleAlterStatus(externalId);
        return StatusCode(ret.StatusCode, ret);
    }
}
