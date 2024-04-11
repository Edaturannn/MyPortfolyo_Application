using System.ComponentModel.DataAnnotations;

namespace MyPortfolyo_Application.DAL.Entities
{
    public class SocialMedia
    {
        [Key]
        public int SocialMediaId { get; set; }

        [StringLength(150)]
        public string Title { get; set; }

        [StringLength(500)]
        public string Url { get; set; }

        [StringLength(200)]
        public string Icon { get; set; }
    }
}
