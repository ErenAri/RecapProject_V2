﻿using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;
using Umbraco.Core.Persistence.Repositories;

namespace DataAccess.Abstract
{
    public interface IBrandDal:IEntityRepository<Brand>
    {
    }
}
