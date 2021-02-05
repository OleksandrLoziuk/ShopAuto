using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Models
{
    public class Order
    {
        [BindNever]
        public int Id { get; set; }
        [Display(Name =  "Имя")]
        [StringLength(25)]
        [Required(ErrorMessage ="Длина не более 25 символов")]
        public string Name { get; set; }
        [Display(Name = "Фамилия")]
        [StringLength(25)]
        [Required(ErrorMessage = "Длина не более 25 символов")]
        public string SurName { get; set; }
        [Display(Name = "Адрес")]
        [StringLength(25)]
        [Required(ErrorMessage = "Длина не более 25 символов")]
        public string Adress { get; set; }
        [Display(Name = "Номер телефона")]
        [DataType(DataType.PhoneNumber)]
        [StringLength(15)]
        [Required(ErrorMessage = "Длина не более 15 символов")]
        public string Phone { get; set; }
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        [StringLength(25)]
        [Required(ErrorMessage = "Длина не более 25 символов")]
        public string Email { get; set; }
        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime OrderTime { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
    }
}
