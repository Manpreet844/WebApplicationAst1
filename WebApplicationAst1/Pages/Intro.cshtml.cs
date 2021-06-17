using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplicationAst1.Pages
{
    public class IntroModel : PageModel
    {
        public void OnGet()
        {
            if (firstNum > 0 && secondNum > 0)
            {
                Result = firstNum * secondNum;
                ResultSet = true;
            }
        }
        [FromQuery(Name = "firstNum")]

            public int firstNum { get; set; }

            [FromQuery(Name = "secondNum")]

            public int secondNum { get; set; }

            public int Result { get; set; }

            public bool ResultSet { get; set; }
       
    }
}
