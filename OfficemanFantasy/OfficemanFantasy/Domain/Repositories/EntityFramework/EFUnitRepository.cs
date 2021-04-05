using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using OfficemanFantasy.Domain.Entities;
using OfficemanFantasy.Domain.Repositories.Abstract;

namespace OfficemanFantasy.Domain.Repositories.EntityFramework
{
    public class EFUnitRepository : IUnitRepository
    {
        private readonly AppDbContext context;
        public EFUnitRepository(AppDbContext context)
        {
            this.context = context;
        }

        //Выбираем все записи из базы данных
        public IQueryable<Unit> GetAllUnits()
        {
            return context.Units;
        }

        //Берем одну запись из списка
        public Unit GetUnitById(Guid id)
        {
            return context.Units.FirstOrDefault(x => x.Id == id);
        }

        //Выбираем по ключевому слову персонажа
        public Unit GetUnitByCodeWord(string codeWord)
        {
            return context.Units.FirstOrDefault(x => x.CodeWord == codeWord);
        }

        public void SaveUnit(Unit entity)
        {
            //Если идентификатор отсутствует , то помечаем его как новый обьект - .Added
            if (entity.Id == default)
                context.Entry(entity).State = EntityState.Added;

            //Если идентификатор уже есть в БД , то помечаем его как измененный - .Modified
            else
                context.Entry(entity).State = EntityState.Modified;
            //Сохраняем
            context.SaveChanges();
        }

        // Удаляем персонажа поле из БД
        public void DeleteUnit(Guid id)
        {
            //создаем новый пустой обьект и назначаем ему идентификатор
            context.Units.Remove(new Unit() { Id = id });
            context.SaveChanges();
        }

    }
}
