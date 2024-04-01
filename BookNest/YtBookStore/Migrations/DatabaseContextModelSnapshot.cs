
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using YtBookStore.Models.Domain;

#nullable disable

namespace YtBookStore.Migrations
{
    // Model snapshot for database context
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        // Method to build the model for database context
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            // Configuration for the 'Author' entity
            modelBuilder.Entity<Author>(b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                b.Property<string>("AuthorName")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.HasKey("Id");

                b.ToTable("Author");
            });

            // Configuration for the 'Book' entity
            modelBuilder.Entity<Book>(b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                b.Property<int>("AuthorId")
                    .HasColumnType("int");

                b.Property<int>("GenreId")
                    .HasColumnType("int");

                b.Property<string>("Isbn")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<int>("PubhlisherId")
                    .HasColumnType("int");

                b.Property<string>("Title")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<int>("TotalPages")
                    .HasColumnType("int");

                b.HasKey("Id");

                b.ToTable("Book");
            });

            // Configuration for the 'Genre' entity
            modelBuilder.Entity<Genre>(b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                b.Property<string>("Name")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.HasKey("Id");

                b.ToTable("Genre");
            });

            // Configuration for the 'Publisher' entity
            modelBuilder.Entity<Publisher>(b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                b.Property<string>("PublisherName")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.HasKey("Id");

                b.ToTable("Publisher");
            });
#pragma warning restore 612, 618
        }
    }
}
