using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class YearMonthDay
    {
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }
    }
}
