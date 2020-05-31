﻿using System;
using System.Collections.Generic;
using CostAccounting.Core.Models;
using CostAccounting.Services.Models.Category;

namespace CostAccounting.Services.Services
{
    public interface ICategoryService
    {
        List<CategoryModel> Get(CategoryRequestModel request);

        void Create(CategoryModel model);

        CategoryModel GetById(Guid id);

        void Update(CategoryModel model);

        void Delete(Guid id);
    }
}
