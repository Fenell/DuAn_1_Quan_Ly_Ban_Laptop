﻿using _1_DAL_DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAccessLayer.Models;
using _2_BUS_BusinessLayer.ViewModel;

namespace _2_BUS_BusinessLayer.IServices
{
    public interface ILaptopService
    {
        public string AddLaptop( SanPhamLaptopView obj);
        public string UpdateLaptop(SanPhamLaptopView obj);
        public string UpdateStatusLaptop(Guid id);
        public string DeleteLaptop(Guid id);
        public List<Laptop> GetLaptopFromDb();
        public List<SanPhamLaptopView> GetAllLaptop();

    }
}