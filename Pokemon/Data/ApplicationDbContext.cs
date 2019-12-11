using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Pokemon.Models;

namespace Pokemon.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Color> Color { get; set; }
        public DbSet<Gender> Gender { get; set; }
        public DbSet<PokeType> PokeType { get; set; }
        public DbSet<Models.Pokemon> Pokemon { get; set; }
        public DbSet<Go> Go { get; set; }
        public DbSet<PokemonType> PokemonType { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<PokemonType>()
                .HasKey(ga => new { ga.PokemonsId, ga.PokeTypeId });
            modelBuilder.Entity<PokemonType>()
                .HasOne(bc => bc.Pokemon)
                .WithMany(c => c.PokemonType)
                .HasForeignKey(bc => bc.PokemonsId);
            modelBuilder.Entity<PokemonType>()
                .HasOne(bc => bc.PokeType)
                .WithMany(b => b.PokemonType)
                .HasForeignKey(bc => bc.PokeTypeId);
        }
    }
}
