using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MegaDesk_ASP.NET_Core_Razor_Web_Application.Data;
using MegaDesk_ASP.NET_Core_Razor_Web_Application.Models;

namespace MegaDesk_ASP.NET_Core_Razor_Web_Application.Pages.Desks
{
    public class IndexModel : PageModel
    {
        private readonly MegaDesk_ASP.NET_Core_Razor_Web_Application.Data.MegaDesk_ASPNET_Core_Razor_Web_ApplicationContext _context;

        public IndexModel(MegaDesk_ASP.NET_Core_Razor_Web_Application.Data.MegaDesk_ASPNET_Core_Razor_Web_ApplicationContext context)
        {
            _context = context;
        }

        public IList<Desk> Desk { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Desk != null)
            {
                Desk = await _context.Desk.ToListAsync();
            }
        }
    }
}
