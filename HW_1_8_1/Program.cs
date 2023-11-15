//Використовуючи Visual Studio, створіть проект за шаблоном Console Application.
//Уявіть, що ви реалізуєте програму для банку, яка допомагає визначити, чи погасив клієнт кредит чи ні.
//Припустимо, щомісячна сума платежу має становити 100 грн. Клієнт повинен виконати 7 платежів, але може платити рідше за великі суми.
//Тобто може двома платежами по 300 і 400 грн. закрити весь обов'язок. Створіть метод, який як аргумент прийматиме суму платежу, введену економістом банку.
//Метод виводить на екран інформацію про стан кредиту (сума заборгованості, сума переплати, повідомлення про відсутність боргу).

int debet = -700;

getStart:

Console.WriteLine("----------------------------------------------------------");

Console.WriteLine("Enter the operation you want to perform");
Console.WriteLine("1. Pay the loan");
Console.WriteLine("2. Check the presence of debt");
Console.WriteLine("3. Exit");

var input2 = Console.ReadLine();
int.TryParse(input2, out int operation);

switch (operation)
{
    case (1):

        int payDebet = PayDebet(ref debet);
        goto getStart;
        
    case (2):
        CheckDebet(debet);
        goto getStart;
    
    case (3):
        Exit();
        goto getStart;
    
    default:
        Console.WriteLine("You entered an incorrect command, please try again");
        goto getStart;
}

static int PayDebet(ref int debet)
{
    Console.WriteLine("Enter the payment amount");
    var input1 = Console.ReadLine();
    int.TryParse(input1, out int pay);
    Console.WriteLine($"You have made {pay} UAH");
    debet = debet + pay;
    if (debet < 0)
    {
        Console.WriteLine($"Your current debt is {Math.Abs(debet)} UAH");
    }

    else if (debet == 0)
    {
        Console.WriteLine("Congratulations. You have completely paid off the debt");
    }

    else
    {
        Console.WriteLine($"Congratulations. You have an overpayment {Math.Abs(debet)} UAH");
    }
    
    return debet;
    
}

static void CheckDebet(int debet)
{
    if (debet < 0)
    {
        Console.WriteLine($"Your current debt is {Math.Abs(debet)} UAH");
    }

    else if (debet == 0)
    {
        Console.WriteLine("Congratulations. You have completely paid off the debt");
    }

    else
    {
        Console.WriteLine($"Congratulations. You have an overpayment {Math.Abs(debet)} UAH");
    }
}

static void Exit()
{
    Console.WriteLine("Thank you for choosing our bank. Goodbye");
}
