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
    public class HoaDonConfigs : IEntityTypeConfiguration<HoaDon>
    {
        public void Configure(EntityTypeBuilder<HoaDon> builder)
        {
            builder.ToTable("HoaDon");
            builder.HasKey(p => p.ID);
            // config khóa ngoại
            builder.HasOne(x=>x.User).WithMany(x=>x.HoaDons).HasForeignKey(x=>x.UserID).HasConstraintName("FK_User_HoaDon");
            //  Với mỗi User sẽ có nhiều hóa đơn , khóa ngoại là cột UserID Nối với bảng User 
            // tên của khóa ngoại là FK_User_HD
        }
    }
}
