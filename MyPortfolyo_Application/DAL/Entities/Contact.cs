using System.ComponentModel.DataAnnotations;

namespace MyPortfolyo_Application.DAL.Entities
{
    public class Contact
    {
        [Key]
        public int ContactId { get; set; }

        [StringLength(200)]
        public string Title { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        [StringLength(15)]
        public string Phone1 { get; set; }

        [StringLength(15)]
        public string Phone2 { get; set; }

        [StringLength(150)]
        public string Email1 { get; set; }

        [StringLength(150)]

        public string Email2 { get; set; }

        [StringLength(250)]

        public string Address { get; set; }
    }
}
