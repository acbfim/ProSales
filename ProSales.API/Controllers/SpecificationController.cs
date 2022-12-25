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
public class SpecificationController : ControllerBase
{
    private readonly ISpecificationService service;

    public SpecificationController(ISpecificationService service)
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
    /// Get Item by Key
    /// </summary>
    /// <param name= "key"></param>
    [HttpGet("by-key/{key}")]
    public async Task<IActionResult> GetAllByKey(string key)
    {
        var ret = await this.service.GetAllByKey(key);
        return StatusCode(ret.StatusCode, ret);
    }

    /// <summary>
    /// Get Item by value
    /// </summary>
    /// <param name= "value"></param>
    [HttpGet("by-value/{value}")]
    public async Task<IActionResult> GetAllByValue(string value)
    {
        var ret = await this.service.GetAllByValue(value);
        return StatusCode(ret.StatusCode, ret);
    }

    /// <summary>
    /// Get Item by productId
    /// </summary>
    /// <param name= "productId"></param>
    [HttpGet("by-product-external-id/{productExternalId}")]
    public async Task<IActionResult> GetAllByProductId(Guid productExternalId)
    {
        var ret = await this.service.GetAllByProductExternalId(productExternalId);
        return StatusCode(ret.StatusCode, ret);
    }

    /// <summary>
    /// Get Item by Query
    /// </summary>
    [HttpGet("by-query")]
    public async Task<IActionResult> GetAllBrandByQuery([FromQuery] SpecificationQuery query)
    {
        var ret = this.service.GetAllByQuery(query).Result;
        return StatusCode(ret.StatusCode, ret);
    }

    /// <summary>
    /// Post create item
    /// </summary>
    [HttpPost("create")]
    public async Task<IActionResult> postCreate(CreateSpecificationDto create)
    {
        var ret = this.service.Create(create).Result;
        return StatusCode(ret.StatusCode, ret);
    }

    /// <summary>
    /// Put update item
    /// </summary>
    [HttpPut("update")]
    public async Task<IActionResult> putUpdate(SpecificationDto update)
    {
        var ret = this.service.Update(update).Result;
        return StatusCode(ret.StatusCode, ret);
    }

    /// <summary>
    /// Delete item
    /// </summary>
    /// <param name= "externalId"></param>
    [HttpDelete("delete/by-external-id/{externalId}")]
    public async Task<IActionResult> Delete(Guid externalId)
    {
        var ret = this.service.Delete(externalId).Result;
        return StatusCode(ret.StatusCode, ret);
    }
}
