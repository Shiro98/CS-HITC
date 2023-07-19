using CustomerSupportHITC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerSupportHITC.Data
{
    public interface IDsVanDeDA
    {
        void InsertData(DsVanDeModel data);
        void UpdateData(DsVanDeModel data);
        void Delete(int id);
        int GetTotal();
        IEnumerable<DsVanDeModel> GetDanhSach(int First, int RowPerPage);
        IEnumerable<DsVanDeModel> GetDanhSachById(int ids);
        IEnumerable<DmLoaiVanDeModel> GetDsLoaiVanDe();
    }
}
