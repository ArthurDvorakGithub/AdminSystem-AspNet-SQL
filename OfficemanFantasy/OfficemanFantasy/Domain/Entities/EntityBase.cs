using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OfficemanFantasy.Domain.Entities
{
    public class EntityBase
    {
        //При создании каждого персонажа дата создания будет равна дате на момент создания объекта
        protected EntityBase() => DateAdded = DateTime.UtcNow;

        //Для записи обязателен выбор идентификатора
        [Required]
        public Guid Id { get; set; }

        [Display(Name = "Имя")]
        public virtual string Title { get; set; }

        [Display(Name = "Краткое описание")]
        public virtual string Subtitle { get; set; }
        
        [Display(Name = "Полное описание")]
        public virtual string Text { get; set; }

        [Display(Name = "Картинка для персонажа")]
        public virtual string TitleImagePath { get; set; }

        [Display(Name = "метатег Title")]
        public virtual string MetaTitle { get; set; }

        [Display(Name = "метатег Description")]
        public virtual string MetaDescription { get; set; }

        [Display(Name = "метатег Keywords")]
        public virtual string MetaKeywords { get; set; }

        

        [DataType(DataType.Time)]
        public DateTime DateAdded { get; set; }

    }
}
