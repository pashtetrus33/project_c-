/* Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет
12821 -> да
23432 -> да*/

Console.Clear();
Console.WriteLine("Программа принимает на вход пятизначное число и проверяет, является ли оно палиндромом.");
bool repeat = true;

void isPalindrom (int fiveDigitNumber)
{   
    if ((fiveDigitNumber > 9999) && (fiveDigitNumber < 100000)) 
    {
        int firstDigit =  fiveDigitNumber / 10000;
        int secondDigit = (fiveDigitNumber / 1000) % 10;
        int fourthDigit = (fiveDigitNumber / 10) % 10;
        int fifthDigit = fiveDigitNumber % 10;
        
        //Console.WriteLine($"Цифра 1 {firstDigit} Цифра 2 {secondDigit} Цифра 4 {fourthDigit} Цифра 5 {fifthDigit}");

        if ((firstDigit == fifthDigit) && (secondDigit == fourthDigit))  // сравниваем 1ю и 5ю цифры и 2ю и 4ю цифру
        Console.WriteLine($"Число {fiveDigitNumber} является палиндромом."); 
        else
        Console.WriteLine($"Число {fiveDigitNumber} не является палиндромом."); 
    }
    else
    {
    Console.WriteLine("Вы ввели не пятизначное число! Попробуйте еще раз.");
    }
}

while (repeat)
{
Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
isPalindrom(number);
Console.WriteLine("Для продолжения нажмите 'ENTER', для выхода 'E' затем 'ENTER'");
string? decision = Console.ReadLine();

if (decision?.ToLower() == "e")
{
    repeat = false;
}
}