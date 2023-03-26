using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAccessLayer.Context;
using _1_DAL_DataAccessLayer.IRepositories;
using _1_DAL_DataAccessLayer.Models;

namespace _1_DAL_DataAccessLayer.Repositories
{
    public class SerialLinhKienRepository : ISerialLinhKienRepository
    {
        private QlBanLaptopContext _context;

        public SerialLinhKienRepository()
        {
            _context = new QlBanLaptopContext();
        }
        public bool AddSerial(SerialLinhKien obj)
        {
            try
            {
                obj.Id = Guid.NewGuid();
                _context.AddRange(obj);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool AddLstSerial(List<SerialLinhKien> lst)
        {
            try
            {
                foreach (var serial in lst)
                {
                    serial.Id = new Guid();
                }

                _context.AddRange(lst);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool UpdateStatusSerial(Guid id)
        {
            try
            {
                var serial = _context.SerialLinhKien.FirstOrDefault(c => c.Id == id);
                if (serial != null)
                {
                    if (serial.TrangThai)
                    {
                        serial.TrangThai = false;
                        return true;
                    }
                    serial.TrangThai = true;
                    return true;
                }

                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool UpdateSerial(SerialLinhKien obj)
        {
            try
            {
                var serial = _context.SerialLinhKien.FirstOrDefault(c => c.Id == obj.Id);
                if (serial != null)
                {
                    serial.Serial = obj.Serial;
                    _context.Update(serial);
                    _context.SaveChanges();
                    return true;
                }

                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeleteSerial(Guid Id)
        {
            try
            {
                var serial = _context.SerialLinhKien.FirstOrDefault(c => c.Id == Id);
                if (serial != null)
                {
                    _context.Remove(serial);
                    _context.SaveChanges();
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<SerialLinhKien> GetLstSerialLinhKienFromDb()
        {
            return _context.SerialLinhKien.ToList();
        }
    }
}
