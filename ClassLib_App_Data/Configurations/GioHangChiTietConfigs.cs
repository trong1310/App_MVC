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
    public class GioHangChiTietConfigs : IEntityTypeConfiguration<GioHangChiTiet>
    {
        public void Configure(EntityTypeBuilder<GioHangChiTiet> builder)
        {
            builder.ToTable("CartDetail");
            builder.HasKey(x => x.ID);
            builder.HasOne(x => x.GioHang).WithMany(x => x.GioHangChiTiets)
                .HasForeignKey(x => x.CartID).HasConstraintName("FK_GioHang_GioHangChiTiet");
            builder.HasOne(x => x.SanPham).WithMany(x => x.GioHangChiTiets).HasForeignKey(x => x.ProductsID)
                .HasConstraintName("FK_SanPham_GioHangChiTiet");
        }
    }
}
