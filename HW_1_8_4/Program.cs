// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

Console.WriteLine("Enter the first number");
var input1 = Console.ReadLine();
int.TryParse(input1, out int operand1);

Console.WriteLine("Enter the second number");
var input2 = Console.ReadLine();
int.TryParse(input2, out int operand2);

Console.WriteLine("Enter the thirt number");
var input3 = Console.ReadLine();
int.TryParse(input3, out int operand3);

double result_operand1 = Calculate(operand1);
double result_operand2 = Calculate(operand2);
double result_operand3 = Calculate(operand3);


Console.WriteLine($"{result_operand1}, {result_operand2}, {result_operand3}");
//Console.WriteLine(calculate);

static double Calculate( int value)
{
    return value / 5;
}