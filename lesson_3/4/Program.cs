Console.Clear();
Console.Write("Введите многозначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int temp = 10;
bool isTrue = true;
while( number > 0)
{
    if(temp < number % 10)
    {
        isTrue = false;
    }
    temp = number % 10;
    number /= 10;
}
if(isTrue)
Console.WriteLine("Число упорядоченное!");
else
Console.WriteLine("Число неупорядоченное!");


