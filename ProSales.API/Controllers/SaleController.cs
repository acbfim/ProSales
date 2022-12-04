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

/// <summary>
/// Gerenciar vendas
/// </summary>

[Route("api/[controller]")]
[ApiController]
public class SaleController : ControllerBase
{
    private readonly ISaleService service;

    public SaleController(ISaleService service)
    {
        this.service = service;
    }


    /// <summary>
    /// Get Item by ExternalID
    /// </summary>
    /// <param name= "externalId"></param>
    /// <param name= "includeJoins"></param>
    [HttpGet("by-external-id/{externalId}")]
    public async Task<IActionResult> getByExternalId(Guid externalId, [FromQuery] bool includeJoins = false)
    {
        var ret = await this.service.GetByExternalId(externalId, includeJoins);
        return StatusCode(ret.StatusCode, ret);
    }

    /// <summary>
    /// Get Item by clientId
    /// </summary>
    /// <param name= "clientExternalId"></param>
    /// <param name= "includeJoins"></param>
    [HttpGet("by-client-external-id/{clientExternalId}")]
    public async Task<IActionResult> getByClientExternalId(Guid clientExternalId, [FromQuery] bool includeJoins = false)
    {
        var ret = await this.service.GetAllByClientExternalId(clientExternalId, includeJoins);
        return StatusCode(ret.StatusCode, ret);
    }

    /// <summary>
    /// Get Item by ExternalID
    /// </summary>
    /// <param name= "userExternalId"></param>
    /// <param name= "includeJoins"></param>
    [HttpGet("by-seller-external-id/{userExternalId}")]
    public async Task<IActionResult> getByUserExternalId(Guid userExternalId, [FromQuery] bool includeJoins = false)
    {
        var ret = await this.service.GetAllByUserExternalId(userExternalId, includeJoins);
        return StatusCode(ret.StatusCode, ret);
    }

    /// <summary>
    /// Get Item by Query
    /// </summary>
    /// <param name= "includeJoins"></param>
    /// <param name= "query"></param>
    [HttpGet("by-query")]
    public async Task<IActionResult> GetAllByQuery([FromQuery] SaleQuery query, [FromQuery] bool includeJoins = false)
    {
        var ret = await this.service.GetAllByQuery(query, includeJoins);
        return StatusCode(ret.StatusCode, ret);
    }

    /// <summary>
    /// Post create item
    /// </summary>
    [HttpPost("create")]
    public async Task<IActionResult> postCreate(CreateSaleDto create)
    {
        var ret = await this.service.Create(create);
        return StatusCode(ret.StatusCode, ret);
    }

    /// <summary>
    /// Add product from sale
    /// </summary>
    [HttpPost("add-product")]
    public async Task<IActionResult> addProduct(CreateProductSaleDto create)
    {
        var ret = await this.service.AddProduct(create);
        return StatusCode(ret.StatusCode, ret);
    }

    /// <summary>
    /// Remove product from sale
    /// </summary>
    [HttpDelete("remove-product")]
    public async Task<IActionResult> removeProduct(CreateProductSaleDto remove)
    {
        var ret = await this.service.RemoveProduct(remove);
        return StatusCode(ret.StatusCode, ret);
    }

    /// <summary>
    /// Post create item
    /// </summary>
    [HttpPut("update-discount-product")]
    public async Task<IActionResult> updateDiscountProduct(UpdateDiscountProductSaleDto update)
    {
        var ret = await this.service.UpdateDiscountProduct(update);
        return StatusCode(ret.StatusCode, ret);
    }


}
