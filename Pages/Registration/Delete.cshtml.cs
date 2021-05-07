using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;


namespace stevefoyetfinalproject1
{
    public class DeleteModel : PageModel
    {
        private readonly Registration.Models.Context _context;

        public DeleteModel(Registration.Models.Context context)
        {
            _context = context;
        }

        [BindProperty]
        public Patient Patient { get; set; }

       
}
}