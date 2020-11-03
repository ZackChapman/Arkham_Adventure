using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ArkhamAdventure.Models
{
    public partial class ArkhamAdventureDBContext : DbContext
    {
        public ArkhamAdventureDBContext()
        {
        }

        public ArkhamAdventureDBContext(DbContextOptions<ArkhamAdventureDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Images> Images { get; set; }
        public virtual DbSet<NavButtons> NavButtons { get; set; }
        public virtual DbSet<NavOptions> NavOptions { get; set; }
        public virtual DbSet<Scenario> Scenario { get; set; }

        //public virtual DbSet<ScenarioImages> ScenarioImages { get; set; }
        //public virtual DbSet<Player> Player { get; set; }
        //public virtual DbSet<ArkhamAdventure.Models.ViewModels.ArkhamAdventureVM> ArkhamAdventureVM { get; set; }

        //        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //        {
        //            if (!optionsBuilder.IsConfigured)
        //            {
        //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
        //                optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=ArkhamAdventureDB;MultipleActiveResultSets=true");
        //            }
        //        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    //modelBuilder.Entity<Images>(entity =>
        //    //{
        //    //    entity.HasKey(e => e.ImageId);

        //    //    entity.Property(e => e.ImageId)
        //    //        .HasColumnName("ImageID")
        //    //        .ValueGeneratedNever();
        //    //});

        //    //modelBuilder.Entity<NavButtons>(entity =>
        //    //{
        //    //    entity.HasKey(e => e.NavigationId);

        //    //    entity.Property(e => e.NavigationId)
        //    //        .HasColumnName("NavigationID")
        //    //        .ValueGeneratedNever();

        //    //    entity.Property(e => e.ButtonId1).HasColumnName("ButtonID1");

        //    //    entity.Property(e => e.ButtonId2).HasColumnName("ButtonID2");

        //    //    entity.Property(e => e.ButtonId3).HasColumnName("ButtonID3");

        //    //    entity.Property(e => e.ButtonId4).HasColumnName("ButtonID4");

        //    //    entity.HasOne(d => d.ButtonId1Navigation)
        //    //        .WithMany(p => p.NavButtonsButtonId1Navigation)
        //    //        .HasForeignKey(d => d.ButtonId1)
        //    //        .OnDelete(DeleteBehavior.ClientSetNull)
        //    //        .HasConstraintName("FK_NavButtons_Scenario1");

        //    //    entity.HasOne(d => d.ButtonId2Navigation)
        //    //        .WithMany(p => p.NavButtonsButtonId2Navigation)
        //    //        .HasForeignKey(d => d.ButtonId2)
        //    //        .HasConstraintName("FK_NavButtons_Scenario2");

        //    //    entity.HasOne(d => d.ButtonId3Navigation)
        //    //        .WithMany(p => p.NavButtonsButtonId3Navigation)
        //    //        .HasForeignKey(d => d.ButtonId3)
        //    //        .HasConstraintName("FK_NavButtons_Scenario3");

        //    //    entity.HasOne(d => d.ButtonId4Navigation)
        //    //        .WithMany(p => p.NavButtonsButtonId4Navigation)
        //    //        .HasForeignKey(d => d.ButtonId4)
        //    //        .HasConstraintName("FK_NavButtons_Scenario");
        //    //});

        //    //modelBuilder.Entity<NavOptions>(entity =>
        //    //{
        //    //    entity.HasKey(e => e.NavigationId);

        //    //    entity.Property(e => e.NavigationId)
        //    //        .HasColumnName("NavigationID")
        //    //        .ValueGeneratedNever();

        //    //    entity.Property(e => e.Option1)
        //    //        .IsRequired()
        //    //        .HasMaxLength(50);

        //    //    entity.Property(e => e.Option2).HasMaxLength(50);

        //    //    entity.Property(e => e.Option3).HasMaxLength(50);

        //    //    entity.Property(e => e.Option4).HasMaxLength(50);

        //    //    entity.HasOne(d => d.Navigation)
        //    //        .WithOne(p => p.NavOptions)
        //    //        .HasForeignKey<NavOptions>(d => d.NavigationId)
        //    //        .OnDelete(DeleteBehavior.ClientSetNull)
        //    //        .HasConstraintName("FK_NavOptions_NavButtons");
        //    //});

        //    //modelBuilder.Entity<Player>(entity =>
        //    //{
        //    //    entity.HasNoKey();

        //    //    entity.Property(e => e.PlayerId)
        //    //        .HasColumnName("PlayerID")
        //    //        .ValueGeneratedOnAdd();

        //    //    entity.Property(e => e.ScenarioId).HasColumnName("ScenarioID");

        //    //    entity.HasOne(d => d.Scenario)
        //    //        .WithMany()
        //    //        .HasForeignKey(d => d.ScenarioId)
        //    //        .OnDelete(DeleteBehavior.ClientSetNull)
        //    //        .HasConstraintName("FK_Player_Scenario");
        //    //});

        //    //modelBuilder.Entity<Scenario>(entity =>
        //    //{
        //    //    entity.Property(e => e.ScenarioId)
        //    //        .HasColumnName("ScenarioID")
        //    //        .ValueGeneratedNever();

        //    //    entity.Property(e => e.NavigationId).HasColumnName("NavigationID");

        //    //    entity.Property(e => e.StoryText).IsRequired();

        //    //    entity.HasOne(d => d.Navigation)
        //    //        .WithMany(p => p.Scenario)
        //    //        .HasForeignKey(d => d.NavigationId)
        //    //        .OnDelete(DeleteBehavior.ClientSetNull)
        //    //        .HasConstraintName("FK_Scenario_NavButtons");
        //    //});

        //    //modelBuilder.Entity<ScenarioImages>(entity =>
        //    //{
        //    //    entity.HasNoKey();

        //    //    entity.ToTable("scenarioImages");

        //    //    entity.Property(e => e.ImageId).HasColumnName("ImageID");

        //    //    entity.Property(e => e.ScenarioId).HasColumnName("ScenarioID");

        //    //    entity.HasOne(d => d.Image)
        //    //        .WithMany()
        //    //        .HasForeignKey(d => d.ImageId)
        //    //        .OnDelete(DeleteBehavior.ClientSetNull)
        //    //        .HasConstraintName("FK_scenarioImages_Images");

        //    //    entity.HasOne(d => d.Scenario)
        //    //        .WithMany()
        //    //        .HasForeignKey(d => d.ScenarioId)
        //    //        .OnDelete(DeleteBehavior.ClientSetNull)
        //    //        .HasConstraintName("FK_scenarioImages_Scenario");
        //    //});

        //    //OnModelCreatingPartial(modelBuilder);
        //}

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
