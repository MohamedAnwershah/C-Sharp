using System;

class Program
{
	static void Main()
	{
		Button btn = new();
        btn.OnClick += () => Console.WriteLine("Subscriber : 1");
        btn.OnClick += () => Console.WriteLine("Subscriber : 2");
        btn.SimulateClick();
        
	}	
}

class Button
{
    public event Action OnClick;

    public void SimulateClick()
    {
        if (OnClick != null)
        {
            OnClick();
        }
    }

}