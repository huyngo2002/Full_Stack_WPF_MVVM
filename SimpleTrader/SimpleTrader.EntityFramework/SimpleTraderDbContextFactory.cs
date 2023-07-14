﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTrader.EntityFramework
{
    public class SimpleTraderDbContextFactory : IDesignTimeDbContextFactory<SimpleTraderDbContext>
    {
        public SimpleTraderDbContext CreateDbContext(string[] arg = null)
        {
            var options = new DbContextOptionsBuilder<SimpleTraderDbContext>();
            options.UseSqlServer("Server=.\\SQLEXPRESS;Database=SimpleTraderDB;Trusted_Connection=True;");
            return new SimpleTraderDbContext(options.Options);
        }
    }
}
