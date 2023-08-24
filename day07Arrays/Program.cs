Solution.Main();
class Solution
{
    public static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
        
        string resultString = "";
        for(int i  = arr.Count - 1 ; i >= 0; i--)
        {
            resultString += arr[i].ToString();
            if(i != 0) 
            {
                resultString += " ";
            }
        }
        Console.Write(resultString);
    }
}