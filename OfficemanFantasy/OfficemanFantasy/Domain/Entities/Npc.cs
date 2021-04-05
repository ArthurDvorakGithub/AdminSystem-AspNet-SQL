using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OfficemanFantasy.Domain.Entities
{
    public class Npc : EntityBase
    {
        [Required]
        public string CodeWord { get; set; }

        [Required(ErrorMessage = "Заполните название и описание враждебного персонажа")]

        [Display(Name = "Имя враждебного персонажа")]
        public override string Title { get; set; } = "Название враждебного персонажа";
    }
}
