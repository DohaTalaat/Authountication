using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Authountication.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Authountication.Views.Shared
{
    public class RegisterModel : PageModel
    {
        public Register modell { get; set; }
        public void OnGet()
        {
        }
    }
}
