﻿using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Entities
{
    [Table("Category")]
    public class Category : Basis
    {
        [ForeignKey("FinancialSystem")]
        [Column(Order = 1)]
        public int IdSystem { get; set; }
        public virtual FinancialSystem FinancialSystem { get; set; }
    }
}