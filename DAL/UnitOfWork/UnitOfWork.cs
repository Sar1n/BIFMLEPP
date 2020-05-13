using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.UnitOfWork
{
	class UnitOfWork : IDisposable
	{
		private PostContext db;
		private UserRepository userRepository;
		private PostRepository postRepository;
		private CommentRepository commentRepository;
		public UserRepository User
		{
			get
			{
				if (userRepository == null)
					userRepository = new UserRepository(db);
				return userRepository;
			}
		}
		public PostRepository Post
		{
			get
			{
				if (postRepository == null)
					postRepository = new PostRepository(db);
				return postRepository;
			}
		}
		public CommentRepository Comment
		{
			get
			{
				if (commentRepository == null)
					commentRepository = new CommentRepository(db);
				return commentRepository;
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
