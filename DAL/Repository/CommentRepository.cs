using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using DAL.Models;
using DAL.Context;

namespace DAL.Repository
{
	public class CommentRepository : IRepository<Comment>
	{
		private PostContext db;
		public CommentRepository(PostContext context)
		{
			db = context;
		}
		public IEnumerable<Comment> GetList()
		{
			return db.Comment;
		}
		public void Create(Comment item)
		{
			db.Comment.Add(item);
		}
		public void Delete(int id)
		{
			Comment commenttodelete = db.Comment.Find(id);
			if (commenttodelete != null)
				db.Comment.Remove(commenttodelete);
		}
		public Comment GetItem(int id)
		{
			return db.Comment.Find(id);
		}
		public void Update(Comment item)
		{
			db.Entry(item).State = EntityState.Modified;
		}
	}
}
