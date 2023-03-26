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
    public class SerialLaptopRepository : ISerialLaptopRepository
    {
        private QlBanLaptopContext _context;

        public SerialLaptopRepository()
        {
            _context = new QlBanLaptopContext();
        }
        public bool AddSerialLaptop(SerialLaptop obj)
        {
            try
            {
                obj.Id = Guid.NewGuid();
                _context.SerialLaptop.Add(obj);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public bool AddLstSerialLaptop(List<SerialLaptop> lst)
        {
            try
            {
                foreach (var serial in lst)
                {
                    serial.Id = Guid.NewGuid();
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
                var serial = _context.SerialLaptop.FirstOrDefault(x => x.Id == id);
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
            catch (Exception )
            {
                return false;
            }
        }

        public bool UpdateSerialLaptop(SerialLaptop obj)
        {
            try
            {
                var serial = _context.SerialLaptop.FirstOrDefault(c => c.Id == obj.Id);
                serial.Serial = obj.Serial;
                _context.Update(serial);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeleteSerialLaptop(Guid Id)
        {
            try
            {
                var serial = _context.SerialLaptop.FirstOrDefault(c => c.Id == Id);
                _context.Remove(serial);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<SerialLaptop> GetLstSerialLaptopFromDb()
        {
            return _context.SerialLaptop.ToList();
        }
    }
}
