using System.ComponentModel.DataAnnotations;

namespace AngWater.Models
{
    public class Schedule : BaseModel
    {
        [Required]
        public string Speaker { get; set; }

        public TimeOnly StartTime { get; set; }

        public TimeOnly EndTime { get; set; }

        public short Channel { get; set; }
    }
}
