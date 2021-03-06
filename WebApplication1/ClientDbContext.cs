﻿namespace WebApplication1
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ClientDbContext : DbContext
    {
        public ClientDbContext()
            : base("name=ClientDbContext")
        {
            base.Configuration.LazyLoadingEnabled = false;
            base.Configuration.ProxyCreationEnabled = false;
        }

        public virtual DbSet<Hjælpere> Hjælpere { get; set; }
        public virtual DbSet<Kunder> Kunders { get; set; }
        public virtual DbSet<Opgaver> Opgavers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Hjælpere>()
                .Property(e => e.Navn)
                .IsUnicode(false);

            modelBuilder.Entity<Hjælpere>()
                .Property(e => e.TelefonNummer)
                .IsUnicode(false);

            modelBuilder.Entity<Hjælpere>()
                .Property(e => e.Kodeord)
                .IsUnicode(false);

            modelBuilder.Entity<Hjælpere>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Kunder>()
                .Property(e => e.KundeNavn)
                .IsUnicode(false);

            modelBuilder.Entity<Kunder>()
                .Property(e => e.KundeNummer)
                .IsUnicode(false);

            modelBuilder.Entity<Kunder>()
                .Property(e => e.KundeAdresse)
                .IsUnicode(false);

            modelBuilder.Entity<Kunder>()
                .HasMany(e => e.Opgavers)
                .WithRequired(e => e.Kunder)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Opgaver>()
                .Property(e => e.Beskrivelse)
                .IsUnicode(false);
        }
    }
}
