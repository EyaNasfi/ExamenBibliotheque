using AM.ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Infrastructure.Configurations
{
    public class PretConfig : IEntityTypeConfiguration<PretLivre>
    {
        public void Configure(EntityTypeBuilder<PretLivre> builder)
        {
           
            builder.HasOne(p=>p.MyLivre).WithMany(p=>p.prets).HasForeignKey(p => p.LivreFk).OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(p=>p.MyAbonne).WithMany(p=>p.Prets).HasForeignKey(p => p.AbonneFk).OnDelete(DeleteBehavior.Cascade);
            builder.HasKey(p=> new { p.AbonneFk, p.LivreFk ,p.DateDebut});
        }
    }
}
