﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OnlineStore.Domain.Entities;

namespace OnlineStore.DataAccess.Common
{
    public class MutableOnlineStoreDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, int>
    {

        public MutableOnlineStoreDbContext(DbContextOptions<MutableOnlineStoreDbContext> options)
            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(MutableOnlineStoreDbContext).Assembly);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        public bool HasPendingChanges()
        {
            return ChangeTracker.HasChanges();
        }
    }
}
