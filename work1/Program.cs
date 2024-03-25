// Напишите программу, которая бесконечно запрашивает целые числа с консоли.
// Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.

bool CheckedSymbol(string answer){

    if(answer=="q") return true;
    if(IsSumOfDigitsEven(Convert.ToInt32(answer))) return true;
    return false;
}

while (true)
{
    Console.Write("Введите число: ");
    string input = Console.ReadLine();
    if(CheckedSymbol(input)) break;
}

bool IsSumOfDigitsEven(int number)
{
    int sum = 0;
    while (number != 0)
    {
        sum += number % 10;
        number /= 10;
    }
    return sum % 2 == 0;
}