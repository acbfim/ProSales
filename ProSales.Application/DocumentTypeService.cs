using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using ProSales.Application.Contracts;
using ProSales.Domain.Dtos;
using ProSales.Domain.Global;
using ProSales.Repository.Contexts;
using ProSales.Repository.Contracts;

namespace ProSales.Application
{
    public class DocumentTypeService : IDocumentTypeService
    {

        private readonly IHttpContextAccessor _accessor;
        private readonly IMapper _mapper;
        private readonly IGlobalRepository _globalRepo;
        private readonly IDocumentTypeRepository Repo;

        public DocumentTypeService(IHttpContextAccessor Accessor, IMapper Mapper
        , IGlobalRepository GlobalRepo
        , IDocumentTypeRepository Repo)
        {
            this.Repo = Repo;
            _accessor = Accessor;
            _mapper = Mapper;
            _globalRepo = GlobalRepo;
        }

        public async Task<RetornoDto> Create(CreateDocumentTypeDto createItem)
        {
            try
            {
                var itemFound = this.Repo.GetByName(createItem.Name).Result;

                if (itemFound != null)
                    return RetornoDto.objectDuplicaded(_mapper.Map<DocumentTypeDto>(itemFound));

                var createMappedItem = _mapper.Map<DocumentType>(createItem);

                //createMappedItem.UserCreatedId = Int32.Parse(_accessor.HttpContext.User.Claims.First(x => x.Type == ClaimTypes.NameIdentifier).Value);
                _globalRepo.Add(createMappedItem);

                if (await _globalRepo.SaveChangesAsync())
                    return RetornoDto.objectCreateSuccess(_mapper.Map<DocumentTypeDto>(createMappedItem));

                throw new Exception();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                return RetornoDto.objectGenericError(ex);
            }
        }

        public async Task<RetornoDto> Update(DocumentTypeDto update)
        {
            try
            {
                var itemFound = this.Repo.GetByExternalId(update.ExternalId).Result;
                if (itemFound is null)
                    return RetornoDto.objectNotFound();

                var itemFoundByName = this.Repo.GetByName(update.Name).Result;
                if (itemFoundByName is not null)
                    return RetornoDto.objectDuplicaded(_mapper.Map<DocumentTypeDto>(itemFoundByName));


                //itemFound.UserUpdatedId = Int32.Parse(_accessor.HttpContext.User.Claims.First(x => x.Type == ClaimTypes.NameIdentifier).Value);
                itemFound.UpdatedDate = DateTime.Now;
                itemFound.Name = update.Name;

                _globalRepo.Update(itemFound);

                if (await _globalRepo.SaveChangesAsync())
                    return RetornoDto.objectUpdateSuccess(_mapper.Map<DocumentTypeDto>(update));

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

                //itemFound.UserUpdatedId = Int32.Parse(_accessor.HttpContext.User.Claims.First(x => x.Type == ClaimTypes.NameIdentifier).Value);
                itemFound.UpdatedDate = DateTime.Now;

                itemFound.IsActive = !itemFound.IsActive;

                _globalRepo.Update(itemFound);

                if (await _globalRepo.SaveChangesAsync())
                    return RetornoDto.objectUpdateSuccess(_mapper.Map<DocumentTypeDto>(itemFound));

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

                return RetornoDto.objectFoundSuccess(_mapper.Map<DocumentTypeDto>(itemFound));
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

                return RetornoDto.objectFoundSuccess(_mapper.Map<DocumentTypeDto>(itemFound));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                return RetornoDto.objectGenericError(ex);
            }
        }

        public async Task<RetornoDto> GetByName(string name)
        {
            try
            {
                var itemFound = this.Repo.GetByName(name).Result;

                if (itemFound == null)
                    return RetornoDto.objectNotFound();

                return RetornoDto.objectFoundSuccess(_mapper.Map<DocumentTypeDto>(itemFound));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                return RetornoDto.objectGenericError(ex);
            }
        }

        public async Task<RetornoDto> GetAllByQuery(DocumentTypeQuery query)
        {
            try
            {
                var itemFound = this.Repo.GetAllByQuery(query).Result;

                if (itemFound == null)
                    return RetornoDto.objectNotFound();

                var totalItems = await this.Repo.GetCountItems(query);

                return RetornoDto.objectsFoundSuccess(_mapper.Map<ICollection<DocumentTypeDto>>(itemFound),query.Skip,query.Take,totalItems);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                return RetornoDto.objectGenericError(ex);
            }
        }
    }
}