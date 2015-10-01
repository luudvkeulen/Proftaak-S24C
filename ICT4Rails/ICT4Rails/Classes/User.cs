using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICT4Rails.Classes
{
	public class User
	{
		private int userID;
		private string name;
		private string surname;

		public int UserID
		{
			get { return userID; }
			set { userID = value; }
		}

		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		public string Surname
		{
			get { return surname; }
			set { surname = value; }
		}

		public User(int userID, string name, string surname)
		{
			UserID = userID;
			Name = name;
			Surname = surname;
		}
	}
}
