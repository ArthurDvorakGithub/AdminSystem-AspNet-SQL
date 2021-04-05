using OfficemanFantasy.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OfficemanFantasy.Domain.Repositories.Abstract
{
    public interface ITextFieldsRepository
    {
        IQueryable<TextField> GetAllTextFields(); //сделать выборку всех текстовых полей
        TextField GetTextFieldById(Guid id); // выбрать текстовое поле по идентификатору
        TextField GetTextFieldByCodeWord(string codeWord); // выбрать текстовое поле по кодовому слову
        void SaveTextField(TextField entity); //сохранить изменения в базу данных
        void DeleteTextField(Guid id); // удалить текстовое поле

    }
}
