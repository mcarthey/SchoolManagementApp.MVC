using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SchoolManagementApp.MVC.Data;

    public class SchoolManagementDbConnection : DbContext
    {
        public SchoolManagementDbConnection (DbContextOptions<SchoolManagementDbConnection> options)
            : base(options)
        {
        }

        public DbSet<SchoolManagementApp.MVC.Data.Course> Course { get; set; } = default!;
    }
