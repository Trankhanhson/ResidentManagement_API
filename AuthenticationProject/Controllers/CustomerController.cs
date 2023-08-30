using AuthenticationProject.common;
using AuthenticationProject.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace AuthenticationProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private AuthenticationDBContext _context;
        public CustomerController(AuthenticationDBContext context)
        {
            _context = context;
        }

        [Route("khachhang_createsingle")]
        [HttpPost]
        [CustomAuthorize("Customer_Create", typeof(CacheHelper))]
        public async Task<IActionResult> CreateSingle([FromForm] Customer Khachhang)
        {

            try
            {
                var fileName = "";
                if (Khachhang.FileImage != null)
                {
                    fileName = DateTime.Now.Ticks.ToString() + ".jpg";
                    Khachhang.Hinhanh = fileName;
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "ImageKhachHang", fileName);
                    using (var stream = System.IO.File.Create(path))
                    {
                        await Khachhang.FileImage.CopyToAsync(stream);
                    }
                }
                var result = _context.Add(Khachhang).Entity;
                _context.SaveChanges();
                return Ok(JsonConvert.SerializeObject(result));
            }
            catch (Exception ex)
            {
                return Ok(false);
            }


        }

        [Route("khachhang_getall")]
        [HttpGet]
        [CustomAuthorize("Customer_GetAll", typeof(CacheHelper))]
        public IActionResult GetAll()
        {
            var listKH = _context.Customers.ToList();
            return Ok(JsonConvert.SerializeObject(listKH));
        }
        [Route("get-by-id/{id}")]
        [HttpGet]
        public IActionResult GetById(long? id)
        {
            try
            {
                var tg = _context.Customers.Find(id);
                if (tg != null)
                {
                    return Ok(JsonConvert.SerializeObject(tg));
                }
                return NotFound();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [Route("khachhang_update")]
        [HttpPost]
        [CustomAuthorize("Customer_Update", typeof(CacheHelper))]
        public async Task<IActionResult> Update([FromForm] Customer Khachhang)
        {
            try
            {

                var existingModel = _context.Customers.Find(Khachhang.Makhachhang);
                if (existingModel == null)
                {
                    return Ok("Khách hàng không tồn tại");
                }
                var fileName = "";
                if (Khachhang.FileImage != null)
                {
                    if (!string.IsNullOrEmpty(existingModel.Hinhanh))
                    {
                        var oldImagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "ImageKhachHang", existingModel.Hinhanh);
                        if (System.IO.File.Exists(oldImagePath))
                        {
                            System.IO.File.Delete(oldImagePath);
                        }
                    }
                    fileName = DateTime.Now.Ticks.ToString() + ".jpg";
                    Khachhang.Hinhanh = fileName;
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "ImageKhachHang", fileName);
                    using (var stream = System.IO.File.Create(path))
                    {
                        await Khachhang.FileImage.CopyToAsync(stream);
                    }
                }
                existingModel.Tenkhachhang = Khachhang.Tenkhachhang;
                existingModel.Cccd = Khachhang.Cccd;
                existingModel.Sodienthoai = Khachhang.Sodienthoai;
                existingModel.Email = Khachhang.Email;
                existingModel.Diachi = Khachhang.Diachi;
                existingModel.Ngaycap = Khachhang.Ngaycap;
                _context.SaveChanges();
                return Ok(JsonConvert.SerializeObject(existingModel));
            }
            catch (Exception ex)
            {
                return Ok("Update thất bại!");
            }

        }
        [Route("khachhang_deletemultiple")]
        [HttpPost]
        [CustomAuthorize("Customer_DeleteMultiple", typeof(CacheHelper))]
        public async Task<bool> DeleteMultiple(List<Customer> list)
        {
            try
            {
                _context.RemoveRange(list);
                await _context.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }
        [Route("khachhang_delete/{id}")]
        [HttpGet]
        [CustomAuthorize("Customer_Delete", typeof(CacheHelper))]
        public async Task<bool> Delete(long id)
        {

            try
            {
                var tg = _context.Customers.FirstOrDefault(s => s.Makhachhang == id);
                if (tg != null)
                {
                    _context.Remove(tg);
                    await _context.SaveChangesAsync();
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
