using Microsoft.AspNet.Identity.EntityFramework;
using SinbaWebUI.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SinbaWebUI.Identity
{
    public class IdentityDataContext: IdentityDbContext<ApplicationUser>
    {
        public IdentityDataContext() : base("dataConnection")
        {
            
        }
    }
}