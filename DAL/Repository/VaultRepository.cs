using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DAL
{
	class VaultRepository : IRepository<Vault>
	{
		VaultContext db;
		public VaultRepository(VaultContext context)
		{
			db = context;
		}
		public IEnumerable<Vault> GetList()
		{
			return db.Vault;
		}
		public void Create(Vault item)
		{
			db.Vault.Add(item);
		}
		public void Delete(int id)
		{
			Vault vaulttodelete = db.Vault.Find(id);
			if (vaulttodelete != null)
				db.Vault.Remove(vaulttodelete);
		}
		public Vault GetItem(int id)
		{
			return db.Vault.Find(id);
		}
		public void Update(Vault item)
		{
			db.Entry(item).State = EntityState.Modified;
		}
		/*public void Save()
		{
			db.SaveChanges();
		}
		private bool disposed = false;
		public virtual void Dispose(bool disposing)
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
		}*/
	}
}