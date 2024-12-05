// 6.1.1. Обчислення середнього заробітку:

//Console.WriteLine("How many employees are in the company");
//int emloyees = int.Parse(Console.ReadLine());
//double salaryintotal = 0;
//for (int i = 1; i <= emloyees; i++)
//{
//    Console.WriteLine($"What is the salary of the employee #{i}: ");
//    salaryintotal += int.Parse(Console.ReadLine());
//}
//double avaragesalary = salaryintotal / emloyees;
//Console.WriteLine($"The avarage salary in the company is: {avaragesalary}");

// 6.1.2. Побудова графіку зірочками:

/* Console.WriteLine("Please enter the number of lines you want to see with stars: ");
int rows = int.Parse(Console.ReadLine());
for (int i = 1; i <= rows; i++)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}*/

// 6.1.3. Генерація простих чисел:

/*Console.WriteLine("Enter the largest number to find prime numbers: ");
int largestNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Prime numbers from 1 to " + largestNumber + " are:");
for (int i = 2; i <= largestNumber; i++)
{
    bool isPrime = true;

    for (int j = 2; j * j <= i; j++)
    {
        if (i % j == 0)
        {
            isPrime = false;
            break;
        }
    }

    if (isPrime)
    {
        Console.WriteLine(i);
    }
}*/

// 6.1.4. Перевірка паролю:

/*{
    Console.WriteLine("Please enter your password: ");
    string pass = Console.ReadLine();
    if (isPasswordValid(pass))
    {
        Console.WriteLine("Password has passed");
    }
    else
    {
        Console.WriteLine("Password has NOT passed. The password must minimum 8 characters, contain one digit, and one special character.");
    }
}
bool isPasswordValid(string pass)
{
    if (pass.Length < 8) return false;
    bool hasDigit = false;
    bool hasSpecialChar = false;
    foreach (char c in pass)
    {
        if (char.IsDigit(c)) hasDigit = true; 
        if (!char.IsLetterOrDigit(c)) hasSpecialChar = true; 
        if (hasDigit && hasSpecialChar)
            return true;
    }
    return false;
}*/

// 6.1.5. Генерація фібоначчівської послідовності:

/*string GenerateFibonacci(int n)
{
    if (n <= 0)
    {
        return "Fibonacci numbers must be bigger than 0";
    }
    int first = 0;
    int second = 1;
    string result = "";
    for (int i = 0; i < n; i++)
    {
        result += first + " ";
        int next = first + second;
        first = second;
        second = next;
    }
    if (result.Length > 0)
    {
        result = result.Substring(0, result.Length - 1);
    }
    return result;
}
Console.WriteLine("Enter how many Fibonacci numbers to create: ");
int n = int.Parse(Console.ReadLine());
string fibonacciSequence = GenerateFibonacci(n);
Console.WriteLine(fibonacciSequence);*/

// 6.1.6. Калькулятор оплати праці за годину:

/*string CalculateDailyPay(int hoursPerDay, double hourlyRate)
{
    double dailyPay = hoursPerDay * hourlyRate;
    return $"The payment for today is: {dailyPay} hryvnia";
}
Console.WriteLine("Please enter the quantity of hours per day: ");
int hoursPerDay = int.Parse(Console.ReadLine());

Console.WriteLine("Enter your hourly rate: ");
double hourlyRate = double.Parse(Console.ReadLine());
string dailyPay = CalculateDailyPay(hoursPerDay, hourlyRate);
Console.WriteLine(dailyPay);*/

// 6.1.7. Генерація таблиці множення для конкретного числа:

/*string GenMultTable(int number)
{
    string result = "";
    for (int i = 1; i <= 10; i++)
    {
        result += $"{number} * {i} = {number * i}\n";
    }
    return result;
}
Console.WriteLine("Enter a specific number to generate multiplication table: ");
int number = int.Parse(Console.ReadLine());
string multiplicationTable = GenMultTable(number);
Console.WriteLine(multiplicationTable);*/

// 6.1.8. Перевірка на простоту:

bool IsPrime(int number)
{
    if (number <= 1) return false;
    for (int i = 2; i <= Math.Sqrt(number); i++)
    {
        if (number % i == 0) return false;
    }
    return true;
}
Console.WriteLine("Please enter a number to check if it is prime: ");
int number = int.Parse(Console.ReadLine());
bool isPrime = IsPrime(number);
if (isPrime)
{
    Console.WriteLine($"{number} IS A PRIME number");
}
else
{
    Console.WriteLine($"{number} is NOT a prime numbe");
}