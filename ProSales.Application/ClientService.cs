
using System.Security.Claims;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using ProSales.Application.Contracts;
using ProSales.Domain.Dtos;
using ProSales.Domain.Global;
using ProSales.Repository.Contracts;

namespace ProSales.Application
{
    public class ClientService : IClientService
    {

        private readonly IHttpContextAccessor _accessor;
        private readonly IMapper _mapper;
        private readonly IGlobalRepository _globalRepo;
        private readonly IClientRepository Repo;

        public ClientService(IHttpContextAccessor Accessor, IMapper Mapper
        , IGlobalRepository GlobalRepo
        , IClientRepository Repo)
        {
            this.Repo = Repo;
            _accessor = Accessor;
            _mapper = Mapper;
            _globalRepo = GlobalRepo;
        }

        public async Task<RetornoDto> Create(CreateClientDto createItem)
        {
            try
            {
                var itemFound = this.Repo.GetByFullName(createItem.FullName).Result;

                if (itemFound != null)
                    return RetornoDto.objectDuplicaded(_mapper.Map<ClientDto>(itemFound));

                var createMappedItem = _mapper.Map<Client>(createItem);

                createMappedItem.UserCreatedId = Int32.Parse(_accessor.HttpContext.User.Claims.First(x => x.Type == ClaimTypes.NameIdentifier).Value);
                _globalRepo.Add(createMappedItem);

                if (await _globalRepo.SaveChangesAsync())
                    return RetornoDto.objectCreateSuccess(_mapper.Map<ClientDto>(createMappedItem));

                throw new Exception();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                return RetornoDto.objectGenericError(ex);
            }
        }

        public async Task<RetornoDto> Update(ClientDto update)
        {
            try
            {
                var itemFound = this.Repo.GetByExternalId(update.ExternalId).Result;
                if (itemFound is null)
                    return RetornoDto.objectNotFound();

                itemFound.UserUpdatedId = Int32.Parse(_accessor.HttpContext.User.Claims.First(x => x.Type == ClaimTypes.NameIdentifier).Value);
                itemFound.UpdatedAt = DateTime.Now;
                itemFound.FullName = update.FullName;
                itemFound.BirthDate = update.BirthDate;

                _globalRepo.Update(itemFound);

                if (await _globalRepo.SaveChangesAsync())
                    return RetornoDto.objectUpdateSuccess(_mapper.Map<ClientDto>(update));

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
                    return RetornoDto.objectUpdateSuccess(_mapper.Map<ClientDto>(itemFound));

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

                return RetornoDto.objectFoundSuccess(_mapper.Map<ClientDto>(itemFound));
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

                return RetornoDto.objectFoundSuccess(_mapper.Map<ClientDto>(itemFound));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                return RetornoDto.objectGenericError(ex);
            }
        }

        public async Task<RetornoDto> GetByFullName(string name)
        {
            try
            {
                var itemFound = this.Repo.GetByFullName(name).Result;

                if (itemFound == null)
                    return RetornoDto.objectNotFound();

                return RetornoDto.objectFoundSuccess(_mapper.Map<ClientDto>(itemFound));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                return RetornoDto.objectGenericError(ex);
            }
        }

        public async Task<RetornoDto> GetAllByQuery(ClientQuery query)
        {
            try
            {
                var itemFound = this.Repo.GetAllByQuery(query).Result;

                if (itemFound == null)
                    return RetornoDto.objectNotFound();

                var totalItems = await this.Repo.GetCountItems(query);

                return RetornoDto.objectsFoundSuccess(_mapper.Map<ICollection<ClientDto>>(itemFound),query.Skip,query.Take,totalItems);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                return RetornoDto.objectGenericError(ex);
            }
        }

        public async Task<RetornoDto> GetAllByDocument(DocumentQuery query)
        {
            try
            {
                var itemFound = this.Repo.GetByDocument(query).Result;

                if (itemFound == null)
                    return RetornoDto.objectNotFound();

                var totalItems = itemFound.Count;

                return RetornoDto.objectsFoundSuccess(_mapper.Map<ICollection<ClientDto>>(itemFound),query.Skip,query.Take,totalItems);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                return RetornoDto.objectGenericError(ex);
            }
        }

        public async Task<RetornoDto> GetAllByContact(ContactQuery query)
        {
            try
            {
                var itemFound = this.Repo.GetByContact(query).Result;

                if (itemFound == null)
                    return RetornoDto.objectNotFound();

                var totalItems = itemFound.Count;

                return RetornoDto.objectsFoundSuccess(_mapper.Map<ICollection<ClientDto>>(itemFound),query.Skip,query.Take,totalItems);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                return RetornoDto.objectGenericError(ex);
            }
        }
    }
}