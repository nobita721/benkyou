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
    public class IndexModel : PageModel
    {
        private readonly FileuploadContext _context;

        public IndexModel(FileuploadContext context)
        {
            _context = context;
        }

        public IList<FileUpload> FileUpload { get;set; }

        public async Task OnGetAsync()
        {
            FileUpload = await _context.FileUpload.ToListAsync();
        }
    }
}
