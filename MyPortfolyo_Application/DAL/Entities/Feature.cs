using System.ComponentModel.DataAnnotations;

namespace MyPortfolyo_Application.DAL.Entities
{
    public class Feature
    {
        [Key]
        public int FeatureId { get; set; }

        [StringLength(200)]
        public string Title { get; set; }

        [StringLength(600)]
        public string Description { get; set; }
    }
}
