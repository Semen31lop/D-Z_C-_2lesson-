int num = Random.Next();
int result = 0;
if (num<100)
{
    Console.WriteLine($"{num}-->третьей чифры нет");
}
else if (num>100)
{
    while(num>999);
    {
        num=num/10;
    } 
    result= num/10%10;
    Console.WriteLine($"{num}-->{result}");
}
