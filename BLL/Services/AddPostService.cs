using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.UnitOfWork;
using BLL.DataTransferObjects;
using DAL.Models;

namespace BLL.Services
{
	class AddPostService : IAddPost
	{
		IUnitOfWork db { get; set; }
		public AddPostService(IUnitOfWork unit)
		{
			db = unit;
		}
		public void PostPost(PostDTO PostToPost)
		{
			if (PostToPost.PostUrl.Trim() != "")
			{
				Post post = new Post
				{
					PostUrl = PostToPost.PostUrl,
					Description = PostToPost.Description,
					Likes = 5,
					Dislikes = 5,
					Views = 11
				};
				db.Post.Create(post);
				db.Save();
			}
		}
		public void Dispose()
		{
			db.Dispose();
		}
	}
}
