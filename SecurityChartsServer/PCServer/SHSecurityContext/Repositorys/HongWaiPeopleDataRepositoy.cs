﻿using SHSecurityContext.IRepositorys;
using System;
using System.Collections.Generic;
using System.Text;
using SHSecurityContext.DBContext;
using System.Linq;
using SHSecurityContext.Base;
using SHSecurityModels;
using Microsoft.EntityFrameworkCore;

namespace SHSecurityContext.Repositorys
{
    public class HongWaiPeopleDataRepositoy : BaseRepository<HongWaiPeopleData>,IHongWaiPeopleDataRepositoy
    {
        public HongWaiPeopleDataRepositoy(SHSecuritySysContext context)
        {
            nContext = context;
        }
    }
}
