
using System.Security.Claims;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using ProSales.Application.Contracts;
using ProSales.Domain.Dtos;
using ProSales.Domain.Global;
using ProSales.Repository.Contracts;

namespace ProSales.Application
{
    public class ProductService : IProductService
    {

        private readonly IHttpContextAccessor _accessor;
        private readonly IMapper _mapper;
        private readonly IGlobalRepository _globalRepo;
        private readonly IProductRepository Repo;
        private readonly IDiscountTypeRepository discountType;

        public IBrandRepository RepoBrand { get; }
        public IDiscountTypeRepository RepoDiscountType { get; }
        public IProductTypeRepository RepoProductType { get; }
        public IDiscountTypeRepository DiscountTypeRepo { get; }
        public IProductTypeRepository ProductTypeRepo { get; }

        public ProductService(IHttpContextAccessor Accessor, IMapper Mapper
        , IGlobalRepository GlobalRepo
        , IProductRepository Repo
        , IBrandRepository RepoBrand
        , IDiscountTypeRepository RepoDiscountType
        , IProductTypeRepository RepoProductType)
        {
            this.Repo = Repo;
            this.RepoBrand = RepoBrand;
            this.RepoDiscountType = RepoDiscountType;
            this.RepoProductType = RepoProductType;
            _accessor = Accessor;
            _mapper = Mapper;
            _globalRepo = GlobalRepo;
        }

        public async Task<RetornoDto> Create(CreateProductDto createItem)
        {
            try
            {
                var itemFound = this.Repo.GetByName(createItem.Name).Result;
                if (itemFound != null)
                    return RetornoDto.objectDuplicaded(_mapper.Map<ProductDto>(itemFound));

                var brandFound = this.RepoBrand.GetBrandByExternalId(createItem.Brand.ExternalId).Result;
                if (brandFound is null)
                    return RetornoDto.objectNotFound("Marca não encontrada pela ExternalId");

                var productFound = this.RepoProductType.GetByExternalId(createItem.ProductType.ExternalId).Result;
                if (productFound is null)
                    return RetornoDto.objectNotFound("Tipo do produto não encontrado pela ExternalId");

                var discountTypeFound = new DiscountType();
                discountTypeFound = null;
                
                if (createItem.DiscountType is not null)
                {
                    discountTypeFound = this.RepoDiscountType.GetByExternalId(createItem.DiscountType.ExternalId).Result;
                    if (discountTypeFound is null)
                        return RetornoDto.objectNotFound("Tipo do desconto não encontrado pela ExternalId");
                }


                var createMappedItem = _mapper.Map<Product>(createItem);

                createMappedItem.UserCreatedId = Int32.Parse(_accessor.HttpContext.User.Claims.First(x => x.Type == ClaimTypes.NameIdentifier).Value);
                createMappedItem.Brand = null;
                createMappedItem.DiscountType = null;
                createMappedItem.ProductType = null;

                createMappedItem.ProductTypeId = productFound.Id;
                createMappedItem.BrandId = brandFound.Id;

                if (discountTypeFound is not null)
                    createMappedItem.DiscountTypeId = discountTypeFound.Id;

                _globalRepo.Add(createMappedItem);

                if (await _globalRepo.SaveChangesAsync())
                    return RetornoDto.objectCreateSuccess(_mapper.Map<ProductDto>(createMappedItem));

                throw new Exception();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                return RetornoDto.objectGenericError(ex);
            }
        }

        public async Task<RetornoDto> Update(ProductDto update)
        {
            try
            {
                var itemFound = this.Repo.GetByExternalId(update.ExternalId).Result;
                if (itemFound is null)
                    return RetornoDto.objectNotFound();

                var brandFound = this.RepoBrand.GetBrandByExternalId(update.ExternalId).Result;
                if (brandFound is null)
                    return RetornoDto.objectNotFound();

                var itemFoundByName = this.Repo.GetByName(update.Name).Result;
                if (itemFoundByName is not null)
                    return RetornoDto.objectDuplicaded(_mapper.Map<ProductDto>(itemFoundByName));


                itemFound.UserUpdatedId = Int32.Parse(_accessor.HttpContext.User.Claims.First(x => x.Type == ClaimTypes.NameIdentifier).Value);
                itemFound.UpdatedAt = DateTime.Now;
                itemFound.Name = update.Name.Trim();
                itemFound.Description = update.Description.Trim();
                itemFound.ImageUrl = update.ImageUrl;
                itemFound.Price = update.Price;
                itemFound.Discount = update.Discount;
                itemFound.BrandId = brandFound.Id;

                itemFound.Brand = null;
                itemFound.ProductType = null;
                itemFound.DiscountType = null;

                _globalRepo.Update(itemFound);

                if (await _globalRepo.SaveChangesAsync())
                    return RetornoDto.objectUpdateSuccess(_mapper.Map<ProductDto>(update));

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
                    return RetornoDto.objectUpdateSuccess(_mapper.Map<ProductDto>(itemFound));

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

                return RetornoDto.objectFoundSuccess(_mapper.Map<ProductDto>(itemFound));
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

                return RetornoDto.objectFoundSuccess(_mapper.Map<ProductDto>(itemFound));
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

                return RetornoDto.objectFoundSuccess(_mapper.Map<ProductDto>(itemFound));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                return RetornoDto.objectGenericError(ex);
            }
        }

        public async Task<RetornoDto> GetAllByQuery(ProductQuery query, bool includeJoins = false)
        {
            try
            {
                var itemFound = this.Repo.GetAllByQuery(query, includeJoins).Result;

                if (itemFound == null)
                    return RetornoDto.objectNotFound();

                var totalItems = await this.Repo.GetCountItems(query);

                return RetornoDto.objectsFoundSuccess(_mapper.Map<ICollection<ProductDto>>(itemFound), query.Skip, query.Take, totalItems);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                return RetornoDto.objectGenericError(ex);
            }
        }
    }
}