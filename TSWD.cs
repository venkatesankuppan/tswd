using System;
 
public class HelloWorld
{
    static public void Main ()
    {
        Console.WriteLine ("Hello this is a sample time duration for a day(minimum working hours-9) from venkat");

		Console.WriteLine ("Enter Check-in Time");
		DateTime usrchkinDateTime;


		//DateTime usrchkoutDateTime;
		if (DateTime.TryParse(Console.ReadLine(), out usrchkinDateTime))
		{
			DateTime x9hrsLater = usrchkinDateTime.AddHours(9);
			Console.WriteLine("We welcome the day : " + usrchkinDateTime.DayOfWeek);
			Console.WriteLine ("You can leave office any time above :" + x9hrsLater);
		}
		else
		{
			Console.WriteLine("You have entered an incorrect value.");
		}
		Console.ReadLine();
    }
}