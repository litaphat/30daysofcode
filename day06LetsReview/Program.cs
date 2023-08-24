Solution.Main();

class Solution
{
    public static void Main()
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int numberOfTest = int.Parse(Console.In.ReadLine());
        string[] arrayStrings = new string[numberOfTest];

        for(int i = 0; i < numberOfTest; i++)
        {
            arrayStrings[i] = Console.ReadLine();
        }

        for(int i = 0; i < arrayStrings.Length; i++)
        {
            char[] charArray = arrayStrings[i].ToCharArray();
            int numberOfCharaters = charArray.Length;
            for(int j = 0; j < numberOfCharaters; j++) 
            {
                if (j % 2 == 0)
                {
                    Console.Write(charArray[j]);
                }
            }
            Console.Write(" ");
            for (int j = 0; j < numberOfCharaters; j++)
            {
                if (j % 2 != 0)
                {
                    Console.Write(charArray[j]);
                }
            }
            Console.WriteLine();
        }
    }
}