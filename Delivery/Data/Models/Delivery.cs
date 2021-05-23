using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Delivery.Data.Models
{
    public class Delivery
    {
        [Key]
        public int id { get; set; }

        [Display(Name = "Город отправителя")]
        public string SenderCity { get; set; }
        [Display(Name = "Адрес отправителя")]
        public string SenderAddress { get; set; }
        [Display(Name = "Город получателя")]
        public string ReciverCity { get; set; }
        [Display(Name = "Адрес получателя")]
        public string ReciverAdress { get; set; }
        [Display(Name = "Вес отправления")]
        public double weight { get; set; }
        [Display(Name = "Дата отправки")]
        public DateTime Date { get; set; }

    }
}
