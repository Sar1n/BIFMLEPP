using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.UnitOfWork
{
	class UnitOfWork : IDisposable
	{
		private VaultContext db;
		private UserRepository userRepository;
		private VaultRepository vaultRepository;
		public UserRepository Users
		{
			get
			{
				if (userRepository == null)
					userRepository = new UserRepository(db);
				return userRepository;
			}
		}
		public VaultRepository Vault
		{
			get
			{
				if (vaultRepository == null)
					vaultRepository = new VaultRepository(db);
				return vaultRepository;
			}
		}
		public void Save()
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
		}
	}
}
