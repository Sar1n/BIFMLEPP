using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
	class Post
	{
		public int Id { get; set; }
		public User Author { get; set; }
		public string PostUrl { get; set; }
		public string Description { get; set; }
		public int Likes { get; set; }
		public int Dislikes { get; set; }
		public ulong Views { get; set; }
}
}
