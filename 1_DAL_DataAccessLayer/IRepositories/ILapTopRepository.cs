﻿using _1_DAL_DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_DataAccessLayer.IRepositories
{
    public interface ILapTopRepository
    {
        bool AddLapTop(Laptop lapTop);
        bool UpdateLapTop(Guid idLapTop, Laptop lapTop);
        Laptop GetLapTopById(Guid idLapTop);
        List<Laptop> GetAllLapTop();
    }
}
