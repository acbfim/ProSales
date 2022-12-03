using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ProSales.Domain;
using ProSales.Domain.Dtos;
using ProSales.Domain.Global;
using ProSales.Domain.Identity;
using ProSales.Repository.Contexts;

namespace ProSales.API.Controllers;

[Route("[controller]")]
[ApiController]
public class TesteController : ControllerBase
{

    private readonly IHttpContextAccessor _accessor;
    private readonly ProSalesContext _context;
    public readonly IMapper _mapper;

    public TesteController(IHttpContextAccessor Acessor, ProSalesContext Context, IMapper mapper)
    {
        _accessor = Acessor;
        _context = Context;
        _mapper = mapper;
    }

    [HttpGet]
    public async Task<IActionResult> Teste()
    {

        //Captura dados do usuário
        var user = _accessor.HttpContext.User.Identity.Name;
        var userId = _accessor.HttpContext.User.Claims.First(x => x.Type == ClaimTypes.NameIdentifier).Value;
        var externalId = _accessor.HttpContext.User.Claims.First(c => c.Type.ToUpper() == "EXTERNALID").Value;

        //Captura o token
        var token = _accessor.HttpContext.Request.Headers.First(c => c.Key == "Authorization").Value.ToString();
        return Ok("Funcionei" + user);
    }

    [AllowAnonymous]
    [HttpGet("testeCarlos")]
    public async Task<IActionResult> TesteCarlos()
    {

        IQueryable<ContactType> query = _context.ContactType;

        var teste = await query.ToArrayAsync();
        return Ok(teste);
    }

    /// <summary>
    /// Cria um novo tipo de contato
    /// </summary>
    /// <param name="contato"></param>
    [HttpPost("criarContato")]
    public async Task<IActionResult> criarContato(CreateContactTypeDto contato)
    {

        var userId = _accessor.HttpContext.User.Claims.First(x => x.Type == ClaimTypes.NameIdentifier).Value;

        var createContact = _mapper.Map<ContactType>(contato);

        //createContact.UserCreatedId = Int32.Parse(userId);
        var add = _context.Add(createContact);

        if (await _context.SaveChangesAsync() > 0)
        {
            RetornoDto retorno = new RetornoDto();
            retorno.Data = _mapper.Map<ContactTypeDto>(add.Entity);

            retorno.Message = "Contato salvo com sucesso";
            retorno.Success = true;
            retorno.StatusCode = StatusCodes.Status201Created;
            return this.StatusCode(retorno.StatusCode, retorno);
        }

        return Ok(_mapper.Map<ContactTypeDto>(add.Entity));
    }

    [AllowAnonymous]
    [HttpGet("pdf")]
    public ActionResult PDFUmDocSelecionado()
    {
        try
        {
            string _nomeArquivo = "Meu_Documento_" + DateTime.Now.ToString().Replace(" ", "_").Replace("/", "_").Replace(":", "_") + ".pdf";

            var pdf = new byte[] { 1, 2, 3 };
            using (MemoryStream file = new MemoryStream())
            {
                file.Write(pdf, 0, pdf.Length);
            }

            byte[] arquivo = pdf;

            MemoryStream pdfStream = new MemoryStream();



            pdfStream.Position = 0;
            return new FileStreamResult(pdfStream, "application/pdf");
        }
        catch
        {
            throw;
        }

    }

    [AllowAnonymous]
    [HttpGet("form")]
    public async Task<IActionResult> GetForm(int perguntaid = 0)
    {
        IQueryable<FormTeste> query = _context.FormTeste;

        query = query.Include(x => x.Respostas);

        if (perguntaid == 0)
        {
            query = query.Where(x => x.FormTesteId == null);
        }
        else
        {
            query = query.Where(x => x.FormTesteId == perguntaid);
        }

        

        return Ok(query);

    }


}
