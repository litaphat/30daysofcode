int i = 4;
double d = 4.0;
string s = "HackerRank ";


// Declare second integer, double, and String variables.
string inputString;
string inputInt;
string inputDouble;
// Read and save an integer, double, and String to your variables.
inputInt = Console.ReadLine();
inputDouble = Console.ReadLine();
inputString = Console.ReadLine();
// Print the sum of both integer variables on a new line.
int sumInt = i + Convert.ToInt16(inputInt);
Console.WriteLine(sumInt);
// Print the sum of the double variables on a new line.
double sumDouble = d + Convert.ToDouble(inputDouble);
Console.WriteLine(sumDouble.ToString("#.0"));
// Concatenate and print the String variables on a new line
string resultConcat = s + (inputString ?? "");
// The 's' variable above should be printed first.
Console.WriteLine(s + (inputString ?? ""));