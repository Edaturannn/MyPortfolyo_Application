using System.ComponentModel.DataAnnotations;

namespace MyPortfolyo_Application.DAL.Entities
{
    public class Portfolio
    {
        [Key]
        public int PortfolioId { get; set; }

        [StringLength(200)]
        public string Title { get; set; }

        [StringLength(200)]
        public string SubTitle { get; set; }

        [StringLength(250)]
        public string ImageUrl { get; set; }

        [StringLength(350)]
        public string Url { get; set; }

        [StringLength(600)]
        public string Description { get; set; }
    }
}
