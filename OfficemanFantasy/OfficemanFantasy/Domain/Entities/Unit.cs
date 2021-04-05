using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OfficemanFantasy.Domain.Entities
{
    public class Unit : EntityBase
    {
        [Required(ErrorMessage = "Заполните название, и описание персонажа")]

        [Display(Name = "Имя персонажа")]        
        public override string Title { get; set; } = "Название персонажа";

        [Required]
        public string CodeWord { get; set; }

        [Display(Name = "Кратко о персонаже")]
        public override string Subtitle { get; set; } = "Краткое описание";

        [Display(Name = "Полное описание")]
        public override string Text { get; set; } = "Описание персонажа";

        [Display(Name = "Здоровье")]
        public virtual string HealthUnit { get; set; }

        [Display(Name = "Арсенал персонажа")]
        public virtual string ArsenalUnit { get; set; }

        [Display(Name = "Уровень Персонажа")]
        public virtual string LevelUnit { get; set; }
    }
}
