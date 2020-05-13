using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DAL
{
	class PostRepository : IRepository<Post>
	{
		private PostContext db;
		public PostRepository(PostContext context)
		{
			db = context;
		}
		public IEnumerable<Post> GetList()
		{
			return db.Post;
		}
		public void Create(Post item)
		{
			db.Post.Add(item);
		}
		public void Delete(int id)
		{
			Post posttodelete = db.Post.Find(id);
			if (posttodelete != null)
				db.Post.Remove(posttodelete);
		}
		public Post GetItem(int id)
		{
			return db.Post.Find(id);
		}
		public void Update(Post item)
		{
			db.Entry(item).State = EntityState.Modified;
		}
	}
}