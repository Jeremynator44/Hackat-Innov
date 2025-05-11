using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Scaffolding.Internal;

namespace ApplicationC.Entities;

public partial class HackatInnovContext : DbContext
{
    public HackatInnovContext()
    {
    }

    public HackatInnovContext(DbContextOptions<HackatInnovContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Administrateur> Administrateurs { get; set; }

    public virtual DbSet<Commentaire> Commentaires { get; set; }

    public virtual DbSet<Equipe> Equipes { get; set; }

    public virtual DbSet<EventsType> EventsTypes { get; set; }

    public virtual DbSet<Hackathon> Hackathons { get; set; }

    public virtual DbSet<Inscrire> Inscrires { get; set; }

    public virtual DbSet<Log> Logs { get; set; }

    public virtual DbSet<Membre> Membres { get; set; }

    public virtual DbSet<Migration> Migrations { get; set; }

    public virtual DbSet<Organisateur> Organisateurs { get; set; }

    public virtual DbSet<Token> Tokens { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySql("server=192.168.150.54;port=5001;user=ap3_bjcode;password=BwfCO3xH;database=hackat_innov", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.4.5-mysql"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_0900_ai_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<Administrateur>(entity =>
        {
            entity.HasKey(e => e.Idadministrateur).HasName("PRIMARY");

            entity
                .ToTable("ADMINISTRATEUR")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_bin");

            entity.Property(e => e.Idadministrateur).HasColumnName("idadministrateur");
            entity.Property(e => e.Codedesactivation2fa)
                .HasMaxLength(255)
                .HasColumnName("codedesactivation_2fa");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .HasColumnName("email");
            entity.Property(e => e.Enable2fa).HasColumnName("enable_2fa");
            entity.Property(e => e.Google2faSecret)
                .HasColumnType("text")
                .HasColumnName("google2fa_secret");
            entity.Property(e => e.Motpasse)
                .HasMaxLength(255)
                .HasColumnName("motpasse");
            entity.Property(e => e.Nom)
                .HasMaxLength(128)
                .HasColumnName("nom");
            entity.Property(e => e.Prenom)
                .HasMaxLength(128)
                .HasColumnName("prenom");
            entity.Property(e => e.Recuperation2fa)
                .HasMaxLength(255)
                .HasColumnName("recuperation_2fa");
        });

        modelBuilder.Entity<Commentaire>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("COMMENTAIRES")
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Equipe, "fk_commentaires_equipe");

            entity.HasIndex(e => e.Hackathon, "fk_commentaires_hackathon");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Contenucommentaires)
                .HasMaxLength(2000)
                .HasColumnName("contenucommentaires");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.Equipe).HasColumnName("equipe");
            entity.Property(e => e.Hackathon).HasColumnName("hackathon");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<Equipe>(entity =>
        {
            entity.HasKey(e => e.Idequipe).HasName("PRIMARY");

            entity.ToTable("EQUIPE");

            entity.HasIndex(e => e.Login, "ulogin").IsUnique();

            entity.Property(e => e.Idequipe).HasColumnName("idequipe");
            entity.Property(e => e.Codedesactivation2fa)
                .HasMaxLength(255)
                .HasColumnName("codedesactivation_2fa");
            entity.Property(e => e.Enable2fa).HasColumnName("enable_2fa");
            entity.Property(e => e.Google2faSecret)
                .HasColumnType("text")
                .HasColumnName("google2fa_secret");
            entity.Property(e => e.Imagepath)
                .HasMaxLength(2555)
                .HasDefaultValueSql("'/img/anonyme.png'")
                .HasColumnName("imagepath");
            entity.Property(e => e.Lienprototype)
                .HasMaxLength(255)
                .HasColumnName("lienprototype");
            entity.Property(e => e.Login).HasColumnName("login");
            entity.Property(e => e.Nomequipe)
                .HasMaxLength(50)
                .HasColumnName("nomequipe");
            entity.Property(e => e.Password)
                .HasMaxLength(255)
                .HasColumnName("password");
            entity.Property(e => e.Recuperation2fa)
                .HasMaxLength(255)
                .HasColumnName("recuperation_2fa");
        });

        modelBuilder.Entity<EventsType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("EVENTS_TYPE")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<Hackathon>(entity =>
        {
            entity.HasKey(e => e.Idhackathon).HasName("PRIMARY");

            entity.ToTable("HACKATHON");

            entity.HasIndex(e => e.Idorganisateur, "hackathon_ibfk_1");

            entity.Property(e => e.Idhackathon).HasColumnName("idhackathon");
            entity.Property(e => e.Affiche)
                .HasMaxLength(255)
                .HasColumnName("affiche");
            entity.Property(e => e.Conditions)
                .HasMaxLength(255)
                .HasColumnName("conditions");
            entity.Property(e => e.Datebutoir)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("datetime")
                .HasColumnName("datebutoir");
            entity.Property(e => e.Dateheuredebuth)
                .HasColumnType("datetime")
                .HasColumnName("dateheuredebuth");
            entity.Property(e => e.Dateheurefinh)
                .HasColumnType("datetime")
                .HasColumnName("dateheurefinh");
            entity.Property(e => e.EstArchive).HasColumnName("est_archive");
            entity.Property(e => e.Idorganisateur).HasColumnName("idorganisateur");
            entity.Property(e => e.Lieu)
                .HasMaxLength(128)
                .HasColumnName("lieu");
            entity.Property(e => e.Nbplacemax).HasColumnName("nbplacemax");
            entity.Property(e => e.Objectifs)
                .HasMaxLength(255)
                .HasColumnName("objectifs");
            entity.Property(e => e.Thematique)
                .HasMaxLength(30)
                .HasColumnName("thematique");
            entity.Property(e => e.Ville)
                .HasMaxLength(128)
                .HasColumnName("ville");

            entity.HasOne(d => d.IdorganisateurNavigation).WithMany(p => p.Hackathons)
                .HasForeignKey(d => d.Idorganisateur)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hackathon_ibfk_1");
        });

        modelBuilder.Entity<Inscrire>(entity =>
        {
            entity.HasKey(e => new { e.Idhackathon, e.Idequipe })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("INSCRIRE");

            entity.HasIndex(e => e.Idequipe, "i_fk_inscrire_equipe1");

            entity.HasIndex(e => e.Idhackathon, "i_fk_inscrire_hackathon1");

            entity.Property(e => e.Idhackathon).HasColumnName("idhackathon");
            entity.Property(e => e.Idequipe).HasColumnName("idequipe");
            entity.Property(e => e.Datearchivage).HasColumnName("datearchivage");
            entity.Property(e => e.Datedesinscription).HasColumnName("datedesinscription");
            entity.Property(e => e.Dateinscription).HasColumnName("dateinscription");

            entity.HasOne(d => d.IdequipeNavigation).WithMany(p => p.Inscrires)
                .HasForeignKey(d => d.Idequipe)
                .HasConstraintName("inscrire_ibfk_2");

            entity.HasOne(d => d.IdhackathonNavigation).WithMany(p => p.Inscrires)
                .HasForeignKey(d => d.Idhackathon)
                .HasConstraintName("inscrire_ibfk_1");
        });

        modelBuilder.Entity<Log>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("LOGS")
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.EventType, "event_type");

            entity.HasIndex(e => e.UserId, "user_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.Details)
                .HasMaxLength(255)
                .HasColumnName("details");
            entity.Property(e => e.EventType).HasColumnName("event_type");
            entity.Property(e => e.IpAddress)
                .HasMaxLength(255)
                .HasColumnName("ip_address");
            entity.Property(e => e.Results).HasColumnName("results");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
            entity.Property(e => e.UserAgent)
                .HasMaxLength(255)
                .HasColumnName("user_agent");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.EventTypeNavigation).WithMany(p => p.Logs)
                .HasForeignKey(d => d.EventType)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("LOGS_ibfk_2");

            entity.HasOne(d => d.User).WithMany(p => p.Logs)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("LOGS_ibfk_1");
        });

        modelBuilder.Entity<Membre>(entity =>
        {
            entity.HasKey(e => e.Idmembre).HasName("PRIMARY");

            entity.ToTable("MEMBRE");

            entity.HasIndex(e => e.Email, "email").IsUnique();

            entity.HasIndex(e => e.Idequipe, "i_fk_membre_equipe1");

            entity.Property(e => e.Idmembre).HasColumnName("idmembre");
            entity.Property(e => e.Datenaissance).HasColumnName("datenaissance");
            entity.Property(e => e.Email).HasColumnName("email");
            entity.Property(e => e.Idequipe).HasColumnName("idequipe");
            entity.Property(e => e.Lienportfolio)
                .HasMaxLength(255)
                .HasColumnName("lienportfolio");
            entity.Property(e => e.Nom)
                .HasMaxLength(255)
                .HasColumnName("nom");
            entity.Property(e => e.Prenom)
                .HasMaxLength(255)
                .HasColumnName("prenom");
            entity.Property(e => e.Telephone)
                .HasMaxLength(10)
                .HasColumnName("telephone");

            entity.HasOne(d => d.IdequipeNavigation).WithMany(p => p.Membres)
                .HasForeignKey(d => d.Idequipe)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("membre_ibfk_2");
        });

        modelBuilder.Entity<Migration>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("migrations")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Batch).HasColumnName("batch");
            entity.Property(e => e.Migration1)
                .HasMaxLength(255)
                .HasColumnName("migration");
        });

        modelBuilder.Entity<Organisateur>(entity =>
        {
            entity.HasKey(e => e.Idorganisateur).HasName("PRIMARY");

            entity
                .ToTable("ORGANISATEUR")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_bin");

            entity.Property(e => e.Idorganisateur).HasColumnName("idorganisateur");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .HasColumnName("email");
            entity.Property(e => e.Nom)
                .HasMaxLength(128)
                .HasColumnName("nom");
            entity.Property(e => e.Prenom)
                .HasMaxLength(128)
                .HasColumnName("prenom");
        });

        modelBuilder.Entity<Token>(entity =>
        {
            entity.HasKey(e => e.Uuid).HasName("PRIMARY");

            entity.ToTable("TOKEN");

            entity.HasIndex(e => e.Idequipe, "i_fk_token_equipe1");

            entity.Property(e => e.Uuid)
                .HasMaxLength(128)
                .HasColumnName("uuid");
            entity.Property(e => e.Idequipe).HasColumnName("idequipe");

            entity.HasOne(d => d.IdequipeNavigation).WithMany(p => p.Tokens)
                .HasForeignKey(d => d.Idequipe)
                .HasConstraintName("token_ibfk_1");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
