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
    public class BrandService : IBrandService
    {

        private readonly IHttpContextAccessor _accessor;
        private readonly IMapper _mapper;
        private readonly IGlobalRepository _globalRepo;
        private readonly IBrandRepository BrandRepository;

        public BrandService(IHttpContextAccessor Accessor, IMapper Mapper
        , IGlobalRepository GlobalRepo
        , IBrandRepository BrandRepository)
        {
            this.BrandRepository = BrandRepository;
            _accessor = Accessor;
            _mapper = Mapper;
            _globalRepo = GlobalRepo;
        }

        public async Task<RetornoDto> CreateBrand(CreateBrandDto createBrand)
        {
            try
            {
                var brandFound = this.BrandRepository.GetBrandByName(createBrand.Name).Result;

                if (brandFound != null)
                    return RetornoDto.objectDuplicaded(brandFound);

                var brand = _mapper.Map<Brand>(createBrand);

                brand.UserCreatedId = Int32.Parse(_accessor.HttpContext.User.Claims.First(x => x.Type == ClaimTypes.NameIdentifier).Value);
                _globalRepo.Add(brand);

                if (await _globalRepo.SaveChangesAsync())
                    return RetornoDto.objectCreateSuccess(_mapper.Map<BrandDto>(brand));

                throw new Exception();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                return RetornoDto.objectGenericError(ex);
            }
        }

        public async Task<RetornoDto> UpdateBrand(BrandDto brand)
        {
            try
            {
                var brandFound = this.BrandRepository.GetBrandByExternalId(brand.ExternalId).Result;
                if (brandFound is null)
                    return RetornoDto.objectNotFound();

                var brandFoundByName = this.BrandRepository.GetBrandByName(brand.Name).Result;
                if (brandFoundByName is not null)
                    return RetornoDto.objectDuplicaded(brandFoundByName);


                brandFound.UserUpdatedId = Int32.Parse(_accessor.HttpContext.User.Claims.First(x => x.Type == ClaimTypes.NameIdentifier).Value);
                brandFound.UpdatedDate = DateTime.Now;
                brandFound.Name = brand.Name;

                _globalRepo.Update(brandFound);

                if (await _globalRepo.SaveChangesAsync())
                    return RetornoDto.objectUpdateSuccess(_mapper.Map<BrandDto>(brand));

                throw new Exception();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                return RetornoDto.objectGenericError(ex);
            }
        }

        public async Task<RetornoDto> ToggleDesactivateBrand(Guid externalId)
        {
            try
            {
                var brandFound = this.BrandRepository.GetBrandByExternalId(externalId).Result;
                if (brandFound == null)
                    return RetornoDto.objectNotFound();

                brandFound.UserUpdatedId = Int32.Parse(_accessor.HttpContext.User.Claims.First(x => x.Type == ClaimTypes.NameIdentifier).Value);
                brandFound.UpdatedDate = DateTime.Now;

                brandFound.IsActive = !brandFound.IsActive;

                _globalRepo.Update(brandFound);

                if (await _globalRepo.SaveChangesAsync())
                    return RetornoDto.objectUpdateSuccess(_mapper.Map<BrandDto>(brandFound));

                throw new Exception();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                return RetornoDto.objectGenericError(ex);
            }
        }

        public async Task<RetornoDto> GetBrandByExternalId(Guid externalId)
        {
            try
            {
                var brandFound = this.BrandRepository.GetBrandByExternalId(externalId).Result;

                if (brandFound == null)
                    return RetornoDto.objectNotFound();

                return RetornoDto.objectFoundSuccess(_mapper.Map<BrandDto>(brandFound));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                return RetornoDto.objectGenericError(ex);
            }
        }

        public async Task<RetornoDto> GetBrandById(long id)
        {
            try
            {
                var brandFound = this.BrandRepository.GetBrandById(id).Result;

                if (brandFound == null)
                    return RetornoDto.objectNotFound();

                return RetornoDto.objectFoundSuccess(_mapper.Map<BrandDto>(brandFound));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                return RetornoDto.objectGenericError(ex);
            }
        }

        public async Task<RetornoDto> GetBrandByName(string name)
        {
            try
            {
                var brandFound = this.BrandRepository.GetBrandByName(name).Result;

                if (brandFound == null)
                    return RetornoDto.objectNotFound();

                return RetornoDto.objectFoundSuccess(_mapper.Map<BrandDto>(brandFound));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                return RetornoDto.objectGenericError(ex);
            }
        }

        public async Task<RetornoDto> GetAllBrandByQuery(BrandQuery query)
        {
            try
            {
                var brandFound = this.BrandRepository.GetAllBrandByQuery(query).Result;

                if (brandFound == null)
                    return RetornoDto.objectNotFound();

                return RetornoDto.objectFoundSuccess(_mapper.Map<ICollection<BrandDto>>(brandFound));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                return RetornoDto.objectGenericError(ex);
            }
        }
    }
}