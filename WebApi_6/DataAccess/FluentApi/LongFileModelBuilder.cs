using Entities.LongFile;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.FluentApi
{
    internal class LongFileModelBuilder
    {
        internal static void LongFileFluentApi(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LongFile>(entity =>
            {
                entity.Property(e => e.File).HasColumnType("LONGBLOB");
                entity.HasKey(e => e.Id);
            });
                    
        }
    }
}
