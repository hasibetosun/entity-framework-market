﻿using AppCore.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.DAL.Dto.Category
{
   public class GetListCategoryDto : IDto
    {
        public int Id { get; set; }
        public string Name { get; set; }

    }
}
