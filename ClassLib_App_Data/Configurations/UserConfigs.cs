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
    public class UserConfigs : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            // Thực hiện các config trên entity
            builder.ToTable("Users"); // đặt tên bảng
            // xác định khóa chính
            // builder.HasNoKey(); // không khóa
            builder.HasKey(x => x.ID);
            // thiết lập thuộc tính
            builder.HasOne(x => x.Roles).WithOne(x => x.Users).HasForeignKey(x => x.RolesID);
            builder.Property(x => x.Name).HasColumnName("Name").HasColumnType("nvarchar(50)");
            builder.Property(x=>x.Address).HasColumnName("Address").HasMaxLength(50).IsFixedLength().IsUnicode(true); // nvarchar50
            builder.Property(x => x.UserName).IsRequired(); // not null
            
        }
    }
}
