using AuthenticationProject.common;
using AuthenticationProject.Data;
using AuthenticationProject.Models;
using AuthenticationProject.Repositories.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Text.Json;
namespace AuthenticationProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResidentController : ControllerBase
    {
        private readonly IResidentRepository _residentRepository;
        private readonly IMapper _mapper;
        public ResidentController(IResidentRepository residentRepository,IMapper mapper) {
            _residentRepository = residentRepository;
            _mapper = mapper;
        }
        [HttpPost]
        [Route("Create")]
        //[CustomAuthorize("Resident_Create", typeof(CacheHelper))]
        public async Task<IActionResult> Create([FromBody] ResidentDTO resident)
        {
            try
            {
                if (resident == null)
                {
                    return BadRequest("Resident data is invalid");
                }
                var mappedResident = _mapper.Map<Resident>(resident);
                var entity = await _residentRepository.Add(mappedResident);
                _residentRepository.Complete();
                return Ok(entity.ResidentId);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occurr");
            }
        }

        [HttpPost]
        [Route("Update")]
        //[CustomAuthorize("Resident_Update", typeof(CacheHelper))]
        public async Task<IActionResult> Update( ResidentDTO resident)
        {
            try
            {
                var mappedResident = _mapper.Map<Resident>(resident);
                await _residentRepository.UpdateResident(mappedResident);
                _residentRepository.Complete();
                return Ok(true);
            }
            catch (Exception ex)
            {
                return Ok(false);
            }
        }

        [HttpGet]
        [Route("Delete/{id}")]
        //[CustomAuthorize("Resident_Delete", typeof(CacheHelper))]
        public IActionResult Delete(int id)
        {
            try
            {
                _residentRepository.DeleteResident(id);
                _residentRepository.Complete();
                return Ok(true);
            }
            catch (Exception ex)
            {
                return Ok(false);
            }
        }


        [HttpPost]
        [Route("DeleteMultiple")]
        //[CustomAuthorize("Resident_DeleteMultiple", typeof(CacheHelper))]
        public IActionResult DeleteMulti(List<ResidentDTO> residents)
        {
            try
            {
                var mappedResidents = _mapper.Map<List<Resident>>(residents);
                _residentRepository.DeleteMutipleResident(mappedResidents);
                _residentRepository.Complete();
                return Ok(true);
            }
            catch (Exception ex)
            {
                return Ok(false);
            }
        }


        [HttpGet]
        [Route("GetAll")]
        //[CustomAuthorize("Resident_GetAll", typeof(CacheHelper))]
        public async Task<object> GetAll([FromQuery] PageInputDto input)
        {
            try
            {
                var query = _residentRepository.GetAllResident(input.keyword);
                var list = await query.Skip(5 * (input.pageIndex - 1)).Take(5).ToListAsync();
                var totalCount = await query.CountAsync();
                var totalPage = Math.Ceiling(totalCount / 5.0);
                return DataResult.ResultSuccess(JsonConvert.SerializeObject(list), "Get list success", totalPage);
            }
            catch
            {
                return DataResult.ResultError("Gte list error");
            }
        }


        [HttpGet]
        [Route("GetById/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            try
            {
                var entity =_residentRepository.GetResidents(id);
                var mapped = _mapper.Map<ResidentDTO>(entity);
                return Ok(JsonConvert.SerializeObject(mapped));
            }   
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred.");
            }

        }


        [HttpGet]
        [Route("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(int id)
        {
            try
            {
                var entity = await _residentRepository.GetDetail(id);
                var mapped = _mapper.Map<List<ResidentDTO>>(entity);
                return Ok(JsonConvert.SerializeObject(mapped));
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred.");
            }

        }
    }
}
