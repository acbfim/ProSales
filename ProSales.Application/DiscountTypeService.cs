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
    public class DiscountTypeService : IDiscountTypeService
    {

        private readonly IHttpContextAccessor _accessor;
        private readonly IMapper _mapper;
        private readonly IGlobalRepository _globalRepo;
        private readonly IDiscountTypeRepository Repo;

        public ICalculationTypeRepository CalculationRepo { get; }

        public DiscountTypeService(IHttpContextAccessor Accessor, IMapper Mapper
        , IGlobalRepository GlobalRepo
        , IDiscountTypeRepository Repo
        , ICalculationTypeRepository CalculationRepo)
        {
            this.Repo = Repo;
            this.CalculationRepo = CalculationRepo;
            _accessor = Accessor;
            _mapper = Mapper;
            _globalRepo = GlobalRepo;
        }

        public async Task<RetornoDto> Create(CreateDiscountTypeDto createItem)
        {
            try
            {
                var itemFound = this.Repo.GetByName(createItem.Name).Result;
                if (itemFound is not null)
                    return RetornoDto.objectDuplicaded(_mapper.Map<DiscountTypeDto>(itemFound));

                var calculateItemFound = await this.CalculationRepo.GetByExternalId(createItem.CalculationTypeExternalId);
                if (calculateItemFound is null)
                    return RetornoDto.objectNotFound("CalculationTypeId não encontrado.");

                var createMappedItem = _mapper.Map<DiscountType>(createItem);

                createMappedItem.CalculationType = null;
                createMappedItem.CalculationTypeId = calculateItemFound.Id;

                //createMappedItem.UserCreatedId = Int32.Parse(_accessor.HttpContext.User.Claims.First(x => x.Type == ClaimTypes.NameIdentifier).Value);
                _globalRepo.Add(createMappedItem);

                if (await _globalRepo.SaveChangesAsync())
                    return RetornoDto.objectCreateSuccess(_mapper.Map<DiscountTypeDto>(createMappedItem));

                throw new Exception();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                return RetornoDto.objectGenericError(ex);
            }
        }

        public async Task<RetornoDto> Update(DiscountTypeDto update)
        {
            try
            {
                var itemFound = this.Repo.GetByExternalId(update.ExternalId).Result;
                if (itemFound is null)
                    return RetornoDto.objectNotFound();

                var itemFoundByName = this.Repo.GetByName(update.Name).Result;
                if (itemFoundByName is not null)
                    return RetornoDto.objectDuplicaded(_mapper.Map<DiscountTypeDto>(itemFoundByName));

                var calculateItemFound = await this.CalculationRepo.GetByExternalId(update.CalculationTypeExternalId);
                if (calculateItemFound is null)
                    return RetornoDto.objectNotFound("Tipo do desconto não encontrado.");

                itemFound.CalculationTypeId = calculateItemFound.Id;
                //itemFound.UserUpdatedId = Int32.Parse(_accessor.HttpContext.User.Claims.First(x => x.Type == ClaimTypes.NameIdentifier).Value);
                itemFound.UpdatedAt = DateTime.Now;
                itemFound.Name = update.Name;

                _globalRepo.Update(itemFound);

                if (await _globalRepo.SaveChangesAsync())
                    return RetornoDto.objectUpdateSuccess(_mapper.Map<DiscountTypeDto>(update));

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
                itemFound.UpdatedAt = DateTime.Now;

                itemFound.IsActive = !itemFound.IsActive;

                _globalRepo.Update(itemFound);

                if (await _globalRepo.SaveChangesAsync())
                    return RetornoDto.objectUpdateSuccess(_mapper.Map<DiscountTypeDto>(itemFound));

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

                return RetornoDto.objectFoundSuccess(_mapper.Map<DiscountTypeDto>(itemFound));
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

                return RetornoDto.objectFoundSuccess(_mapper.Map<DiscountTypeDto>(itemFound));
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

                return RetornoDto.objectFoundSuccess(_mapper.Map<DiscountTypeDto>(itemFound));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                return RetornoDto.objectGenericError(ex);
            }
        }

        public async Task<RetornoDto> GetAllByQuery(DiscountTypeQuery query)
        {
            try
            {
                var itemFound = this.Repo.GetAllByQuery(query).Result;

                if (itemFound == null)
                    return RetornoDto.objectNotFound();

                var totalItems = await this.Repo.GetCountItems(query);

                return RetornoDto.objectsFoundSuccess(_mapper.Map<ICollection<DiscountTypeDto>>(itemFound), query.Skip, query.Take, totalItems);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                return RetornoDto.objectGenericError(ex);
            }
        }
    }
}