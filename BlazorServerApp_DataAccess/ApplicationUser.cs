using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorServerApp_DataAccess
{
    public class ApplicationUser : IdentityUser
    {
        public string Access { get; set; }
    }
}
