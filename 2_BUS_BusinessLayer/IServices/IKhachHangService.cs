using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2_BUS_BusinessLayer.ViewModel;

namespace _2_BUS_BusinessLayer.IServices
{
    public interface IKhachHangService
    {
        public List<KhachHangView> GetLstKhachHang();
    }
}
