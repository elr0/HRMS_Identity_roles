using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRMS_Identity.Models
{
    public class RoleConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
            new IdentityRole
            {
                Name = "Pracownik HR",
                //NormalizedName = "PRACOWNIK_HR"
            },
            new IdentityRole
            {
                Name = "Administrator",
                //NormalizedName = "ADMINISTRATOR"
            },
            new IdentityRole
            {
                Name = "Manager",
                //NormalizedName = "MANAGER"
            },
            new IdentityRole
            {
                Name = "Pracownik",
                //NormalizedName = "ADMINISTRATOR"
            });
        }
    }
}
