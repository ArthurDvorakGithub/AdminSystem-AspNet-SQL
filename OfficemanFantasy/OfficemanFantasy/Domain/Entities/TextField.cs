using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OfficemanFantasy.Domain.Entities
{
    //Текст для страниц сайта
    public class TextField : EntityBase
    {
        [Required]
        public string CodeWord { get; set; }

        [Display(Name = "Имя страницы")]
        public override string Title { get; set; } = "Название страницы";

        [Display(Name = "Полное описание")]
        public override string Text { get; set; } = "Описание страницы";

    }
}
