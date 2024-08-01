// See https://aka.ms/new-console-template for more information
// To test out your code , comment the other parts and uncomment the part you want to test.
//To comment a part, select the part and press Ctrl + K + C
//To uncomment a part, select the part and press Ctrl + K + U
//Press Ctrl + F5 to run the code.

//---------------------------------------------------------------------
// Part 1: Mathematical Operators
// Write a C# program to print the sum of two numbers.
// Hint: You can use the + operator to add two numbers.
// Test data: int num1 = 10, int num2 = 5

int num1 = 10;
int num2 = 5;
int plus = num1 + num2;
Console.WriteLine ("num1 + num2 = " + plus);


//---------------------------------------------------------------------
// Part 2: Mathematical Operators
// Write a C# program to print the difference between two numbers.
// Hint: You can use the - operator to subtract two numbers.
// Test data: int num1 = 10, int num2 = 5
int minus = num1 - num2;
Console.WriteLine ("num1 - num2 = " +minus);


//---------------------------------------------------------------------
// Part 3: Mathematical Operators
// Write a C# program to print the product of two numbers.
// Hint: You can use the * operator to multiply two numbers.
// Test data: int num1 = 10, int num2 = 5
int time = num1 * num2;
Console.WriteLine ("num1 * num2 = " +time);



//---------------------------------------------------------------------
// Part 4: Mathematical Operators
// Write a C# program to print the division of two numbers.
// Hint: You can use the / operator to divide two numbers.
// Test data: int num1 = 10, int num2 = 5
float divide = num1 / num2;
Console.WriteLine ("num1 / num2 = " + divide);

//---------------------------------------------------------------------
// Part 5: Mathematical Operators
// Write a C# program to print the remainder of two numbers.
// Hint: You can use the % operator to find the remainder of two numbers.
// Test data: int num1 = 10, int num2 = 5
float modular = num1 % num2;
Console.WriteLine ("num1 % num2 = " + modular);


//---------------------------------------------------------------------
// Part 6: Mathematical Operators
// Write a C# program to calculate the square of a number.
// Hint: You can use the * operator to multiply a number by itself.
// Test data: int num = 5
int num = 5;
int square = num * num;
Console.WriteLine ("Square of the number is: " + square);


//---------------------------------------------------------------------
// Part 7: Mathematical Operators
// Write a C# program to calculate the average of two numbers.
// Hint: You can add the two numbers together and then divide the sum by 2 to find the average.
// Test data: int num1 = 10, int num2 = 20
int num3 = 10;
int num4 = 20;
int sum = num3 + num4;
double average = (double)sum / 2;
Console.WriteLine("The average of " + num3 + " and " + num4 + " is: " + average);


//---------------------------------------------------------------------
// Part 8: Mathematical Operators
// Write a C# program to calculate the average of three numbers.
// Hint: You can add the three numbers together and then divide the sum by 3 to find the average.
// Test data: int num1 = 10, int num2 = 20, int num3 = 30
int[] numArray = { 10, 20, 30 };
int count = numArray.Length;
int sum1 = 0;

for (int i = 0; i < count; i++)
{
    sum1 += numArray[i];
}

float average1 = (float)sum1 / count;
Console.WriteLine("The average of the numbers is: " + average1);

//---------------------------------------------------------------------
// Part 9: Mathematical Operators
// Write a C# program to convert temperature from Celsius to Fahrenheit.
// Hint: Use the formula (Celsius * 9/5) + 32.
// Test data: double celsius = 20
double celsius = 20;
double fahrenheit = (celsius * 9/5) +32;
Console.WriteLine("The fahrenheit: "+ fahrenheit);

//---------------------------------------------------------------------
// Part 10: Mathematical Operators
// Write a C# program to calculate the area of a rectangle given its length and width.
// Hint: Use the formula area = length * width.
// Test data: double length = 10, double width = 5

double length = 10, width = 5;
double area = length * width;
Console.WriteLine("The area: "+ area);


//---------------------------------------------------------------------
// Part 11: Mathematical Operators
// Write a C# program to calculate the volume of a sphere given its radius.
// Hint: Use the formula volume = (4/3) * Pi * radius^3.
// Test data: double radius = 5
double radius = 5;
const double Pi = 3.14;
double volume = (4.0/3.0) * Pi *Math.Pow(radius, 3);
Console.WriteLine("The area: "+ volume);

//---------------------------------------------------------------------
// Part 12: Mathematical Operators
// Write a C# program to calculate the factorial of a given integer.
// Hint: Use a loop to multiply the numbers from 1 to the given integer.
// Test data: int num = 5
int number = 5;
int multiply =1;
for (int i=1; i <= number; i++)
{
    multiply *= i;
}
Console.WriteLine("Multiply: "+ multiply);


//---------------------------------------------------------------------
// Part 13: Mathematical Operators
// Write a C# program to calculate the compound interest given the principal amount, interest rate, and time period.
// Hint: Use the formula A = P * (1 + r/n)^(nt).
// Test data: double principal = 1000, double rate = 0.05, int time = 5
double principal = 1000; 
double rate = 0.05;
int time1 = 5;
int n = 1; 

double amount = principal * Math.Pow((1 + rate / n), n * time1);
double compoundInterest = amount - principal;

Console.WriteLine("The compound interest is: " + compoundInterest);
Console.WriteLine("The total amount after " + time1 + " years is: " + amount);

