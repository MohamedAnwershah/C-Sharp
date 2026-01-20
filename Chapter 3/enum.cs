using System;

class Program{
	static void Main(){
		User shah = new(){
			Name = "Anwer Shah",
			Role = UserRole.Admin
		};
		switch (shah.Role){
		case UserRole.Admin:
			Console.WriteLine("Welcome Admin!");
			break;
		
		case UserRole.Member:
			Console.WriteLine("Welcome Member!");
			break;
			
		default:
			Console.WriteLine("Welcome!");
			break;
	}
		
	}
	
	
}	

enum UserRole{
	Admin,
	Member,
	Guest
}
class User{
	public string Name;
	public UserRole Role;
}