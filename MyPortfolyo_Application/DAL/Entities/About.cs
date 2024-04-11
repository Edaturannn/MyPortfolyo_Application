using System.ComponentModel.DataAnnotations;

namespace MyPortfolyo_Application.DAL.Entities
{
    public class About
    {
        [Key]
        public int AboutId { get; set; }

        [StringLength(200)]
        public string Title { get; set; }

        [StringLength(600)]
        public string SubDescription { get; set; }

        [StringLength(600)]
        public string Details { get; set; }
    }
}
