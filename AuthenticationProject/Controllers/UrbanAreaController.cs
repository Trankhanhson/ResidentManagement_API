using AuthenticationProject.common;
using AuthenticationProject.Data;
using AuthenticationProject.Models;
using AuthenticationProject.Repositories;
using AuthenticationProject.Repositories.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace AuthenticationProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UrbanAreaController : ControllerBase
    {
        private readonly IUrbanAreaRepository urbanAreaRepository;
        public UrbanAreaController(IUrbanAreaRepository urbanAreaRepository, CacheHelper cacheHelper)
        {
            this.urbanAreaRepository = urbanAreaRepository;
        }
        [HttpPost]
        [Route("Create")]
        //[CustomAuthorize("UrbanArea_Create", typeof(CacheHelper))]
        public async Task<IActionResult> Create(UrbanArea urbanArea)
        {
            try
            {
                if (urbanArea == null)
                {
                    return BadRequest("UrbanArea data is invalid");
                }

                var entity = await urbanAreaRepository.Add(urbanArea);
                urbanAreaRepository.Complete();
                return Ok(entity.UrbanId);
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred.");
            }
        }

        [HttpPost]
        [Route("Update")]
        //[CustomAuthorize("UrbanArea_Update", typeof(CacheHelper))]
        public IActionResult Update(UrbanArea urbanArea)
        {
            try
            {
                urbanAreaRepository.Update(urbanArea);
                urbanAreaRepository.Complete();
                return Ok(true);
            }
            catch
            {
                return Ok(false);
            }
        }

        [HttpGet]
        [Route("Delete/{id}")]
        //[CustomAuthorize("UrbanArea_Delete", typeof(CacheHelper))]
        public IActionResult Delete(int id)
        {
            try
            {
                urbanAreaRepository.Remove(id);
                urbanAreaRepository.Complete();
                return Ok(true);
            }
            catch
            {
                return Ok(false);
            }
        }


        [HttpPost]
        [Route("DeleteMultiple")]
        //[CustomAuthorize("UrbanArea_DeleteMultiple", typeof(CacheHelper))]
        public IActionResult DeleteMultiple(List<UrbanArea> urbanAreaList)
        {
            try
            {
                urbanAreaRepository.RemoveRange(urbanAreaList);
                urbanAreaRepository.Complete();
                return Ok(true);
            }
            catch (Exception ex)
            {
                return Ok(false);
            }
        }


        [HttpGet]
        [Route("GetAll")]
        public async Task<object> GetAllUrbanArea([FromQuery]PageInputDto input)
        {
            try
            {
                var query = urbanAreaRepository.GetAllUrbanArea(input.keyword);
                var list = await query.Skip(5 * (input.pageIndex-1)).Take(5).ToListAsync();
                var totalCount = await query.CountAsync();
                var totalPage = Math.Ceiling(totalCount / 5.0);
                return DataResult.ResultSuccess(JsonConvert.SerializeObject(list),"Get list success", totalPage);
            }
            catch
            {
                return DataResult.ResultError("Get list error");
            }
        }

        [HttpGet]
        [Route("GetSelect")]
        public async Task<object> GetSelect()
        {
            try
            {
                var list = await urbanAreaRepository.GetSelect().ToListAsync();
                return DataResult.ResultSuccess(JsonConvert.SerializeObject(list));

            }
            catch
            {
                return DataResult.ResultError("Get Select fail");
            }
        }

        [HttpGet]
        [Route("GetById")]
        public async Task<IActionResult> GetById(int id)
        {
            try
            {
                return Ok(await urbanAreaRepository.GetById(id));
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred");
            }
        }
    }
}
