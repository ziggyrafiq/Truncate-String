using System.Text;

string longString = "This is a simple long string that need to be truncated";
int maxLength = 20;
string truncatedString = longString.Substring(0, maxLength);
Console.WriteLine(truncatedString);

//Using StringBuilder 
StringBuilder sb = new StringBuilder();
sb.Append("This is ");
sb.Append("a string ");
sb.Append("built using .Net System.Text String Builder ");
sb.Append("by Ziggy Rafiq ");

string result = sb.ToString();
Console.WriteLine(result);

//Using Substring Method
//Example One
string helloWorld = "Hello, World!";
string subStringHelloWorld = helloWorld.Substring(7, 5);

Console.WriteLine(subStringHelloWorld);

//Example Two
string subStringLongString = longString.Substring(0, maxLength);
Console.WriteLine(subStringLongString);

//Using LINQ
maxLength = 10;
string linqString = new string(longString.Take(maxLength).ToArray());
Console.WriteLine(linqString);

Console.ReadLine();