using DLB.CrackingPM.Services.Stakeholder.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLB.CrackingPM.Services.Stakeholder.Data.Context
{
    public class CrackingPMDataContext: DbContext
    {
        public DbSet<Stakeholders> stakeholders { get; set; }
        public CrackingPMDataContext(DbContextOptions<CrackingPMDataContext> options) :base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Stakeholders>().Property(p => p.Code).HasMaxLength(50);

            modelBuilder.Entity<Stakeholders>().Property(p => p.Name).HasMaxLength(50);

            base.OnModelCreating(modelBuilder); 
        }
    }
}
