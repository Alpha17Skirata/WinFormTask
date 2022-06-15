using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask.Model
{
    public class UserFormViewModel
    {
        [System.ComponentModel.DisplayName("Имя")]
        public string Name { get; set; }
        [System.ComponentModel.DisplayName("Фамилия")]
        public string Surname { get; set; }
        [System.ComponentModel.DisplayName("Отчество")]
        public string MiddleName { get; set; }
        [System.ComponentModel.DisplayName("День рождения")]
        public DateTime? Birthday { get; set; }
        [System.ComponentModel.DisplayName("Номер")]
        public string Number { get; set; }
        [System.ComponentModel.DisplayName("Улица")]
        public string AddressName { get; set; }
        [System.ComponentModel.DisplayName("Номер дома")]
        public int? HouseNumber { get; set; }
        [System.ComponentModel.DisplayName("Квартира")]
        public int? Flat { get; set; }
    }
}
