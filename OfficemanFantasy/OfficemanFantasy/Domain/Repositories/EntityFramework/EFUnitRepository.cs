using OfficemanFantasy.Domain.Repositories.Abstract;
using OfficemanFantasy.Models;
using System.Linq;

namespace OfficemanFantasy.Domain.Repositories.EntityFramework
{
    public class EFUnitRepository : IUnitRepository
    {
        private readonly AppDbContext context;
        public EFUnitRepository(AppDbContext context)
        {
            this.context = context;
        }
        //Выбираем все юниты из базы данных
        public IQueryable<Unit> GetAllUnit()
        {
            return context.Units;
        }
    }
}
