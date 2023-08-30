using AuthenticationProject.common;
using AuthenticationProject.Data;
using AuthenticationProject.Models;
using AuthenticationProject.Repositories.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using Newtonsoft.Json;
using System.Drawing;

namespace AuthenticationProject.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class ApartmentController : ControllerBase
    {
        private readonly IApartmentRepository apartmentRepository;
        private readonly IMapper _mapper;
        public ApartmentController(IApartmentRepository apartmentRepository, CacheHelper cacheHelper,IMapper mapper) {
            this.apartmentRepository = apartmentRepository;
            _mapper = mapper;
        }
        [HttpPost]
        [Route("Create")]
        //[CustomAuthorize("Apartment_Create", typeof(CacheHelper))]
        public async Task<IActionResult> Create(ApartmentDTO apartment)
        {
            try
            {
                if (apartment == null)
                {
                    return BadRequest("Apartment data is invalid");
                }
                apartment.BuildingCategory = null;
                var mappedApartment = _mapper.Map<Apartment>(apartment);
                var entity = await apartmentRepository.Add(mappedApartment);
                apartmentRepository.Complete();
                return Ok(entity.ApartmentId);
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred.");
            }
        }

        [HttpPost]
        [Route("Update")]
        [CustomAuthorize("Apartment_Update", typeof(CacheHelper))]
        public IActionResult Update(ApartmentDTO apartment)
        {
            try
            {
                var mappedApartment = _mapper.Map<Apartment>(apartment);
                apartmentRepository.Update(mappedApartment);
                apartmentRepository.Complete();
                return Ok(true);
            }
            catch
            {
                return Ok(false);
            }
        }

        [HttpGet]
        [Route("Delete/{id}")]
        [CustomAuthorize("Apartment_Delete", typeof(CacheHelper))]
        public IActionResult Delete(int id)
        {
            try
            {
                apartmentRepository.Remove(id);
                apartmentRepository.Complete();
                return Ok(true);
            }
            catch
            {
                return Ok(false);
            }
        }


        [HttpPost]
        [Route("DeleteMultiple")]
        [CustomAuthorize("Apartment_DeleteMultiple", typeof(CacheHelper))]
        public IActionResult DeleteMultiple(List<Apartment> apartmentList)
        {
            try
            {
                apartmentRepository.RemoveRange(apartmentList);
                apartmentRepository.Complete();
                return Ok(true);
            }
            catch (Exception ex)
            {
                return Ok(false);
            }
        }
        

        [HttpGet]
        [Route("GetAll")]
        [CustomAuthorize("Apartment_GetAll", typeof(CacheHelper))]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var list = await apartmentRepository.GetAll();
                var mapped = _mapper.Map<List<ApartmentDTO>>(list);
                return Ok(JsonConvert.SerializeObject(list));
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred");
            }
        }

        [HttpGet]
        [Route("GetSelect")]
        //[CustomAuthorize("Apartment_GetSelect", typeof(CacheHelper))]
        public async Task<IActionResult> GetSelect()
        {
            try
            {
                var list = await apartmentRepository.GetApartmentSelect();
                var mapped = _mapper.Map<List<ApartmentDTO>>(list);
                return Ok(JsonConvert.SerializeObject(mapped));
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred");
            }
        }

        [HttpGet]
        [Route("GetById")]
        public async Task<IActionResult> GetById(int id)
        {
            try
            {
                var res = await apartmentRepository.GetApartmentById(id);
                var entity = _mapper.Map<ApartmentDTO>(res);
                return Ok(new
                {
                    ApartmentId = entity.ApartmentId,
                    ApartmentName = entity.ApartmentName,
                    CategoryId = entity.CategoryId,
                    Building = entity.Building,
                    Space = entity.Space,
                    Floor = entity.Floor,
                    BuildingCategory = new
                    {
                        CategoryName = entity.BuildingCategory.CategoryName
                    }
                });
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred");
            }
        }
    }
}
