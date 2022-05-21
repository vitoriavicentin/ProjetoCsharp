namespace ProjetoCsharp.Classes
{
	public class Structs
	{
		static void ProductStance()
		{
			Product product = new Product();
			Console.WriteLine(product);
		}
	}
	struct Product
	{
		//Struct sempre fora da classe pq eles competem entre si
		public Product(int id, string name, double price)
		{
			Id = id;
			Name = name;
			Price = price;
		}
		public int Id;
		public string Name;
		public double Price;
		public double PriceInDolar(double dolar)
		{
			var total = Price * dolar;
			return total;
		}
	}
}