using DLB.CrackingPM.Services.Stakeholder.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLB.CrackingPM.Services.Stakeholder.Data.Context
{

        public static class SeedData
        {
            public static void Initialize(IServiceProvider serviceProvider)
            {
                using (var context = new CrackingPMDataContext(serviceProvider.GetRequiredService<DbContextOptions<CrackingPMDataContext>>())) { 

                    if (context.stakeholders.Any())
                    {
                        return;
                    }

                context.stakeholders.AddRange(
                  new Stakeholders
                  {
                      Id = Guid.NewGuid(),
                      Code = "ST01",
                      Name = "Test 1"
                  }); 
                };
            }
        }
    
}
