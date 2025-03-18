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

        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<CoverType> CoverTypes { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Favorite> Favorites { get; set; }
        public DbSet<BookReview> BookReviews { get; set; }

        private static readonly Lazy<AppDbContext> _instance = new Lazy<AppDbContext>(() =>
                    new AppDbContext(new DbContextOptionsBuilder<AppDbContext>()
                    .UseNpgsql("Server=localhost; Port=5432; DataBase=book_store_windows_forms; User Id=postgres; Password=1")
                    .UseLazyLoadingProxies()
                    .LogTo(message => System.Diagnostics.Debug.WriteLine(message), Microsoft.Extensions.Logging.LogLevel.Information)
                    .EnableSensitiveDataLogging()
                    .Options));

        public static AppDbContext INSTANCE => _instance.Value;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().ToTable("book");
            modelBuilder.Entity<Category>().ToTable("category");
            modelBuilder.Entity<Publisher>().ToTable("publisher");
            modelBuilder.Entity<Author>().ToTable("author");
            modelBuilder.Entity<CoverType>().ToTable("cover_type");
            modelBuilder.Entity<Language>().ToTable("language");
            modelBuilder.Entity<User>().ToTable("users");
            modelBuilder.Entity<CartItem>().ToTable("cart_item")
                .HasKey(c => new { c.UserId, c.BookId });
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

            modelBuilder.Entity<Favorite>().ToTable("favorites")
            .HasKey(f => new { f.BookId, f.UserId });

            modelBuilder.Entity<BookReview>().ToTable("book_review")
        .HasIndex(b => new { b.UserId, b.BookId })
        .IsUnique();

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

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries<BookReview>())
            {
                if (entry.State == EntityState.Modified)
                {
                    entry.Entity.UpdatedAt = DateTime.UtcNow;
                }
            }
            return base.SaveChanges();
        }


        private static string ToSnakeCase(string input)
        {
            return Regex.Replace(input, @"([a-z0-9])([A-Z])", "$1_$2").ToLower();
        }
    }
}
