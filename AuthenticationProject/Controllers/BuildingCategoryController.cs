﻿using AuthenticationProject.common;
using AuthenticationProject.Data;
using AuthenticationProject.Models;
using AuthenticationProject.Repositories.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.IO;

namespace AuthenticationProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BuildingCategoryController : ControllerBase
    {
        private readonly IBuildingCategoryRepository buildingCategoryRepository;
        private readonly IMapper _mapper;
        public BuildingCategoryController(IBuildingCategoryRepository buildingCategoryRepository, CacheHelper cacheHelper,IMapper mapper)
        {
            this.buildingCategoryRepository = buildingCategoryRepository;
            _mapper = mapper;
        }
        [HttpPost]
        [Route("Create")]
        [CustomAuthorize("BuildingCategory_Create", typeof(CacheHelper))]
        public async Task<IActionResult> Create(BuildingCategoryDTO buildingCategory)
        {
            try
            {
                if (buildingCategory == null)
                {
                    return BadRequest("BuildingCategory data is invalid");
                }
                buildingCategory.Address = null;
                buildingCategory.UrbanArea = null;
                var mapped = _mapper.Map<BuildingCategory>(buildingCategory);
                var entity = await buildingCategoryRepository.Add(mapped);
                buildingCategoryRepository.Complete();
                return Ok(entity.CategoryId);
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred.");
            }
        }

        [HttpPost]
        [Route("Update")]
        [CustomAuthorize("BuildingCategory_Update", typeof(CacheHelper))]
        public IActionResult Update(BuildingCategoryDTO buildingCategory)
        {
            try
            {
                var mapped = _mapper.Map<BuildingCategory>(buildingCategory);
                buildingCategoryRepository.Update(mapped);
                buildingCategoryRepository.Complete();
                return Ok(true);
            }
            catch
            {
                return Ok(false);
            }
        }

        [HttpGet]
        [Route("Delete/{id}")]
        [CustomAuthorize("BuildingCategory_Delete", typeof(CacheHelper))]
        public IActionResult Delete(int id)
        {
            try
            {

                buildingCategoryRepository.Remove(id);
                buildingCategoryRepository.Complete();
                return Ok(true);
            }
            catch
            {
                return Ok(false);
            }
        }


        [HttpPost]
        [Route("DeleteMultiple")]
        [CustomAuthorize("BuildingCategory_DeleteMultiple", typeof(CacheHelper))]
        public IActionResult DeleteMultiple(List<BuildingCategoryDTO> buildingCategoryList)
        {
            try
            {
                var mapped = _mapper.Map<List<BuildingCategory>>(buildingCategoryList);
                buildingCategoryRepository.RemoveRange(mapped);
                buildingCategoryRepository.Complete();
                return Ok(true);
            }
            catch (Exception ex)
            {
                return Ok(false);
            }
        }


        [HttpGet]
        [Route("GetAll")]
        [CustomAuthorize("BuildingCategory_GetAll", typeof(CacheHelper))]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var list = await buildingCategoryRepository.GetAllBuildingCategory();
                var mapped = _mapper.Map<List<BuildingCategoryDTO>>(list);
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
                var res = await buildingCategoryRepository.GetBuildingCategory(id);
                var entity = _mapper.Map<BuildingCategoryDTO>(res);
                return Ok(new
                {
                    CategoryId = entity.CategoryId,
                    CategoryName = entity.CategoryName,
                    UrbanId = entity.UrbanId,
                    AddressId = entity.AddressId,
                    UrbanArea = new { UrbanName = entity.UrbanArea.UrbanName },
                    Address = new { Street = entity.Address.Street, Commune = entity.Address.Commune, District = entity.Address.District, City = entity.Address.City }
                });
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred");
            }
        }
    }
}
