using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DAL
{
	class UsersContext : DbContext
	{
		public UsersContext() : base("DbConnection")
		{
		}
		public DbSet<Users> Users { get; set; }
	}
}