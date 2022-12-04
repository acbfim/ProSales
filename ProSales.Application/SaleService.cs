
using System.Security.Claims;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using ProSales.Application.Contracts;
using ProSales.Domain.Dtos;
using ProSales.Domain.Global;
using ProSales.Domain.Identity;
using ProSales.Repository.Contexts;
using ProSales.Repository.Contracts;

namespace ProSales.Application
{
    public class SaleService : ISaleService
    {

        private readonly IHttpContextAccessor _accessor;
        private readonly IMapper _mapper;
        private readonly IGlobalRepository _globalRepo;
        private readonly ISaleRepository Repo;
        private readonly IUserManagerRepository userManager;

        public IClientRepository ClientRepo { get; }
        public IProductRepository ProductRepo { get; }
        public IProductSaleRepository ProductSaleRepo { get; }
        public IDiscountTypeRepository DiscountTypeRepo { get; }

        public SaleService(IHttpContextAccessor Accessor, IMapper Mapper
        , IGlobalRepository GlobalRepo
        , ISaleRepository Repo
        , IClientRepository ClientRepo
        , IProductRepository ProductRepo
        , IProductSaleRepository ProductSaleRepo
        , IUserManagerRepository userManager
        , IDiscountTypeRepository DiscountTypeRepository)
        {
            this.Repo = Repo;
            this.ClientRepo = ClientRepo;
            this.ProductRepo = ProductRepo;
            this.ProductSaleRepo = ProductSaleRepo;
            this.userManager = userManager;
            this.DiscountTypeRepo = DiscountTypeRepository;
            _accessor = Accessor;
            _mapper = Mapper;
            _globalRepo = GlobalRepo;
        }

        public async Task<RetornoDto> Create(CreateSaleDto createItem)
        {
            try
            {
                var clientFound = new Client();
                clientFound = null;

                if (createItem.Client is not null)
                {
                    clientFound = this.ClientRepo.GetByExternalId(createItem.Client.ExternalId).Result;

                    if (clientFound == null)
                        return RetornoDto.objectNotFound("Cliente não localizado pela externalId");
                }


                var createMappedItem = _mapper.Map<Sale>(createItem);

                if (clientFound is not null)
                    createMappedItem.ClientId = clientFound.Id;

                // Alterar para coinType configuravel
                // CoinType 1 = REAL
                createMappedItem.CoinTypeId = 1;

                createMappedItem.Client = null;
                createMappedItem.SellerId = Int32.Parse(_accessor.HttpContext.User.Claims.First(x => x.Type == ClaimTypes.NameIdentifier).Value);

                _globalRepo.Add(createMappedItem);

                if (await _globalRepo.SaveChangesAsync())
                    return RetornoDto.objectCreateSuccess(_mapper.Map<SaleDto>(createMappedItem));

                throw new Exception();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return RetornoDto.objectGenericError(ex.InnerException?.Message + ex.Message);
            }
        }



        public async Task<RetornoDto> GetByExternalId(Guid externalId, bool includeJoins = false)
        {
            try
            {
                var itemFound = this.Repo.GetByExternalId(externalId, includeJoins).Result;

                if (itemFound == null)
                    return RetornoDto.objectNotFound();

                return RetornoDto.objectFoundSuccess(_mapper.Map<SaleDto>(itemFound));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                return RetornoDto.objectGenericError(ex.InnerException?.Message + ex.Message);
            }
        }

        public async Task<RetornoDto> GetById(long id)
        {
            try
            {
                var itemFound = this.Repo.GetById(id).Result;

                if (itemFound == null)
                    return RetornoDto.objectNotFound();

                return RetornoDto.objectFoundSuccess(_mapper.Map<SaleDto>(itemFound));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                return RetornoDto.objectGenericError(ex.InnerException?.Message + ex.Message);
            }
        }

        public async Task<RetornoDto> GetAllByQuery(SaleQuery query, bool includeJoins = false)
        {
            try
            {
                var itemFound = this.Repo.GetAllByQuery(query, includeJoins).Result;

                if (itemFound == null)
                    return RetornoDto.objectNotFound();

                var totalItems = await this.Repo.GetCountItems(query);

                var teste = _mapper.Map<ICollection<SaleDto>>(itemFound);

                return RetornoDto.objectsFoundSuccess(_mapper.Map<ICollection<SaleDto>>(itemFound), query.Skip, query.Take, totalItems);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                return RetornoDto.objectGenericError(ex.InnerException?.Message + ex.Message);
            }
        }

        public async Task<RetornoDto> AddProduct(CreateProductSaleDto productSale)
        {
            try
            {
                if (productSale.Product is null)
                    return RetornoDto.objectNotFound("Sem produtos para adicionar");

                var saleFound = await this.Repo.GetByExternalId(productSale.Sale.ExternalId);

                if (saleFound is null)
                    return RetornoDto.objectNotFound("Venda não localizado pela externalId");

                var productFound = await this.ProductRepo.GetByExternalId(productSale.Product.ExternalId);
                if (productFound is null)
                    return RetornoDto.objectNotFound("Produto não localizado pela externalId");

                var productInSale = await this.Repo.GetProductSaleByProductIdAndSaleId(productFound.Id, saleFound.Id);

                if (productInSale is null)
                {
                   
                    var createMappedItem = _mapper.Map<ProductSale>(productSale);

                    createMappedItem.UserCreatedId = Int32.Parse(_accessor.HttpContext.User.Claims.First(x => x.Type == ClaimTypes.NameIdentifier).Value);

                    createMappedItem.ProductId = productFound.Id;
                    createMappedItem.SaleId = saleFound.Id;

                    createMappedItem.Sale = null;
                    createMappedItem.Product = null;
                    createMappedItem.DiscountType = null;

                    this._globalRepo.Add(createMappedItem);

                    if (await _globalRepo.SaveChangesAsync())
                        return RetornoDto.objectCreateSuccess(_mapper.Map<SaleDto>(this.Repo.GetByExternalId(productSale.Sale.ExternalId).Result));
                }
                else
                {
                    return RetornoDto.objectFoundSuccess(_mapper.Map<SaleDto>(this.Repo.GetByExternalId(productSale.Sale.ExternalId).Result));
                }

                throw new Exception();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return RetornoDto.objectGenericError(ex.InnerException?.Message + ex.Message);
            }
        }

