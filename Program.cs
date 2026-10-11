using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("                     Калькулятор");
            Console.WriteLine("Знаки: +, -, *, /");
            Console.WriteLine();

            double number_1 = ReadNumber("Введите первое число: ");
            double number_2 = ReadNumber("Введите второе число: ");
            char operation = ReadOperation();
            if (operation == '/' && number_2 == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Ошибка!Деление на 0 невозможно\nНажмите любую клавишу чтобы начать заново...");
                Console.ResetColor();
                Console.ReadKey();
                continue;
            }


            if (operation != '+' && operation != '-' && operation != '*' && operation != '/')
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($"Ошибка!Знак {operation} не соотвествует\nНажмите любую клавишу чтобы начать заново...");
                Console.ResetColor();
                Console.ReadKey();
                continue;
            }


            double result = Calculate(number_1, number_2, operation);

            Console.WriteLine($"\nРезультат: {number_1} {operation} {number_2} = {result}\nНажмите любую клавишу чтобы начать заново...");
            Console.ReadKey(true);


            static double ReadNumber(string message)
            {
                Console.Write(message);
                return Convert.ToDouble(Console.ReadLine());
            }

            static char ReadOperation()
            {
                Console.Write("Введите знак: ");
                return Convert.ToChar(Console.ReadLine());
            }

            static double Calculate(double num1, double num2, char op)
            {

                if (op == '+') return num1 + num2;
                if (op == '-') return num1 - num2;
                if (op == '*') return num1 * num2;
                if (op == '/') return num1 / num2;

                return 0;
            }
        }
    }
}