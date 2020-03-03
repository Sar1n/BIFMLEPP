using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DAL
{
	class VaultContext : DbContext
	{
		public VaultContext() : base("DbConnection")
		{
		}
		public DbSet<Vault> Vault { get; set; }
	}
}