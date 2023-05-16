namespace ProiectCofetarie
{
	public class Produs
	{


        public string denumireProd { get; set; }	
		public int pret { get; set; }
		public  int cantitate {get; set; }
	

		Produs(string denumireProd,int pret, int cantitate)
		{
			this.denumireProd = denumireProd;
			this.pret = pret;
			this.cantitate = cantitate;
		}	
	}
}
