Console.WriteLine("value:m");
int m = int.Parse(Console.ReadLine());

Console.WriteLine("value:n");
int n = int.Parse(Console.ReadLine());
for (int i = m; i <= n; i++)
{
    if (IsPrime(i))
    {
        Console.WriteLine(i);
    }
}
static bool IsPrime(int number)
{
    if (number <= 1) return false;
    for (int i = 2; i <= Math.Sqrt(number); i++)
    {
        if (number % i == 0)
        {
            return false;
        }
    }
    return true;
}


    Console.WriteLine("Enter a non-negative value for m:");
     m = int.Parse(Console.ReadLine());

    Console.WriteLine("Enter a non-negative value for n");
     n = int.Parse(Console.ReadLine());

if (m > n)
{
    Console.WriteLine("The firstnumber (m) must be less than or equal to the secend number(n)");
    return;
}

    Console.WriteLine($"Palindromic numbers between{m}and{n}are:");

for (int i = m; i < n; i++)
{
    if (Ispalindrome(i))
    {
        Console.WriteLine(i);
    }
}
static bool Ispalindrome(int number)
{
    string str = number.ToString();
    char[] charArry = str.ToCharArray();
    Array.Reverse(charArry);
    string reversedStr = new string(charArry);
    return str == reversedStr;
}






  Console.WriteLine("Enter a number:");
  int number = int.Parse(Console.ReadLine());

   if (IsFibonacci(number))
   {
       Console.WriteLine($"{number} is a Fibonacci number.");
   }
   else
   {
       Console.WriteLine($"{number} is not a Fibonacci number");
   }

static bool IsFibonacci (int n)
{
    if (n < 0) return false;

    int a = 0, b = 1;
    if (n == a || n == b) return true;

    while (b < n)
    {
        int temp = b;
        b = a + b;
        a = temp;
    }

    return b == n;
}







