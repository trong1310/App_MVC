using System;
using System.Collections.Generic;
using System.Reflection;
using Microsoft.EntityFrameworkCore;

namespace ClassLib_App_Data.Models;

public partial class DemoCodeFisrtContext : DbContext
{
    public DemoCodeFisrtContext()
    {
    }

    public DemoCodeFisrtContext(DbContextOptions<DemoCodeFisrtContext> options)
        : base(options)
    {
    }
    // db set de tro toi moi bang
    public DbSet<HoaDon> HoaDons { get; set; }
    public DbSet<User> Users { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-HG74371\\SQLEXPRESS;Database=DemoCodeFisrt;Trusted_Connection=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
