using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DAL
{
	class UserRepository : IRepository<User>
	{
		private PostContext db;
		public UserRepository(PostContext context)
		{
			db = context;
		}
		public IEnumerable<User> GetList()
		{
			return db.User;
		}
		public void Create(User item)
		{
			db.User.Add(item);
		}
		public void Delete(int id)
		{
			User usertodelete = db.User.Find(id);
			if (usertodelete != null)
				db.User.Remove(usertodelete);
		}
		public User GetItem(int id)
		{
			return db.User.Find(id);
		}
		public void Update(User item)
		{
			db.Entry(item).State = EntityState.Modified;
		}
	}
}