        public async Task<RetornoDto> RemoveProduct(CreateProductSaleDto productSale)
        {
            try
            {

                var SaleFound = this.Repo.GetByExternalId(productSale.Sale.ExternalId).Result;
                if (SaleFound is null)
                    return RetornoDto.objectNotFound("Venda não localizada pela externalId");

                var productFound = this.ProductRepo.GetByExternalId(productSale.Sale.ExternalId).Result;
                if (productFound is null)
                    return RetornoDto.objectNotFound("Produto não localizado pela externalId");

                var productRemove = new ProductSale()
                {
                    ProductId = productFound.Id
                    ,SaleId = SaleFound.Id
                };

                this._globalRepo.Delete(productRemove);


                if (await _globalRepo.SaveChangesAsync())
                    return RetornoDto.objectDeletedSuccess("Produto removido com sucesso da venda!");

                throw new Exception();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return RetornoDto.objectGenericError(ex.InnerException?.Message + ex.Message);
            }
        }

        public async Task<RetornoDto> UpdateDiscountProduct(UpdateDiscountProductSaleDto productSale)
        {
             try
            {
                var SaleFound = this.Repo.GetByExternalId(productSale.Sale.ExternalId).Result;
                if (SaleFound is null)
                    return RetornoDto.objectNotFound("Venda não localizada pela externalId");
                
                var discountTypeFound = this.DiscountTypeRepo.GetByExternalId(productSale.DiscountType.ExternalId).Result;
                if (discountTypeFound is null)
                    return RetornoDto.objectNotFound("Desconto não encontrado pela externalId");

                var productFound = await this.ProductRepo.GetByExternalId(productSale.Product.ExternalId);
                if (productFound is null)
                    return RetornoDto.objectNotFound("Produto não localizado pela externalId");

                var productSaleFound = this.ProductSaleRepo.GetByProductIdAndSaleId(productFound.Id, SaleFound.Id).Result;
                if (productSaleFound is null)
                    return RetornoDto.objectNotFound("Relação da venda com produto não encontrada");

                // CalculationType = 3 é Subtração
                if((discountTypeFound.CalculationType.Id == 3) && productFound.Price < productSale.Discount)
                    return RetornoDto.unauthorized("Não é possível aplicar um desconto com valor maior que o preço do produto");


                var productUpdate = new ProductSale()
                {
                    ProductId = productFound.Id
                    ,SaleId = SaleFound.Id
                    ,DiscountTypeId = discountTypeFound.Id
                    ,Discount = productSale.Discount
                    ,UserUpdatedId = Int32.Parse(_accessor.HttpContext.User.Claims.First(x => x.Type == ClaimTypes.NameIdentifier).Value)
                    ,UpdatedAt = DateTime.Now
                };



                this._globalRepo.Update(productUpdate);


                if (await _globalRepo.SaveChangesAsync())
                    return RetornoDto.objectUpdateSuccess("Desconto atualizado com sucesso!");

                throw new Exception();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return RetornoDto.objectGenericError(ex.InnerException?.Message + ex.Message);
            }
        }

        public async Task<RetornoDto> GetAllByClientExternalId(Guid clientExternalId, bool includeJoins)
        {
            try
            {
                var clientFound = await this.ClientRepo.GetByExternalId(clientExternalId);
                if (clientFound == null)
                    return RetornoDto.objectNotFound("Cliente não localizado pela ExternalId");

                var itemFound = await this.Repo.GetAllByClientId(clientFound.Id,includeJoins);

                if (itemFound == null)
                    return RetornoDto.objectNotFound();

                return RetornoDto.objectFoundSuccess(_mapper.Map<ICollection<SaleDto>>(itemFound));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                return RetornoDto.objectGenericError(ex.InnerException?.Message + ex.Message);
            }
        }

        public async Task<RetornoDto> GetAllByUserExternalId(Guid userExternalId, bool includeJoins)
        {
            try
            {
                var userFound = await this.userManager.GetByExternalId(userExternalId);
                if (userFound == null)
                    return RetornoDto.objectNotFound("Usuário não localizado pela ExternalId");

                var itemFound = await this.Repo.GetAllByUserId(userFound.Id,includeJoins);

                if (itemFound is null || itemFound.Count is 0)
                    return RetornoDto.objectNotFound();

                return RetornoDto.objectFoundSuccess(_mapper.Map<ICollection<SaleDto>>(itemFound));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                return RetornoDto.objectGenericError(ex.InnerException?.Message + ex.Message);
            }
        }
    }
}