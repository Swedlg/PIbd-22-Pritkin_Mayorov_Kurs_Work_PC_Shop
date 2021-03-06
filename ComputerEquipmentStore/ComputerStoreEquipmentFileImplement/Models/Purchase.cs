﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ComputerEquipmentStoreDatabaseImplement.Models
{
    public class Purchase
    {
        //ID покупки
        public int Id { get; set; }

        //Общая стоимость покупки
        [Required]
        public int TotalCost { get; set; }

        //Дата покупки
        [Required]
        public DateTime DatePurchase { get; set; }

        public Buyer Buyer { get; set; }

        //Сборки находящиеся в этой покупке
        [ForeignKey("PurchaseId")]
        public virtual List<PurchaseAssembly> PurchaseAssembly { get; set; }

        //Товары находящиеся в этой покупке
        [ForeignKey("PurchaseId")]
        public virtual List<PurchaseProduct> PurchaseProduct { get; set; }
    }
}
