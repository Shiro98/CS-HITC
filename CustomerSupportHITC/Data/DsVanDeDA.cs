using Dapper;
using CustomerSupportHITC.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerSupportHITC.Data
{
    public class DsVanDeDA : IDsVanDeDA
    {
        private readonly string _connectionString;
        public DsVanDeDA(string connectionString)
        {
            _connectionString = connectionString;
        }
        private DbConnection OpenConnection()
        {
            var conn = new MySqlConnection(_connectionString);
            conn.Open();
            return conn;
        }
        public void InsertData(DsVanDeModel data)
        {
            using (var conn = OpenConnection())
            {
                var id = conn.ExecuteScalar<int>(@"INSERT INTO ds_vande(idLoaiVanDe, SoDienThoai, TenKhachHang, DiaChi, TraLoi, NguoiTao, NgayTao, TrangThai, NgayHoanThanh, MucDoUuTien, NoiDung, NguoiXuLy, YKienKhachHang, DanhGiaKhachHang)
                                                    VALUES(@idLoaiVanDe,@SoDienThoai,@TenKhachHang,@DiaChi,@TraLoi,@NguoiTao,@NgayTao,@TrangThai,@NgayHoanThanh,@MucDoUuTien,@NoiDung,@NguoiXuLy,@YKienKhachHang,@DanhGiaKhachHang)
                                                    ", data);
            }
        }
        public void UpdateData(DsVanDeModel data)
        {
            using (var conn = OpenConnection())
            {
                var ck = conn.ExecuteScalar<int>(@"UPDATE ds_vande
                                                    SET idLoaiVanDe = @idLoaiVanDe,
		                                                    SoDienThoai = @SoDienThoai, 
		                                                    TenKhachHang = @TenKhachHang,
		                                                    DiaChi = @DiaChi, 
		                                                    TraLoi = @TraLoi,
		                                                    NguoiTao = @NguoiTao, 
		                                                    NgayTao = @NgayTao,
		                                                    TrangThai = @TrangThai, 
		                                                    NgayHoanThanh = @NgayHoanThanh,
		                                                    MucDoUuTien = @MucDoUuTien, 
		                                                    NoiDung = @NoiDung,
		                                                    NguoiXuLy = @NguoiXuLy, 
		                                                    YKienKhachHang = @YKienKhachHang,
		                                                    DanhGiaKhachHang = @DanhGiaKhachHang
                                                    WHERE id = @id", data);
            }
        }
        public void Delete(int id)
        {
            using (var conn = OpenConnection())
            {
                conn.Execute("DELETE FROM ds_vande WHERE id=@id", new { id });
            }
        }
        public IEnumerable<DmLoaiVanDeModel> GetDsLoaiVanDe()
        {
            using (var conn = OpenConnection())
            {
                return conn.Query<DmLoaiVanDeModel>(@"SELECT * FROM dm_loaivande").ToArray();
            }
        }
        public int GetTotal()
        {
            using (var conn = OpenConnection())
            {
                return conn.Query<int>(@"SELECT COUNT(*) FROM ds_vande").SingleOrDefault();
            }
        }
        public IEnumerable<DsVanDeModel> GetDanhSach(int First, int RowPerPage)
        {
            using (var conn = OpenConnection())
            {
                return conn.Query<DsVanDeModel>(@"SELECT 
	                                                a.id AS id,
	                                                a.idLoaiVanDe AS idLoaiVanDe,
	                                                b.TenLoaiVanDe AS TenLoaiVanDe,
	                                                a.SoDienThoai AS SoDienThoai,
	                                                a.TenKhachHang AS TenKhachHang,
	                                                a.DiaChi AS DiaChi,
	                                                a.TraLoi AS TraLoi,
	                                                a.NguoiTao AS NguoiTao,
	                                                a.NgayTao AS NgayTao,
	                                                a.TrangThai AS TrangThai,
	                                                a.NgayHoanThanh AS NgayHoanThanh,
	                                                a.MucDoUuTien AS MucDoUuTien,
	                                                a.NoiDung AS NoiDung,
	                                                a.NguoiXuLy AS NguoiXuLy,
	                                                a.YKienKhachHang AS YKienKhachHang,
	                                                a.DanhGiaKhachHang AS DanhGiaKhachHang
                                                FROM ds_vande a
                                                LEFT JOIN dm_loaivande b on a.idLoaiVanDe = b.id
                                                LIMIT @First, @RowPerPage;
                SELECT COUNT(*) FROM ds_vande;", new
                {
                                                    First = First,
                                                    RowPerPage = RowPerPage
                }).ToArray();
            }
        }
        public IEnumerable<DsVanDeModel> GetDanhSachById(int ids)
        {
            using (var conn = OpenConnection())
            {
                return conn.Query<DsVanDeModel>(@"SELECT 
	                                                a.id AS id,
	                                                a.idLoaiVanDe AS idLoaiVanDe,
	                                                b.TenLoaiVanDe AS TenLoaiVanDe,
	                                                a.SoDienThoai AS SoDienThoai,
	                                                a.TenKhachHang AS TenKhachHang,
	                                                a.DiaChi AS DiaChi,
	                                                a.TraLoi AS TraLoi,
	                                                a.NguoiTao AS NguoiTao,
	                                                a.NgayTao AS NgayTao,
	                                                a.TrangThai AS TrangThai,
	                                                a.NgayHoanThanh AS NgayHoanThanh,
	                                                a.MucDoUuTien AS MucDoUuTien,
	                                                a.NoiDung AS NoiDung,
	                                                a.NguoiXuLy AS NguoiXuLy,
	                                                a.YKienKhachHang AS YKienKhachHang,
	                                                a.DanhGiaKhachHang AS DanhGiaKhachHang
                                                FROM ds_vande a
                                                LEFT JOIN dm_loaivande b on a.idLoaiVanDe = b.id
                                                WHERE a.id = @ids", new {ids}).ToArray();
            }
        }
        //public DsVanDeModel GetDanhSach(int id)
        //{
        //    using (var conn = OpenConnection())
        //    {
        //        return conn.Query<DsVanDeModel>("SELECT * FROM ds_vande WHERE id=@id", new { id }).SingleOrDefault();
        //    }
        //}
    }
}
