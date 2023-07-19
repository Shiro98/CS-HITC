using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System;
using CustomerSupportHITC.Data;
using System.Linq;
using CustomerSupportHITC.Models;
using Org.BouncyCastle.Crypto;
using Microsoft.AspNetCore.Cors;

namespace CustomerSupportHITC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerSupportController : ControllerBase
    {
        private readonly IDsVanDeDA _dsvandeda;
        public CustomerSupportController(IDsVanDeDA dsvandeda)
        {
            _dsvandeda = dsvandeda;
        }
       
        [HttpPost("insert")]
        public ActionResult Insertdata([FromBody] DsVanDeModel model)
        {
            _dsvandeda.InsertData(model);
            return Ok();
        }
        [HttpPut("update")]
        public ActionResult Updatedata([FromBody] DsVanDeModel model)
        {
            _dsvandeda.UpdateData(model);
            return Ok();
        }
        [HttpDelete("delete/{id}")]
        public ActionResult Delete(int id)
        {
            _dsvandeda.Delete(id);
            return Ok();
        }
        [HttpGet("total")]
        public ActionResult GetTotal()
        {
            var result = _dsvandeda.GetTotal();
            return Ok(result);
        }
        [HttpGet("all/{page}/{RowPerPage}")]
        public IActionResult GetListAll(int page, int RowPerPage)
        {
            var ds = _dsvandeda.GetDanhSach((page-1)* RowPerPage, RowPerPage);
            var result = ds.Select(a => new DsVanDeModel
            {
                id = a.id,
                idLoaiVanDe = a.idLoaiVanDe,
                TenLoaiVanDe = a.TenLoaiVanDe,
                TenKhachHang = a.TenKhachHang,
                SoDienThoai = a.SoDienThoai,
                DiaChi = a.DiaChi,
                TraLoi = a.TraLoi,
                NguoiTao = a.NguoiTao,
                NgayTao = a.NgayTao,
                TrangThai = a.TrangThai,
                NgayHoanThanh = a.NgayHoanThanh,
                MucDoUuTien = a.MucDoUuTien,
                NoiDung = a.NoiDung,
                NguoiXuLy = a.NguoiXuLy,
                YKienKhachHang = a.YKienKhachHang,
                DanhGiaKhachHang = a.DanhGiaKhachHang,
            }).ToArray();
            return Ok(result);
        }
        [HttpGet("getid/{id}")]
        public IActionResult GetListById(int id)
        {

            var ds = _dsvandeda.GetDanhSachById(id);
            var result = ds.Select(a => new DsVanDeModel
            {
                id = a.id,
                idLoaiVanDe = a.idLoaiVanDe,
                TenLoaiVanDe = a.TenLoaiVanDe,
                TenKhachHang = a.TenKhachHang,
                SoDienThoai = a.SoDienThoai,
                DiaChi = a.DiaChi,
                TraLoi = a.TraLoi,
                NguoiTao = a.NguoiTao,
                NgayTao = a.NgayTao,
                TrangThai = a.TrangThai,
                NgayHoanThanh = a.NgayHoanThanh,
                MucDoUuTien = a.MucDoUuTien,
                NoiDung = a.NoiDung,
                NguoiXuLy = a.NguoiXuLy,
                YKienKhachHang = a.YKienKhachHang,
                DanhGiaKhachHang = a.DanhGiaKhachHang,
            }).ToArray();
            return Ok(result);
        }
        [HttpGet("dslvde")]
        public IActionResult GetListLoaiVanDe()
        {

            var ds = _dsvandeda.GetDsLoaiVanDe();
            var result = ds.Select(a => new DmLoaiVanDeModel
            {
                id = a.id,
                TenLoaiVanDe = a.TenLoaiVanDe,
            }).ToArray();
            return Ok(result);
        }
    }
}
