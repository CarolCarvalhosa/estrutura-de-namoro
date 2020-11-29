using EstruturasDeNamoro.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.Owin.Security.Provider;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EstruturasDeNamoro
{
    public class DashboardContext : DbContext
    {
        public DashboardContext() : base()
        {

        }

        public DbSet<User> DbUser { get; set; }
    }
}