using OfficemanFantasy.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OfficemanFantasy.Domain.Repositories.Abstract
{
    public interface IUserRepository
    {
        //User
        IQueryable<User> GetAllUsers(); //сделать выборку всех пользователей
        User GetUserById(Guid id); // выбрать пользователя по идентификатору
        User GetUserByCodeWord(string codeWord); // выбрать пользователя по кодовому слову
        void SaveUser(User entity); //обновить или создать пользователя
        void DeleteUser(Guid id); // удалить пользователя
    }
}
