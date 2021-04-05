using OfficemanFantasy.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OfficemanFantasy.Domain.Repositories.Abstract
{
    public interface INpcRepository
    {
        IQueryable<Npc> GetAllNpc(); //сделать выборку всех вражеских персонажей
        Npc GetNpcById(Guid id); // выбрать вражеского персонажа по идентификатору
        Npc GetNpcByCodeWord(string CodeWord); // выбрать вражеского персонажа по кодовому слову
        void SaveNpc(Npc entity); //сохранить изменения для вражеского персонажа в базу данных
        void DeleteNpc(Guid id); // удалить вражеского персонажа
    }
}
