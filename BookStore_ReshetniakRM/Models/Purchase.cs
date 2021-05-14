using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStore_ReshetniakRM.Models
{
    public class Purchase
    {
        // ID покупки
        public int PurchaseId { get; set; }
        // ФИ покупателя
        public string Person { get; set; }
        // Адрес покупателя
        public string Adress { get; set; }
        // ID книги
        public int BookID { get; set; }
        // Дата покупки
        public DateTime Date { get; set; }
    }
}