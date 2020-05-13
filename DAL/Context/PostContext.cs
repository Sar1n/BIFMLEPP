using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using DAL.Models;

namespace DAL.Context
{
	public class PostContext : DbContext
	{
		public PostContext(string connectionString) : base("DbConnection")
		{
		}
		public DbSet<Post> Post { get; set; }
		public DbSet<User> User { get; set; }
		public DbSet<Comment> Comment { get; set; }
	}
}