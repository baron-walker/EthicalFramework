using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EthicalFramework.Views.Shared
{
    public class ResultsFramPartialModel : PageModel
    {
        public string Name { get; set; }

        public string Description { get; set; }
        public void OnGet()
        {

        }
    }
}
