using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace JeuNim.Models;

public partial class NesContext : DbContext
{
    public NesContext()
    {
    }

    public NesContext(DbContextOptions<NesContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Coup> Coups { get; set; }

    public virtual DbSet<Joueur> Joueurs { get; set; }

    public virtual DbSet<Participant> Participants { get; set; }

    public virtual DbSet<Partie> Parties { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=192.168.29.13,1433\\MSSQLSERVER;User ID=sa;Password=erty64%;Database=NES;TrustServerCertificate=true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Coup>(entity =>
        {
            entity.HasKey(e => e.IdCoup).HasName("PK__Coup__80B3650A55939704");

            entity.ToTable("Coup");

            entity.Property(e => e.IdCoup).HasColumnName("idCoup");
            entity.Property(e => e.IdParticipant).HasColumnName("idParticipant");
            entity.Property(e => e.NbBaton).HasColumnName("nbBaton");
            entity.Property(e => e.Ordre).HasColumnName("ordre");

            entity.HasOne(d => d.IdParticipantNavigation).WithMany(p => p.Coups)
                .HasForeignKey(d => d.IdParticipant)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Coup__idParticip__52593CB8");
        });

        modelBuilder.Entity<Joueur>(entity =>
        {
            entity.HasKey(e => e.IdJoueur).HasName("PK__Joueur__64E2661B85E36F14");

            entity.ToTable("Joueur");

            entity.HasIndex(e => e.Login, "UQ__Joueur__7838F27284010409").IsUnique();

            entity.Property(e => e.IdJoueur).HasColumnName("idJoueur");
            entity.Property(e => e.Login)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("login");
            entity.Property(e => e.MotDePasse)
                .IsUnicode(false)
                .HasColumnName("motDePasse");
        });

        modelBuilder.Entity<Participant>(entity =>
        {
            entity.HasKey(e => e.IdParticipant).HasName("PK__Particip__74DE0E4E2C830808");

            entity.ToTable("Participant");

            entity.Property(e => e.IdParticipant).HasColumnName("idParticipant");
            entity.Property(e => e.ACommence).HasColumnName("aCommence");
            entity.Property(e => e.AGagne).HasColumnName("aGagne");
            entity.Property(e => e.IdJoueur).HasColumnName("idJoueur");
            entity.Property(e => e.IdPartie).HasColumnName("idPartie");

            entity.HasOne(d => d.IdJoueurNavigation).WithMany(p => p.Participants)
                .HasForeignKey(d => d.IdJoueur)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Participa__idJou__4F7CD00D");

            entity.HasOne(d => d.IdPartieNavigation).WithMany(p => p.Participants)
                .HasForeignKey(d => d.IdPartie)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Participa__idPar__4E88ABD4");
        });

        modelBuilder.Entity<Partie>(entity =>
        {
            entity.HasKey(e => e.IdPartie).HasName("PK__Partie__EE3714C579FC5FFA");

            entity.ToTable("Partie");

            entity.Property(e => e.IdPartie).HasColumnName("idPartie");
            entity.Property(e => e.DatePartie).HasColumnName("datePartie");
            entity.Property(e => e.EstCommence).HasColumnName("estCommence");
            entity.Property(e => e.EstTermine).HasColumnName("estTermine");
            entity.Property(e => e.NbBaton).HasColumnName("nbBaton");
            entity.Property(e => e.Numero)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("numero");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
