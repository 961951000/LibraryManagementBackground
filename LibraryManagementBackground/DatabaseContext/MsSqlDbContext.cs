using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementBackground.DatabaseContext
{
    public class MsSqlDbContext : DbContext
    {
        public MsSqlDbContext() : base("name=MsSqlDbContext") { }
    }
}
