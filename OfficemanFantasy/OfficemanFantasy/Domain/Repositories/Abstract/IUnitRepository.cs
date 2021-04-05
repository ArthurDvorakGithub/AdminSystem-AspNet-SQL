using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OfficemanFantasy.Domain.Entities;

namespace OfficemanFantasy.Domain.Repositories.Abstract
{
    public interface IUnitRepository
    {
        //Unit
        IQueryable<Unit> GetAllUnits(); //сделать выборку всех персонажей
        Unit GetUnitById(Guid id); // выбрать персонажа по идентификатору
        Unit GetUnitByCodeWord(string codeWord); // выбрать персонажа по кодовому слову
        void SaveUnit(Unit entity); //обновить или создать персонажа
        void DeleteUnit(Guid id); // удалить персонажа


    }
}
