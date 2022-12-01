/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели,
 и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет*/

Console.WriteLine("Введите число, которое обозначает день недели");
string number1Str = Console.ReadLine();
int number1 = Convert.ToInt32(number1Str);


if(number1 == 1)
{
Console.WriteLine("не выходной");
} else if (number1 == 2){
    Console.WriteLine("не выходной");
}
else if (number1 == 3){
    Console.WriteLine("не выходной");
}
else if (number1 == 4){
    Console.WriteLine("не выходной");
}
else if (number1 == 5){
    Console.WriteLine("не выходной");
}
else if (number1 == 6){
    Console.WriteLine("выходной");
}
else if (number1 == 7){
    Console.WriteLine ("выходной");
} else
    Console.WriteLine ("Ввели не число недели от 1 до 7");