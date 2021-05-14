using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookStore_ReshetniakRM.Models
{
    public class Book
    {
        // Id книги
        [HiddenInput(DisplayValue=false)]
        public int Id { get; set; }
        // Наименование книги
        [Required]
        [Display(Name="Название")]
        public string Name { get; set; }
        // Автор книги
        [Required]
        [Display(Name="Автор")]
        public string Author { get; set; }
        // Стоимость
        [Required]
        [Display(Name="Стоимость книги")]
        public int Price { get; set; }
    }
}