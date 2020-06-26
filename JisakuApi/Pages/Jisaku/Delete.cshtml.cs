using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using JisakuApi.Models;

namespace JisakuApi.Pages.Jisaku
{
    public class DeleteModel : PageModel
    {
        private readonly FileuploadContext _context;

        public DeleteModel(FileuploadContext context)
        {
            _context = context;
        }

        [BindProperty]
        public FileUpload FileUpload { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            FileUpload = await _context.FileUpload.FirstOrDefaultAsync(m => m.Id == id);

            if (FileUpload == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            FileUpload = await _context.FileUpload.FindAsync(id);

            if (FileUpload != null)
            {
                _context.FileUpload.Remove(FileUpload);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
