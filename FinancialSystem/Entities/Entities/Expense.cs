using Entities.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Entities
{
    [Table("Expense")]
    public class Expense : Basis
    {
        public decimal Value { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public EnumTypeExpense TypeExpense { get; set; }
        public DateTime RegistrationDate { get; set; }
        public DateTime ChangeDate { get; set; }
        public DateTime PaymentDate { get; set; }
        public DateTime DueDate { get; set; }
        public bool Paid { get; set; }
        public bool OverdueExpense { get; set; }

        [ForeignKey("Category")]
        [Column(Order = 1)]
        public int IdCategory { get; set; }
        //public virtual Category Category { get; set; }
    }
}
