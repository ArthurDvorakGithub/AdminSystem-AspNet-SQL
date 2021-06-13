using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebGameNetCore.Models;

namespace OfficemanFantasy.Domain.Repositories.Abstract
{
    public interface ITileRepository
    {
        IQueryable<Tile> GetAllTile(); //сделать выборку всех тайлов или посмотреть всю карту
    }
}
