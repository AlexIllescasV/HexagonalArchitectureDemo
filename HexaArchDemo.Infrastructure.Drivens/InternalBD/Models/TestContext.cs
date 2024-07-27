using Microsoft.EntityFrameworkCore;

namespace HexaArchDemo.Infrastructure.Drivens.InternalBD.Models;

public partial class TestContext : DbContext
{
    public TestContext()
    {
    }

    public TestContext(DbContextOptions<TestContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Departamento> Departamentos { get; set; }

    public virtual DbSet<DepartamentoPersona> DepartamentoPersonas { get; set; }

    public virtual DbSet<Persona> Personas { get; set; }

    //    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
    //        => optionsBuilder.UseSqlServer("Server=ALEXANDER\\SQLEXPRESS;Database=Test;User Id=sa;Password=Prueba@123; Trusted_Connection=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Departamento>(entity =>
        {
            entity.ToTable("departamento", "departamento");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.IdJefeNavigation).WithMany(p => p.Departamentos)
                .HasForeignKey(d => d.IdJefe)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_departamento_persona");
        });

        modelBuilder.Entity<DepartamentoPersona>(entity =>
        {
            entity.ToTable("DepartamentoPersona", "departamento");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.IdDepartamentoNavigation).WithMany(p => p.DepartamentoPersonas)
                .HasForeignKey(d => d.IdDepartamento)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DepartamentoPersona_departamento");

            entity.HasOne(d => d.IdPersonaNavigation).WithMany(p => p.DepartamentoPersonas)
                .HasForeignKey(d => d.IdPersona)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DepartamentoPersona_persona");
        });

        modelBuilder.Entity<Persona>(entity =>
        {
            entity.ToTable("persona", "departamento");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Apellido)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
