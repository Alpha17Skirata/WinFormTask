using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace TestTask.Model
{
    public class Address
    {
     public int Id { get; set; }
      [Required(ErrorMessage = "Введите название улицы")]
      [StringLength(40, MinimumLength = 3, ErrorMessage = "Длина названия улицы от 3 до 40 символов")]
      public string AddressName { get; set; }
    }
}
