using Microsoft.EntityFrameworkCore;
using MyPortfolyo_Application.DAL.Entities;

namespace MyPortfolyo_Application.DAL.Context
{
    public class MyPortfolioContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) //Bu yöntem, DbContext sınıfının yapılandırılmasını sağlar ve DbContextOptionsBuilder nesnesini kullanarak bağlantı seçeneklerini belirtir.
        {
            optionsBuilder.UseSqlServer("Server=LAPTOP-2PUE7SMB;initial Catalog=MyPortfolioDb;integrated Security=true;TrustServerCertificate=True;");
        }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<WorkExperience> WorkExperiences { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<ToDoList> ToDoLists { get; set; }
    }
}
