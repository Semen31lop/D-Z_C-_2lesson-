int num = new Random().Next(100,999);
int a1 = (num / 10) ;
int a2 = (a1 % 10 );
Console.WriteLine( + num + " -->" + a2);