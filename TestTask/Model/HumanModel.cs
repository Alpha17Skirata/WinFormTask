using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using TestTask.Model;

namespace TestTask.Model
{
    public class HumanModel
    {
      public int Id { get; set; }
      [Required(ErrorMessage = "Введите имя")]
      [StringLength(25, MinimumLength = 3, ErrorMessage = "Длина имени от 3 до 30 символов")]
      public string Name { get; set; }
      [Required(ErrorMessage = "Введите фамилию")]
      [StringLength(25, MinimumLength = 3, ErrorMessage = "Длина фамилии от 3 до 30 символов")]
      public string Surname { get; set; }
      [Required(ErrorMessage = "Введите отчество")]
      [StringLength(25, MinimumLength = 3, ErrorMessage = "Длина отчества от 3 до 30 символов")]
      public string MiddleName { get; set; }
      [Required(ErrorMessage = "Не была введена дата, или она имеет некорректный формат.")]
      public DateTime? Birthday { get; set; }
      [Required(ErrorMessage = "Введите номер квартиры")]
      [RegularExpression(@"^([1-9]|[1-9][0-9]|[1-9][0-9][0-9])$", ErrorMessage = "Номер квартиры должен быть от 1 до 999")]
      public int? Flat { get; set; }
    }
}
