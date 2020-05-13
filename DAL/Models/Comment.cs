using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
	public class Comment
	{
		public int Id { get; set; }
		public Post Post { get; set; }
		public User Author { get; set; }
		public string Text { get; set; }
		public int Likes { get; set; }
		public int Dislikes { get; set; }
	}
}
