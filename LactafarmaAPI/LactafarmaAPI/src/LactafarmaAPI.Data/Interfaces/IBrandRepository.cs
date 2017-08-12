﻿using LactafarmaAPI.Core.Interfaces;
using LactafarmaAPI.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace LactafarmaAPI.Data.Interfaces
{
    public interface IBrandRepository : IDataRepository<Brand>
    {
        IEnumerable<BrandMultilingual> GetAllBrands();
        IEnumerable<BrandMultilingual> GetBrandsByDrug(int drugId);
        BrandMultilingual GetBrand(int brandId);

    }
}
