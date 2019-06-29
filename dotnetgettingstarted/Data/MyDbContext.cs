using System;
using dotnetgettingstarted.Models;
using Microsoft.EntityFrameworkCore;

namespace dotnetgettingstarted.Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options): base(options)
        {

        }

        public DbSet<ValueModel> Values { get; set; }
    }
}
