
using System.Security.Claims;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using ProSales.Application.Contracts;
using ProSales.Domain.Dtos;
using ProSales.Domain.Global;
using ProSales.Repository.Contexts;
using ProSales.Repository.Contracts;

namespace ProSales.Application
{
    public class CartService : ICartService
    {

        private readonly IHttpContextAccessor _accessor;
        private readonly IMapper _mapper;
        private readonly IGlobalRepository _globalRepo;
        private readonly ICartRepository Repo;
        private readonly ProSalesContext context;

        public IClientRepository ClientRepo { get; }
        public IProductRepository ProductRepo { get; }

        public CartService(IHttpContextAccessor Accessor, IMapper Mapper
        , IGlobalRepository GlobalRepo
        , ICartRepository Repo
        , IClientRepository ClientRepo
        , IProductRepository ProductRepo
        , ProSalesContext context)
        {
            this.Repo = Repo;
            this.ClientRepo = ClientRepo;
            this.ProductRepo = ProductRepo;
            this.context = context;
            _accessor = Accessor;
            _mapper = Mapper;
            _globalRepo = GlobalRepo;
        }

        public async Task<RetornoDto> Create(CreateCartDto createItem)
        {
            try
            {
                var clientFound = this.ClientRepo.GetByExternalId(createItem.Client.ExternalId).Result;

                if (clientFound == null)
                    return RetornoDto.objectNotFound("Cliente não localizado pela externalId");

                var createMappedItem = _mapper.Map<Cart>(createItem);

                createMappedItem.ClientId = clientFound.Id;
                createMappedItem.Client = null;

                _globalRepo.Add(createMappedItem);

                if (await _globalRepo.SaveChangesAsync())
                    return RetornoDto.objectCreateSuccess(_mapper.Map<CartDto>(createMappedItem));

                throw new Exception();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
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

                return RetornoDto.objectFoundSuccess(_mapper.Map<CartDto>(itemFound));
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

                return RetornoDto.objectFoundSuccess(_mapper.Map<CartDto>(itemFound));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                return RetornoDto.objectGenericError(ex);
            }
        }

        public async Task<RetornoDto> GetAllByQuery(CartQuery query)
        {
            try
            {
                var itemFound = this.Repo.GetAllByQuery(query).Result;

                if (itemFound == null)
                    return RetornoDto.objectNotFound();

                var totalItems = await this.Repo.GetCountItems(query);

                return RetornoDto.objectsFoundSuccess(_mapper.Map<ICollection<CartDto>>(itemFound), query.Skip, query.Take, totalItems);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                return RetornoDto.objectGenericError(ex);
            }
        }

        public async Task<RetornoDto> AddProduct(CartDtoAddProduct cart)
        {
            try
            {
                if (cart.Products is null)
                    return RetornoDto.objectNotFound("Sem itens no carrinho para adicionar");

                var cartFound = this.Repo.GetByExternalId(cart.ExternalId).Result;

                if (cartFound is null)
                    return RetornoDto.objectNotFound("Carrinho não localizado pela externalId");

                var productsAdd = new List<ProductCart>();

                for (int i = 0; i < cart.Products.Count; i++)
                {
                    var product = this.ProductRepo.GetByExternalId(cart.Products.ToList()[i].ExternalId).Result;

                    //var productCart = await this.Repo.GetProductCartByProductIdAndCartId(product.Id, cartFound.Id);
                    var productCart = cartFound.ProductsCart.FirstOrDefault(x => x.ProductId == product.Id);

                    if (productCart is null)
                    {
                        var newProduct = new ProductCart()
                        {
                            ProductId = product.Id
                        ,
                            CartId = cartFound.Id
                        };
                        productsAdd.Add(newProduct);
                    }
                }

                if (productsAdd.Count > 0)
                {
                    this._globalRepo.AddRange(productsAdd);


                    if (await _globalRepo.SaveChangesAsync())
                        return RetornoDto.objectCreateSuccess(_mapper.Map<CartDto>(this.Repo.GetByExternalId(cart.ExternalId).Result));

                }else
                {
                    return RetornoDto.objectFoundSuccess(_mapper.Map<CartDto>(this.Repo.GetByExternalId(cart.ExternalId).Result));
                }


                throw new Exception();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return RetornoDto.objectGenericError(ex);
            }
        }

        public async Task<RetornoDto> RemoveProduct(CartDtoAddProduct cart)
        {
            try
            {

                var cartFound = this.Repo.GetByExternalId(cart.ExternalId).Result;

                if (cartFound is null)
                    return RetornoDto.objectNotFound("Carrinho não localizado pela externalId");

                var productsRemove = new List<ProductCart>();

                for (int i = 0; i < cart.Products.Count; i++)
                {
                    var product = this.ProductRepo.GetByExternalId(cart.Products.ToList()[i].ExternalId).Result;

                    var productCart = cartFound.ProductsCart.FirstOrDefault(x => x.ProductId == product.Id);

                    if (productCart is not null)
                    {
                        var newProduct = new ProductCart()
                        {
                            ProductId = product.Id
                        ,
                            CartId = cartFound.Id
                        };
                        productsRemove.Add(newProduct);
                    }
                }

                if (productsRemove.Count > 0)
                {
                    this._globalRepo.DeleteRange(productsRemove);


                    if (await _globalRepo.SaveChangesAsync())
                        return RetornoDto.objectDeletedSuccess("Produto removido com sucesso do carrinho!");

                }else
                {
                    return RetornoDto.objectDeletedSuccess("Sem produtos para remover!");
                }


                throw new Exception();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return RetornoDto.objectGenericError(ex);
            }
        }
    }
}