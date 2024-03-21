using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ClassLib_App_Data.Models;

public partial class WebMvcContext : DbContext
{
    public WebMvcContext()
    {
    }

    public WebMvcContext(DbContextOptions<WebMvcContext> options)
        : base(options)
    {
    }
    public DbSet<User> Users { get; set; }
    public DbSet<SanPham> sanPhams { get; set; }
    public DbSet <ThanhToan> thanhToans { get; set; }
    public DbSet<Roles> roles { get; set; } 
    public DbSet<PhuongThucThanhToan> phuongThucThanhToans { get; set; }
    public DbSet<HoaDon> hoaDons { get; set; }  
    public DbSet<HoaDonChiTiet>hoaDonChiTiets { get; set; }
    public DbSet<GioHang> gioHangs { get; set; }
    public DbSet<GioHangChiTiet> gioHangChiTiets { get; set; }
    public DbSet<DanhMuc> danhMucs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=vantrong\\SQLEXPRESS;Database=Web_MVC;Trusted_Connection=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
