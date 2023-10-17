using AuthenticationProject.common;
using AuthenticationProject.Data;
using AuthenticationProject.Models;
using AuthenticationProject.Repositories.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Net.WebSockets;

namespace AuthenticationProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressController : ControllerBase
    {
        private readonly IAddressRepository addressRepository;
        private readonly IMapper _mapper;
        public AddressController(IAddressRepository addressRepository,IMapper mapper)
        {
            this.addressRepository = addressRepository;
            this._mapper = mapper;
        }
        [HttpPost]
        [Route("Create")]
        //[CustomAuthorize("Address_Create", typeof(CacheHelper))]
        public async Task<IActionResult> Create(AddressDTO address)
        {
            try
            {
                if (address == null)
                {
                    return BadRequest("Address data is invalid");
                }

                var model = _mapper.Map<Address>(address);
                var entity = await addressRepository.Add(model);
                addressRepository.Complete();
                return Ok(entity.AddressId);
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred.");
            }
        }

        [HttpPost]
        [Route("Update")]
        //[CustomAuthorize("Address_Update", typeof(CacheHelper))]
        public IActionResult Update(AddressDTO address)
        {
            try
            {
                var model = _mapper.Map<Address>(address);
                addressRepository.Update(model);
                addressRepository.Complete();
                return Ok(true);
            }
            catch
            {
                return Ok(false);
            }
        }

        [HttpGet]
        [Route("Delete/{id}")]
        //[CustomAuthorize("Address_Delete", typeof(CacheHelper))]
        public IActionResult Delete(int id)
        {
            try
            {
                addressRepository.Remove(id);
                addressRepository.Complete();
                return Ok(true);
            }
            catch
            {
                return Ok(false);
            }
        }


        [HttpPost]
        [Route("DeleteMultiple")]
        //[CustomAuthorize("Address_DeleteMultiple", typeof(CacheHelper))]
        public IActionResult DeleteMultiple(List<Address> addressList)
        {
            try
            {
                addressRepository.RemoveRange(addressList);
                addressRepository.Complete();
                return Ok(true);
            }
            catch (Exception ex)
            {
                return Ok(false);
            }
        }


        [HttpGet]
        [Route("GetAll")]
        //[CustomAuthorize("Address_GetAll", typeof(CacheHelper))]
        public async Task<object> GetAll([FromQuery] PageInputDto input)
        {
            try
            {
                var query = addressRepository.GetAllAddress(input.keyword);

                var list = await query.Skip(5 * (input.pageIndex-1)).Take(5).ToListAsync();
                var totalCount = await query.CountAsync();
                var totalPage = Math.Ceiling(totalCount / 5.0);
                
                return DataResult.ResultSuccess(JsonConvert.SerializeObject(list),"Get list success", totalPage);
            }
            catch
            {
                return DataResult.ResultError("Get list fail");
            }
        }

        [HttpGet]
        [Route("GetSelect")]
        public async Task<object> GetSelect()
        {
            try
            {
                var list = await addressRepository.GetSelect().ToListAsync();
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
                var address = await addressRepository.GetById(id);
                var mappedAddressDTO = _mapper.Map<AddressDTO>(address); ;
                return Ok(mappedAddressDTO);
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred");
            }
        }
    }
}
