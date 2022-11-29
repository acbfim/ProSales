
using System.Security.Claims;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using ProSales.Application.Contracts;
using ProSales.Domain.Dtos;
using ProSales.Domain.Global;
using ProSales.Repository.Contracts;

namespace ProSales.Application
{
    public class DocumentService : IDocumentService
    {

        private readonly IHttpContextAccessor _accessor;
        private readonly IMapper _mapper;
        private readonly IGlobalRepository _globalRepo;
        private readonly IDocumentRepository Repo;

        public IDocumentTypeRepository DocumentRepo { get; }
        public IClientRepository ClientRepo { get; }

        public DocumentService(IHttpContextAccessor Accessor, IMapper Mapper
        , IGlobalRepository GlobalRepo
        , IDocumentRepository Repo
        , IDocumentTypeRepository DocumentRepo
        , IClientRepository ClientRepo)
        {
            this.Repo = Repo;
            this.DocumentRepo = DocumentRepo;
            this.ClientRepo = ClientRepo;
            _accessor = Accessor;
            _mapper = Mapper;
            _globalRepo = GlobalRepo;
        }

        public async Task<RetornoDto> Create(CreateDocumentDto createItem)
        {
            try
            {
                var itemFound = await this.Repo.GetByValueAndType(createItem.Value, createItem.DocumentType.ExternalId);

                if (itemFound != null)
                    return RetornoDto.objectDuplicaded(_mapper.Map<DocumentDto>(itemFound));

                var DocumentTypeFound = this.DocumentRepo.GetByExternalId(createItem.DocumentType.ExternalId).Result;

                if (DocumentTypeFound is null)
                    return RetornoDto.objectNotFound("Tipo do documento não localizado pela ExternalId");

                var clientFound = this.ClientRepo.GetByExternalId(createItem.Client.ExternalId).Result;

                if (clientFound is null)
                    return RetornoDto.objectNotFound("Cliente não localizado pela ExternalId");

                var createMappedItem = _mapper.Map<Document>(createItem);

                createMappedItem.UserCreatedId = Int32.Parse(_accessor.HttpContext.User.Claims.First(x => x.Type == ClaimTypes.NameIdentifier).Value);
                createMappedItem.Value = createItem.Value;
                createMappedItem.ClientId = clientFound.Id;
                createMappedItem.DocumentTypeId = DocumentTypeFound.Id;

                createMappedItem.Client = null;
                createMappedItem.DocumentType = null;

                _globalRepo.Add(createMappedItem);


                if (await _globalRepo.SaveChangesAsync())
                    return RetornoDto.objectCreateSuccess(_mapper.Map<DocumentDto>(createMappedItem));

                throw new Exception();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                return RetornoDto.objectGenericError(ex);
            }
        }

        public async Task<RetornoDto> Update(DocumentDto update)
        {
            try
            {
                var itemFound = this.Repo.GetByExternalId(update.ExternalId).Result;
                if (itemFound is null)
                    return RetornoDto.objectNotFound("Documento não localizado pela ExternalId");

                var DocumentTypeFound = this.DocumentRepo.GetByExternalId(update.DocumentType.ExternalId).Result;

                if (DocumentTypeFound is null)
                    return RetornoDto.objectNotFound("Tipo do documento não localizado pela ExternalId");


                itemFound.UserUpdatedId = Int32.Parse(_accessor.HttpContext.User.Claims.First(x => x.Type == ClaimTypes.NameIdentifier).Value);
                itemFound.UpdatedAt = DateTime.Now;
                itemFound.DocumentTypeId = DocumentTypeFound.Id;
                itemFound.Value = update.Value;

                _globalRepo.Update(itemFound);

                if (await _globalRepo.SaveChangesAsync())
                    return RetornoDto.objectUpdateSuccess(_mapper.Map<DocumentDto>(update));

                throw new Exception();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                return RetornoDto.objectGenericError(ex);
            }
        }

        public async Task<RetornoDto> ToogleAlterStatus(Guid externalId)
        {
            try
            {
                var itemFound = this.Repo.GetByExternalId(externalId).Result;
                if (itemFound == null)
                    return RetornoDto.objectNotFound();

                itemFound.UserUpdatedId = Int32.Parse(_accessor.HttpContext.User.Claims.First(x => x.Type == ClaimTypes.NameIdentifier).Value);
                itemFound.UpdatedAt = DateTime.Now;

                itemFound.IsActive = !itemFound.IsActive;

                _globalRepo.Update(itemFound);

                if (await _globalRepo.SaveChangesAsync())
                    return RetornoDto.objectUpdateSuccess(_mapper.Map<DocumentDto>(itemFound));

                throw new Exception();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                return RetornoDto.objectGenericError(ex);
            }
        }

        public async Task<RetornoDto> GetByExternalId(Guid externalId)
        {
            try
            {
                var itemFound = this.Repo.GetByExternalId(externalId).Result;

                if (itemFound == null)
                    return RetornoDto.objectNotFound();

                return RetornoDto.objectFoundSuccess(_mapper.Map<DocumentDto>(itemFound));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                return RetornoDto.objectGenericError(ex);
            }
        }

        public async Task<RetornoDto> GetById(long id)
        {
            try
            {
                var itemFound = this.Repo.GetById(id).Result;

                if (itemFound == null)
                    return RetornoDto.objectNotFound();

                return RetornoDto.objectFoundSuccess(_mapper.Map<DocumentDto>(itemFound));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                return RetornoDto.objectGenericError(ex);
            }
        }

        public async Task<RetornoDto> GetByValueAndTypeDocument(string value, Guid DocumentTypeExternalId)
        {
            try
            {
                var itemFound = await this.Repo.GetByValueAndType(value, DocumentTypeExternalId);

                if (itemFound == null)
                    return RetornoDto.objectNotFound();

                return RetornoDto.objectFoundSuccess(_mapper.Map<DocumentDto>(itemFound));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                return RetornoDto.objectGenericError(ex);
            }
        }

        public async Task<RetornoDto> GetAllByQuery(DocumentQuery query)
        {
            try
            {
                var itemFound = this.Repo.GetAllByQuery(query).Result;

                if (itemFound == null)
                    return RetornoDto.objectNotFound();

                var totalItems = await this.Repo.GetCountItems(query);

                return RetornoDto.objectsFoundSuccess(_mapper.Map<ICollection<DocumentDto>>(itemFound),query.Skip,query.Take,totalItems);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                return RetornoDto.objectGenericError(ex);
            }
        }

    }
}