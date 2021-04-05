using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using OfficemanFantasy.Domain.Entities;
using OfficemanFantasy.Domain.Repositories.Abstract;

namespace OfficemanFantasy.Domain.Repositories.EntityFramework
{
    public class EFUserRepository : IUserRepository
    {
        private readonly AppDbContext context;
        public EFUserRepository(AppDbContext context)
        {
            this.context = context;
        }

        //Выбираем все записи из базы данных
        public IQueryable<User> GetAllUsers()
        {
            return context.Users;
        }

        //Берем одну запись из списка
        public User GetUserById(Guid id)
        {
            return context.Users.FirstOrDefault(x => x.Id == id);
        }

        //Выбираем по ключевому слову из списка
        public User GetUserByCodeWord(string codeWord)
        {
            return context.Users.FirstOrDefault(x => x.CodeWord == codeWord);
        }

        public void SaveUser(User entity)
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

        // Удаляем пользователя поле из БД
        public void DeleteUser(Guid id)
        {
            //создаем новый пустой обьект и назначаем ему идентификатор
            context.Users.Remove(new User() { Id = id });
            context.SaveChanges();
        }

    }
}
