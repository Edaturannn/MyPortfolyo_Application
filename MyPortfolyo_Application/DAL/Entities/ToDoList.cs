using System.ComponentModel.DataAnnotations;

namespace MyPortfolyo_Application.DAL.Entities
{
    public class ToDoList
    {
        [Key]
        public int ToDoListId { get; set; }

        [StringLength(200)]
        public string Title { get; set; }

        [StringLength(200)]
        public string ImageUrl { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;

        [StringLength(500)]
        public string Text { get; set; }
        public bool Status { get; set; } = false;
    }
}
