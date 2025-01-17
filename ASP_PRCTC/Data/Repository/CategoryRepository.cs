﻿using ASP_Practice.Data.Interfaces;
using ASP_Practice.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_PRCTC.Data.Repository
{
    public class CategoryRepository : ICarsCategory
    {
        private readonly AppDBContent appDBContent;
        public CategoryRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        public IEnumerable<Category> AllCategoies => appDBContent.Category;
    }
}
