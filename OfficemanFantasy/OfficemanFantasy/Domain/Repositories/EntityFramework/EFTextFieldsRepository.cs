using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OfficemanFantasy.Domain.Entities;
using OfficemanFantasy.Domain.Repositories.Abstract;

namespace OfficemanFantasy.Domain.Repositories.EntityFramework
{
    public class EFTextFieldsRepository : ITextFieldsRepository
    {
        
        private readonly AppDbContext context;
        public EFTextFieldsRepository(AppDbContext context)
        {
            this.context = context;
        }

        //Выбираем все записи из базы данных
        public IQueryable<TextField> GetAllTextFields()
        {
            return context.TextFields;
        }

        //Берем одну запись из списка
        public TextField GetTextFieldById(Guid id)
        {
            return context.TextFields.FirstOrDefault(x => x.Id == id);
        }

        //Выбираем по ключевому слову из списка
        public TextField GetTextFieldByCodeWord(string codeWord)
        {
            return context.TextFields.FirstOrDefault(x => x.CodeWord == codeWord);
        }

        public void SaveTextField(TextField entity)
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
        public void DeleteTextField(Guid id)
        {
            //создаем новый пустой обьект и назначаем ему идентификатор
            context.TextFields.Remove(new TextField() { Id = id });
            context.SaveChanges();
        }
    }
}
