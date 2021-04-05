using Microsoft.EntityFrameworkCore;
using OfficemanFantasy.Domain.Entities;
using OfficemanFantasy.Domain.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OfficemanFantasy.Domain.Repositories.EntityFramework
{
    public class EFNpcRepository : INpcRepository
    {
        private readonly AppDbContext context;
        public EFNpcRepository(AppDbContext context)
        {
            this.context = context;
        }

        //Выбираем все записи из базы данных
        public IQueryable<Npc> GetAllNpc()
        {
            return context.Npcs;
        }

        //Берем одну запись из списка
        public Npc GetNpcById(Guid id)
        {
            return context.Npcs.FirstOrDefault(x => x.Id == id);
        }

        //Выбираем по ключевому слову из списка
        public Npc GetNpcByCodeWord(string codeWord)
        {
            return context.Npcs.FirstOrDefault(x => x.CodeWord == codeWord);
        }

        public void SaveNpc(Npc entity)
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

        // Удаляем текстовое поле из БД
        public void DeleteNpc(Guid id)
        {
            //создаем новый пустой обьект и назначаем ему идентификатор
            context.Npcs.Remove(new Npc() { Id = id });
            context.SaveChanges();
        }
    }
}
