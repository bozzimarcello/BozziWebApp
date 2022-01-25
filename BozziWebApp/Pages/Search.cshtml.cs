using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BozziWebApp.Pages
{
    public class SearchModel : PageModel
    {
        public string dati { get; set; }
        public void OnGet(string query)
        {
            dati = query;
        }
    }
}
