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
public class CartController : ControllerBase
{
    private readonly ICartService service;

    public CartController(ICartService service)
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
    /// Get Item by Query
    /// </summary>
    [HttpGet("by-query")]
    public async Task<IActionResult> GetAllByQuery([FromQuery] CartQuery query)
    {
        var ret = this.service.GetAllByQuery(query).Result;
        return StatusCode(ret.StatusCode, ret);
    }

    /// <summary>
    /// Post create item
    /// </summary>
    [HttpPost("create")]
    public async Task<IActionResult> postCreate(CreateCartDto create)
    {
        var ret = this.service.Create(create).Result;
        return StatusCode(ret.StatusCode, ret);
    }

    /// <summary>
    /// Post create item
    /// </summary>
    [HttpPost("addProduct")]
    public async Task<IActionResult> addProduct(CartDtoAddProduct create)
    {
        var ret = this.service.AddProduct(create).Result;
        return StatusCode(ret.StatusCode, ret);
    }

    /// <summary>
    /// Post create item
    /// </summary>
    [HttpDelete("removeProduct")]
    public async Task<IActionResult> removeProduct(CartDtoAddProduct create)
    {
        var ret = this.service.RemoveProduct(create).Result;
        return StatusCode(ret.StatusCode, ret);
    }

    
}
