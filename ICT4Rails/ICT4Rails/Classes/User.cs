using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICT4Rails
{
    public class User
    {
        //Properties
        public string Name { get; set; }
        public string SurName { get; set; }
		public int UserType { get; set; }

        public User(string name, string surname, int userType)
        {
            Name = name;
            SurName = surname;
			UserType = userType;
        }
    }
}
