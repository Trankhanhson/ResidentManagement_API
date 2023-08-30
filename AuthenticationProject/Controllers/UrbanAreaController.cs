using AuthenticationProject.common;
using AuthenticationProject.Models;
using AuthenticationProject.Repositories.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
        [CustomAuthorize("UrbanArea_Create", typeof(CacheHelper))]
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
        [CustomAuthorize("UrbanArea_Update", typeof(CacheHelper))]
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
        [CustomAuthorize("UrbanArea_Delete", typeof(CacheHelper))]
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
        [CustomAuthorize("UrbanArea_DeleteMultiple", typeof(CacheHelper))]
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
        public async Task<IActionResult> GetAllUrbanArea()
        {
            try
            {
                var list = await urbanAreaRepository.GetAllUrbanArea();
                return Ok(JsonConvert.SerializeObject(list));
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
                return Ok(await urbanAreaRepository.GetById(id));
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred");
            }
        }
    }
}
