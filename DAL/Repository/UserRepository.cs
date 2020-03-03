using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DAL
{
	class UserRepository : IRepository<Users>
	{
		private UsersContext db;
		public UserRepository()
		{
			db = new UsersContext();
		}
		public IEnumerable<Users> GetList()
		{
			return db.Users;
		}
		public void Create(Users item)
		{
			db.Users.Add(item);
		}
		public void Delete(int id)
		{
			Users usertodelete = db.Users.Find(id);
			if (usertodelete != null)
				db.Users.Remove(usertodelete);
		}
		public Users GetItem(int id)
		{
			return db.Users.Find(id);
		}
		public void Update(Users item)
		{
			db.Entry(item).State = EntityState.Modified;
		}
		public void Save()
		{
			db.SaveChanges();
		}
		private bool disposed = false;
		public virtual void Dispose (bool disposing)
		{
			if (!disposed)
				if (disposing)
					db.Dispose();
			disposed = true;
		}
		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}
	}
}
