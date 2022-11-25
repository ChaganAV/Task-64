int number = InputInt("Введите число ");
int min = 1;

Console.WriteLine($"{PrintNumber(number)}");

int PrintNumber(int num)
{
    if (num==min)
        return 1;
    else
    {
        Console.Write($"{num} ");
        return PrintNumber(num - 1);
    }   
}


int InputInt(string message)
{
    Console.WriteLine(message);
    Console.Write("> ");
    return Convert.ToInt32(Console.ReadLine());
}

