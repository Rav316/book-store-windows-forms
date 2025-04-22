using book_store.database.entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Text.RegularExpressions;

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
        public DbSet<Warehouse> Warehouses { get; set; }
        public DbSet<BookWarehouse> BookWarehouses { get; set; }
        public DbSet<OrderStatus> OrderStatuses { get; set; }
        public DbSet<PaymentStatus> PaymentStatuses { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }

        private static readonly DbContextOptions<AppDbContext> _options =
                new DbContextOptionsBuilder<AppDbContext>()
               .UseNpgsql("Server=localhost; Port=5432; DataBase=book_store_copy; User Id=postgres; Password=1")
               .UseLazyLoadingProxies()
               .LogTo(message => System.Diagnostics.Debug.WriteLine(message), Microsoft.Extensions.Logging.LogLevel.Information)
               .EnableSensitiveDataLogging()
               .Options;

        public static AppDbContext INSTANCE => new AppDbContext(_options);

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

            modelBuilder.Entity<Warehouse>().ToTable("warehouse")
                .HasIndex(w => w.Name)
                .IsUnique();

            modelBuilder.Entity<BookWarehouse>().ToTable("book_warehouse")
            .HasKey(bw => new { bw.BookId, bw.WarehouseId });

            modelBuilder.Entity<BookWarehouse>()
                .HasOne(bw => bw.Book)
                .WithMany()
                .HasForeignKey(bw => bw.BookId);

            modelBuilder.Entity<BookWarehouse>()
                .HasOne(bw => bw.Warehouse)
                .WithMany()
                .HasForeignKey(bw => bw.WarehouseId);

            modelBuilder.Entity<OrderItem>().ToTable("order_item")
            .HasKey(oi => new { oi.OrderId, oi.BookId, oi.WarehouseId });

            modelBuilder.Entity<OrderItem>()
                .HasOne(oi => oi.Order)
                .WithMany(o => o.OrderItems)
                .HasForeignKey(oi => oi.OrderId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<OrderItem>()
                .HasOne(oi => oi.Book)
                .WithMany()
                .HasForeignKey(oi => oi.BookId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<OrderItem>()
                .HasOne(oi => oi.Warehouse)
                .WithMany()
                .HasForeignKey(oi => oi.WarehouseId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<OrderStatus>().ToTable("order_status");
            modelBuilder.Entity<PaymentStatus>().ToTable("payment_status");
            modelBuilder.Entity<Order>().ToTable("orders");

            modelBuilder.Entity<PaymentDetail>().ToTable("payment_detail")
                .HasOne(pd => pd.Order)
                .WithOne(o => o.PaymentDetail)
                .HasForeignKey<PaymentDetail>(pd => pd.OrderId)
                .OnDelete(DeleteBehavior.Cascade);

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
