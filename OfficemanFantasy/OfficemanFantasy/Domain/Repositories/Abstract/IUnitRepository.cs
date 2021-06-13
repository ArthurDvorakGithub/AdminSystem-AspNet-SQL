using OfficemanFantasy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OfficemanFantasy.Domain.Repositories.Abstract
{
    public interface IUnitRepository
    {
        IQueryable<Unit> GetAllUnit(); //сделать выборку всех юнитов
    }
}
