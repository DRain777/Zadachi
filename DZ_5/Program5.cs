// Тапишите программу которая  на входе примет число (N>0) а на выходе показывает все четные числа от 1 до N
Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
if(n > 0)
{
    int count = 2;
    while(count <= n)
    {
        if(count%2 == 0)
        {
            Console.Write(count + " ");
            count += 2;
        }
    }
}
// Эту задачу я подсмотрел не Могли бы Денис Батькович подробней разобрать ее на следующим уроке.
// Я постараюсь понять ее до конца. другой способ
// number = 17 
// int counter = 2;   'это переменная к которой будет прибовляться + 2
// while (counter <= number)
// {
   // Console.Write(conter);
// counter += 2;  КАЖДЫЙ РАЗ ДОБОВЛЯЕТСЯ 2


