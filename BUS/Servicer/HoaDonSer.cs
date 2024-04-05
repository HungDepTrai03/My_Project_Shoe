using BUS.Viewmoder;
using DAL.Models;
using DAL.Repositori;
using Project_SHOE.Controller.Repositori;
using Project_SHOE.Controller.Servicer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services
{
    public class HoaDonSer
    {
        KhuyenMaiService khuyenMaiService = new KhuyenMaiService();
        KhachHangService khachHangService =  new KhachHangService();
        HoaDonRepos _repos = new HoaDonRepos();
        public HoaDonSer()
        {

        }
        public HoaDonSer(HoaDonRepos repos)
        {
            _repos = repos;
        }
        public bool AddHoaDon(Hoadon hoadon)
        {
            return _repos.AddHoaDon(hoadon);
        }
        public bool DeleteHoaDon(int id)
        {
            return _repos.DeleteHoaDon(id);
        }
        public bool UpdateHoaDon(int id)
        {
            return _repos.UpdateHoaDon(id);
        }
        public IEnumerable<Hoadon> GetALLHoadons()
        {
            return _repos.GetALLHoadons().ToList();
        }
    }
}
