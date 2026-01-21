using System;

class Program
{
	static void Main()
	{
		StockMarket nse = new();

        nse.OnPriceChanged += (price) => Console.WriteLine($"Price has changed : {price}");

        nse.UpdatePrice(100);
	}	
}

class StockMarket
{
    public event Action<int> OnPriceChanged;

    public void UpdatePrice(int price)
    {
        if (OnPriceChanged != null)
        {
            OnPriceChanged(price);
        }
    }
}