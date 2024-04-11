using System.ComponentModel.DataAnnotations;

namespace MyPortfolyo_Application.DAL.Entities
{
    public class Message
    {
        [Key]
        public int MessageId { get; set; }

        [StringLength(200)]
        public string NameSurname { get; set; }

        [StringLength(150)]
        public string Subject { get; set; }

        [StringLength(250)]
        public string Email { get; set; }

        [StringLength(600)]
        public string MessageDetail { get; set; }

        public DateTime SendDate { get; set; } = DateTime.Now;

        public string IsRead { get; set; } = "Okunmadı";
    }
}
