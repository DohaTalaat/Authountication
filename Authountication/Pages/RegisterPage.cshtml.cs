using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Authountication.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Authountication.Page
{
    public class RegisterPageModel : PageModel
    {
        public Register RegisterModel { get; set; }
        public void OnGet()
        {
        }
    }
}
