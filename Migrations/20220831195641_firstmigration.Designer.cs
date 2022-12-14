// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace NotesMinimalAPI.Migrations
{
    [DbContext(typeof(DataDb))]
    [Migration("20220831195641_firstmigration")]
    partial class firstmigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Data", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<decimal>("dewPoint")
                        .HasColumnType("numeric");

                    b.Property<decimal>("gust")
                        .HasColumnType("numeric");

                    b.Property<byte>("humidity")
                        .HasColumnType("smallint");

                    b.Property<decimal>("precipitationAcc")
                        .HasColumnType("numeric");

                    b.Property<decimal>("precipitationRate")
                        .HasColumnType("numeric");

                    b.Property<decimal>("pressure")
                        .HasColumnType("numeric");

                    b.Property<decimal>("solarIrradiation")
                        .HasColumnType("numeric");

                    b.Property<string>("station")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("temperature")
                        .HasColumnType("numeric");

                    b.Property<string>("timeStamp")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("uv")
                        .HasColumnType("numeric");

                    b.Property<string>("windDirection")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("windSpeed")
                        .HasColumnType("numeric");

                    b.HasKey("id");

                    b.ToTable("Logs");
                });
#pragma warning restore 612, 618
        }
    }
}
