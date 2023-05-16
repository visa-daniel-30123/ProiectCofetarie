namespace ProiectCofetarie
{
	public class IstoricComenzi
	{
		public string emailclient { get; set; }
		public string data { get; set; }

		IstoricComenzi(string emailclient, string data)
		{
			this.emailclient = emailclient;
			this.data = data;
		}
	}
}
