using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace TestTask.Model
{
    public class PhoneNumberModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Введите номер")]
        [RegularExpression(@"^\d{1}-\d{2}-\d{2}$", ErrorMessage = "Введите номер в формате х-хх-хх")]
        public string? Number { get; set; }
    }
}
