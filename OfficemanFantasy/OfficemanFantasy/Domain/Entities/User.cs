using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OfficemanFantasy.Domain.Entities
{
    public class User : EntityBase
    {
        [Required(ErrorMessage = "Заполните название никнейм,имя и фамилию нового игрока ")]

        [Display(Name = "Имя игрока")]
        public override string Title { get; set; } = "Имя нового игрока";

        [Required]
        public string CodeWord { get; set; }

        [Display(Name = "Фамилия игрока")]
        public override string Subtitle { get; set; } = "Фамилия нового игрока";

        [Display(Name = "Никнейм игрока")]
        public override string Text { get; set; } = "Никнейм нового игрока";
    }
}
