using System;
namespace PersonalProfile.DataLayer.Models
{
	public class Bio
	{
		public Bio()
		{
		}

		public Guid Id { get; set; }
		public string Firstname { get; set; }
		public string Lastname { get; set; }
		public string Email { get; set; }
        public string Nickname { get; set; }
        public string Sex { get; set; }
		public DateTime DOB { get; set; }
	}
}

