Console.WriteLine("Введите трехзначное число.\nВыхода из программы команда Exit.");
 while(true)
    {
        string input = Console.ReadLine();
        if(!number.Equals("exit"))
{
Console.WriteLine("{0}->{1}",input, input[1]);
}
            
        else
            break;
    }
