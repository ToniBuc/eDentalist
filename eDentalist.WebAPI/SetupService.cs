using eDentalist.WebAPI.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eDentalist.WebAPI
{
    public class SetupService
    {
        public static void Seed(eDentalistDbContext context)
        {
            context.Database.Migrate();
        }
    }
}
