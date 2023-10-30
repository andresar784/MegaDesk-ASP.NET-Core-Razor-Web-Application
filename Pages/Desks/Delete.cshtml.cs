﻿using System;
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
    public class DeleteModel : PageModel
    {
        private readonly MegaDesk_ASP.NET_Core_Razor_Web_Application.Data.MegaDesk_ASPNET_Core_Razor_Web_ApplicationContext _context;

        public DeleteModel(MegaDesk_ASP.NET_Core_Razor_Web_Application.Data.MegaDesk_ASPNET_Core_Razor_Web_ApplicationContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Desk Desk { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Desk == null)
            {
                return NotFound();
            }

            var desk = await _context.Desk.FirstOrDefaultAsync(m => m.Id == id);

            if (desk == null)
            {
                return NotFound();
            }
            else 
            {
                Desk = desk;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Desk == null)
            {
                return NotFound();
            }
            var desk = await _context.Desk.FindAsync(id);

            if (desk != null)
            {
                Desk = desk;
                _context.Desk.Remove(Desk);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
