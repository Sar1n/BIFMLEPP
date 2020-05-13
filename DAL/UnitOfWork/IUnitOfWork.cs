using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Repository;
using DAL.Models;

namespace DAL.UnitOfWork
{
	public interface IUnitOfWork : IDisposable
	{
		UserRepository User { get; }
		PostRepository Post { get; }
		CommentRepository Comment { get; }
		void Save();
	}
}
