namespace ProiectCofetarie
{
	public class Users
	{
		public string email { get; set; }
		public string password { get; set; }
		public int numarComenzi { get; set; }

		public Users(string em, string ps)
		{
			this.email = em;
			this.password = ps;
			this.numarComenzi = 0;
		}

		public void creteNrComenzi(string s)
		{
			numarComenzi++;
		}
	}
}
