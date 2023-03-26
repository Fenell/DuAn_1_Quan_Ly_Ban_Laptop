﻿using _1_DAL_DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS_BusinessLayer.IServices
{
    public interface ILaptopService
    {
        string AddLapTop(Laptop lapTop);
        string UpdateLapTop(Laptop lapTop);
        Laptop GetLapTopById(Guid idLapTop);
        List<Laptop> GetAllLapTop();
    }
}
