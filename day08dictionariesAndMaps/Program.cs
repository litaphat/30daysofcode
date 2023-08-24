using System.Xml.Linq;

Solution.Main();

class Solution
{
    public static void Main()
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */

        Dictionary<string, string> phoneBooks = new Dictionary<string, string>();
        int numberOfTest = int.Parse(Console.In.ReadLine());
        for (int i = 0; i < numberOfTest; i++)
        {
            string input = Console.ReadLine().TrimEnd();
            string[] separatedValue = new string[2];
            if (input.Split(' ').Count() == 1)
            {
                separatedValue[0] = input.Split(' ')[0];
                separatedValue[1] = "";
            }
            else if (input.Split(' ').Count() == 2)
            {
                separatedValue[0] = input.Split(' ')[0];
                separatedValue[1] = input.Split(' ')[1];
            }
            if (!phoneBooks.ContainsKey(separatedValue[0].ToLower()))
            {
                phoneBooks.Add(separatedValue[0].ToLower(), separatedValue[1]);
            }
            else
            {
                phoneBooks[separatedValue[0].ToLower()] = separatedValue[1];
            }
        }

        for (int i = 0; i < numberOfTest; i++)
        {
            string queryValue = Console.ReadLine();
            if (!string.IsNullOrEmpty(queryValue))
            {
                if (phoneBooks.ContainsKey(queryValue.ToLower()))
                {
                    Console.WriteLine($"{queryValue}={phoneBooks[queryValue.ToLower()]}");
                }
                else
                {
                    Console.WriteLine($"Not found");
                }
            }
        }
    }
}