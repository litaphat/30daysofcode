int N = Convert.ToInt32(Console.ReadLine().Trim());
if(N % 2 == 1)
{
    Console.WriteLine("Weird");
}
else if(N % 2 == 0 && 2 <= N && N <= 5)
{
    Console.WriteLine("Not Weird");
}
else if(N % 2 == 0 && 6 <= N && N <= 20)
{
    Console.WriteLine("Weird");
}
else if (N % 2 == 0 && 20 < N)
{
    Console.WriteLine("Not Weird");
}