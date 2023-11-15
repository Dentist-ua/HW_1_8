//Використовуючи Visual Studio, створіть проект за шаблоном Windows Forms.
//Напишіть програму, в який користувач textbox1 і textBox2 вводить дані і вибирає за допомогою декількох radioButton тип операції,
//потрібно виконати: залишок від поділу, зведення в ступінь, конкатенація, поділ. Результат виводиться в textBox3, натиснувши кнопку «Обчислити».

namespace HW_1_8_3;

static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
        Application.Run(new Form1());
    }
}