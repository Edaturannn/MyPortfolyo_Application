using System.ComponentModel.DataAnnotations;

namespace MyPortfolyo_Application.DAL.Entities
{
    public class WorkExperience
    {
        [Key]
        public int WorkExperienceId { get; set; }

        [StringLength(200)]
        public string Head { get; set; }

        [StringLength(200)]
        public string Title { get; set; }

        public DateTime SendDate { get; set; }

        [StringLength(500)]
        public string Description { get; set; }
    }
}
