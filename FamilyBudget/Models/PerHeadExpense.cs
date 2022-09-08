using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FamilyBudget.Models
{
    public class PerHeadExpense
    {
        [Key]
        public int Id { get; set; }
        public decimal Father { get; set; }
        public decimal Mother { get; set; }
        public decimal Sister { get; set; }
        public decimal Brother { get; set; }
        public decimal Wife { get; set; }
        public decimal Children { get; set; }
        public decimal HouseRent { get; set; }
        public decimal MonthlyEarning { get; set; }


        public int MonthId { get; set; }
        [ForeignKey("MonthId")]
        public Month MonthName { get; set; }

        public int PersonId { get; set; }
        [ForeignKey("PersonInfo")]
        public PersonInfo PersonInfo { get; set; }
    }
}
