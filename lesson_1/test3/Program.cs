Console.Write("Введите число день недели (число от 1 до 7):  ");
int x = Convert.ToInt32(Console.ReadLine());

switch (x)
    {
        case 1:
            Console.WriteLine(" Ваш день недели - понедельник!");
            break;

        case 2:
            Console.WriteLine(" Ваш день недели - вторник!");
            break;

        case 3:
            Console.WriteLine(" Ваш день недели - среда!");
            break;

        case 4:
            Console.WriteLine(" Ваш день недели - четверг!");
            break;

        case 5:
            Console.WriteLine(" Ваш день недели - пятница!");
            break;

        case 6:
            Console.WriteLine(" Ваш день недели - суббота!");
            break;
        
        case 7:
            Console.WriteLine(" Ваш день недели - воскресенье!");
            break;

        default:
            Console.WriteLine("Вы ввели некорректное значение!");
            break;

    }