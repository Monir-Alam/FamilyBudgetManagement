using System.ComponentModel.DataAnnotations;

namespace FamilyBudget.Models
{
    public class PersonInfo
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DOB { get; set; }
        public string Profession { get; set; }
        public string JobDescription { get; set; }
    }
}
