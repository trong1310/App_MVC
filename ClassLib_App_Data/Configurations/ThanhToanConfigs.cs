using ClassLib_App_Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib_App_Data.Configurations
{
    public class ThanhToanConfigs : IEntityTypeConfiguration<ThanhToan>
    {
        public void Configure(EntityTypeBuilder<ThanhToan> builder)
        {
            builder.ToTable("ThanhToan");
            builder.HasKey(x => x.ID);
            builder.HasOne(x=>x.HoaDon).WithMany(x=>x.ThanhToans).HasForeignKey(x=>x.HoaDonID)
                .HasConstraintName("FK_HoaDon_ThanhToan");
            builder.HasOne(x => x.PhuongThucThanhToan).WithMany(x => x.ThanhToans).HasForeignKey(x => x.PhuongThucID)
                .HasConstraintName("FK_PhuongThucThanhToan_ThanhToan");
        }
    }
}
