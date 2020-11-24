using DataBaseImplement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.ViewModel
{
    [Serializable]
    public class ProductViewModel
    {
        public int Id { get; set; }

        [DisplayName("Название")]
        public string Name { get; set; }

        [DisplayName("Количество на складе")]
        public int? Count { get; set; }

        [DisplayName("Категория")]
        public Category Category { get; set; }

        [DisplayName("Вид продукта")]
        public string KindOFProduct { get; set; }
    }
}
