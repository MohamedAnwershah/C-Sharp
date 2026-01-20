using System;

class Program{
	static void Main(){
		SmartPhone myPhone = new();
		myPhone.TakePhoto();
		myPhone.MakePhoneCall();
	}
}

interface ICamera{
	void TakePhoto();
}

interface IPhone{
	void MakePhoneCall();
}

class SmartPhone : IPhone, ICamera{
	public void TakePhoto(){
		Console.WriteLine("Picture took!");
	}
	
	public void MakePhoneCall(){
		Console.WriteLine("Ring Ring!");
	}
}