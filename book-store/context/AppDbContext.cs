using book_store.database.entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace book_store.context
{
    public class AppDbContext: DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { }

        public DbSet<Book> book { get; set; }
        public DbSet<Category> category { get; set; }
        public DbSet<Publisher> publisher { get; set; }
        public DbSet<Author> author { get; set; }
        public DbSet<CoverType> cover_type { get; set; }
        public DbSet<Language> language { get; set; }
        public DbSet<User> user { get; set; }

        private static readonly Lazy<AppDbContext> _instance = new Lazy<AppDbContext>(() =>
                    new AppDbContext(new DbContextOptionsBuilder<AppDbContext>()
                    .UseNpgsql("Server=localhost; Port=5432; DataBase=book_store_windows_forms; User Id=postgres; Password=1")
                    .UseLazyLoadingProxies()
                    .Options));

        public static AppDbContext INSTANCE => _instance.Value;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>()
                .HasOne(b => b.Category)
                .WithMany()
                .HasForeignKey(b => b.CategoryId);

            modelBuilder.Entity<Book>()
                .HasOne(b => b.Publisher)
                .WithMany()
                .HasForeignKey(b => b.PublisherId);

            modelBuilder.Entity<Book>()
                .HasOne(b => b.Author)
                .WithMany()
                .HasForeignKey(b => b.AuthorId);

            modelBuilder.Entity<Book>()
                .HasOne(b => b.CoverType)
                .WithMany()
                .HasForeignKey(b => b.CoverTypeId);

            modelBuilder.Entity<Book>()
                .HasOne(b => b.Language)
                .WithMany()
                .HasForeignKey(b => b.LanguageId);

            base.OnModelCreating(modelBuilder);

            foreach (IMutableEntityType entity in modelBuilder.Model.GetEntityTypes())
            {
                foreach (IMutableProperty property in entity.GetProperties())
                {
                    // Преобразуем название свойства в snake_case
                    string snakeCaseName = ToSnakeCase(property.Name);
                    property.SetColumnName(snakeCaseName);
                }
            }
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                    .UseNpgsql("Host=localhost;Port=5432;Database=book_store_windows_forms;Username=postgres;Password=1")
                    .UseLazyLoadingProxies();
            }
        }

        private static string ToSnakeCase(string input)
        {
            return Regex.Replace(input, @"([a-z0-9])([A-Z])", "$1_$2").ToLower();
        }
    }
}
