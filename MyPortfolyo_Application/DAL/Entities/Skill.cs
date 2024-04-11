using System.ComponentModel.DataAnnotations;

namespace MyPortfolyo_Application.DAL.Entities
{
    public class Skill
    {
        [Key]
        public int SkillId { get; set; }

        [StringLength(200)]
        public string Title { get; set; }

        public int Values { get; set; }
    }
}