//---------------------------------------------------------------------
// Part 14: Mathematical Operators
// Write a C# program to solve a quadratic equation of the form ax^2 + bx + c = 0.
// Hint: Use the quadratic formula.
// Test data: double a = 1, double b = 5, double c = 6
double a = 1;
double b = 5; 
double c = 6;
double x1, x2;
double delta = Math.Pow(b,2) - 4 * a *c;
if (delta < 0)
{
    Console.WriteLine("Phuong trinh vo nghiem !");
}
else if (delta == 0)
{
    Console.WriteLine("Phuong trinh co 2 nghiem duy nhat");
    Console.WriteLine("x1 = x2 =" + (-b/2*a));
}
else
{
    Console.WriteLine("Phuong trinh co 2 nghiem phan biet");
    Console.WriteLine("x1 =" +(-b + Math.Sqrt(delta)) / (2 * a));
    Console.WriteLine("x2 =" +(-b - Math.Sqrt(delta)) / (2 * a));
}

//---------------------------------------------------------------------
// Part 15: Mathematical Operators
// Write a C# program to calculate the nth Fibonacci number using recursion.
// Hint: Use a recursive function to calculate Fibonacci numbers.
// Test data: int n = 8
int m = 8;
int result = Fibonacci(m);
Console.WriteLine("Result of Fibonacci: " + result);

static int Fibonacci(int n)
{
    if (n <= 1)
        return n;
    return Fibonacci(n - 1) + Fibonacci(n - 2);
}



//---------------------------------------------------------------------
// Part 16: Mathematical Operators
// Write a C# program to calculate the nth term of the arithmetic sequence given the first term, common difference, and term number.
// Hint: Use the formula nth term = first term + (n - 1) * common difference.
// Test data: int firstTerm = 3, int commonDifference = 2, int termNumber = 5
int firstTerm = 3; 
int commonDifference = 2;
int termNumber = 5;
int term = (firstTerm + (termNumber-1) * commonDifference);
Console.WriteLine ("The term of number = " + term);


//---------------------------------------------------------------------
// Part 17: Relational Operators
// Write a C# program to check if a given number is greater than another number.
// Hint: Use the > operator to check if the first number is greater than the second number.
// Test data: int num1 = 10, int num2 = 5

int numA = 10;
int numB = 5;

if (numA > numB)
{
    Console.WriteLine(numA + " is greater than " + numB);
}
else if (numA < numB)
{
    Console.WriteLine(numA + " is less than " + numB);
}
else
{
    Console.WriteLine(numA + " is equal to " + numB);
}



//---------------------------------------------------------------------
// Part 18: Relational Operators
// Write a C# program to check if a given number is less than or equal to 100.
// Prompt the user to enter a number and check if it is less than or equal to 100.
// Hint: Use the <= operator to check if the number is less than or equal to 100.
// Test data: Enter a number: 88
Console.WriteLine("Enter a number of part 18: ");
int so = int.Parse(Console.ReadLine());
if (so <= 100)
{
    Console.WriteLine(so + " is less than or equal to 100.");
}
else
{
    Console.WriteLine(so + " is greater than 100.");
}


//---------------------------------------------------------------------
// Part 19: Logical Operators
// Write a C# program to check if a given number is even AND greater than 10.
// Prompt the user to enter a number and check if it satisfies both conditions.
// Hint: Use the % operator to check if the number is even, and the && operator to check both conditions.
// Test data: Enter a number: 16
Console.WriteLine("Enter a number of part 19: ");
int number1 = int.Parse(Console.ReadLine());
if (number1 % 2 == 0 && number1 > 10)
{
    Console.WriteLine(number + " is even and greater than 10.");
}
else
{
    Console.WriteLine(number + " does not satisfy both conditions.");
}

//---------------------------------------------------------------------
// Part 20: Logical Operators
// Write a C# program to check if a given number is divisible by 3 OR 5.
// Prompt the user to enter a number and check if it is divisible by either 3 or 5.
// Hint: Use the % operator to check for divisibility, and the || operator to check either condition.
// Test data: Enter a number: 9
Console.WriteLine("Enter a number of part 20: ");
int number2 = int.Parse(Console.ReadLine());
if (number2 % 3 == 0 || number2 % 5 == 0)
{
    Console.WriteLine(number2 + " is divisible by either 3 or 5.");
}
else
{
    Console.WriteLine(number2 + " is not divisible by either 3 or 5.");
}


//---------------------------------------------------------------------
// Part 21: Initialization and Assignment Operators
// Write a C# program to increment a variable by 5 using the shorthand assignment operator.
// Prompt the user to enter a number and increment it by 5 using the shorthand assignment operator.
// Hint: Use the += operator to increment the variable by 5.
// Test data: Enter a number: 7
Console.WriteLine("Enter a number of part 22: ");
int number3 = int.Parse(Console.ReadLine());
number3 += 5;
Console.WriteLine("The number after incrementing by 5 is: " + number3);


//---------------------------------------------------------------------
// Part 22: Initialization and Assignment Operators
// Write a C# program to calculate the remainder when dividing a number by 7 and update the number using the %= operator.
// Initialize a variable 'number' with a value of 27, then calculate the remainder when dividing 'number' by 7 and update 'number' with the result.
// Hint: Use the %= operator to update the value of 'number' with the remainder of 'number' divided by 7.
// Test data: int number = 27

int number4 = 27;
number4 %= 7;
Console.WriteLine("The remainder when dividing the number by 7 is: " + number4);