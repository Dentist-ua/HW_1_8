//Є N клієнтів, яким компанія-виробник має доставити товар.
//Скільки існує можливих маршрутів доставки товару з урахуванням того, що товар доставлятиме одна машина?
//Використовуючи Visual Studio, створіть проект за шаблоном Console Application.
//Напишіть програму, яка розраховуватиме і виводитиме на екран кількість можливих варіантів доставки товару.
//Для вирішення задачі, використовуйте факторіал N!, що розраховується за допомогою рекурсії.
//Поясніть, чому не рекомендується використовувати рекурсію для розрахунку факторіалу.
//Вкажіть слабкі місця цього підходу.




static int Factorial(int operand)
{
    if (operand == 0)
        return 1;
    else
        return operand * Factorial(operand - 1);
}

Console.WriteLine("What is the number of customers?");
var input1 = Console.ReadLine();
int.TryParse(input1, out int operand);
int factorial = Factorial(operand);

Console.WriteLine(factorial);