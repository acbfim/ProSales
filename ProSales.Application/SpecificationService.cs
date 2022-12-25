
using System.Security.Claims;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using ProSales.Application.Contracts;
using ProSales.Domain.Dtos;
using ProSales.Domain.Global;
using ProSales.Repository.Contracts;

namespace ProSales.Application
{
    public class SpecificationService : ISpecificationService
    {

        private readonly IHttpContextAccessor _accessor;
        private readonly IMapper _mapper;
        private readonly IGlobalRepository _globalRepo;
        private readonly ISpecificationRepository Repo;

        public IProductRepository ProductRepo { get; }

        public SpecificationService(IHttpContextAccessor Accessor, IMapper Mapper
        , IGlobalRepository GlobalRepo
        , ISpecificationRepository Repo
        , IProductRepository ProductRepo)
        {
            this.Repo = Repo;
            this.ProductRepo = ProductRepo;
            _accessor = Accessor;
            _mapper = Mapper;
            _globalRepo = GlobalRepo;
        }

        public async Task<RetornoDto> Create(CreateSpecificationDto createItem)
        {
            try
            {
                var productFound = await this.ProductRepo.GetByExternalId(createItem.Product.ExternalId);

                if (productFound is null)
                    return RetornoDto.objectNotFound("Produto não localizado pela ExternalId");

                var createMappedItem = _mapper.Map<Specification>(createItem);

                createMappedItem.Product = null;

                createMappedItem.UserCreatedId = Int32.Parse(_accessor.HttpContext.User.Claims.First(x => x.Type == ClaimTypes.NameIdentifier).Value);
                createMappedItem.ProductId = productFound.Id;
                
                _globalRepo.Add(createMappedItem);

                if (await _globalRepo.SaveChangesAsync())
                    return RetornoDto.objectCreateSuccess(_mapper.Map<SpecificationDto>(createMappedItem));

                throw new Exception();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                return RetornoDto.objectGenericError(ex.InnerException?.Message + ex);
            }
        }

        public async Task<RetornoDto> Update(SpecificationDto update)
        {
            try
            {
                var itemFound = this.Repo.GetByExternalId(update.ExternalId).Result;
                if (itemFound is null)
                    return RetornoDto.objectNotFound("Item não encontrado pela ExternalId");


                itemFound.UserUpdatedId = Int32.Parse(_accessor.HttpContext.User.Claims.First(x => x.Type == ClaimTypes.NameIdentifier).Value);
                itemFound.UpdatedAt = DateTime.Now;
                itemFound.Key = update.Key;
                itemFound.Value = update.Value;

                _globalRepo.Update(itemFound);

                if (await _globalRepo.SaveChangesAsync())
                    return RetornoDto.objectUpdateSuccess(_mapper.Map<SpecificationDto>(update));

                throw new Exception();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                return RetornoDto.objectGenericError(ex.InnerException?.Message + ex);
            }
        }

        public async Task<RetornoDto> Delete(Guid externalId)
        {
            try
            {
                var itemFound = this.Repo.GetByExternalId(externalId).Result;
                if (itemFound is null)
                    return RetornoDto.objectNotFound("Item não encontrado pela ExternalId");

    

                _globalRepo.Delete(itemFound);

                if (await _globalRepo.SaveChangesAsync())
                    return RetornoDto.objectDeletedSuccess();

                throw new Exception();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                return RetornoDto.objectGenericError(ex.InnerException?.Message + ex);
            }
        }

        public async Task<RetornoDto> GetByExternalId(Guid externalId)
        {
            try
            {
                var itemFound = this.Repo.GetByExternalId(externalId).Result;

                if (itemFound == null)
                    return RetornoDto.objectNotFound();

                return RetornoDto.objectFoundSuccess(_mapper.Map<SpecificationDto>(itemFound));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                return RetornoDto.objectGenericError(ex.InnerException?.Message + ex);
            }
        }

        public async Task<RetornoDto> GetById(long id)
        {
            try
            {
                var itemFound = this.Repo.GetById(id).Result;

                if (itemFound == null)
                    return RetornoDto.objectNotFound();

                return RetornoDto.objectFoundSuccess(_mapper.Map<SpecificationDto>(itemFound));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                return RetornoDto.objectGenericError(ex.InnerException?.Message + ex);
            }
        }

        public async Task<RetornoDto> GetAllByQuery(SpecificationQuery query)
        {
            try
            {
                var itemFound = this.Repo.GetAllByQuery(query).Result;

                if (itemFound == null)
                    return RetornoDto.objectNotFound();

                var totalItems = await this.Repo.GetCountItems(query);

                return RetornoDto.objectsFoundSuccess(_mapper.Map<ICollection<SpecificationDto>>(itemFound),query.Skip,query.Take,totalItems);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                return RetornoDto.objectGenericError(ex.InnerException?.Message + ex);
            }
        }

        public async Task<RetornoDto> GetAllByKey(string key)
        {
            try
            {
                var itemFound = await this.Repo.GetAllByKey(key);

                if (itemFound == null)
                    return RetornoDto.objectNotFound();

                return RetornoDto.objectFoundSuccess(_mapper.Map<SpecificationDto>(itemFound));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                return RetornoDto.objectGenericError(ex.InnerException?.Message + ex);
            }
        }

        public async Task<RetornoDto> GetAllByValue(string value)
        {
            try
            {
                var itemFound = await this.Repo.GetAllByValue(value);

                if (itemFound == null)
                    return RetornoDto.objectNotFound();

                return RetornoDto.objectFoundSuccess(_mapper.Map<SpecificationDto>(itemFound));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                return RetornoDto.objectGenericError(ex.InnerException?.Message + ex);
            }
        }

        public async Task<RetornoDto> GetAllByProductExternalId(Guid productExternalId)
        {
            try
            {
                var productFound = await this.ProductRepo.GetByExternalId(productExternalId);
                if (productFound == null)
                    return RetornoDto.objectNotFound("Produto não encontrado pela ExternalId");

                var itemFound = await this.Repo.GetAllByProductId(productFound.Id);

                if (itemFound == null)
                    return RetornoDto.objectNotFound();

                return RetornoDto.objectFoundSuccess(_mapper.Map<SpecificationDto>(itemFound));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                return RetornoDto.objectGenericError(ex.InnerException?.Message + ex);
            }
        }
    }
}