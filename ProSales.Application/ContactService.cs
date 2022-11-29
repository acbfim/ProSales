
using System.Security.Claims;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using ProSales.Application.Contracts;
using ProSales.Domain.Dtos;
using ProSales.Domain.Global;
using ProSales.Repository.Contracts;

namespace ProSales.Application
{
    public class ContactService : IContactService
    {

        private readonly IHttpContextAccessor _accessor;
        private readonly IMapper _mapper;
        private readonly IGlobalRepository _globalRepo;
        private readonly IContactRepository Repo;

        public IContactTypeRepository ContactRepo { get; }
        public IClientRepository ClientRepo { get; }

        public ContactService(IHttpContextAccessor Accessor, IMapper Mapper
        , IGlobalRepository GlobalRepo
        , IContactRepository Repo
        , IContactTypeRepository ContactRepo
        , IClientRepository ClientRepo)
        {
            this.Repo = Repo;
            this.ContactRepo = ContactRepo;
            this.ClientRepo = ClientRepo;
            _accessor = Accessor;
            _mapper = Mapper;
            _globalRepo = GlobalRepo;
        }

        public async Task<RetornoDto> Create(CreateContactDto createItem)
        {
            try
            {
                var itemFound = await this.Repo.GetByValueAndType(createItem.Value, createItem.ContactType.ExternalId);

                if (itemFound != null)
                    return RetornoDto.objectDuplicaded(_mapper.Map<ContactDto>(itemFound));

                var contactTypeFound = this.ContactRepo.GetByExternalId(createItem.ContactType.ExternalId).Result;

                if (contactTypeFound is null)
                    return RetornoDto.objectNotFound("Tipo do contato não localizado pela ExternalId");

                var clientFound = this.ClientRepo.GetByExternalId(createItem.Client.ExternalId).Result;

                if (clientFound is null)
                    return RetornoDto.objectNotFound("Cliente não localizado pela ExternalId");

                var createMappedItem = _mapper.Map<Contact>(createItem);

                createMappedItem.UserCreatedId = Int32.Parse(_accessor.HttpContext.User.Claims.First(x => x.Type == ClaimTypes.NameIdentifier).Value);
                createMappedItem.Value = createItem.Value;
                createMappedItem.ClientId = clientFound.Id;
                createMappedItem.ContactTypeId = contactTypeFound.Id;

                createMappedItem.Client = null;
                createMappedItem.ContactType = null;

                _globalRepo.Add(createMappedItem);


                if (await _globalRepo.SaveChangesAsync())
                    return RetornoDto.objectCreateSuccess(_mapper.Map<ContactDto>(createMappedItem));

                throw new Exception();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                return RetornoDto.objectGenericError(ex);
            }
        }

        public async Task<RetornoDto> Update(ContactDto update)
        {
            try
            {
                var itemFound = this.Repo.GetByExternalId(update.ExternalId).Result;
                if (itemFound is null)
                    return RetornoDto.objectNotFound("Contato não localizado pela ExternalId");

                var contactTypeFound = this.ContactRepo.GetByExternalId(update.ContactType.ExternalId).Result;

                if (contactTypeFound is null)
                    return RetornoDto.objectNotFound("Tipo do contato não localizado pela ExternalId");


                itemFound.UserUpdatedId = Int32.Parse(_accessor.HttpContext.User.Claims.First(x => x.Type == ClaimTypes.NameIdentifier).Value);
                itemFound.UpdatedAt = DateTime.Now;
                itemFound.ContactTypeId = contactTypeFound.Id;
                itemFound.Value = update.Value;

                _globalRepo.Update(itemFound);

                if (await _globalRepo.SaveChangesAsync())
                    return RetornoDto.objectUpdateSuccess(_mapper.Map<ContactDto>(update));

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
                    return RetornoDto.objectUpdateSuccess(_mapper.Map<ContactDto>(itemFound));

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

                return RetornoDto.objectFoundSuccess(_mapper.Map<ContactDto>(itemFound));
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

                return RetornoDto.objectFoundSuccess(_mapper.Map<ContactDto>(itemFound));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                return RetornoDto.objectGenericError(ex);
            }
        }

        public async Task<RetornoDto> GetByValueAndTypeContact(string value, Guid contactTypeExternalId)
        {
            try
            {
                var itemFound = await this.Repo.GetByValueAndType(value, contactTypeExternalId);

                if (itemFound == null)
                    return RetornoDto.objectNotFound();

                return RetornoDto.objectFoundSuccess(_mapper.Map<ContactDto>(itemFound));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                return RetornoDto.objectGenericError(ex);
            }
        }

        public async Task<RetornoDto> GetAllByQuery(ContactQuery query)
        {
            try
            {
                var itemFound = this.Repo.GetAllByQuery(query).Result;

                if (itemFound == null)
                    return RetornoDto.objectNotFound();

                var totalItems = await this.Repo.GetCountItems(query);

                return RetornoDto.objectsFoundSuccess(_mapper.Map<ICollection<ContactDto>>(itemFound),query.Skip,query.Take,totalItems);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                return RetornoDto.objectGenericError(ex);
            }
        }

    }
}