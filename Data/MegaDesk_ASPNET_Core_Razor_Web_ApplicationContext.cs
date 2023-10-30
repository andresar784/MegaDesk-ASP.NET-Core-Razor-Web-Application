using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MegaDesk_ASP.NET_Core_Razor_Web_Application.Models;

namespace MegaDesk_ASP.NET_Core_Razor_Web_Application.Data
{
    public class MegaDesk_ASPNET_Core_Razor_Web_ApplicationContext : DbContext
    {
        public MegaDesk_ASPNET_Core_Razor_Web_ApplicationContext (DbContextOptions<MegaDesk_ASPNET_Core_Razor_Web_ApplicationContext> options)
            : base(options)
        {
        }

        public DbSet<MegaDesk_ASP.NET_Core_Razor_Web_Application.Models.Desk> Desk { get; set; } = default!;
    }
}
