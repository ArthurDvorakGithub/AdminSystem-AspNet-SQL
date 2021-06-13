using OfficemanFantasy.Domain.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebGameNetCore.Models;

namespace OfficemanFantasy.Domain.Repositories.EntityFramework
{
    public class EFTileRepository : ITileRepository
    {
        private readonly AppDbContext context;
        public EFTileRepository(AppDbContext context)
        {
            this.context = context;
        }
        //Выбираем все тайлы из базы данных
        public IQueryable<Tile> GetAllTile()
        {
            return context.Tiles;
        }
    }
}

   


    