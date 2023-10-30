using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MegaDesk_ASP.NET_Core_Razor_Web_Application.Data;
using MegaDesk_ASP.NET_Core_Razor_Web_Application.Models;

namespace MegaDesk_ASP.NET_Core_Razor_Web_Application.Pages.Desks
{
    public class CreateModel : PageModel
    {
        private readonly MegaDesk_ASP.NET_Core_Razor_Web_Application.Data.MegaDesk_ASPNET_Core_Razor_Web_ApplicationContext _context;

        public CreateModel(MegaDesk_ASP.NET_Core_Razor_Web_Application.Data.MegaDesk_ASPNET_Core_Razor_Web_ApplicationContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Desk Desk { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Desk == null || Desk == null)
            {
                return Page();
            }

            _context.Desk.Add(Desk);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
