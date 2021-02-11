using Core.DataAccess.EntityFramework;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;
using Core.DataAccess;

namespace DataAccess.Abstract
{
    public interface IRentDal: IEntityRepository<Rentals>
    {
    }
}
