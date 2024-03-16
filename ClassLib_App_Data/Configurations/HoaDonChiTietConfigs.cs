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
    public class HoaDonChiTietConfigs : IEntityTypeConfiguration<HoaDonChiTiet>
    {
        public void Configure(EntityTypeBuilder<HoaDonChiTiet> builder)
        {
            builder.ToTable("HoaDonChiTiet");
            builder.HasKey(x => x.ID);
            builder.HasOne(x=>x.HoaDon).WithMany(x=>x.HoaDonChiTiets).HasForeignKey(x=>x.HoaDonID).HasConstraintName("FK_HoaDon_HoaDonChiTiet");
            builder.HasOne(x => x.SanPham).WithMany(x => x.HoaDonChiTiets).HasForeignKey(x => x.ProductsID).HasConstraintName("FK_SanPham_HoaDonChiTiet");
        }
    }
}
