﻿using BusinessObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Repositories
{
    public interface ICategoryRepository
    {
        List<Category> GetCategories();
    }

}
