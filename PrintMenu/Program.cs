void PrintMenu();
{

    Console.WriteLine("Please enter a valid option from below:");
    Console.WriteLine("1.Hello in French?");
    Console.WriteLine("2.Hello in Spainish?");
    Console.WriteLine("3.Hello in German?");
    Console.WriteLine("4.Hello in Italian?");
    Console.WriteLine("0.Exit the Application");

}

int GetOption()
{

	try
	{
		int option = Convert.ToInt32(Console.ReadLine);
		return option;
	}
	catch (Exception ex)
	{
		Console.WriteLine("Please enter a valid operation");
	}

}

GetMessage(){

	switch (operation)
	{
        case '0':
            Console.WriteLine(Goodbye);
            break;
        case '1':
			Console.WriteLine(Bonjour);
			break;
        case '2':
            Console.WriteLine(Ola);
            break;
        case '3':
            Console.WriteLine(Hallo);
            break;
        case '4':
            Console.WriteLine(Ciao);
            break;
       
    }

}